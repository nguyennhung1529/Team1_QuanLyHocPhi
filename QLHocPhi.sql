-- create database QuanLyHocPhi;
use QuanLyHocPhi;

-- create table 'KY_HOC'
create table KY_HOC(
	MaKyHoc char(10) not null primary key,
	TenKyHoc nvarchar(30) not null,
	NamHoc char(10) not null,
	HocKy char(5) not null,
	Status bit not null default 1
);

-- create table 'KHOA_VIEN'
create table KHOA_VIEN(
	MaKh char(10) not null primary key,
	TenKh nvarchar(30) not null unique,
	DiaChi nvarchar(50) not null,
	Sdt char(10) not null,
	Status bit not null default 1
);

-- create table 'TIEN_TIN'
create table TIEN_TIN(
	MaTT char(10) not null primary key,
	TenTT nvarchar(20) not null,
	TienTC decimal(12,0) not null,
	Mota Ntext null,
	Status bit not null default 1
);

-- create table 'LOP'
create table LOP(
	MaL char(10) not null primary key,
	TenL nvarchar(60) not null unique,
	SiSo tinyint not null,
	MaKh char(10) not null,
	MaTT char(10) not null,
	Status bit not null default 1,
	constraint fk_lop_makh foreign key (MaKH) references KHOA_VIEN(MaKh),
	constraint fk_lop_matt foreign key (MaTT) references TIEN_TIN(MaTT)
);

-- create table 'HOC_PHAN'
create table HOC_PHAN(
	MaHP char(10) not null primary key,
	TenHP nvarchar(60) not null,
	SoTC tinyint not null,
	LopHP char(5) not null,
	MaKyHoc char(10) not null,
	Status bit not null default 1,
	constraint fk_hocphan_kyhoc foreign key (MaKyHoc) references KY_HOC(MaKyHoc)
);

-- create table 'DOI_TUONG'
CREATE TABLE DOI_TUONG(
	MaDT Char(10) NOT NULL PRIMARY KEY,
	TenDT Nvarchar(50) NOT NULL,
	MucGiam Float(2) NOT NULL,
	Mota Ntext,
	Status Bit NOT NULL DEFAULT 1
);

-- create table 'SINH_VIEN'
create table SINH_VIEN(
	MSV char(10) not null primary key,
	HoTen nvarchar(30) not null,
	GioiTinh bit not null,
	NgaySinh date not null,
	DiaChi nvarchar(50) not null,
	Sdt char(10) not null,
	Mail varchar(255) not null,
	MaL char(10) not null,
	-- MaDT char(10) not null,
	Status bit not null default 1,
	constraint fk_sinhvien_mal foreign key (MaL) references LOP(MaL),
	-- constraint fk_sinhvien_madt foreign key (MaDT) references DOI_TUONG(MaDT) 
);

-- create table 'CT_DOI_TUONG'
create table CT_DOI_TUONG(
	MaKyHoc char(10) not null foreign key references KY_HOC(MaKyHoc),
	MSV char(10) not null foreign key references SINH_VIEN(MSV),
	MaDT Char(10) not null foreign key references DOI_TUONG(MaDT),
	Status Bit not null default 1,
	constraint pk_ctdoituong primary key(MaKyHoc, MSV)
);

-- create table 'HOC_TAP'
create table HOC_TAP(
	MSV char(10) not null foreign key references SINH_VIEN(MSV),
	MaHP char(10) not null foreign key references HOC_PHAN(MaHP),
	constraint pk_hoctap primary key(MSV, MaHP)
);

-- create table 'NHAN_SU'
CREATE TABLE NHAN_SU(
	MaNS Char(10) NOT NULL PRIMARY KEY,
	TenNS Nvarchar(30) NOT NULL UNIQUE,
	GioiTinh Bit NOT NULL,
	NgaySinh Date NOT NULL,
	ChucVu Nvarchar(50) NOT NULL,
	DiaChi Nvarchar(50) NOT NULL,
	Sdt Char(10) NOT NULL,
	Mail Varchar(255) NOT NULL,
	Status Bit NOT NULL DEFAULT 1
);

