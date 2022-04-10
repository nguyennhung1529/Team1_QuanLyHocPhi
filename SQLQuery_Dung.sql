use QuanLyHocPhi;
GO;
-- tạo View cho form Xem học phí sinh viên
CREATE VIEW Xem_HocPhiSV
AS
	SELECT DISTINCT SINH_VIEN.MSV AS 'MSV',
		KY_HOC.NamHoc AS 'Năm học',
		KY_HOC.HocKy AS 'Học kỳ',
		HOC_PHAN.MaHP AS 'Mã học phần',
		HOC_PHAN.TenHP AS 'Tên học phần',
		HOC_PHAN.SoTC AS 'Số tín chỉ',
		KY_HOC_PHI.CanDong AS 'Cần đóng',
		KY_HOC_PHI.DaDong AS 'Đã đóng',
		CT_HOC_PHI.NgayNop AS 'Ngày đóng',
		(KY_HOC_PHI.CanDong - KY_HOC_PHI.DaDong) AS 'Còn nợ'
	FROM KY_HOC_PHI
		JOIN KY_HOC ON KY_HOC.MaKyHoc = KY_HOC_PHI.MaKyHoc
		JOIN SINH_VIEN ON SINH_VIEN.MSV = KY_HOC_PHI.MSV
		JOIN CT_HOC_PHI ON CT_HOC_PHI.MaKyHP = KY_HOC_PHI.MaKyHP
		JOIN HOC_PHAN ON HOC_PHAN.MaHP = CT_HOC_PHI.MaHP
		
GO;
SELECT SUM ([Số tín chỉ]) AS 'TongTinNo', SUM ([Còn nợ]) AS 'TongTienNo' FROM Xem_HocPhiSV
WHERE [Còn nợ] > 0
AND MSV = 'SV002';



-- SP loc hoc phi SV form XemHocPhiSV
go;
CREATE PROC SP_TIMKIEM_XemHocPhiSV
	@MSV char(10),
	@NamHoc char(10),
	@HocKy char(5),
	@TinConNo bit
AS 
BEGIN
	IF @TinConNo = 1  -- Tìm kiếm xét tín còn nợ
	BEGIN
		SELECT * FROM Xem_HocPhiSV
		WHERE (@NamHoc = '' OR [Năm học] = @NamHoc )
		AND (@HocKy = '' OR [Học kỳ] = @HocKy)
		AND [Còn nợ]  > 0
		AND MSV = @MSV;	
	END
	ELSE
	BEGIN
		SELECT * FROM Xem_HocPhiSV
		WHERE (@NamHoc = '' OR [Năm học] = @NamHoc )
		AND (@HocKy = '' OR [Học kỳ] = @HocKy)
		AND MSV = @MSV;
	END;
END;
EXEC SP_TIMKIEM_XemHocPhiSV 'SV001', '', '', 0;


-- SP loc hoc phi SV form XemHocPhiSV
go;
CREATE PROC SP_TIMKIEM_XemHocPhiSV_TongKet
	@MSV char(10),
	@NamHoc char(10),
	@HocKy char(5)
AS 
BEGIN
	SELECT ISNULL(SUM ([Số tín chỉ]), 0) AS 'TongTinNo', 
			ISNULL(SUM ([Còn nợ]), 0) AS 'TongTienNo' 
			FROM Xem_HocPhiSV
	WHERE (@NamHoc = '' OR [Năm học] = @NamHoc )
	AND (@HocKy = '' OR [Học kỳ] = @HocKy)
	AND [Còn nợ]  > 0
	AND MSV = @MSV;	
END;
EXEC SP_TIMKIEM_XemHocPhiSV_TongKet 'SV001', '', '';

GO;

--Tìm kiếm biên lai
CREATE PROC SP_TIMBIENLAI
	@MaBL char(10)
AS
BEGIN
	SELECT	MaBL, TenBL, MaKyHoc, TienNop, NgayNop, Mota, NgayCapNhat, MaNguoiCapNhat
	FROM	BIEN_LAI, SINH_VIEN
	WHERE	BIEN_LAI.MSV = SINH_VIEN.MSV 
			AND BIEN_LAI.MaBL = @MaBL
END

drop proc SP_TIMBIENLAI