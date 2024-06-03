use QLNH
go

--View xem ca làm việc của nhân viên theo ngày
CREATE VIEW V_CaLamTheoNgay AS
SELECT NV.MaNV, NV.HoNV, NV.TenNV, CLV.*, PC.Ngay
FROM NhanVien NV
INNER JOIN PhanCa PC ON NV.MaNV = PC.MaNV
INNER JOIN CaLamViec CLV ON PC.MaCa = CLV.MaCa
go

--View xem thông tin của nhân viên
CREATE VIEW V_ThongTinNhanVien AS
SELECT NV.*, CV.TenCV, CV.Luong
FROM NhanVien NV
INNER JOIN CongViec CV ON NV.MaCV = CV.MaCV
go


--View xem Danh sách sản phẩm và nguyên liệu
CREATE VIEW V_SanPhamVaNguyenLieu AS
SELECT SP.*, NL.TenNL, SPNL.SoLuong AS SoLuongNguyenLieu, NL.DonViTinh
FROM SanPham SP
INNER JOIN SP_NL SPNL ON SP.MaSP = SPNL.MaSP
INNER JOIN NguyenLieu NL ON SPNL.MaNL = NL.MaNL;
go

--View xem danh sách sản phẩm
CREATE VIEW V_DanhSachSanPham AS
SELECT SanPham.*
FROM SanPham
go

--View số lượng sản phẩm đã bán và doanh thu theo ngày
CREATE VIEW V_SoLuongSPVaDoanhThuTheoNgay AS
SELECT HD.ThoiGian AS Ngay, SP.TenSP,
    SUM(CTHD.SoLuong) AS SoLuongSanPhamDaBan,
    SUM(CTHD.SoLuong * SP.DonGia) AS DoanhThu
FROM HoaDon HD
INNER JOIN ChiTietHD CTHD ON HD.MaHD = CTHD.MaHD
INNER JOIN SanPham SP ON CTHD.MaSP = SP.MaSP
WHERE HD.TrangThai = 'Hoàn thành' -- Chỉ tính các hóa đơn đã thanh toán
GROUP BY HD.ThoiGian, SP.TenSP;
go

--View xem chi tiết nhập nguyên liệu của nhà hàng.
CREATE VIEW V_ChiTietDonNhap AS
SELECT DN.MaDon, DN.NgNhap, CTNL.GiaTienNL , NCC.TenNCC AS NhaCungCap, NL.TenNL AS NguyenLieu, NL.DonViTinh, CTDN.SoLuong AS SoLuongNhap
FROM DonNhapTP DN
INNER JOIN CTDonNhap CTDN ON DN.MaDon = CTDN.MaDon
INNER JOIN NguyenLieu NL ON CTDN.MaNL = NL.MaNL
INNER JOIN CTNgLieu CTNL ON CTNL.MaNL = NL.MaNL
INNER JOIN NhaCungCap NCC ON NCC.MaNCC = CTNL.MaNCC;
go

--View xem thông tin khách hàng
CREATE VIEW V_KhachHang AS
SELECT KhachHang.*
FROM KhachHang
go

--View xem các hóa đơn chưa thanh toán
CREATE VIEW V_HoaDonChuaThanhToan AS
SELECT HD.MaHD, HD.TriGiaHD, HD.ThoiGian, HD.TrangThai, KH.TenKH, KH.SDT
FROM HoaDon HD
INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
WHERE HD.TrangThai != N'Hoàn thành';
go

--View xem số lượng nguyên liệu của nhà hàng
CREATE VIEW V_SoLuongNguyenLieu AS
SELECT NguyenLieu.*
FROM NguyenLieu
go

--Trigger Cập nhập điểm tích lũy khi khách hàng thanh toán hóa đơn
CREATE TRIGGER Trigger_CapNhatDiemTichLuy
ON HoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @MaHD int, @MaKH int, @TriGiaHD float;
    SELECT @MaHD = MaHD, @MaKH = MaKH, @TriGiaHD = TriGiaHD
    FROM inserted;
    
    DECLARE @DiemTL INT;
    SELECT @DiemTL = DiemTL
    FROM KhachHang
    WHERE MaKH = @MaKH;
    
    -- Tính toán điểm tích lũy mới dựa trên tổng tiền hóa đơn (ví dụ: 1 điểm cho mỗi 1000 VNĐ)
    DECLARE @DiemMoi INT;
    SET @DiemMoi = @TriGiaHD / 1000;
    
    -- Cập nhật điểm tích lũy mới
    UPDATE KhachHang
    SET DiemTL = @DiemTL + @DiemMoi
    WHERE MaKH = @MaKH;