-- create table 'BIEN_LAI'
create table BIEN_LAI(
	MaBL char(10) not null primary key,
	TenBL nvarchar(50) not null unique,
	MSV char(10) not null,
	MaKyHoc char(10) not null,
	TienNop decimal(12,0) not null,
	NgayNop date not null,
	Mota Ntext null,
	NgayCapNhat date not null,
	MaNguoiCapNhat char(10) not null,
	Status tinyint default 2, -- 0: ẩn, 1: đã duyệt, 2: chưa duyệt
	constraint fk_bienlai_msv foreign key (MSV) references SINH_VIEN(MSV),
	constraint fk_bienlai_mans foreign key (MaNguoiCapNhat) references NHAN_SU(MaNS)
);
ALTER TABLE BIEN_LAI
ALTER COLUMN MaNguoiCapNhat char(10) null;

-- drop table [USER];
create table [USER](
	UserID int not null identity(1,1) primary key,
	Username char(10) null,
	[Password] varchar(255) not null,
	Status Bit NOT NULL
);

-- create table 'KY_HOC_PHI'
create table KY_HOC_PHI(
	MaKyHP int not null identity(1,1) primary key,
	MaKyHoc char(10) not null,
	MSV char(10) not null,
	HocPhi decimal (12,0) not null default 0,
	CanDong decimal (12,0) not null default 0,
	DaDong decimal (12,0) not null default 0,
	constraint pk_kyhocphi_kyhoc foreign key (MaKyHoc) references KY_HOC(MaKyHoc),
	constraint fk_kyhocphi_msv foreign key (MSV) references SINH_VIEN(MSV)
);

-- create table 'CT_HOC_PHI'
create table CT_HOC_PHI(
	MaKyHP int not null foreign key (MaKyHP) references KY_HOC_PHI(MaKyHP),
	MaHP char(10) not null foreign key (MaHP) references HOC_PHAN(MaHP),
	TienHoc decimal (12,0) not null,
	CanDong decimal (12,0) not null,
	ConNo decimal (12,0) not null default 0,
	NgayNop date null,
	constraint pk_cthocphi primary key(MaKyHP, MaHP)
);

---- create table 'CT_BIEN_LAI'
--create table CT_BIEN_LAI(
--	MaBL char(10) not null foreign key (MaBL) references BIEN_LAI(MaBL),
--	MaHP char(10) not null foreign key (MaHP) references HOC_PHAN(MaHP),
--	SoTien decimal (12,0) not null,
--	constraint pk_ctbl primary key (MaBL, MaHP)
--);

-- ---------------------------------------------
-- insert table 'KY_HOC'
insert into KY_HOC(MaKyHoc, TenKyHoc, NamHoc, HocKy) 
values 
	('MKH001', N'Năm 2020-2021, Học kỳ 1', '2020-2021', '1'),
	('MKH002', N'Năm 2020-2021, Học kỳ 2', '2020-2021', '2'),
	('MKH003', N'Năm 2020-2021, Học kỳ 3', '2020-2021', '3'),
	('MKH004', N'Năm 2021-2022, Học kỳ 1', '2021-2022', '1'),
	('MKH005', N'Năm 2021-2022, Học kỳ 2', '2021-2022', '2'),
	('MKH006', N'Năm 2021-2022, Học kỳ 3', '2021-2022', '3');
-- select * from KY_HOC;

-- insert table 'KHOA_VIEN'
insert into KHOA_VIEN (MaKh, TenKh, DiaChi, Sdt, Status) values ('KH001', N'Khoa học máy tính', N'Phòng 1001', '093784186', 1);
insert into KHOA_VIEN (MaKh, TenKh, DiaChi, Sdt, Status) values ('KH002', N'Công nghệ thông tin', N'Phòng 1003', '093784186', 1);
insert into KHOA_VIEN (MaKh, TenKh, DiaChi, Sdt, Status) values ('KH003', N'Hệ thống thông tin quản lý', N'Phòng 1002', '093784186', 1);
-- select * from KHOA_VIEN;

