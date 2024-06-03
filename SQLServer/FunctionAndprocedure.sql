USE QLNH
GO

----Xem các thông tin danh mục

-- Danh mục nhân viên
CREATE VIEW V_DanhMucNhanVien AS
SELECT NV.*, CV.TenCV, CV.Luong
FROM NhanVien NV
INNER JOIN CongViec CV ON NV.MaCV = CV.MaCV
GO

-- Danh mục bảng phân ca
CREATE VIEW V_DanhMucBangPhanCa AS
SELECT PhanCa.*
FROM PhanCa
GO

-- Danh mục ca làm việc
CREATE VIEW V_DanhMucCaLamViec AS
SELECT NV.MaNV, NV.HoNV, NV.TenNV, CLV.*, PC.Ngay
FROM NhanVien NV
INNER JOIN PhanCa PC ON NV.MaNV = PC.MaNV
INNER JOIN CaLamViec CLV ON PC.MaCa = CLV.MaCa
GO

-- Danh mục hóa đơn
CREATE VIEW V_DanhMucHoaDon AS
SELECT HD.MaHD, HD.TriGiaHD, HD.ThoiGian, HD.TrangThai, KH.TenKH, KH.SDT
FROM HoaDon HD
INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
GO

-- Danh mục sản phẩm
CREATE VIEW V_DanhMucSanPham AS
SELECT SanPham.*
FROM SanPham
GO

-- Danh mục đơn nhập thực phẩm
CREATE VIEW V_DanhMucDonNhapTP AS
SELECT DonNhapTP.*
FROM DonNhapTP
GO

-- Danh mục kho nguyên liệu
CREATE VIEW V_DanhMucNguyenLieu AS
SELECT NguyenLieu.*
FROM NguyenLieu
GO

-- Danh mục nhà cung cấp
CREATE VIEW V_DanhMucNhaCungCap AS
SELECT NhaCungCap.*
FROM NhaCungCap
GO

-- Danh mục bàn ăn
CREATE VIEW V_DanhMucBanAn AS
SELECT BanAn.*
FROM BanAn
GO

-- Danh mục công việc
CREATE VIEW V_DanhMucCongViec AS
SELECT CongViec.*
FROM CongViec
GO

----Chức năng quản lý Khách hàng
-- Chức năng tìm khách hàng bằng SĐT
CREATE FUNCTION FUNC_TimKHBangSDT (@SDT nvarchar(11))
RETURNS TABLE
	AS
	RETURN( SELECT * FROM KhachHang WHERE SDT = @SDT);
GO

-- Chức năng thêm khách hàng
CREATE PROCEDURE PROC_ThemKHMoi
	@TenKH nvarchar(50),
	@SDT nchar(11),
	@DiaChi nvarchar(100),
	@GioiTinh nvarchar(10)
AS 
BEGIN 
	BEGIN TRY
		INSERT INTO KhachHang (TenKH, SDT, DiaChi, GioiTinh, DiemTL) 
		VALUES (@TenKH, @SDT, @DiaChi, @GioiTinh, 0)
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()			
			-- Kiểm tra SDT ko đủ 10 chữ số theo TABLE
			IF LEN(@SDT) <> 10
			BEGIN
				SELECT @err = N'Số điện thoại không hợp lệ, phải gồm 10 chữ số'
			END
			RAISERROR(@err, 16, 1)
			RETURN;
		END
	END CATCH
END 
GO

-- Chức năng sửa khách hàng
CREATE PROCEDURE PROC_SuaThongTinKH
	@MaKH int,
	@TenKH nvarchar(50),
	@SDT nchar(11),
	@DiaChi nvarchar(100), 
	@GioiTinh nvarchar(3), 
	@DiemTL int
AS 
BEGIN 
	-- Kiểm tra MaKH không tồn tại
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKH = @MaKH)
    BEGIN
        RAISERROR (N'Mã khách hàng không tồn tại', 16, 1)
        RETURN;
    END
	BEGIN TRY
		UPDATE KhachHang
		SET TenKH = @TenKH, GioiTinh = @GioiTinh, DiemTL = @DiemTL, DiaChi = @DiaChi, SDT = @SDT
		WHERE MaKH = @MaKH
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()
			-- Kiểm tra SDT ko đủ 10 chữ số theo TABLE
			IF LEN(@SDT) <> 10
			BEGIN
				SELECT @err = N'Số điện thoại không hợp lệ, phải gồm 10 chữ số'
			END
			-- Kiểm tra DiemTL trống
			IF @DiemTL IS NULL
			BEGIN
				SELECT @err = (N'Điểm tích lũy không được để trống')	
			END
			RAISERROR(@err, 16, 1)
			RETURN;
		END
	END CATCH
END 
GO

