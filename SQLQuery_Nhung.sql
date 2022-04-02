use QuanLyHocPhi;
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
-- View tổng quát tình trạng học phí của các sinh viên
-- vw_TinhTrangHP (NamHoc, HocKy, MSV, HocPhi, MienGiam, CanDong, DaDong, ConNo)
CREATE VIEW vw_TinhTrangHP AS
	SELECT sanpham.id_sanpham, sanpham.ten_sanpham, hangtonkho.chatluong
	FROM sanpham
	INNER JOIN hangtonkho
	ON sanpham.id_sanpham = hangtonkho.id_sanpham
	WHERE sanpham.id_sanpham >= 1000;


-- Hàm tính mức giảm theo các năm học của từng đối tượng sinh viên
-- Input: NamHoc, MSV
-- Output: MucGiam
GO;
CREATE FUNCTION func_TinhMucGiam
(@NamHoc CHAR(10), @MSV CHAR(10))
RETURNS FLOAT(2)
AS
BEGIN
	DECLARE @MucGiam FLOAT(2);

	SET @MucGiam = ISNULL((SELECT DOI_TUONG.MucGiam 
							FROM SINH_VIEN
								JOIN CT_DOI_TUONG ON SINH_VIEN.MSV = CT_DOI_TUONG.MSV
								JOIN DOI_TUONG ON CT_DOI_TUONG.MaDT = DOI_TUONG.MaDT
							WHERE SINH_VIEN.MSV = 'SV002'
							AND CT_DOI_TUONG.NamHoc = '2021-2022'), 0);
RETURN @MucGiam;
END;
GO;

-- Hàm tính tiền nợ (nợ: +, dư: -) của sinh viên theo các học kỳ của năm học
-- Input: HocKy, NamHoc, MSV
-- Output: TienNo
CREATE FUNCTION func_TinhTienNo
(@HocKy CHAR(5), @NamHoc CHAR(10), @MSV CHAR(10))
RETURNS DECIMAL(12,0)
AS
BEGIN
	DECLARE @TienNo DECIMAL(12,0);
	DECLARE @NamHoc_Max CHAR(10);
	DECLARE @HocKy_Max CHAR(5);

	-- set value for @NamHoc_Max and @HocKy_Max
	SELECT DISTINCT TOP 1 @NamHoc_Max = HOC_PHAN.NamHoc, @HocKy_Max = HOC_PHAN.HocKy
	FROM HOC_TAP
		JOIN HOC_PHAN		ON HOC_TAP.MaHP = HOC_PHAN.MaHP
		JOIN SINH_VIEN		ON HOC_TAP.MSV = SINH_VIEN.MSV
	WHERE SINH_VIEN.MSV = 'SV002'
	ORDER BY HOC_PHAN.NamHoc DESC, HOC_PHAN.HocKy DESC;

	IF @NamHoc = @NamHoc_Max AND @HocKy = @HocKy_Max
	BEGIN
		SET @TienNo = 2;
	END
	ELSE
	BEGIN
		SET @TienNo = 0.0;
	END;
RETURN @TienNo;
END;
GO;



-- tiền học phí theo năm A và học kỳ B
SELECT SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) AS 'TienHocPhi'
FROM HOC_TAP, HOC_PHAN, SINH_VIEN, LOP, 
	TIEN_TIN, BIEN_LAI
WHERE
    HOC_TAP.MaHP = HOC_PHAN.MaHP
AND HOC_TAP.MSV = SINH_VIEN.MSV
AND SINH_VIEN.MaL = LOP.MaL
AND LOP.MaTT = TIEN_TIN.MaTT
AND SINH_VIEN.MSV = 'SV001'
AND HOC_PHAN.HocKy = '1'
AND HOC_PHAN.NamHoc = '2020-2021'

-- Các học phần đã học và tiền tín
SELECT 
	SINH_VIEN.MSV, 
	HOC_PHAN.MaHP, 
	HOC_PHAN.SoTC, 
	TIEN_TIN.TienTC, 
	HOC_PHAN.HocKy, 
	HOC_PHAN.NamHoc,
	CT_DOI_TUONG.MaDT,
	DOI_TUONG.MucGiam
FROM HOC_TAP
	JOIN HOC_PHAN		ON HOC_TAP.MaHP = HOC_PHAN.MaHP
	JOIN SINH_VIEN		ON HOC_TAP.MSV = SINH_VIEN.MSV
	JOIN LOP			ON SINH_VIEN.MaL = LOP.MaL
	JOIN TIEN_TIN		ON LOP.MaTT = TIEN_TIN.MaTT
	LEFT JOIN CT_DOI_TUONG	ON SINH_VIEN.MSV = CT_DOI_TUONG.MSV
	JOIN DOI_TUONG		ON CT_DOI_TUONG.MaDT = DOI_TUONG.MaDT