-- insert table 'TIEN_TIN'
insert into TIEN_TIN (MaTT, TenTT, TienTC, Mota) values ('TT001',N'Tiền tín chỉ loại 01',425000,'');
insert into TIEN_TIN (MaTT, TenTT, TienTC, Mota) values ('TT002',N'Tiền tín chỉ loại 02',525000,'');
insert into TIEN_TIN (MaTT, TenTT, TienTC, Mota) values ('TT003',N'Tiền tín chỉ loại 03',625000,'');
-- select * from TIEN_TIN

-- insert table 'LOP'
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L001', N'Khoa học máy tính 61', 60, 'KH001', 'TT001');
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L002', N'Khoa học máy tính 62', 55, 'KH001', 'TT001');
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L003', N'Công nghệ thông tin 61', 88, 'KH002', 'TT002');
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L004', N'Công nghệ thông tin 62', 80, 'KH002', 'TT002');
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L005', N'Hệ thống thông tin quản lý 61', 95, 'KH003', 'TT003');
Insert into LOP (MaL, TenL, SiSo, MaKh, MaTT) values ('L006', N'Hệ thống thông tin quản lý 62', 100, 'KH003', 'TT003');
-- select * from LOP;

-- insert table 'HOC_PHAN'
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, MaKyHoc) 
values 
	('HP001',N'Quản trị mạng',3,'01','MKH001'),
	('HP002',N'Dữ liệu phi cấu trúc',3,'01','MKH001'),
	('HP003',N'Mạng máy tính và truyền số liệu',3,'01','MKH001'),
	('HP004',N'Lập trình ứng dụng',3,'01','MKH001'),
	('HP005',N'Đại số',3,'01','MKH002'),
	('HP006',N'Giải tích',3,'01','MKH002'),
	('HP007',N'Vật lý đại cương',3,'01','MKH002'),
	('HP008',N'Cơ sở lập trình',3,'01','MKH002'),
	('HP009',N'Cấu trúc dữ liệu và giải thuật',3,'01','MKH002'),
	('HP010',N'Cơ sở dữ liệu',3,'01','MKH002'),
	('HP011',N'Hệ điều hành',3,'01','MKH004'),
	('HP012',N'Kiến trúc máy tính',3,'01','MKH004'),
	('HP013',N'Phân tích thiết kế hệ thống',3,'01','MKH004'),
	('HP014',N'Lập trình hướng đối tượng',3,'01','MKH004'),
	('HP015',N'Hệ hỗ trợ ra quyết định',3,'01','MKH005'),
	('HP016',N'Kỹ nghệ phần mềm',3,'01','MKH005'),
	('HP017',N'Xử lý ảnh',3,'01','MKH005'),
	('HP018',N'Trí tuệ nhân tạo',3,'01','MKH005');
-- select * from HOC_PHAN

-- insert table 'DOI_TUONG'
insert into DOI_TUONG (MaDT, TenDT, MucGiam, Mota)
values
	('DT000',N'Sinh viên bình thường',0,''),
	('DT001',N'Sinh viên gia đình hộ nghèo',0.5,''),
	('DT002',N'Sinh viên có hoàn cảnh khó khăn',0.7,''),
	('DT003',N'Sinh viên khuyết tật',0.9,''),
	('DT004',N'Sinh viên có gia đình là thương binh liệt sĩ',1,'');
-- select * from DOI_TUONG;