-- Trigger bắt lỗi khi thêm, sửa khách hàng
CREATE TRIGGER TRG_ThemSuaKhachHang
ON KhachHang 
FOR INSERT, UPDATE
AS
BEGIN
    -- Kiểm tra tên khách hàng trống
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(TenKH) = '')
    BEGIN
		ROLLBACK;
        RAISERROR (N'Tên khách hàng không được để trống', 16, 1)		
        RETURN;
    END
	-- Kiểm tra giới tính trống
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(GioiTinh) = '')
    BEGIN
		ROLLBACK;
        RAISERROR (N'Giới tính không được để trống', 16, 1)	
        RETURN;
    END
	-- Kiểm tra điểm tích lũy là số âm
    IF EXISTS (SELECT * FROM inserted WHERE DiemTL < 0)
    BEGIN
		ROLLBACK;
        RAISERROR (N'Điểm tích lũy phải là giá trị dương', 16, 1)     
        RETURN
    END
	-- Kiểm tra địa chỉ trống
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(DiaChi) = '')
    BEGIN
		ROLLBACK;
        RAISERROR (N'Địa chỉ không được để trống', 16, 1)
        RETURN;
    END
	-- Kiểm tra SDT có chứa ký tự không phải số
    IF EXISTS (SELECT * FROM inserted WHERE TRY_CAST(SDT AS INT) IS NULL OR PATINDEX('%[^0-9]%', TRIM(SDT)) > 0)
    BEGIN
        ROLLBACK;
        RAISERROR (N'Số điện thoại không hợp lệ', 16, 1)
        RETURN;
    END
END
GO

-- Chức năng xóa khách hàng
CREATE PROCEDURE PROC_XoaKH @MaKH int
AS
BEGIN
    -- Kiểm tra MaKH không tồn tại
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKH = @MaKH)
    BEGIN
        RAISERROR (N'Mã khách hàng không tồn tại', 16, 1)
        RETURN;
    END
    -- Xóa khách hàng
    DELETE FROM KhachHang WHERE MaKH = @MaKH
END
GO

------Chức năng quản lý hóa đơn
----Tìm kiếm hóa đơn

--Chức năng xưm hóa đơn thuộc giữa 2 ngày
CREATE FUNCTION FUNC_XemHoaDonTuNgayDenNgay
(
    @TuNgay datetime, -- Tham số để chỉ định ngày bắt đầu
    @DenNgay datetime -- Tham số để chỉ định ngày kết thúc
)
RETURNS TABLE
AS
RETURN (
    SELECT
        HD.MaHD, HD.MaBan, HD.ThoiGian, HD.TrangThai, HD.TriGiaHD,
        KH.TenKH,  -- Trích xuất tên từ bảng KhachHang
        NV.TenNV  -- Trích xuất tên từ bảng NhanVien
    FROM HoaDon HD
    LEFT JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    LEFT JOIN NhanVien NV ON HD.MaNV = NV.MaNV
    WHERE
        (
            (@TuNgay IS NULL OR CAST(HD.ThoiGian AS DATE) >= CAST(@TuNgay AS DATE))  -- Điều kiện để lọc từ ngày
            AND
            (@DenNgay IS NULL OR CAST(HD.ThoiGian AS DATE) <= CAST(@DenNgay AS DATE))  -- Điều kiện để lọc đến ngày
        )
);
GO

-- Chức năng xem hóa đơn theo ngày
CREATE FUNCTION FUNC_HoaDonTheoNgayThangNam
(
    @Ngay datetime -- Tham số để lọc theo ngày, tháng và năm
)
RETURNS TABLE
AS
RETURN (
    SELECT
        HD.MaHD, HD.MaBan, HD.ThoiGian, HD.TrangThai, HD.TriGiaHD,
        KH.TenKH,  -- Trích xuất tên từ bảng KhachHang
        NV.TenNV  -- Trích xuất tên từ bảng NhanVien
    FROM HoaDon HD
    LEFT JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    LEFT JOIN NhanVien NV ON HD.MaNV = NV.MaNV
    WHERE
        (@Ngay IS NULL OR CAST(HD.ThoiGian AS DATE) = CAST(@Ngay AS DATE))  -- Điều kiện để lọc theo ngày, tháng và năm
);
GO

-- Chức năng xem hóa đơn theo tháng
CREATE FUNCTION FUNC_HoaDonTheoThangCuaNam
(
    @Ngay datetime
)
RETURNS TABLE
AS
RETURN (
    SELECT
        HD.MaHD, HD.MaBan, HD.ThoiGian, HD.TrangThai, HD.TriGiaHD,
        KH.TenKH,  -- Trích xuất tên từ bảng KhachHang
        NV.TenNV  -- Trích xuất tên từ bảng NhanVien
    FROM HoaDon HD
    LEFT JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    LEFT JOIN NhanVien NV ON HD.MaNV = NV.MaNV
    WHERE
        (YEAR(@Ngay) IS NULL OR YEAR(HD.ThoiGian) = YEAR(@Ngay))  -- Điều kiện để lọc theo năm
        AND (Month(@Ngay) IS NULL OR MONTH(HD.ThoiGian) = MONTH(@Ngay))  -- Điều kiện để lọc theo tháng
);
GO

-- Chức năng xem hoa đơn theo năm
CREATE FUNCTION FUNC_HoaDonTheoNam
(
    @Ngay datetime 
)
RETURNS TABLE
AS
RETURN (
    SELECT
        HD.MaHD, HD.MaBan, HD.ThoiGian, HD.TrangThai, HD.TriGiaHD,
        KH.TenKH,  -- Trích xuất tên từ bảng KhachHang
        NV.TenNV  -- Trích xuất tên từ bảng NhanVien
    FROM HoaDon HD
    LEFT JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    LEFT JOIN NhanVien NV ON HD.MaNV = NV.MaNV
    WHERE
        (Year(@Ngay) IS NULL OR YEAR(HD.ThoiGian) = Year(@Ngay))  -- Điều kiện để lọc theo năm
);
GO

