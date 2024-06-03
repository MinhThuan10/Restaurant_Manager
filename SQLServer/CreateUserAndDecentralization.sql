use QLNH
GO

CREATE ROLE Staff
GO

--Gán các quyền trên table cho role Staff
GRANT SELECT, Z ON BanAn TO Staff
GRANT SELECT, REFERENCES ON CaLamViec TO Staff
GRANT SELECT, INSERT, REFERENCES ON ChiTietHD TO Staff
GRANT REFERENCES ON CTDonNhap TO Staff
GRANT REFERENCES ON CongViec TO Staff
GRANT SELECT, REFERENCES ON CTNgLieu TO Staff
GRANT REFERENCES ON DonNhapTp TO Staff
GRANT SELECT, INSERT, REFERENCES ON HoaDon TO Staff
GRANT SELECT, INSERT, REFERENCES ON KhachHang TO Staff
GRANT SELECT, REFERENCES ON NguyenLieu TO Staff
GRANT SELECT, REFERENCES ON NhaCungCap TO Staff
GRANT REFERENCES ON NhanVien TO Staff
GRANT SELECT, REFERENCES ON SanPham TO Staff
GRANT SELECT, REFERENCES ON SP_NL TO Staff


GRANT SELECT ON V_SoLuongNguyenLieu TO Staff;
GRANT SELECT ON V_DanhSachSanPham TO Staff;
GRANT SELECT ON V_KhachHang TO Staff;
GRANT SELECT ON V_HoaDonChuaThanhToan TO Staff;
--Gán quyền thực thi trên các procedure, function cho role Staff
GRANT EXECUTE TO Staff
DENY EXECUTE ON PROC_SuaNguyenLieu to Staff;
DENY EXECUTE ON PROC_SuaDonNhap to Staff;
DENY EXECUTE ON PROC_SuaNhanVien to Staff;
DENY EXECUTE ON PROC_SuaThongTinNL to Staff;
DENY EXECUTE ON PROC_SuaThongTinSanPham to Staff;
DENY EXECUTE ON PROC_ThemChiTietDonNhap to Staff;
DENY EXECUTE ON PROC_ThemDonNhap to Staff;
DENY EXECUTE ON PROC_ThemNguyenLieuMoi to Staff;
DENY EXECUTE ON PROC_ThemNhanvien to Staff;
DENY EXECUTE ON PROC_ThemSanPham to Staff;
DENY EXECUTE ON PROC_ThemSanPham_NguyenLieu to Staff;
DENY EXECUTE ON PROC_XoaDonNhap to Staff;
DENY EXECUTE ON PROC_XoaHoaDon to Staff;
DENY EXECUTE ON PROC_XoaKH to Staff;
DENY EXECUTE ON PROC_XoaNhanVien to Staff;
DENY EXECUTE ON PROC_XoaNL to Staff;
DENY EXECUTE ON PROC_XoaSanPham to Staff;

DENY EXECUTE ON [dbo].[FUNC_TinhChiPhiTheoNam] TO Staff;

-- Sử dụng SELECT để gọi function và trả về dữ liệu
SELECT * FROM Func_TimKiemCTHoaDonTheoMaHD(2)

GRANT SELECT ON dbo.Func_TimKiemCTHoaDonTheoMaHD TO Staff;


-- Tạo table DangNhap 
CREATE TABLE DANGNHAP (
    ID INT CONSTRAINT PK_DangNhap PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(30),
    MatKhau NVARCHAR(10),
    MaNV int CONSTRAINT FK_DN_NV FOREIGN KEY REFERENCES NhanVien(MaNV)
);
GO

--Procedure thêm Đang Nhập
CREATE PROCEDURE PROC_ThemDangNhap
    @TenDangNhap NVARCHAR(30),
    @MatKhau NVARCHAR(10),
    @MaNV INT