-- insert table 'SINH_VIEN'
insert into SINH_VIEN (MSV, HoTen, GioiTinh, NgaySinh, DiaChi, Sdt, Mail, MaL) 
values 
	('SV001', N'Nguyễn Bình An', 1,'2001-08-01', N'213 Trần Đại Nghĩa', '1234567891','hot@gmail.com', 'L001'),
	('SV002', N'Nguyễn Minh Châu', 1,'2001-05-01', N'213 Trần Đại Nghĩa', '1334567891','chau@gmail.com', 'L001'),
	('SV003', N'Đỗ Khánh An', 0,'2000-01-01', N'123 Ngọc Khánh', '2234567891','an@gmail.com', 'L002'),
	('SV004', N'Bùi Văn Lâm', 0,'2001-05-01', N'213 Trần Đại Nghĩa', '1334567877','lam@gmail.com', 'L003'),
	('SV005', N'Nguyễn Văn Chính', 0,'2002-02-01', N'124 Chùa Bộc', '1334567823','chinh@gmail.com', 'L002'),
	('SV006', N'Nguyễn Hải An', 1,'2001-05-01', N'213 Trần Đại Nghĩa', '4434567891','tt@gmail.com', 'L001'),
	('SV007', N'Đỗ Tấn Phát', 0,'2001-05-09', N'213 Trần Đại Nghĩa', '1312367891','phat@gmail.com', 'L003'),
	('SV008', N'Nguyễn Thị Linh', 1,'2001-10-01', N'213 Trần Đại Nghĩa', '1134567891','linh@gmail.com', 'L004'),
	('SV009', N'Nguyễn Hải An', 1,'2001-05-07', N'213 Trần Đại Nghĩa', '1330067891','an@gmail.com', 'L005'),
	('SV010', N'Nguyễn Tuyết Ngân', 1,'2001-12-01', N'213 Trần Đại Nghĩa', '0034567891','ngan@gmail.com', 'L006');
-- select * from SINH_VIEN;

-- insert table 'CT_DOI_TUONG'
insert into CT_DOI_TUONG (MaDT, MSV, MaKyHoc)
values
	('DT001', 'SV001', 'MKH001'),
	('DT001', 'SV001', 'MKH002'),
	('DT001', 'SV001', 'MKH003'),
	('DT001', 'SV001', 'MKH004'),
	('DT001', 'SV001', 'MKH005'),
	('DT002', 'SV001', 'MKH006'),
	('DT002', 'SV002', 'MKH004'),
	('DT002', 'SV002', 'MKH005'),
	('DT002', 'SV002', 'MKH006');

insert into CT_DOI_TUONG (MaKyHoc, MSV, MaDT)
values
	('MKH001', 'SV002', 'DT000'),
	('MKH001', 'SV003', 'DT000'),
	('MKH001', 'SV004', 'DT000'),
	('MKH001', 'SV005', 'DT000'),
	('MKH001', 'SV006', 'DT000'),
	('MKH001', 'SV007', 'DT000'),
	('MKH001', 'SV008', 'DT000'),
	('MKH001', 'SV009', 'DT000'),
	('MKH001', 'SV010', 'DT000'),
	('MKH002', 'SV002', 'DT000'),
	('MKH002', 'SV003', 'DT000'),
	('MKH002', 'SV004', 'DT000'),
	('MKH002', 'SV005', 'DT000'),
	('MKH002', 'SV006', 'DT000'),
	('MKH002', 'SV007', 'DT000'),
	('MKH002', 'SV008', 'DT000'),
	('MKH002', 'SV009', 'DT000'),
	('MKH002', 'SV010', 'DT000'),
	('MKH003', 'SV002', 'DT000'),
	('MKH003', 'SV003', 'DT000'),
	('MKH003', 'SV004', 'DT000'),
	('MKH003', 'SV005', 'DT000'),
	('MKH003', 'SV006', 'DT000'),
	('MKH003', 'SV007', 'DT000'),
	('MKH003', 'SV008', 'DT000'),
	('MKH003', 'SV009', 'DT000'),
	('MKH003', 'SV010', 'DT000'),
	('MKH004', 'SV003', 'DT000'),
	('MKH004', 'SV004', 'DT000'),
	('MKH004', 'SV005', 'DT000'),
	('MKH004', 'SV006', 'DT000'),
	('MKH004', 'SV007', 'DT000'),
	('MKH004', 'SV008', 'DT000'),
	('MKH004', 'SV009', 'DT000'),
	('MKH004', 'SV010', 'DT000'),
	('MKH005', 'SV003', 'DT000'),
	('MKH005', 'SV004', 'DT000'),
	('MKH005', 'SV005', 'DT000'),
	('MKH005', 'SV006', 'DT000'),
	('MKH005', 'SV007', 'DT000'),
	('MKH005', 'SV008', 'DT000'),
	('MKH005', 'SV009', 'DT000'),
	('MKH005', 'SV010', 'DT000'),
	('MKH006', 'SV003', 'DT000'),
	('MKH006', 'SV004', 'DT000'),
	('MKH006', 'SV005', 'DT000'),
	('MKH006', 'SV006', 'DT000'),
	('MKH006', 'SV007', 'DT000'),
	('MKH006', 'SV008', 'DT000'),
	('MKH006', 'SV009', 'DT000'),
	('MKH006', 'SV010', 'DT000');