-- Chức năng tìm hóa đơn theo SĐT
CREATE FUNCTION FUNC_TimKiemHoaDonTheoSDT
(
	@SDT nchar(11)
)
RETURNS TABLE
AS
RETURN (
    SELECT
        HD.MaHD, HD.MaBan, HD.ThoiGian, HD.TrangThai, HD.TriGiaHD,
        KH.TenKH,  -- Trích xuất tên từ bảng KhachHang
        NV.TenNV  -- Trích xuất tên từ bảng NhanVien
    FROM HoaDon HD
    LEFT JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    LEFT JOIN NhanVien NV ON HD.MaNV = NV.MaNV
    WHERE
        KH.SDT = @SDT
);
GO

-- Chức năng thêm hóa đơn
CREATE PROCEDURE PROC_ThemHoaDon
@MaKH int, @MaNV int, @MaBan int
AS
BEGIN 
	DECLARE @ThoiGian datetime = GETDATE();
	DECLARE @TrangThai nvarchar(50) = N'Chưa hoàn thành';
	DECLARE @TriGiaHD float = 0;
	-- Kiểm tra xem MaKH đã tồn tại trong bảng KhachHang hay không
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKH = @MaKH)
	BEGIN 
		RAISERROR (N'Mã Khách hàng không tồn tại', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaNV đã tồn tại trong bảng NhanVien hay không
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
	BEGIN 
		RAISERROR (N'Mã Nhân Viên không tồn tại', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaBan đã tồn tại trong bảng BanAn hay không
    IF NOT EXISTS (SELECT 1 FROM BanAn WHERE MaBan = @MaBan)
	BEGIN 
		RAISERROR (N'Mã Bàn không tồn tại', 16, 1);
		RETURN;
	END
    INSERT INTO HoaDon(ThoiGian, TrangThai, TriGiaHD, MaKH, MaNV, MaBan) 
	VALUES (@ThoiGian,@TrangThai, @TriGiaHD, @MaKH, @MaNV, @MaBan);
END
GO

-- Chức năng sửa hóa đơn
CREATE PROCEDURE PROC_SuaHoaDon
    @MaHD int,
    @TrangThai nvarchar(50),
    @TriGiaHD float
AS
BEGIN
	DECLARE @ThoiGian datetime = GETDATE();
    -- Kiểm tra xem MaHD đã tồn tại trong bảng HoaDon
    IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHD = @MaHD)
    BEGIN
        RAISERROR (N'Mã Hóa Đơn không tồn tại', 16, 1);
        RETURN;
    END
	-- Kiểm tra xem @TrangThai có giá trị NULL hay không
	IF @TrangThai IS NULL
	BEGIN 
		RAISERROR (N'Dữ liệu Trạng Thái không được để trống (NOT NULL)', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem @TriGiaHD có giá trị NULL hay không và có lớn hơn 0 hay không
	ELSE IF @TriGiaHD <= 0
	BEGIN
		RAISERROR (N'Dữ liệu Trị giá hóa đơn phải lớn hơn 0', 16, 1);
		RETURN;
	END
    -- Cập nhật thông tin hóa đơn
    UPDATE HoaDon
    SET
        ThoiGian = @ThoiGian,
        TrangThai = @TrangThai,
        TriGiaHD = @TriGiaHD
    WHERE MaHD = @MaHD;
END
GO

-- Chức năng xóa hóa đơn
CREATE PROCEDURE PROC_XoaHoaDon
    @MaHD int
AS
BEGIN
    -- Kiểm tra xem MaHD đã tồn tại trong bảng HoaDon
    IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHD = @MaHD)
    BEGIN
        RAISERROR (N'Mã Hóa Đơn không tồn tại', 16, 1);
        RETURN;
    END
	-- Thực hiện thao tác xóa hóa đơn
    DELETE FROM HoaDon WHERE MaHD = @MaHD;
END
GO

CREATE PROCEDURE PROC_ThemChiTietHD
    @MaHD int,
    @TenSP nvarchar(255), -- Tên sản phẩm
    @SoLuong int
AS
BEGIN
    -- Tìm MaSP dựa trên TenSP
    DECLARE @MaSP int
    SELECT @MaSP = MaSP FROM SanPham WHERE TenSP = @TenSP
	IF @MaSP IS NULL
    BEGIN
		RAISERROR (N'Tên sản phẩm không hợp lệ', 16, 1);
        RETURN
    END
    IF @SoLuong <= 0
	BEGIN
		RAISERROR (N'Số lượng sản phẩm phải lớn hơn 0', 16, 1);
        RETURN
    END
    BEGIN
   -- Chèn dữ liệu vào bảng ChiTietHD
    INSERT INTO ChiTietHD (MaHD, MaSP, SoLuong)
    VALUES (@MaHD, @MaSP, @SoLuong)
    END 
END
GO

----Quản lý kho nguyên liệu
-- Chức năng tìm kiếm nguyên liệu theo tên
CREATE FUNCTION FUNC_TimKiemNguyenLieuTheoTen (@TenNL nvarchar(50))
RETURNS TABLE
	AS
	RETURN ( SELECT * FROM NguyenLieu WHERE TenNL = @TenNL )
GO

-- Chức năng thêm nguyên liệu
CREATE PROCEDURE PROC_ThemNguyenLieuMoi
	@TenNL nvarchar(50), 
	@DonViTinh nchar(20), 
	@SoLuong int, 
	@MaNVQL int, 
	@SLTonKho int
AS 
BEGIN 
	BEGIN TRY
		INSERT INTO NguyenLieu(TenNL, DonViTinh, SoLuong, MaNVQL, SLTonKho) 
		VALUES (@TenNL, @DonViTinh, @SoLuong, @MaNVQL, @SLTonKho)
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()
			-- Kiểm tra tên nguyên liệu trùng
			IF EXISTS (SELECT * FROM NguyenLieu WHERE TenNL = @TenNL)
			BEGIN
				SELECT @err = N'Tên nguyên liệu đã tồn tại'
			END
			-- Kiểm tra số lượng trống
			IF @SoLuong IS NULL OR @SoLuong <= 0
			BEGIN
				SELECT @err = (N'Số lượng không được để trống, phải > 0')	
			END
			-- Kiểm tra mã người quản lý trống
			IF @MaNVQL IS NULL OR @MaNVQL <= 0
			BEGIN
				SELECT @err = (N'Mã người quản lý không được để trống, phải > 0')	
			END
			-- Kiểm tra số lượng tồn kho trống
			IF @SLTonKho IS NULL OR @SLTonKho <= 0
			BEGIN
				SELECT @err = (N'Số lượng tồn kho không được để trống, phải > 0')	
			END
			RAISERROR(@err, 16, 1)
			RETURN
		END
	END CATCH
END 
GO

-- Chức năng sửa nguyên liệu
CREATE PROCEDURE PROC_SuaThongTinNL
	@MaNL int,
	@TenNL nvarchar(50), 
	@DonViTinh nchar(20), 
	@SoLuong int, 
	@MaNVQL int, 
	@SLTonKho int
AS 
BEGIN 
	-- Kiểm tra mã nguyên liệu không tồn tại
    IF NOT EXISTS (SELECT 1 FROM NguyenLieu WHERE MaNL = @MaNL)
    BEGIN
        RAISERROR (N'Mã nguyên liệu không tồn tại', 16, 1);
        RETURN;
    END
	BEGIN TRY
		UPDATE NguyenLieu
		SET TenNL = @TenNL, DonViTinh = @DonViTinh, SoLuong = @SoLuong, MaNVQL = @MaNVQL, SLTonKho = @SLTonKho
		WHERE MaNL = @MaNL
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()
			-- Kiểm tra số lượng trống
			IF @SoLuong IS NULL OR @SoLuong <= 0
			BEGIN
				SELECT @err = (N'Số lượng không được để trống, phải > 0')	
			END
			-- Kiểm tra mã người quản lý trống
			IF @MaNVQL IS NULL OR @MaNVQL <= 0
			BEGIN
				SELECT @err = (N'Mã người quản lý không được để trống, phải > 0')	
			END
			-- Kiểm tra số lượng tồn kho trống
			IF @SLTonKho IS NULL OR @SLTonKho <= 0
			BEGIN
				SELECT @err = (N'Số lượng tồn kho không được để trống, phải > 0')	
			END
			RAISERROR(@err, 16, 1)
			RETURN
		END
	END CATCH
END 
GO

-- Trigger bắt lỗi khi thêm, sửa nguyên liệu
CREATE TRIGGER TRG_ThemSuaNguyenLieu
ON NguyenLieu 
FOR INSERT, UPDATE
AS
BEGIN
	-- Kiểm tra tên nguyên liệu trống
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(TenNL) = '')
    BEGIN
		ROLLBACK
        RAISERROR (N'Tên nguyên liệu không được để trống', 16, 1)
        RETURN
    END
	-- Kiểm tra đơn vị tính trống
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(DonViTinh) = '')
    BEGIN
		ROLLBACK
        RAISERROR (N'Đơn vị tính không được để trống', 16, 1)
        RETURN
    END
