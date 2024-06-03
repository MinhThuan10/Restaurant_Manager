create database QLNH
go

use QLNH
go

create table CongViec
(
	MaCV int CONSTRAINT PK_CongViec PRIMARY KEY IDENTITY(1,1),
	TenCV nvarchar(50) NOT NULL,
	Luong float check (Luong > 0)
)
go

CREATE TABLE NhanVien(
	MaNV int CONSTRAINT PK_NhanVien PRIMARY KEY IDENTITY(1,1),
	HoNV nvarchar(20) NOT NULL,
	TenNV nvarchar(10) NOT NULL,
	NgaySinh date check (DATEDIFF(year, NgaySinh, GETDATE())>=18),
	GioiTinh nvarchar(3),
	DiaChi nvarchar(100),
	SDT nchar(11) NOT NULL check (len(SDT)=10) unique,
	NgayTD date check (DATEDIFF(day, NgayTD, GETDATE())>=0),
	MaNQL int CONSTRAINT FK_NV_QL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaCV int CONSTRAINT FK_NL_CV FOREIGN KEY REFERENCES CongViec(MaCV)
)
go

create table CaLamViec
(
	MaCa int CONSTRAINT PK_CaLamViec PRIMARY KEY IDENTITY(1,1),
	GioBD time,
	GioKT time,
	CONSTRAINT GioBD_KT CHECK (GioBD < GioKT)
)
go

create table NhaCungCap
(
	MaNCC int CONSTRAINT PK_NhaCungCap PRIMARY KEY IDENTITY(1,1),
	TenNCC nvarchar(50) NOT NULL,
	DiaChi nvarchar(100),
	SDT nchar(10) NOT NULL unique
)
go

create table NguyenLieu
(
	MaNL int CONSTRAINT PK_NguyenLieu PRIMARY KEY IDENTITY(1,1),
	TenNL nvarchar(50) NOT NULL unique,
	DonViTinh nvarchar(10) Not Null,
	SoLuong int check (SoLuong > 0) not null,
	MaNVQL int CONSTRAINT FK_NL_QL FOREIGN KEY REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
	SLTonKho int check (SLTonKho > 0) not null
)
go

create table DonNhapTP
(
	MaDon int CONSTRAINT PK_DonNhapTP PRIMARY KEY IDENTITY(1,1),
	NgNhap datetime not null,
	GiaTien float not null,
	MaNV int CONSTRAINT FK_DNTP_NV FOREIGN KEY REFERENCES NhanVien(MaNV) ON DELETE SET NULL
)
go


create table KhachHang
(
	MaKH int CONSTRAINT PK_KhachHang PRIMARY KEY IDENTITY(1,1),
	TenKH nvarchar(50),
	GioiTinh nvarchar(3),
	DiemTL int not null,
	DiaChi nvarchar(100),
	SDT nchar(11) check (len(SDT)=10)
)
go

create table SanPham
(
	MaSP int CONSTRAINT PK_SanPham PRIMARY KEY IDENTITY(1,1),
	TenSP nvarchar(50) NOT NULL unique,
	DonGia int check (DonGia > 0),
)
go

CREATE TABLE BanAn
(
    MaBan int CONSTRAINT PK_BanAn PRIMARY KEY IDENTITY(1,1),
    LoaiBan nvarchar(50) NOT NULL,
    SoNguoi int NOT NULL
);
go


CREATE TABLE HoaDon
(
    MaHD int CONSTRAINT PK_HoaDon PRIMARY KEY IDENTITY(1,1),
    ThoiGian datetime NOT NULL,
    TrangThai nvarchar(50) NOT NULL,
    TriGiaHD float NOT NULL,
    MaKH int CONSTRAINT FK_HoaDon_KH FOREIGN KEY REFERENCES KhachHang(MaKH) ON DELETE SET NULL,
	MaNV int CONSTRAINT FK_HoaDon_NV FOREIGN KEY REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
    MaBan int CONSTRAINT FK_HoaDon_BA FOREIGN KEY REFERENCES BanAn(MaBan),
);
go


create table ChiTietHD
(
	MaHD int CONSTRAINT FK_ChiTietHD_HD FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
	MaSP int CONSTRAINT FK_ChiTietHD_SP FOREIGN KEY REFERENCES SanPham(MaSP) ON DELETE CASCADE,
	CONSTRAINT PK_ChiTietHD PRIMARY KEY (MaHD, MaSP),
	SoLuong int check (SoLuong > 0)
)
go

create table PhanCa
(
	MaNV int CONSTRAINT FK_PhanCa_NV FOREIGN KEY REFERENCES NhanVien(MaNV) ON DELETE CASCADE,
	MaCa int CONSTRAINT FK_PhanCa_CLV FOREIGN KEY REFERENCES CaLamViec(MaCa),
	CONSTRAINT PK_PhanCa PRIMARY KEY (MaNV, MaCa),
	Ngay Date not null 
)
go

create table CheBien
(
	MaNV int CONSTRAINT FK_CheBien_NV FOREIGN KEY REFERENCES NhanVien(MaNV) ON DELETE CASCADE,
	MaSP int CONSTRAINT FK_CheBien_SP FOREIGN KEY REFERENCES SanPham(MaSP) ON DELETE CASCADE,
	CONSTRAINT PK_CheBien PRIMARY KEY (MaNV, MaSP),
	ThoiGian DateTime not null
)
go

create table CTDonNhap
(
	MaNL int CONSTRAINT FK_CTDonNhap_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL) ON DELETE CASCADE,
	MaDon int CONSTRAINT FK_CTDonNhap_HD FOREIGN KEY REFERENCES DonNhapTP(MaDon) ON DELETE CASCADE,
	CONSTRAINT PK_CTDonNhap PRIMARY KEY (MaNL, MaDon),
	SoLuong int Check (SoLuong > 0)
)
go

create table CTNgLieu
(
	MaNL int CONSTRAINT FK_CTNgLieu_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL) ON DELETE CASCADE,
	MaNCC int CONSTRAINT FK_CTNgLieu_NCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC),
	CONSTRAINT PK_CTNgLieu PRIMARY KEY (MaNL, MaNCC),
	GiaTienNL float check (GiaTienNL > 0)
)
go

create table SP_NL
(
	MaSP int CONSTRAINT FK_SP_NL_SP FOREIGN KEY REFERENCES SanPham(MaSP) ON DELETE CASCADE,
	MaNL int CONSTRAINT FK_SP_NL_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL) ON DELETE CASCADE,
	CONSTRAINT PK_SP_NL PRIMARY KEY (MaSP, MaNL),
	SoLuong int Check (SoLuong > 0)
)
go