-- select * from CT_DOI_TUONG;

-- insert table 'HOC_TAP'
insert into HOC_TAP (MSV, MaHP)
values 
	('SV001', 'HP001'), 
	('SV001', 'HP002'), 
	('SV001', 'HP003'),
	('SV001', 'HP005'),
	('SV001', 'HP006'),
	('SV001', 'HP011'),
	('SV001', 'HP012'),
	('SV001', 'HP018'),
	('SV002', 'HP016'),
	('SV002', 'HP017'),
	('SV002', 'HP018'),
	('SV003', 'HP015'),
	('SV003', 'HP016'),
	('SV003', 'HP017'),
	('SV004', 'HP013'),
	('SV004', 'HP014'),
	('SV004', 'HP018'),
	('SV005', 'HP012'),
	('SV005', 'HP013'),
	('SV005', 'HP014'),
	('SV006', 'HP001'),
	('SV006', 'HP004'),
	('SV006', 'HP005'),
	('SV006', 'HP010'),
	('SV006', 'HP011'),
	('SV006', 'HP014'),
	('SV006', 'HP015'),
	('SV006', 'HP017'),
	('SV007', 'HP017'),
	('SV007', 'HP018'),
	('SV008', 'HP012'),
	('SV008', 'HP013'),
	('SV008', 'HP016'),
	('SV008', 'HP017'),
	('SV009', 'HP017'),
	('SV009', 'HP018'),
	('SV010', 'HP001'),
	('SV010', 'HP002'),
	('SV010', 'HP003'),
	('SV010', 'HP005'),
	('SV010', 'HP010'),
	('SV010', 'HP011'), 
	('SV010', 'HP012'), 
	('SV010', 'HP013'), 
	('SV010', 'HP015'), 
	('SV010', 'HP016'), 
	('SV010', 'HP017');
-- select * from HOC_TAP;

-- insert table 'NHAN_SU'
insert into NHAN_SU
values
	('NS001',N'Vũ Mai Linh',0,'2001-06-05',N'Trưởng phòng',N'Phòng 1320','0324545399','mailinhvu@gmail.com',1),
	('NS002',N'Nguyễn Hương Giang',0,'2001-10-23',N'Phó Trưởng phòng',N'Phòng 1320','0345777766','huonggiang2310@gmail.com',1),
	('NS003',N'Đặng Bảo Ngọc',0,'2001-07-22',N'Chuyên viên',N'Phòng 1320','0344563288','baongoc2207@gmail.com',1),
	('NS004',N'Phan Khánh Vân',0,'2001-09-15',N'Chuyên viên',N'Phòng 1320','0388656549','khanhvanphan@gmail.com',1);
-- select * from NHAN_SU;