END
GO

-- Chức năng xóa nguyên liệu
CREATE PROCEDURE PROC_XoaNL @MaNL int
AS
BEGIN
    -- Kiểm tra mã nguyên liệu không tồn tại
    IF NOT EXISTS (SELECT 1 FROM NguyenLieu WHERE MaNL = @MaNL)
    BEGIN
        RAISERROR (N'Mã nguyên liệu không tồn tại', 16, 1);
        RETURN;
    END
    -- Xóa nguyên liệu
    DELETE FROM NguyenLieu WHERE MaNL = @MaNL;
END
GO

---- Quản lý đơn nhập thực phẩm
-- Tìm kiếm đơn nhập
-- Chức năng tìm kiếm đơn nhập thực phẩm theo ngày tháng năm
CREATE FUNCTION FUNC_TimKiemDonNhapTPTheoNgayThangNam (@ngaythangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT MaDon, CONCAT(DAY(NgNhap), '-', MONTH(NgNhap), '-', YEAR(NgNhap)) AS NgNhap, GiaTien, MaNV
    FROM DonNhapTP
    WHERE DAY(NgNhap) = DAY(@ngaythangnam) AND MONTH(NgNhap) = MONTH(@ngaythangnam) 
						AND YEAR(NgNhap) = YEAR(@ngaythangnam)
	)
GO

-- Chức năng tìm kiếm đơn nhập thực phẩm theo tháng năm
CREATE FUNCTION FUNC_TimKiemDonNhapTPTheoThangNam (@thangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT MaDon, CONCAT(DAY(NgNhap), '-', MONTH(NgNhap), '-', YEAR(NgNhap)) AS NgNhap, GiaTien, MaNV
    FROM DonNhapTP
    WHERE MONTH(NgNhap) = MONTH(@thangnam) AND YEAR(NgNhap) = YEAR(@thangnam)
	)
GO