WHERE SINH_VIEN.MSV = 'SV002'
-- AND HOC_PHAN.HocKy = '1'
AND HOC_PHAN.NamHoc <= '2021-2022'
AND CT_DOI_TUONG.NamHoc = HOC_PHAN.NamHoc

----
SELECT COUNT(DOI_TUONG.MucGiam)
FROM SINH_VIEN
	JOIN CT_DOI_TUONG ON SINH_VIEN.MSV = CT_DOI_TUONG.MSV
	JOIN DOI_TUONG ON CT_DOI_TUONG.MaDT = DOI_TUONG.MaDT
WHERE SINH_VIEN.MSV = 'SV002'
AND CT_DOI_TUONG.NamHoc = '2020-2021'
----
SELECT SINH_VIEN.MSV, 
	HOC_PHAN.MaHP, 
	HOC_PHAN.SoTC, 
	TIEN_TIN.TienTC, 
	HOC_PHAN.HocKy, 
	HOC_PHAN.NamHoc
FROM HOC_TAP
	JOIN HOC_PHAN		ON HOC_TAP.MaHP = HOC_PHAN.MaHP
	JOIN SINH_VIEN		ON HOC_TAP.MSV = SINH_VIEN.MSV
	JOIN LOP			ON SINH_VIEN.MaL = LOP.MaL
	JOIN TIEN_TIN		ON LOP.MaTT = TIEN_TIN.MaTT
WHERE SINH_VIEN.MSV = 'SV002'
AND HOC_PHAN.NamHoc = '2020-2021'
----
SELECT SINH_VIEN.MSV, 
	HOC_PHAN.MaHP, 
	HOC_PHAN.SoTC, 
	HOC_PHAN.HocKy, 
	HOC_PHAN.NamHoc,
	CT_DOI_TUONG.MaDT
FROM HOC_TAP
	JOIN HOC_PHAN		ON HOC_TAP.MaHP = HOC_PHAN.MaHP
	JOIN SINH_VIEN		ON HOC_TAP.MSV = SINH_VIEN.MSV
	FULL JOIN CT_DOI_TUONG ON HOC_PHAN.NamHoc = CT_DOI_TUONG.NamHoc
WHERE SINH_VIEN.MSV = 'SV002'
AND CT_DOI_TUONG.MSV = SINH_VIEN.MSV
--
SELECT HOC_PHAN.MaHP, 
	HOC_PHAN.SoTC, 
	HOC_PHAN.HocKy, 
	HOC_PHAN.NamHoc,
	CT_DOI_TUONG.MaDT
FROM HOC_PHAN
	LEFT JOIN CT_DOI_TUONG ON HOC_PHAN.NamHoc = CT_DOI_TUONG.NamHoc
WHERE CT_DOI_TUONG.MSV = 'SV002'

==========================================
SELECT * FROM CT_DOI_TUONG
WHERE MSV = 'SV002'

SELECT * FROM CT_DOI_TUONG WHERE MSV = 'SV001'





-- Số tiền cần đóng trong học kỳ  
--	= số tiền tín học trong học kỳ 
--	  + Số tiền nợ trong học kỳ trước
--	  - Miễn giảm trong học kỳ
SELECT (SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) * (1 - DOI_TUONG.MucGiam)) AS 'SoTienCanDong'
FROM HOC_TAP, HOC_PHAN, SINH_VIEN, LOP, 
	TIEN_TIN, CT_DOI_TUONG, DOI_TUONG, BIEN_LAI
WHERE
    HOC_TAP.MaHP = HOC_PHAN.MaHP
AND HOC_TAP.MSV = SINH_VIEN.MSV
AND SINH_VIEN.MaL = LOP.MaL
AND LOP.MaTT = TIEN_TIN.MaTT
AND SINH_VIEN.MSV = CT_DOI_TUONG.MSV
AND CT_DOI_TUONG.MaDT = DOI_TUONG.MaDT
AND SINH_VIEN.MSV = 'SV001'
AND HOC_PHAN.HocKy = '1'
AND HOC_PHAN.NamHoc = '2020-2021'
AND CT_DOI_TUONG.NamHoc = HOC_PHAN.NamHoc
GROUP BY DOI_TUONG.MucGiam

-- Tổng số tiền đã đóng theo các học kỳ và năm học
SELECT BIEN_LAI.TienNop, BIEN_LAI.NamHoc, BIEN_LAI.HocKy
FROM BIEN_LAI
WHERE BIEN_LAI.MSV = 'SV001'
AND BIEN_LAI.NamHoc = '2020-2021'
AND BIEN_LAI.HocKy = '1'

SELECT SUM(BIEN_LAI.TienNop)
FROM BIEN_LAI
WHERE BIEN_LAI.MSV = 'SV001'



-- insert into table 'CT_HOC_PHI'
insert into CT_HOC_PHI (MaKyHP, MaHP,TienHoc, TienNop, NgayNop)