-- insert table 'BIEN_LAI'
insert into BIEN_LAI (MaBL, TenBL, MSV, TienNop, NgayNop, Mota, NgayCapNhat, MaNguoiCapNhat, MaKyHoc, Status) 
values 
	('BL001', N'001 Trả tiền học phí kì 1 năm 2020-2021', 'SV001', 4000000, '2020-06-05', N'Sinh viên 001', '2020-06-05', 'NS001', 'MKH001', 1),
	('BL002', N'002 Trả tiền học phí kì 2 năm 2020-2021', 'SV001', 3000000, '2021-04-05', N'Sinh viên 001', '2021-04-05', 'NS001', 'MKH002', 1),
	('BL003', N'003 Trả tiền học phí kì 1 năm 2021-2022', 'SV001', 2550000, '2021-06-05', N'Sinh viên 001', '2021-06-05', 'NS001', 'MKH004', 1),
	('BL004', N'004 Trả tiền học phí kì 2 năm 2021-2022', 'SV001', 1275000, '2022-04-05', N'Sinh viên 001', '2022-04-05', 'NS001', 'MKH005', 2),
	('BL005', N'005 Trả tiền học phí kì 2 năm 2021-2022', 'SV002', 3800000, '2022-04-05', N'Sinh viên 002', '2022-04-05', 'NS002', 'MKH005', 2),
	('BL006', N'006 Trả tiền học phí kì 2 năm 2021-2022', 'SV003', 3800000, '2022-04-05', N'Sinh viên 003', '2022-04-05', 'NS003', 'MKH005', 2),
	('BL007', N'007 Trả tiền học phí kì 1 năm 2021-2022', 'SV004', 3800000, '2021-06-05', N'Sinh viên 004', '2021-06-05', 'NS004', 'MKH004', 1),
	('BL008', N'008 Trả tiền học phí kì 2 năm 2021-2022', 'SV004', 1500000, '2022-04-05', N'Sinh viên 004', '2022-04-05', 'NS004', 'MKH005', 2),
	('BL009', N'009 Trả tiền học phí kì 1 năm 2021-2022', 'SV005', 4000000, '2021-06-05', N'Sinh viên 005', '2021-06-05', 'NS004', 'MKH004', 1),
	('BL010', N'010 Trả tiền học phí kì 1 năm 2020-2021', 'SV006', 2550000, '2020-06-05', N'Sinh viên 006', '2020-06-05', 'NS004', 'MKH001', 1),
	('BL011', N'011 Trả tiền học phí kì 2 năm 2020-2021', 'SV006', 2550000, '2021-04-05', N'Sinh viên 006', '2021-04-05', 'NS004', 'MKH002', 1),
	('BL012', N'012 Trả tiền học phí kì 1 năm 2021-2022', 'SV006', 2550000, '2021-06-05', N'Sinh viên 006', '2021-06-05', 'NS003', 'MKH004', 1),
	('BL013', N'013 Trả tiền học phí kì 1 năm 2021-2022', 'SV008', 3150000, '2021-06-05', N'Sinh viên 006', '2021-06-05', 'NS003', 'MKH004', 1),
	('BL014', N'014 Trả tiền học phí kì 1 năm 2020-2021', 'SV010', 6000000, '2020-06-05', N'Sinh viên 001', '2020-06-05', 'NS002', 'MKH001', 1),
	('BL015', N'015 Trả tiền học phí kì 2 năm 2020-2021', 'SV010', 5600000, '2021-04-05', N'Sinh viên 001', '2021-04-05', 'NS002', 'MKH002', 1),
	('BL016', N'016 Trả tiền học phí kì 1 năm 2021-2022', 'SV010', 5625000, '2021-06-05', N'Sinh viên 001', '2021-06-05', 'NS002', 'MKH004', 1);
-- select * from BIEN_LAI;

-- insert table 'USER'
insert into [USER] ([Username], [Password], [Status])
values 
	('NS001', 'NS001123456789', 1),
	('NS002', 'NS002123456789', 1),
	('NS003', 'NS003123456789', 1),
	('NS004', 'NS004123456789', 1),
	('SV001', 'SV001123456789', 0),
	('SV002', 'SV002123456789', 0),
	('SV003', 'SV003123456789', 0),
	('SV004', 'SV004123456789', 0),
	('SV005', 'SV005123456789', 0),
	('SV006', 'SV006123456789', 0),
	('SV007', 'SV007123456789', 0),
	('SV008', 'SV008123456789', 0),
	('SV009', 'SV009123456789', 0),
	('SV010', 'SV010123456789', 0)