-- Chức năng tìm kiếm đơn nhập thực phẩm theo năm
CREATE FUNCTION FUNC_TimKiemDonNhapTPTheoNam (@nam date)
RETURNS TABLE
AS
RETURN (
    SELECT MaDon, CONCAT(DAY(NgNhap), '-', MONTH(NgNhap), '-', YEAR(NgNhap)) AS NgNhap, GiaTien, MaNV
    FROM DonNhapTP
    WHERE YEAR(NgNhap) = YEAR(@nam)
	)
GO

-- Thêm đơn nhập
CREATE PROCEDURE PROC_ThemDonNhap
@MaNV int
AS
BEGIN
	-- Lấy ngày hiện tại
	DECLARE @NgayNhap DATETIME SET @NgayNhap = GETDATE()
	DECLARE @GiaTienNhap FLOAT SET @GiaTienNhap = 0
	-- Kiểm tra mã nhân viên tồn tại trong bảng nhân viên hay không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV= @MaNV)
	BEGIN 
		RAISERROR(N'Mã nhân viên không tồn tại', 16, 1)
		RETURN
	END
	INSERT INTO DonNhapTP (NgNhap, GiaTien, MaNV)
	VALUES (@NgayNhap, @GiaTienNhap, @MaNV)
END
GO

-- Thêm chi tiết đơn nhập
CREATE PROCEDURE PROC_ThemCTDonNhap
@TenNL nvarchar(50),
@SoLuong int
AS
BEGIN
	-- Kiểm tra tên nguyên liệu tồn tại trong bảng nguyên liệu hay không
	IF NOT EXISTS (SELECT 1 FROM NguyenLieu WHERE TenNL = @TenNl)
	BEGIN 
		RAISERROR(N'Tên nguyên liệu không tồn tại', 16, 1);
		RETURN;
	END
	IF @SoLuong <= 0
	BEGIN 
		RAISERROR(N'Số lượng không hợp lệ', 16, 1);
		RETURN;
	END
	-- Lấy mã đơn nhập
	DECLARE @MaDon int
	IF NOT EXISTS (SELECT * FROM DonNhapTP)
	BEGIN
		SET @MaDon = 1
	END
	ELSE
	BEGIN
		SELECT @MaDon = MAX(MaDon) FROM DonNhapTP
	END
	-- Lấy mã nguyên liệu
	DECLARE @MaNL int
	SELECT @MaNL = MaNL FROM NguyenLieu WHERE TenNL = @TenNL
	-- Thêm CTDonNhap
	INSERT INTO CTDonNhap (MaNL, MaDon, SoLuong)
	VALUES (@MaNL, @MaDon, @SoLuong)
END
GO
-- Sửa đơn nhập
CREATE PROCEDURE PROC_SuaDonNhap
@MaDon int,
@GiaTienNhap float
AS
BEGIN
	-- Kiểm tra mã đơn tồn tại trong bảng đơn nhập thành phần hay không
	IF NOT EXISTS (SELECT 1 FROM DonNhapTP WHERE MaDon = @MaDon)
	BEGIN 
		RAISERROR(N'Mã đơn không tồn tại', 16, 1)
		RETURN
	END
	UPDATE DonNhapTP
	SET GiaTien = @GiaTienNhap
	WHERE MaDon = @MaDon
END
GO

-- Xóa đơn nhập
CREATE PROCEDURE PROC_XoaDonNhap
@MaDon int
AS
BEGIN
	-- Kiểm tra mã đơn tồn tại trong bảng đơn nhập thành phần hay không
	IF NOT EXISTS (SELECT 1 FROM DonNhapTP WHERE MaDon= @MaDon)
	BEGIN 
		RAISERROR(N'Mã đơn không tồn tại', 16, 1)
		RETURN
	END
	DELETE FROM DonNhapTP WHERE MaDon = @MaDon
END
GO

---- Quản lý sản phẩm

-- Chức năm tìm kiếm sản phẩm theo tên
CREATE FUNCTION FUNC_TimSanPham (@TenSP NVARCHAR(50))
RETURNS TABLE
	AS
	RETURN( SELECT * FROM SanPham WHERE TenSP = @TenSP);
GO

-- Chức năng thêm sản phẩm
CREATE PROCEDURE PROC_ThemSanPham
	@TenSP nvarchar(50),
	@DonGia int
AS 
BEGIN 
	BEGIN TRY
		INSERT INTO SanPham (TenSP, DonGia) 
		VALUES (@TenSP, @DonGia)
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()			
			-- Kiểm tra TenSP trống
			IF @TenSP IS NULL OR LTRIM(RTRIM(@TenSP)) = ''
			BEGIN
				SELECT @err = (N'Tên sản phẩm không được để trống')	
			END
			-- Kiểm tra trùng tên SP
			IF EXISTS (SELECT 1 FROM SanPham WHERE TenSP = @TenSP)
			BEGIN
				SELECT @err = (N'Tên sản phẩm đã tồn tại')	
			END
			-- Kiểm tra DonGia trống
			IF @DonGia IS NULL OR LTRIM(RTRIM(@DonGia)) = ''
			BEGIN
				SELECT @err = (N'Đơn giá không được để trống')	
			END
			-- Kiểm tra đơn giá âm, =0
			IF @DonGia <= 0
			BEGIN
				SELECT @err = (N'Đơn giá phải lớn hơn không')	
			END
			RAISERROR(@err, 16, 1)
			RETURN
		END
	END CATCH
END 
GO

-- Thêm thông tin SP_NL sau khi thêm sản phẩm
CREATE PROCEDURE PROC_ThemSanPham_NguyenLieu
	@MaSP int,
	@TenNL nvarchar(50),
	@SoLuong int
