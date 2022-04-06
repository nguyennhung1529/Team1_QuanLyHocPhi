use QuanLyHocPhi;
-- Tạo thủ tục PROCEDURE thực hiện cập nhật giá trị CT_HOC_PHI.ConNo
GO;
CREATE PROCEDURE sp_update_CTHP
	@MaKyHP int
AS
BEGIN
	DECLARE @MaHP CHAR(10);
	DECLARE @CanDong DECIMAL(12,0), @ConNo DECIMAL(12,0), @TongDaDong DECIMAL(12,0);
	DECLARE @NgayNop DATE;
	DECLARE @countRow INT, @i INT;

	SET @TongDaDong = (SELECT DaDong FROM KY_HOC_PHI WHERE MaKyHP = @MaKyHP);
	SET @countRow = (SELECT COUNT(MaHP) FROM CT_HOC_PHI WHERE MaKyHP = @MaKyHP);
	SET @i = 0;

	-- Khai báo con trỏ
	DECLARE cursorCTHP CURSOR FOR
		SELECT MaHP, CanDong, ConNo, NgayNop FROM CT_HOC_PHI WHERE MaKyHP = @MaKyHP;
	OPEN cursorCTHP;
	FETCH NEXT FROM cursorCTHP INTO @MaHP, @CanDong, @ConNo, @NgayNop;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @i = @i + 1;
		IF @TongDaDong >= @CanDong
		BEGIN
			SET @ConNo = (CASE WHEN @i = @countRow THEN @CanDong - @TongDaDong ELSE 0 END);
			SET @TongDaDong = @TongDaDong - @CanDong;
		END
		ELSE
		BEGIN
			SET @ConNo = @CanDong - @TongDaDong;
			SET @TongDaDong = 0;
		END;

		UPDATE CT_HOC_PHI SET ConNo = @ConNo WHERE MaKyHP = @MaKyHP AND MaHP = @MaHP;
		--PRINT @MaHP;
		--PRINT @CanDong;
		--PRINT @ConNo;
		--PRINT @NgayNop;
		--PRINT @TongDaDong;
		--PRINT '==========';

		FETCH NEXT FROM cursorCTHP INTO @MaHP, @CanDong, @ConNo, @NgayNop;
	END;
	CLOSE cursorCTHP;
	DEALLOCATE cursorCTHP;
END;
GO;
-- tạo View cho form Tổng quát học phí sinh viên
CREATE VIEW VW_TongQuatHocPhi
AS
	SELECT DISTINCT KY_HOC.NamHoc AS 'Năm học',
		KY_HOC.HocKy AS 'Học kỳ',
		KY_HOC_PHI.MSV AS 'MSV',
		SINH_VIEN.MaL AS 'Mã lớp',
		DOI_TUONG.MucGiam AS 'Mức giảm',
		KY_HOC_PHI.CanDong AS 'Cần đóng',
		(KY_HOC_PHI.CanDong - KY_HOC_PHI.DaDong) AS 'Còn nợ'
	FROM KY_HOC_PHI
		JOIN KY_HOC ON KY_HOC.MaKyHoc = KY_HOC_PHI.MaKyHoc
		JOIN SINH_VIEN ON SINH_VIEN.MSV = KY_HOC_PHI.MSV
		JOIN CT_DOI_TUONG ON CT_DOI_TUONG.MSV = SINH_VIEN.MSV
		JOIN DOI_TUONG ON DOI_TUONG.MaDT = CT_DOI_TUONG.MaDT;
GO;
SELECT * FROM VW_TongQuatHocPhi;
SELECT * FROM KY_HOC;
SELECT DISTINCT NamHoc FROM KY_HOC;
SELECT DISTINCT HocKy FROM KY_HOC;
GO;
-- tạo Procedure cho thao tác tìm kiếm tổng quát học phí
CREATE PROC SP_TIMKIEM_TongQuatHocPhi
	@NamHoc char(10),
	@HocKy char(5),
	@MSV char(10),
	@TinhTang nvarchar(20)