-- select * from [USER]

---- create table 'CT_BIEN_LAI'
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL001','HP001',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL001','HP003',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL001','HP011',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL001','HP015',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL002','HP001',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL002','HP005',1275000);
--insert into CT_BIEN_LAI (MaBL, MaHP, SoTien) values ('BL002','HP002',1250000);
---- select * from CT_BIEN_LAI
--
GO;
-- insert into table 'KY_HOC_PHI'
-- delete from KY_HOC_PHI
insert into KY_HOC_PHI (MaKyHoc, MSV, HocPhi, CanDong, DaDong)
select HOC_PHAN.MaKyHoc, 
	SINH_VIEN.MSV, 
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC) as 'HocPhi',
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)) as 'CanDong',
	SUM(HOC_PHAN.SoTC * TIEN_TIN.TienTC * (1 - DOI_TUONG.MucGiam)) as 'DaDong'
from HOC_TAP
	join SINH_VIEN on SINH_VIEN.MSV = HOC_TAP.MSV
	join HOC_PHAN on HOC_PHAN.MaHP = HOC_TAP.MaHP
	join LOP on LOP.MaL = SINH_VIEN.MaL
	join TIEN_TIN on TIEN_TIN.MaTT = LOP.MaTT
	join CT_DOI_TUONG on CT_DOI_TUONG.MSV = SINH_VIEN.MSV
	join DOI_TUONG on DOI_TUONG.MaDT = CT_DOI_TUONG.MaDT
where CT_DOI_TUONG.MaKyHoc = HOC_PHAN.MaKyHoc
group by HOC_PHAN.MaKyHoc, SINH_VIEN.MSV
-- select * from KY_HOC_PHI
-- 
-- update value of DaDong (xét ở kỳ cuối)
-- Nợ = Tổng học phí - Tổng miễn giảm - Tổng đóng (tất cả xét ở kỳ cuối) = Tổng cần đóng - tổng đã đóng
-- => Tổng đóng = Tổng học phí - Tổng miễn giảm - 
-- Đã đóng = Cần Đóng - Tổng cần đóng + tổng nộp

--UPDATE KY_HOC_PHI
--SET DaDong = (select ((select CanDong 
--							from KY_HOC_PHI
--							where KY_HOC_PHI.MSV = SV.MSV 
--							and MaKyHoc = (select MAX(MaKyHoc) from KY_HOC_PHI where KY_HOC_PHI.MSV = SV.MSV))
--					- (SUM(HP.SoTC * TT.TienTC * (1 - DT.MucGiam)))
--					+ (ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = SV.MSV), 0))) as 'DaDong'
--				from HOC_TAP AS HT
--					join SINH_VIEN		AS SV	on SV.MSV = HT.MSV
--					join HOC_PHAN		AS HP	on HP.MaHP = HT.MaHP
--					join CT_DOI_TUONG	AS CTDT on CTDT.MSV = SV.MSV
--					join DOI_TUONG		AS DT	on DT.MaDT = CTDT.MaDT
--					join LOP			AS L	on L.MaL = SV.MaL
--					join TIEN_TIN		AS TT	on TT.MaTT = L.MaTT
--				where CTDT.MaKyHoc = HP.MaKyHoc
--				and SV.MSV = KY_HOC_PHI.MSV
--				group by SV.MSV)
--WHERE MaKyHoc = (SELECT MAX(A1.MaKyHoc) 
--					FROM KY_HOC_PHI AS A1
--					WHERE A1.MSV = KY_HOC_PHI.MSV
--					GROUP BY A1.MSV);
---- select * from KY_HOC_PHI