AS
BEGIN
	-- Kiểm tra TenNL trống
	IF @TenNL IS NULL OR LTRIM(RTRIM(@TenNL)) = ''
	BEGIN
		RAISERROR (N'Tên nguyên liệu không được để trống', 16, 1)	
		RETURN
	END
	-- Kiểm tra TenNL trống
	IF @SoLuong IS NULL OR LTRIM(RTRIM(@SoLuong)) = ''
	BEGIN
		RAISERROR (N'Số lượng nguyên liệu không được để trống', 16, 1)	
		RETURN
	END
    DECLARE @MaNL INT
    SELECT @MaNL = MaNL FROM NguyenLieu WHERE TenNL = @TenNL
	begin try
		INSERT INTO SP_NL(MaSP, MaNL, SoLuong) 
		VALUES (@MaSP, @MaNL, @SoLuong)
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()
			-- Kiểm tra mã sản phẩm đã tồn tại
			IF NOT EXISTS (SELECT 1 FROM NguyenLieu WHERE MaNL = @MaNL)
			BEGIN
				SELECT @err = N'Tên nguyên liệu không tồn tại'
			END			
			-- Kiểm số lượng giá âm, =0
			IF @SoLuong <= 0 
			BEGIN
				SELECT @err = (N'Số lượng phải lớn hơn không')	
			END
			RAISERROR(@err, 16, 1)
			RETURN;
		END
	END CATCH
END
GO

-- Chức năng sửa sản phẩm
CREATE PROCEDURE PROC_SuaThongTinSanPham
	@MaSP int,
	@TenSP nvarchar(50),
	@DonGia int
AS 
BEGIN
	-- Kiểm tra MaSP không tồn tại
    IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSP = @MaSP)
    BEGIN
        RAISERROR (N'Mã sản phẩm không tồn tại', 16, 1)
        RETURN;
    END
	BEGIN TRY
		UPDATE SanPham
		SET TenSP = @TenSP, DonGia = @DonGia
		WHERE MaSP = @MaSP
	END TRY
	BEGIN CATCH
		BEGIN
			DECLARE @err nvarchar(max)
			SELECT @err = ERROR_MESSAGE()
			-- Kiểm tra TenSP trống
			IF @TenSP IS NULL OR LTRIM(RTRIM(@TenSP)) = ''
			BEGIN
				SELECT @err = (N'Tên sản phẩm không được để trống')	
			END
			-- Kiểm tra trùng tên SP
			IF EXISTS (SELECT 1 FROM SanPham WHERE TenSP = @TenSP)
			BEGIN
				SELECT @err = (N'Tên sản phẩm đã tồn tại')	
			END
			-- Kiểm tra DonGia trống
			IF @DonGia IS NULL OR LTRIM(RTRIM(@DonGia)) = ''
			BEGIN
				SELECT @err = (N'Đơn giá không được để trống')	
			END
			-- Kiểm tra đơn giá âm, =0
			IF @DonGia <= 0
			BEGIN
				SELECT @err = (N'Đơn giá phải lớn hơn không')	
			END
			RAISERROR(@err, 16, 1)
			RETURN;
		END
	END CATCH
END 
GO

-- Chức năng xóa sản phẩm
CREATE PROCEDURE PROC_XoaSanPham @MaSP int
AS
BEGIN
    -- Kiểm tra MaSP không tồn tại
    IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSP = @MaSP)
    BEGIN
        RAISERROR (N'Mã sản phẩm không tồn tại', 16, 1)
        RETURN;
    END
    -- Xóa sản phẩm
    DELETE FROM SanPham WHERE MaSP = @MaSP
END
GO

---- Quản lý doanh thu và chi phú
-- Chức năng xem doanh thu theo ngày tháng năm
CREATE PROCEDURE PROC_XemDoanhThuTheoNgayThangNam
AS
BEGIN
    SELECT 
        CONCAT(DAY(ThoiGian), '-', MONTH(ThoiGian), '-', YEAR(ThoiGian)) AS NgayThangNam,
        SUM(TriGiaHD) AS DoanhThu
    FROM HoaDon
    WHERE TrangThai = N'Hoàn thành'
    GROUP BY DAY(ThoiGian), MONTH(ThoiGian), YEAR(ThoiGian)
    ORDER BY YEAR(ThoiGian), MONTH(ThoiGian), DAY(ThoiGian)
END
GO

-- Chức năng xem doanh thu theo tháng năm
CREATE PROCEDURE PROC_XemDoanhThuTheoThangNam
AS
BEGIN
    SELECT 
        CONCAT(MONTH(ThoiGian), '-', YEAR(ThoiGian)) AS ThangNam,
        SUM(TriGiaHD) AS DoanhThu
    FROM HoaDon
    WHERE TrangThai = N'Hoàn thành'
    GROUP BY MONTH(ThoiGian), YEAR(ThoiGian)
    ORDER BY YEAR(ThoiGian), MONTH(ThoiGian)
END
GO

-- Chức năng xem doanh thu theo năm
CREATE PROCEDURE PROC_XemDoanhThuTheoNam
AS
BEGIN
    SELECT 
        YEAR(ThoiGian) AS Nam,
        SUM(TriGiaHD) AS DoanhThu
    FROM HoaDon
    WHERE TrangThai = N'Hoàn thành'
    GROUP BY YEAR(ThoiGian)
    ORDER BY YEAR(ThoiGian)
END
GO