AS
BEGIN
    SET NOCOUNT ON;
    -- Kiểm tra xem tên đăng nhập đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM DangNhap WHERE TenDangNhap = @TenDangNhap)
    BEGIN
        RAISERROR (N'Tên đăng nhập đã tồn tại.', 16, 1);
        RETURN;
    END
	-- Kiểm tra xem Mã Nhân Viên có tồn tại không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        RAISERROR (N'Nhân Viên không tồn tại.', 16, 1);
        RETURN;
    END
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Thêm thông tin người dùng vào bảng DangNhap
        INSERT INTO DangNhap (TenDangNhap, MatKhau, MaNV)
        VALUES (@TenDangNhap, @MatKhau, @MaNV);
        -- Thêm các bước khác tùy thuộc vào yêu cầu của bạn
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @errMsg NVARCHAR(MAX);
        SET @errMsg = N'Lỗi: ' + ERROR_MESSAGE();
        RAISERROR(@errMsg, 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH
END;
GO
-- Trigger tạo tài khoản

CREATE TRIGGER Trigger_CreateSQLAccount ON DANGNHAP
AFTER INSERT
AS
DECLARE @UserName nvarchar(30), @PassWord nvarchar(10), @MaNV INT
SELECT @UserName=dn.TenDangNhap, @PassWord=dn.MatKhau, @Manv=dn.MaNV
FROM inserted dn
BEGIN
DECLARE @sqlString nvarchar(2000), @MaCV nvarchar(10)
----
SET @sqlString= 'CREATE LOGIN [' + @userName +'] WITH PASSWORD=''' + @passWord +''', DEFAULT_DATABASE=[QuanLyNhaHangAnUong], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
EXEC (@sqlString)
----
SET @sqlString= 'CREATE USER ' + @userName +' FOR LOGIN '+ @userName
EXEC (@sqlString)
----
SELECT @MaCV = MaCV
FROM NhanVien
WHERE MaNV = @MaNV
if (@MaCV = 1)
SET @sqlString = 'ALTER SERVER ROLE sysadmin' + ' ADD MEMBER ' + @userName;
else
SET @sqlString = 'ALTER ROLE Staff ADD MEMBER ' + @userName;
EXEC (@sqlString)
END
GO

--Procedure Xóa Nhân Viên
CREATE PROCEDURE PROC_XoaNhanVien
 @MaNV int
AS
BEGIN
IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        RAISERROR (N'Mã Nhân Viên không tồn tại', 16, 1);
        RETURN;
    END
    -- Xóa hóa đơn
	UPDATE NhanVien
	SET MaNQL = NULL
	WHERE MaNQL = @MaNV;
    DELETE FROM NhanVien WHERE MaNV = @MaNV
SET NOCOUNT ON;
	DECLARE @username varchar(30);
SELECT @username=TenDangNhap FROM DANGNHAP WHERE MaNV=@MaNV
	DECLARE @sql varchar(100)
	DECLARE @SessionID INT;
SELECT @SessionID = session_id --kiểm tra xem có phiên đăng nhập nào liên quan đến tên đăng nhập của nhân viên không
	FROM sys.dm_exec_sessions
	WHERE login_name = @username;
IF @SessionID IS NOT NULL
BEGIN
	SET @sql = 'kill ' + Convert(NVARCHAR(20), @SessionID) --đóng phiên đăng nhập đó.
	exec(@sql)
END
BEGIN TRANSACTION;
BEGIN TRY
	--
	SET @sql = 'DROP USER '+ @username
	exec (@sql)
	--
	SET @sql = 'DROP LOGIN '+ @username
	exec (@sql)
--
DELETE FROM DANGNHAP WHERE MaNV=@maNV;
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(MAX)
	SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
	RAISERROR(@err, 16, 1)
	ROLLBACK TRANSACTION;
THROW;
END CATCH
COMMIT TRANSACTION;
END
GO


INSERT INTO DANGNHAP(TenDangNhap, MatKhau, MaNV)
VALUES
    (N'quanly1', N'quanly1', 1);,
    (N'nhanvien2', N'nhanvien2', 2),
	(N'nhanvien3', N'nhanvien3', 3),
	(N'nhanvien4', N'nhanvien4', 4),
	(N'nhanvien5', N'nhanvien5', 5),
	(N'nhanvien6', N'nhanvien6', 6),
	(N'nhanvien7', N'nhanvien7', 7),
	(N'nhanvien8', N'nhanvien8', 8),
	(N'nhanvien9', N'nhanvien9', 9),
	(N'nhanvien10', N'nhanvien10', 10);


INSERT INTO DANGNHAP(TenDangNhap, MatKhau, MaNV)
VALUES
	(N'nhanvien3', N'nhanvien3', 3)

