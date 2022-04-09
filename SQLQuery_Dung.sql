use QuanLyHocPhi;
GO;
-- tạo View cho form Xem học phí sinh viên
CREATE VIEW Xem_HocPhiSV
AS
	SELECT DISTINCT KY_HOC.NamHoc AS 'Năm học',
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
		JOIN CT_HOC_PHI ON CT_HOC_PHI.MaKyHP = KY_HOC_PHI.MaKyHP
		JOIN HOC_PHAN ON HOC_PHAN.MaHP = CT_HOC_PHI.MaHP;
		
GO;
SELECT * FROM Xem_HocPhiSV;
SELECT * FROM KY_HOC;
SELECT DISTINCT NamHoc FROM KY_HOC;
SELECT DISTINCT HocKy FROM KY_HOC;
GO;

--Tổng kết
CREATE FUNCTION func_TinNo
(@TinNo int, @CanDong decimal (12,0), @DaDong decimal (12,0))
RETURNS int
AS
BEGIN
	RETURN 
		(IF (@CanDong -@DaDong) > 0
		) 
END;

-- thao tác tìm kiếm form Xem học phí sinh viên
CREATE PROC SP_TIMKIEM_XemHocPhiSV
	@NamHoc char(10),
	@HocKy char(5),
	@TinConNo char(5)
AS
	
	BEGIN
		SELECT DISTINCT *
		FROM Xem_HocPhiSV
		WHERE ([Năm học] = @NamHoc OR @NamHoc = '')
		AND ([Học kỳ] = @HocKy OR @HocKy = '')
		
	END
	
GO;
EXEC SP_TIMKIEM_XemHocPhiSV '2020-2021', '', '';
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