-- Chức năng xem chi phí theo ngày tháng năm
CREATE PROCEDURE PROC_XemChiPhiTheoNgayThangNam
AS
BEGIN
    SELECT 
        CONCAT(DAY(NgNhap), '-', MONTH(NgNhap), '-', YEAR(NgNhap)) AS NgayThangNam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    GROUP BY DAY(NgNhap), MONTH(NgNhap), YEAR(NgNhap)
    ORDER BY YEAR(NgNhap), MONTH(NgNhap), DAY(NgNhap)
END
GO

-- Chức năng xem chi phí theo tháng năm
CREATE PROCEDURE PROC_XemChiPhiTheoThangNam
AS
BEGIN
    SELECT 
        CONCAT(MONTH(NgNhap), '-', YEAR(NgNhap)) AS ThangNam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    GROUP BY DAY(NgNhap), MONTH(NgNhap), YEAR(NgNhap)
    ORDER BY YEAR(NgNhap), MONTH(NgNhap)
END
GO

-- Chức năng xem chi phí theo năm
CREATE PROCEDURE PROC_XemChiPhiTheoNam
AS
BEGIN
    SELECT 
        YEAR(NgNhap) AS Nam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    GROUP BY YEAR(NgNhap)
    ORDER BY YEAR(NgNhap)
END
GO

-- Chức năng tính doanh thu theo ngày tháng năm
CREATE FUNCTION FUNC_TinhDoanhThuTheoNgayThangNam (@ngaythangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        CONCAT(DAY(ThoiGian), '-', MONTH(ThoiGian), '-', YEAR(ThoiGian)) AS NgayThangNam,
        SUM(TriGiaHD) AS DoanhThu
    FROM HoaDon
    WHERE DAY(ThoiGian) = DAY(@ngaythangnam) AND MONTH(ThoiGian) = MONTH(@ngaythangnam) AND YEAR(ThoiGian) = YEAR(@ngaythangnam)
    GROUP BY DAY(ThoiGian), MONTH(ThoiGian), YEAR(ThoiGian)
	)
GO

-- Chức năng tính doanh thu theo tháng năm
CREATE FUNCTION FUNC_TinhDoanhThuTheoThangNam (@thangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        CONCAT(MONTH(ThoiGian), '-', YEAR(ThoiGian)) AS ThangNam,
        SUM(TriGiaHD) AS DoanhThu 
    FROM HoaDon
    WHERE MONTH(ThoiGian) = MONTH(@thangnam) AND YEAR(ThoiGian) = YEAR(@thangnam)
    GROUP BY MONTH(ThoiGian), YEAR(ThoiGian)
	)
GO

-- Chức năng tính doanh thu theo năm
CREATE FUNCTION FUNC_TinhDoanhThuTheoNam (@nam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        YEAR(ThoiGian) AS Nam,
        SUM(TriGiaHD) AS DoanhThu 
    FROM HoaDon
    WHERE YEAR(ThoiGian) = YEAR(@nam)
    GROUP BY YEAR(ThoiGian)
	)
GO

-- Chức năng tính chi phí theo ngày tháng năm
CREATE FUNCTION FUNC_TinhChiPhiTheoNgayThangNam (@ngaythangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        CONCAT(DAY(NgNhap), '-', MONTH(NgNhap), '-', YEAR(NgNhap)) AS NgayThangNam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    WHERE DAY(NgNhap) = DAY(@ngaythangnam) AND MONTH(NgNhap) = MONTH(@ngaythangnam) AND YEAR(NgNhap) = YEAR(@ngaythangnam)
    GROUP BY DAY(NgNhap), MONTH(NgNhap), YEAR(NgNhap)
	)
GO

-- Chức năng tính chi phí theo tháng năm
CREATE FUNCTION FUNC_TinhChiPhiTheoThangNam (@thangnam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        CONCAT(MONTH(NgNhap), '-', YEAR(NgNhap)) AS ThangNam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    WHERE MONTH(NgNhap) = MONTH(@thangnam) AND YEAR(NgNhap) = YEAR(@thangnam)
    GROUP BY MONTH(NgNhap), YEAR(NgNhap)
	)
GO

-- Chức năng tính chi phí theo năm
CREATE FUNCTION FUNC_TinhChiPhiTheoNam (@nam date)
RETURNS TABLE
AS
RETURN (
    SELECT
        YEAR(NgNhap) AS Nam,
        SUM(GiaTien) AS ChiPhi
    FROM DonNhapTP
    WHERE YEAR(NgNhap) = YEAR(@nam)
    GROUP BY YEAR(NgNhap)
	)
GO

---- Chức năng quản lý nhân viên
-- Chức năng tìm kiếm nhân viên theo tên
CREATE FUNCTION FUNC_TimKiemNhanVien(@TenNV nvarchar(10))
RETURNS TABLE
AS
RETURN (
    SELECT
        NV.HoNV, NV.TenNV, NV.NgaySinh, NV.GioiTinh, NV.DiaChi, NV.SDT, NV.NgayTD, NV.MaNQL, CV.TenCV
    FROM NhanVien NV
    LEFT JOIN CongViec CV ON NV.MaCV = CV.MaCV
    WHERE
       (@TenNV IS NULL OR NV.TenNV = @TenNV)		
);
GO