END;
go
-- Trigger không cho xóa hóa đơn chưa thanh toán
CREATE TRIGGER Trigger_NganXoaHoaDonChuaThanhToan
ON HoaDon
INSTEAD OF DELETE
AS
BEGIN
    -- Kiểm tra xem có bất kỳ hóa đơn nào chưa thanh toán trong bảng bị xóa không
    IF EXISTS (SELECT 1 FROM deleted WHERE TrangThai <> N'Hoàn thành')
    BEGIN
        ROLLBACK TRANSACTION -- Hủy bỏ thao tác xóa
		Print N'Không thể xóa hóa đơn chưa hoàn thành'
    END
    ELSE
    BEGIN
        -- Nếu không có hóa đơn chưa thanh toán, thực hiện xóa bình thường
        DELETE FROM HoaDon WHERE MaHD IN (SELECT MaHD FROM deleted);
    END
END;
go
CREATE TRIGGER Trigger_CapNhatSoLuongNL
ON ChiTietHD
AFTER INSERT
AS
BEGIN
    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    -- Cập nhật số lượng nguyên liệu dựa trên dữ liệu từ bảng SP_NL và inserted
    UPDATE nl
    SET nl.SoLuong = nl.SoLuong - (i.SoLuong * sn.SoLuong)
    FROM NguyenLieu nl
    JOIN SP_NL sn ON nl.MaNL = sn.MaNL
    JOIN inserted i ON i.MaSP = sn.MaSP;
    -- Kết thúc giao dịch
    COMMIT TRANSACTION;
END;
go

CREATE TRIGGER Trigger_ThongBaoNhapHang
ON NguyenLieu
AFTER INSERT, UPDATE
AS
BEGIN
    -- Lấy danh sách các nguyên liệu dưới ngưỡng SLTonKho
    DECLARE @NguyenLieuDuoiNguong nvarchar(max) = N'';

    SELECT @NguyenLieuDuoiNguong = @NguyenLieuDuoiNguong + n.TenNL + N', '
    FROM inserted i
    INNER JOIN NguyenLieu n ON i.MaNL = n.MaNL
    WHERE i.SoLuong <= n.SLTonKho;

    -- Loại bỏ dấu phẩy và khoảng trắng cuối cùng (nếu có)
    IF @NguyenLieuDuoiNguong IS NOT NULL AND LEN(@NguyenLieuDuoiNguong) > 0
	BEGIN
		SET @NguyenLieuDuoiNguong = RTRIM(LEFT(@NguyenLieuDuoiNguong, LEN(@NguyenLieuDuoiNguong) - 1));
	END

    -- Kiểm tra và thông báo về số lượng nguyên liệu dưới ngưỡng SLTonKho
    IF @NguyenLieuDuoiNguong != ''
    BEGIN
        PRINT N'Các nguyên liệu dưới ngưỡng SLTonKho cần phải nhập hàng: ' + @NguyenLieuDuoiNguong;
    END
END;
GO

CREATE TRIGGER Trigger_CapNhatSoLuongNLKhiNhapHang
ON CTDonNhap
AFTER INSERT
AS
BEGIN
    -- Duyệt qua các dòng được chèn vào bảng CTDonNhap
    DECLARE @MaNL nchar(10), @SoLuongNhap int;
    
    DECLARE db_cursor CURSOR FOR
    SELECT MaNL, SoLuong
    FROM inserted;

    OPEN db_cursor;
    FETCH NEXT FROM db_cursor INTO @MaNL, @SoLuongNhap;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Cập nhật số lượng nguyên liệu trong bảng NguyenLieu
        UPDATE NguyenLieu
        SET SoLuong = SoLuong + @SoLuongNhap
        WHERE MaNL = @MaNL;
		Print N'Cập nhập số lượng nguyên liệu thành công';
        FETCH NEXT FROM db_cursor INTO @MaNL, @SoLuongNhap;
    END

    CLOSE db_cursor;
    DEALLOCATE db_cursor;
END;
GO