AS
	IF @TinhTang = N'Còn nợ'
	BEGIN
		SELECT DISTINCT *
		FROM VW_TongQuatHocPhi
		WHERE ([Năm học] = @NamHoc OR @NamHoc = '')
		AND ([Học kỳ] = @HocKy OR @HocKy = '')
		AND ([MSV] = @MSV OR @MSV = '')
		AND ([Còn nợ] > 0 OR @TinhTang = '')
	END
	ELSE IF @TinhTang = N'Đã đóng'
	BEGIN
		SELECT DISTINCT *
		FROM VW_TongQuatHocPhi
		WHERE ([Năm học] = @NamHoc OR @NamHoc = '')
		AND ([Học kỳ] = @HocKy OR @HocKy = '')
		AND ([MSV] = @MSV OR @MSV = '')
		AND ([Còn nợ] <= 0 OR @TinhTang = '')
	END
	ELSE IF @TinhTang = N'Dư tiền'
	BEGIN
		SELECT DISTINCT *
		FROM VW_TongQuatHocPhi
		WHERE ([Năm học] = @NamHoc OR @NamHoc = '')
		AND ([Học kỳ] = @HocKy OR @HocKy = '')
		AND ([MSV] = @MSV OR @MSV = '')
		AND ([Còn nợ] < 0 OR @TinhTang = '')
	END
	ELSE IF @TinhTang = ''
	BEGIN
		SELECT DISTINCT *
		FROM VW_TongQuatHocPhi
		WHERE ([Năm học] = @NamHoc OR @NamHoc = '')
		AND ([Học kỳ] = @HocKy OR @HocKy = '')
		AND ([MSV] = @MSV OR @MSV = '')
	END;
GO;
EXEC SP_TIMKIEM_TongQuatHocPhi '2020-2021', '', '', N'';
GO;
---- TẠO TRIGGER CHO BẢNG BIEN_LAI (tác động đến bảng KY_HOC_PHI)
--- Khi INSERT BIEN_LAI (chỉ có thể insert biên lai trong năm mà nhà trường đang mở 
--tức năm hiện tại)
--  Tại bảng KY_HOC_PHI:
     
--     if BIEN_LAI.Status = 1:
--     	-- Cập nhật bản ghi có KY_HOC_PHI.MaKyHoc = BIEN_LAI.MaKyHoc:
--	if BIEN_LAI.MaKyHoc = MAX(KY_HOC.MaHocKy): -- luôn đúng
--	   DaDong = DaDong + BIEN_LAI.TienNop;
CREATE TRIGGER trg_Insert_BienLai ON BIEN_LAI
AFTER INSERT AS
BEGIN
	UPDATE KY_HOC_PHI SET DaDong = (DaDong + inserted.TienNop)
	FROM KY_HOC_PHI
		JOIN inserted ON inserted.MSV = KY_HOC_PHI.MSV
	WHERE KY_HOC_PHI.MaKyHoc = inserted.MaKyHoc
	AND inserted.Status = 1
	AND inserted.MaKyHoc = (SELECT MAX(KY_HOC.MaKyHoc) FROM KY_HOC);
END;

SELECT * FROM KY_HOC_PHI ORDER BY MaKyHoc;
 DELETE BIEN_LAI WHERE MaBL = 'BL017';
insert into BIEN_LAI (MaBL, TenBL, MSV, TienNop, NgayNop, Mota, NgayCapNhat, MaKyHoc) 
values 
	('BL017', N'001 Trả tiền học phí kì 2 năm 2021-2022', 'SV008', 4000000, '2021-04-05', N'Sinh viên 008', '2021-06-05', 'MKH005');
SELECT * FROM KY_HOC_PHI ORDER BY MaKyHoc;
SELECT * FROM BIEN_LAI WHERE MaBL = 'BL017';