-- Chức năng thêm nhân viên
CREATE PROCEDURE PROC_ThemNhanvien
@HoNV nvarchar(20), @TenNV nvarchar(10), @NgaySinh date, @GioiTinh nvarchar(3), @DiaChi nvarchar(100), @SDT nchar(11), @NgayTD date, @MaNQL int, @TenCV nvarchar(50)
AS
BEGIN
	-- Kiểm tra xem @HoNV có giá trị NULL hay không
	IF @HoNV IS NULL OR @HoNV = ''
	BEGIN 
		RAISERROR (N'Dữ liệu Họ nhân viên không được để trống (NOT NULL)', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem @TenNV có giá trị NULL hay không
	IF @TenNV IS NULL OR @TenNV = ''
	BEGIN 
		RAISERROR (N'Dữ liệu Tên nhân viên không được để trống (NOT NULL)', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT có đủ 10 số
	IF LEN(@SDT) <> 10
	BEGIN
		RAISERROR (N'Số điện thoại phải có đủ 10 số', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT unique
	IF EXISTS (SELECT 1 FROM NhanVien WHERE SDT = @SDT)
	BEGIN 
		RAISERROR (N'Số điện thoại đã tồn tại', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT có phải là các chữu số hay không
	IF ISNUMERIC(@SDT) = 0
	BEGIN
		RAISERROR (N'Số điện thoại chỉ được chứa các ký tự số', 16, 1);
		RETURN;
	END
	--Kiểm tra đủ 18 tuổi hay chưa
	IF DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 18
	BEGIN
		RAISERROR (N'Ngày sinh không đủ 18 tuổi', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaNQL đã tồn tại trong bảng NhanVien hay không
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNQL)
	BEGIN 
		RAISERROR (N'Mã Người quản lý không tồn tại', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaVC đã tồn tại trong bảng CongViec hay không
	DECLARE @MaCV INT
    SELECT @MaCV = MaCV
    FROM CongViec
    WHERE TenCV = @TenCV
	IF @MaCV IS NULL
    BEGIN
		RAISERROR (N'Tên công việc không hợp lệ', 16, 1);
        RETURN
    END
    INSERT INTO NhanVien(HoNV, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, NgayTD, MaNQL, MaCV)
	VALUES (@HoNV, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @NgayTD, @MaNQL, @MaCV);
END
GO

-- Chức năng sửa nhân viên
CREATE PROCEDURE PROC_SuaNhanVien
@MaNV INT, @HoNV nvarchar(10), @TenNV nvarchar(10), @NgaySinh date, @GioiTinh nvarchar(3), @DiaChi nvarchar(100), @SDT nchar(11), @NgayTD date, @MaNQL int, @TenCV nvarchar(50)
AS
BEGIN
	-- Kiểm tra nhân viên hàng trống
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        PRINT N'Mã Nhân viên không tồn tại';
        RETURN;
    END
	-- Kiểm tra xem @HoNV có giá trị NULL hay không
	IF @HoNV IS NULL OR @HoNV = ''
	BEGIN 
		RAISERROR (N'Dữ liệu Họ nhân viên không được để trống (NOT NULL)', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem @TenNV có giá trị NULL hay không
	IF @TenNV IS NULL OR @TenNV = ''
	BEGIN 
		RAISERROR (N'Dữ liệu Tên nhân viên không được để trống (NOT NULL)', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT có đủ 10 số
	IF LEN(@SDT) <> 10
	BEGIN
		RAISERROR (N'Số điện thoại phải có đủ 10 số', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT unique
	IF EXISTS (SELECT 1 FROM NhanVien WHERE SDT = @SDT And  @SDT <> (select SDT from NhanVien where MaNV = @MaNV))
	BEGIN 
		RAISERROR (N'Số điện thoại đã tồn tại', 16, 1);
		RETURN;
	END
	--Kiểm tra SDT có phải là các chữu số hay không
	IF ISNUMERIC(@SDT) = 0
	BEGIN
		RAISERROR (N'Số điện thoại chỉ được chứa các ký tự số', 16, 1);
		RETURN;
	END
	--Kiểm tra đủ 18 tuổi hay chưa
	IF DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 18
	BEGIN
		RAISERROR (N'Ngày sinh không đủ 18 tuổi', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaNQL đã tồn tại trong bảng NhanVien hay không
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNQL)
	BEGIN 
		RAISERROR (N'Mã Người quản lý không tồn tại', 16, 1);
		RETURN;
	END
	-- Kiểm tra xem MaVC đã tồn tại trong bảng CongViec hay không
	DECLARE @MaCV int
    SELECT @MaCV = MaCV
    FROM CongViec
    WHERE TenCV = @TenCV
	IF @MaCV IS NULL
    BEGIN
		RAISERROR (N'Tên công việc không hợp lệ', 16, 1);
        RETURN
    END
	UPDATE NhanVien
    SET
        HoNV = @HoNV,
        TenNV = @TenNV,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
		DiaChi = @DiaChi,
        SDT = @SDT,
		NgayTD = @NgayTD,
        MaNQL = @MaNQL,
		MaCV = @MaCV
    WHERE MaNV = @MaNV
END
GO

-- Chức năng xóa nhân viên
CREATE PROCEDURE PROC_XoaNhanVien
    @MaNV int
AS
BEGIN
    -- Kiểm tra xem MaNV đã tồn tại trong bảng HoaDon
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        RAISERROR (N'Mã Nhân Viên không tồn tại', 16, 1)
        RETURN;
    END
    -- Xóa hóa đơn
	UPDATE NhanVien
	SET MaNQL = NULL
	WHERE MaNQL = @MaNV;
    DELETE FROM NhanVien WHERE MaNV = @MaNV
END
GO