UPDATE KY_HOC_PHI
SET DaDong = ((SELECT CanDong 
					FROM KY_HOC_PHI AS KHP
					WHERE KHP.MSV = KY_HOC_PHI.MSV 
					AND KHP.MaKyHoc = (SELECT MAX(A1.MaKyHoc) FROM KY_HOC_PHI AS A1 WHERE A1.MSV = KY_HOC_PHI.MSV))
			- ((SELECT SUM(A2.CanDong) FROM KY_HOC_PHI AS A2 WHERE A2.MSV = KY_HOC_PHI.MSV) - 
				(ISNULL((SELECT SUM(BIEN_LAI.TienNop) FROM BIEN_LAI WHERE BIEN_LAI.MSV = KY_HOC_PHI.MSV AND BIEN_LAI.Status != 2), 0))))
WHERE MaKyHoc = (SELECT MAX(A1.MaKyHoc) FROM KY_HOC_PHI AS A1 WHERE A1.MSV = KY_HOC_PHI.MSV);
-- SELECT * FROM KY_HOC_PHI;
GO;

--SELECT SUM(CanDong), MSV FROM KY_HOC_PHI GROUP BY MSV
--SELECT SUM(TienNop), MSV FROM BIEN_LAI WHERE BIEN_LAI.Status != 2 GROUP BY MSV
--SELECT * FROM KY_HOC_PHI;

-- update value of CT_HOC_PHI
GO;
INSERT INTO CT_HOC_PHI (MaKyHP, MaHP, TienHoc, CanDong)
SELECT DISTINCT
	KHP.MaKyHP,
	HP.MaHP,
	TT.TienTC * HP.SoTC AS 'TienHoc',
	TT.TienTC * HP.SoTC * (1 - DT.MucGiam) AS 'CanDong'
FROM HOC_TAP AS HT
	JOIN SINH_VIEN		AS SV	ON SV.MSV = HT.MSV
	JOIN HOC_PHAN		AS HP	ON HP.MaHP = HT.MaHP
	JOIN CT_DOI_TUONG	AS CTDT ON CTDT.MSV = SV.MSV
	JOIN DOI_TUONG		AS DT	ON DT.MaDT = CTDT.MaDT
	JOIN LOP			AS L	ON L.MaL = SV.MaL
	JOIN TIEN_TIN		AS TT	ON TT.MaTT = L.MaTT
	JOIN KY_HOC_PHI		AS KHP	ON KHP.MSV = SV.MSV
WHERE CTDT.MaKyHoc = HP.MaKyHoc
AND CTDT.MaKyHoc = KHP.MaKyHoc

-- select * from CT_HOC_PHI
-- Cập nhật giá trị CT_HOC_PHI.NgayNop
GO;
UPDATE CT_HOC_PHI
SET NgayNop = BIEN_LAI.NgayNop
FROM CT_HOC_PHI
	JOIN KY_HOC_PHI ON KY_HOC_PHI.MaKyHP = CT_HOC_PHI.MaKyHP
	JOIN BIEN_LAI ON BIEN_LAI.MSV = KY_HOC_PHI.MSV
WHERE BIEN_LAI.MaKyHoc = KY_HOC_PHI.MaKyHoc

-- select * from CT_HOC_PHI
-- Cập nhật giá trị KY_HOC_PHI.ConNo
GO;
DECLARE @MaKyHP int;
DECLARE cursorGetLastMKH CURSOR FOR
	SELECT DISTINCT MaKyHP
	FROM KY_HOC_PHI
	WHERE MaKyHoc = (SELECT MAX(A.MaKyHoc) 
						FROM KY_HOC_PHI AS A 
						WHERE A.MSV = KY_HOC_PHI.MSV);
OPEN cursorGetLastMKH;
FETCH NEXT FROM cursorGetLastMKH INTO @MaKyHP;
WHILE @@FETCH_STATUS = 0
BEGIN
	EXEC sp_update_CTHP @MaKyHP;
	FETCH NEXT FROM cursorGetLastMKH INTO @MaKyHP;
END;
CLOSE cursorGetLastMKH;
DEALLOCATE cursorGetLastMKH;
--select * from CT_HOC_PHI
--select *  from KY_HOC_PHI
GO;
--UPDATE CT_HOC_PHI
--SET NgayNop = '2021-06-05'
--WHERE MaKyHP = 147
--AND MaHP = 'HP015'