GO;
-- TRIGGER BIEN_LAI KHI UPDATE
CREATE TRIGGER trg_Update_BienLai ON BIEN_LAI
AFTER UPDATE AS
BEGIN
	DECLARE @stt_cu TINYINT, @stt_moi TINYINT;
	DECLARE @tiennop_cu DECIMAL(12,0), @tiennop_moi DECIMAL(12,0);
	DECLARE @makyhoc CHAR(10), @msv CHAR(10);

	SET @makyhoc = (SELECT inserted.MaKyHoc FROM inserted);
	SET @msv = (SELECT inserted.MSV FROM inserted);

	SET @stt_cu = (SELECT deleted.Status FROM deleted);
	SET @tiennop_cu = (SELECT deleted.TienNop FROM deleted);

	SET @stt_moi = (SELECT inserted.Status FROM inserted);
	SET @tiennop_moi = (SELECT inserted.TienNop FROM inserted);

	IF @stt_cu = 2 AND @stt_moi = 1 -- duyệt biên lai
	BEGIN
		UPDATE KY_HOC_PHI SET DaDong = (DaDong + @tiennop_moi)
		WHERE MSV = @msv
		AND MaKyHoc = @makyhoc;
	END
	ELSE IF @tiennop_cu != @tiennop_moi AND @stt_cu = 1
	BEGIN
		UPDATE KY_HOC_PHI SET DaDong = (DaDong + @tiennop_moi - @tiennop_cu)
		WHERE MSV = @msv
		AND MaKyHoc = @makyhoc;
	END;
END;

--SELECT * FROM KY_HOC_PHI ORDER BY MaKyHoc;
---- DELETE BIEN_LAI WHERE MaBL = 'BL017';
--UPDATE BIEN_LAI SET Status = 1 WHERE MaBL = 'BL017';
---- UPDATE BIEN_LAI SET TienNop = 4000000 WHERE MaBL = 'BL017';
--SELECT * FROM BIEN_LAI WHERE MaBL = 'BL017';
--SELECT * FROM KY_HOC_PHI ORDER BY MaKyHoc;

GO;
-- TRIGGER BIEN_LAI KHI DELETE
CREATE TRIGGER trg_Delete_BienLai ON BIEN_LAI
FOR DELETE AS
BEGIN
	UPDATE KY_HOC_PHI SET DaDong = (DaDong - deleted.TienNop)
	FROM KY_HOC_PHI
		JOIN deleted ON deleted.MSV = KY_HOC_PHI.MSV
	WHERE KY_HOC_PHI.MaKyHoc = deleted.MaKyHoc
	AND deleted.Status != 2;
END;
--DELETE BIEN_LAI WHERE MaBL = 'BL017';
--SELECT * FROM KY_HOC_PHI ORDER BY MaKyHoc;
GO;

---- TẠO TRIGGER CHO BẢNG KY_HOC_PHI (tác động đến bảng CT_HOC_PHI)
--- Khi INSERT KY_HOC_PHI 
--	=> EXEC PROCEDURE sp_update_CTHP
--- Khi UPDATE KY_HOC_PHI
--	=> EXEC PROCEDURE sp_update_CTHP
GO;
CREATE TRIGGER trg_Insert_KyHocPhi ON KY_HOC_PHI
AFTER INSERT, UPDATE AS
BEGIN
	DECLARE @MaKyHP INT;
	SET @MaKyHP = (SELECT MaKyHP FROM inserted);
	EXEC sp_update_CTHP @MaKyHP;
END;
---- TRIGGER BIEN_LAI KHI UPDATE
--GO;
--CREATE TRIGGER trg_Update_KyHocPhi ON KY_HOC_PHI
--AFTER UPDATE AS
--BEGIN
--	DECLARE @MaKyHP INT;
--	SET @MaKyHP = (SELECT MaKyHP FROM inserted);
--	EXEC sp_update_CTHP @MaKyHP;
--END;



