-- create database QLHocPhi;
use QLHocPhi;

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
	HocKy char(10) not null,
	NamHoc char(10) not null,
	Status bit not null default 1
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
	NamHoc char(10) not null,
	MSV char(10) not null foreign key references SINH_VIEN(MSV),
	MaDT Char(10) not null foreign key references DOI_TUONG(MaDT),
	Status Bit not null default 1,
	constraint pk_ctdoituong primary key(NamHoc, MSV)
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
	NamHoc char(10) not null default '2021-2022',
	HocKy char(5) not null default '1',
	TienNop decimal(12,0) not null,
	NgayNop date not null,
	Mota Ntext null,
	NgayCapNhat date not null,
	MaNguoiCapNhat char(10) not null,
	Status tinyint default 2, -- 0: hủy, 1: đã duyệt, 2: chưa duyệt
	constraint fk_bienlai_msv foreign key (MSV) references SINH_VIEN(MSV),
	constraint fk_bienlai_mans foreign key (MaNguoiCapNhat) references NHAN_SU(MaNS)
);


-- drop table [USER];
create table [USER](
	UserID int not null identity(1,1) primary key,
	Username char(10) null,
	[Password] varchar(255) not null,
	Status Bit NOT NULL
);

---- create table 'CT_BIEN_LAI'
--create table CT_BIEN_LAI(
--	MaBL char(10) not null foreign key (MaBL) references BIEN_LAI(MaBL),
--	MaHP char(10) not null foreign key (MaHP) references HOC_PHAN(MaHP),
--	SoTien decimal (12,0) not null,
--	constraint pk_ctbl primary key (MaBL, MaHP)
--);

-- ---------------------------------------------
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
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP001',N'Quản trị mạng',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP002',N'Dữ liệu phi cấu trúc',3,'01','1','2021');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP003',N'Mạng máy tính và truyền số liệu',3,'01','1','2021');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP004',N'Lập trình ứng dụng',3,'01','1','2021');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP005',N'Đại số',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP006',N'Giải tích',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP007',N'Vật lý đại cương',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP008',N'Cơ sở lập trình',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP009',N'Cấu trúc dữ liệu và giải thuật',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP010',N'Cơ sở dữ liệu',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP011',N'Hệ điều hành',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP012',N'Kiến trúc máy tính',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP013',N'Phân tích thiết kế hệ thống',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP014',N'Lập trình hướng đối tượng',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP015',N'Hệ hỗ trợ ra quyết định',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP016',N'Kỹ nghệ phần mềm',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP017',N'Xử lý ảnh',3,'01','2','2022');
insert into HOC_PHAN (MaHP, TenHP, SoTC, LopHP, HocKy, NamHoc) values ('HP018',N'Trí tuệ nhân tạo',3,'01','2','2022');
-- select * from HOC_PHAN
update HOC_PHAN set NamHoc = '2020-2021' where NamHoc = '2021'
update HOC_PHAN set NamHoc = '2021-2022' where NamHoc = '2022'

-- insert table 'DOI_TUONG'
insert into DOI_TUONG (MaDT, TenDT, MucGiam, Mota)
values
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
insert into CT_DOI_TUONG (MaDT, MSV, NamHoc)
values
	('DT001', 'SV001', '2020-2021'),
	('DT001', 'SV001', '2021-2022'),
	('DT002', 'SV002', '2021-2022');
-- select * from CT_DOI_TUONG;

-- insert table 'HOC_TAP'
insert into HOC_TAP (MSV, MaHP)
values 
	('SV001', 'HP001'), 
	('SV001', 'HP003'),
	('SV001', 'HP011'),
	('SV001', 'HP015'),
	('SV002', 'HP001'),
	('SV002', 'HP005'),
	('SV002', 'HP002'),
	('SV003', 'HP001'),
	('SV003', 'HP006'),
	('SV003', 'HP009'),
	('SV004', 'HP001'),
	('SV004', 'HP007'),
	('SV004', 'HP009'),
	('SV005', 'HP002'),
	('SV005', 'HP009'),
	('SV005', 'HP017'),
	('SV006', 'HP003'),
	('SV006', 'HP014'),
	('SV006', 'HP007'),
	('SV007', 'HP001'),
	('SV007', 'HP007'),
	('SV008', 'HP010'),
	('SV008', 'HP003'),
	('SV008', 'HP007'),
	('SV008', 'HP009'),
	('SV009', 'HP001'),
	('SV009', 'HP002'),
	('SV010', 'HP001'),
	('SV010', 'HP002'),
	('SV010', 'HP003'),
	('SV010', 'HP013'),
	('SV010', 'HP018'); 
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
insert into BIEN_LAI (MaBL, TenBL, MSV, TienNop, NgayNop, Mota, NgayCapNhat, MaNguoiCapNhat, Status) values ('BL001', N'001 Trả tiền học phí kì 1', 'SV001', 5100000, '2022-01-05', N'Sinh viên 001', '2022-01-05', 'NS001', 1);
insert into BIEN_LAI (MaBL, TenBL, MSV, TienNop, NgayNop, Mota, NgayCapNhat, MaNguoiCapNhat, Status) values ('BL002', N'002 Trả tiền học phí kì 1', 'SV002', 3800000, '2022-01-05', N'Sinh viên 002', '2022-01-05', 'NS001', 1);
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