GO;
-- Some test, note for insert table CT_HOC_PHI
select SINH_VIEN.MSV, 
		HOC_TAP.MaHP, 
		SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) as 'TienHoc',
		HOC_PHAN.MaKyHoc
from HOC_TAP
	join SINH_VIEN on SINH_VIEN.MSV = HOC_TAP.MSV
	join HOC_PHAN on HOC_PHAN.MaHP = HOC_TAP.MaHP
	join LOP on LOP.MaL = SINH_VIEN.MaL
	join TIEN_TIN on TIEN_TIN.MaTT = LOP.MaTT
group by SINH_VIEN.MSV, HOC_TAP.MaHP, HOC_PHAN.MaKyHoc

select * from KY_HOC_PHI
GO;
-- Some test, note for insert table KY_HOC_PHI
select SINH_VIEN.MSV, 
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) as 'HocPhi',
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)) as 'CanDong',
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) as 'CanDong'
from HOC_TAP
	join SINH_VIEN on SINH_VIEN.MSV = HOC_TAP.MSV
	join HOC_PHAN on HOC_PHAN.MaHP = HOC_TAP.MaHP
	join LOP on LOP.MaL = SINH_VIEN.MaL
	join TIEN_TIN on TIEN_TIN.MaTT = LOP.MaTT
	join CT_DOI_TUONG on CT_DOI_TUONG.MSV = SINH_VIEN.MSV
	join DOI_TUONG on DOI_TUONG.MaDT = CT_DOI_TUONG.MaDT
where  CT_DOI_TUONG.MaKyHoc = HOC_PHAN.MaKyHoc
group by SINH_VIEN.MSV
--
select SINH_VIEN.MSV, 
	((select CanDong from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV and MaKyHoc = (select MAX(MaKyHoc) from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV))
	- (SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)))
	+ (ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = SINH_VIEN.MSV), 0))) as 'DaDong'
from HOC_TAP
	join SINH_VIEN on SINH_VIEN.MSV = HOC_TAP.MSV
	join HOC_PHAN on HOC_PHAN.MaHP = HOC_TAP.MaHP
	join CT_DOI_TUONG on CT_DOI_TUONG.MSV = SINH_VIEN.MSV
	join DOI_TUONG on DOI_TUONG.MaDT = CT_DOI_TUONG.MaDT
	join LOP on LOP.MaL = SINH_VIEN.MaL
	join TIEN_TIN on TIEN_TIN.MaTT = LOP.MaTT
where CT_DOI_TUONG.MaKyHoc = HOC_PHAN.MaKyHoc
group by SINH_VIEN.MSV

--
select SINH_VIEN.MSV, 
	(SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam))) 'TongTienCanDong',
	(ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = SINH_VIEN.MSV), 0)) 'TongTienDaDong',

	(select CanDong from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV and MaKyHoc = (select MAX(MaKyHoc) from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV)) 'CanDong',

	((SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)))
	- (ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = SINH_VIEN.MSV), 0))) as 'ConNo',

	((select CanDong from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV and MaKyHoc = (select MAX(MaKyHoc) from KY_HOC_PHI where KY_HOC_PHI.MSV = SINH_VIEN.MSV))
	- (SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)))
	+ (ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = SINH_VIEN.MSV), 0))) as 'DaDong'
from HOC_TAP
	join SINH_VIEN on SINH_VIEN.MSV = HOC_TAP.MSV
	join HOC_PHAN on HOC_PHAN.MaHP = HOC_TAP.MaHP
	join CT_DOI_TUONG on CT_DOI_TUONG.MSV = SINH_VIEN.MSV
	join DOI_TUONG on DOI_TUONG.MaDT = CT_DOI_TUONG.MaDT
	join LOP on LOP.MaL = SINH_VIEN.MaL
	join TIEN_TIN on TIEN_TIN.MaTT = LOP.MaTT
where CT_DOI_TUONG.MaKyHoc = HOC_PHAN.MaKyHoc
group by SINH_VIEN.MSV
order by SINH_VIEN.MSV
--
-- Số tiền cần đóng của kỳ học gần đây nhất
select CanDong 
from KY_HOC_PHI 
where MSV = 'SV001' 
and MaKyHoc = (select MAX(MaKyHoc) from KY_HOC_PHI where MSV = 'SV001')

GO;
CREATE FUNCTION func_TinhTienDaDong
(@MSV CHAR(10))
RETURNS FLOAT(2)
AS
BEGIN
	DECLARE @TienDaNop DECIMAL(12,0);

	SET @TienDaNop = ISNULL((SELECT SUM(BIEN_LAI.TienNop)
							FROM BIEN_LAI
							WHERE MSV = 'SV001'), 0);
	PRINT @TienDaNop;
RETURN @TienDaNop;
END;

GO;