--main
CREATE DATABASE QLBV
USE QLBV
go
CREATE TABLE BENHNHAN (
    MaBenhNhan CHAR(10) PRIMARY KEY, -- Mã Bệnh Nhân
    HoTen NVARCHAR(100), -- Họ Tên
    NgaySinh DATE, -- Ngày Sinh
    GioiTinh NVARCHAR(10), -- Giới Tính
    DiaChi NVARCHAR(255), -- Địa Chỉ
    SoDienThoai NVARCHAR(15), -- Số Điện Thoại
	TrangThai NVARCHAR(50),
    MaBHYT CHAR(15), -- Mã Bảo Hiểm Y Tế, Có Thể NULL
	Tukhoa NVARCHAR(50),
	Denkhoa NVARCHAR(50)
);
GO
ALTER TABLE BENHNHAN
ADD Tuoi INT;

INSERT INTO BENHNHAN (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, TrangThai, MaBHYT, Tukhoa, Denkhoa)
VALUES 
    ('BN00000001', N'Nguyễn Văn A', '1990-01-15', N'Nam', N'Hà Nội', '0905123456', N'Đang điều trị', 'BHYT0001', N'Nội khoa', N'Ngoại khoa'),
    ('BN00000002', N'Lê Thị B', '1985-05-21', N'Nữ', N'TP Hồ Chí Minh', '0917123456', N'Xuất viện', 'BHYT0002', N'Nhi khoa', N'Tai mũi họng'),
    ('BN00000003', N'Phạm Văn C', '1979-12-12', N'Nam', N'Đà Nẵng', '0938123456', N'Tái khám', 'BHYT0003', N'Nội khoa', N'Tim mạch'),
    ('BN00000004', N'Hoàng Thị D', '1992-07-23', N'Nữ', N'Hải Phòng', '0949123456', N'Đang điều trị', NULL, N'Nhi khoa', N'Sản phụ khoa'),
    ('BN00000005', N'Vũ Minh E', '1988-03-14', N'Nam', N'Cần Thơ', '0970123456', N'Chờ xét nghiệm', 'BHYT0005', N'Nội khoa', N'Ngoại khoa'),
    ('BN00000006', N'Đỗ Thị F', '1994-11-11', N'Nữ', N'Nha Trang', '0961123456', N'Xuất viện', NULL, N'Tim mạch', N'Hô hấp'),
    ('BN00000007', N'Trần Văn G', '1983-08-19', N'Nam', N'Vinh', '0952123456', N'Đang điều trị', 'BHYT0007', N'Nội khoa', N'Ngoại khoa'),
    ('BN00000008', N'Ngô Thị H', '1991-10-30', N'Nữ', N'Quảng Ninh', '0923123456', N'Chờ phẫu thuật', 'BHYT0008', N'Sản phụ khoa', N'Tai mũi họng'),
    ('BN00000009', N'Lương Minh I', '1975-09-05', N'Nam', N'Bình Dương', '0914123456', N'Tái khám', 'BHYT0009', N'Nội khoa', N'Ngoại khoa'),
    ('BN00000010', N'Phan Thị K', '1987-04-28', N'Nữ', N'Quảng Nam', '0906123456', N'Xuất viện', NULL, N'Nhi khoa', N'Răng hàm mặt'),
    ('BN00000011', N'Huỳnh Văn L', '1970-06-14', N'Nam', N'Huế', '0907123456', N'Chờ xét nghiệm', 'BHYT0011', N'Nội khoa', N'Tim mạch'),
    ('BN00000012', N'Lý Thị M', '1993-02-02', N'Nữ', N'Tây Ninh', '0908123456', N'Đang điều trị', NULL, N'Nhi khoa', N'Hô hấp'),
    ('BN00000013', N'Hồ Văn N', '1981-11-22', N'Nam', N'Hậu Giang', '0913123456', N'Tái khám', 'BHYT0013', N'Tim mạch', N'Nội tiết'),
    ('BN00000014', N'Tạ Thị O', '1996-07-16', N'Nữ', N'Hòa Bình', '0920123456', N'Xuất viện', NULL, N'Nhi khoa', N'Răng hàm mặt'),
    ('BN00000015', N'Cao Văn P', '1984-10-11', N'Nam', N'Bắc Giang', '0930123456', N'Đang điều trị', 'BHYT0015', N'Tai mũi họng', N'Nội khoa');

CREATE TABLE KHOA (
	MaKhoa CHAR(10) PRIMARY KEY,
	TenKhoa NVARCHAR(50)
)

INSERT INTO KHOA (MaKhoa, TenKhoa) VALUES 
('K01', N'Nội tổng hợp'),
('K02', N'Ngoại tổng hợp'),
('K03', N'Nhi khoa'),
('K04', N'Sản khoa'),
('K05', N'Tim mạch'),
('K06', N'Tai mũi họng'),
('K07', N'Tiêu hóa'),
('K08', N'Nhãn khoa'),
('K09', N'Da liễu'),
('K10', N'Phục hồi chức năng');
CREATE TABLE BACSI (
    MaBacSi CHAR(10) PRIMARY KEY, -- Mã Bác Sĩ
    HoTen NVARCHAR(100), -- Họ Tên
    MaKhoa CHAR(10), -- Khoa
    SoDienThoai NVARCHAR(15), -- Số Điện Thoại
	SoCaTruc INT DEFAULT 0,
	MatKhau char(20),
	ChucVu nvarchar(30),
	FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);
GO

INSERT INTO BACSI (MaBacSi, HoTen, MaKhoa, SoDienThoai, SoCaTruc, MatKhau, ChucVu)
VALUES
('B001', N'Nguyễn Văn A', 'K01', '0901234567', 3, 'password123', N'Bác sĩ'),
('B002', N'Phan Thị B', 'K02', '0902345678', 4, 'password123', N'Bác sĩ'),
('B003', N'Hoàng Minh C', 'K03', '0903456789', 2, 'password123', N'Bác sĩ'),
('B004', N'Trần Thị D', 'K01', '0904567890', 5, 'password123', N'Bác sĩ'),
('B005', N'Lê Văn E', 'K04', '0905678901', 1, 'password123', N'Bác sĩ'),
('B006', N'Ngô Thị F', 'K02', '0906789012', 6, 'password123', N'Bác sĩ'),
('B007', N'Vũ Minh G', 'K03', '0907890123', 0, 'password123', N'Bác sĩ'),
('B008', N'Phạm Thị H', 'K04', '0908901234', 7, 'password123', N'Bác sĩ'),
('B009', N'Toàn Hoàng I', 'K01', '0909012345', 8, 'password123', N'Bác sĩ'),
('B010', N'Hồng Thị J', 'K02', '0900123456', 9, 'password123', N'Bác sĩ');
GO


CREATE TABLE TOATHUOC (
    MaToa CHAR(10) NOT NULL, -- Mã Toa
    NgayKetoa DATE, -- Ngày Kê Toa
    SoNgayDung INT, -- Số Ngày Dùng
    NgayKetThuc DATE, -- Ngày Kết Thúc
    SoLoaiThuoc INT, -- Số Loại Thuốc
    MaBsKetoa CHAR(10) NOT NULL, -- Mã Bác Sĩ Kê Toa
    CONSTRAINT PR_TOATHUOC PRIMARY KEY (MaToa), -- Khóa Chính
    CONSTRAINT FK_TOATHUOC_BACSI FOREIGN KEY (MaBsKetoa) REFERENCES BACSI(MaBacSi) -- Khóa Ngoại
);
GO

INSERT INTO TOATHUOC (MaToa, NgayKetoa, SoNgayDung, NgayKetThuc, SoLoaiThuoc, MaBsKetoa)
VALUES
('T001', '2024-11-01', 7, '2024-11-08', 3, 'B001'),
('T002', '2024-11-02', 5, '2024-11-07', 2, 'B002'),
('T003', '2024-11-03', 10, '2024-11-13', 4, 'B003'),
('T004', '2024-11-04', 14, '2024-11-18', 5, 'B004'),
('T005', '2024-11-05', 3, '2024-11-08', 1, 'B005'),
('T006', '2024-11-06', 7, '2024-11-13', 6, 'B006'),
('T007', '2024-11-07', 8, '2024-11-15', 2, 'B007'),
('T008', '2024-11-08', 12, '2024-11-20', 3, 'B008'),
('T009', '2024-11-09', 4, '2024-11-13', 4, 'B009'),
('T010', '2024-11-10', 6, '2024-11-16', 3, 'B010');
GO


CREATE TABLE THUOC (
    MaThuoc CHAR(10) NOT NULL, -- Mã Thuốc
    TenThuoc NVARCHAR(50), -- Tên Thuốc
    ThanhPhan NVARCHAR(50), -- Thành Phần
    Gia FLOAT, -- Giá
    CONSTRAINT PR_THUOC PRIMARY KEY (MaThuoc) -- Khóa Chính
);
GO
INSERT INTO THUOC (MaThuoc, TenThuoc, ThanhPhan, Gia)
VALUES 
('T001', 'Paracetamol', 'Paracetamol 500mg', 2000),
('T002', 'Ibuprofen', 'Ibuprofen 200mg', 2500),
('T003', 'Amoxicillin', 'Amoxicillin 500mg', 3000),
('T004', 'Vitamin C', 'Vitamin C 1000mg', 1500),
('T005', 'Aspirin', 'Aspirin 500mg', 1800),
('T006', 'Doxycycline', 'Doxycycline 100mg', 3500),
('T007', 'Cetirizine', 'Cetirizine 10mg', 2200),
('T008', 'Omeprazole', 'Omeprazole 20mg', 2800),
('T009', 'Loratadine', 'Loratadine 10mg', 2400),
('T010', 'Diphenhydramine', 'Diphenhydramine 25mg', 2100);
GO


CREATE TABLE CHITIETTOA (
    MaToa CHAR(10) NOT NULL, -- Mã Toa
    MaThuoc CHAR(10) NOT NULL, -- Mã Thuốc
    SoLuong INT, -- Số Lượng
    CachDung NVARCHAR(50), -- Cách Dùng
    CONSTRAINT PR_CHITIETTOA PRIMARY KEY (MaToa, MaThuoc), -- Khóa Chính
    CONSTRAINT FK_CHITIETTOA_TOATHUOC FOREIGN KEY (MaToa) REFERENCES TOATHUOC(MaToa), -- Khóa Ngoại
    CONSTRAINT FK_CHITIETTOA_THUOC FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc) -- Khóa Ngoại
);
GO

INSERT INTO CHITIETTOA (MaToa, MaThuoc, SoLuong, CachDung)
VALUES 
('T001', 'T001', 2, N'Uống 1 viên mỗi 4 giờ'),
('T001', 'T002', 1, N'Uống 1 viên mỗi 6 giờ'),
('T002', 'T003', 3, N'Uống 1 viên mỗi 8 giờ'),
('T002', 'T004', 2, N'Uống 1 viên mỗi ngày'),
('T003', 'T005', 1, N'Uống 1 viên mỗi 6 giờ'),
('T003', 'T006', 2, N'Uống 1 viên mỗi 8 giờ'),
('T004', 'T007', 1, N'Uống 1 viên mỗi ngày'),
('T004', 'T008', 1, N'Uống 1 viên vào buổi sáng'),
('T005', 'T009', 3, N'Uống 1 viên mỗi tối'),
('T005', 'T010', 2, N'Uống 1 viên mỗi ngày');
GO


CREATE TABLE PHIEUKHAM (
    MaPhieuKham CHAR(10) PRIMARY KEY, -- Mã Phiếu Khám
    MaBenhNhan CHAR(10), -- Mã Bệnh Nhân
    NgayKham DATE, -- Ngày Khám
    ChanDoan NVARCHAR(255), -- Chẩn Đoán
    MaBacSi CHAR(10), -- Mã Bác Sĩ
    KetQua NVARCHAR(255), -- Kết Quả
    GiaKham FLOAT, -- Giá Khám
    MaToa CHAR(10), -- Mã Toa
    FOREIGN KEY (MaToa) REFERENCES TOATHUOC(MaToa), -- Khóa Ngoại
    FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan), -- Khóa Ngoại
    FOREIGN KEY (MaBacSi) REFERENCES BACSI(MaBacSi) -- Khóa Ngoại
);
GO

INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK001', 'BN00000001', '2024-11-01', N'Viêm họng cấp', 'B002', N'Đã điều trị, khỏe mạnh', 100000, 'T001')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK002', 'BN00000001', '2024-11-02', N'Cảm cúm', 'B003', N'Điều trị khỏi, tiếp tục theo dõi', 120000, 'T002')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK003', 'BN00000003', '2024-11-03', N'Đau bụng', 'B004', N'Khám và điều trị ổn', 110000, 'T003')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK004', 'BN00000004', '2024-11-04', N'Viêm phổi', 'B005', N'Điều trị khỏi, đã hồi phục', 150000, 'T004')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK005', 'BN00000005', '2024-11-05', N'Viêm dạ dày', 'B006', N'Điều trị, tái khám sau 1 tuần', 130000, 'T005')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK006', 'BN00000006', '2024-11-06', N'Chấn thương đầu gối', 'B007', N'Điều trị phục hồi chức năng', 140000, 'T006')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK007', 'BN00000008', '2024-11-07', N'Viêm gan', 'B008', N'Điều trị và theo dõi lâu dài', 160000, 'T007')
INSERT INTO PHIEUKHAM (MaPhieuKham, MaBenhNhan, NgayKham, ChanDoan, MaBacSi, KetQua, GiaKham, MaToa)
VALUES
('PK008', 'BN00000008', '2024-11-08', N'Thử nghiệm máu', 'B009', N'Kết quả bình thường', 180000, 'T008')



CREATE TABLE NHAPVIEN (
    MaNhapVien CHAR(10) PRIMARY KEY, -- Mã Nhập Viện
    MaBenhNhan CHAR(10), -- Mã Bệnh Nhân
    NgayNhapVien DATE, -- Ngày Nhập Viện
    MaBacSi CHAR(10), -- Mã Bác Sĩ
    MaPhong CHAR(10), -- Mã Phòng
    LyDoNhapVien NVARCHAR(255), -- Lý Do Nhập Viện
    FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan), -- Khóa Ngoại
    FOREIGN KEY (MaBacSi) REFERENCES BACSI(MaBacSi) -- Khóa Ngoại
);
GO

INSERT INTO NHAPVIEN (MaNhapVien, MaBenhNhan, NgayNhapVien, MaBacSi, MaPhong, LyDoNhapVien)
VALUES 
    ('NV001', 'BN00000001', '2024-01-10', 'B001', 'P001', N'Cảm cúm nặng')
	INSERT INTO NHAPVIEN (MaNhapVien, MaBenhNhan, NgayNhapVien, MaBacSi, MaPhong, LyDoNhapVien)
VALUES
    ('NV002', 'BN00000005', '2024-01-15', 'B002', 'P002', N'Viêm phổi cấp')

CREATE TABLE RAVIEN (
    MaRaVien CHAR(10) PRIMARY KEY, -- Mã Ra Viện
    MaNhapVien CHAR(10), -- Mã Nhập Viện
    NgayRaVien DATE, -- Ngày Ra Viện
    TinhTrangRaVien NVARCHAR(255), -- Tình Trạng Ra Viện
	MaBenhNhan CHAR(10), 
	SoNgayNamVien INT,
    FOREIGN KEY (MaNhapVien) REFERENCES NHAPVIEN(MaNhapVien), -- Khóa Ngoại
	FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan)
);
GO
  

CREATE TABLE HOSOBENHAN (
    MaHoSo CHAR(10) PRIMARY KEY, -- Mã Hồ Sơ
    MaBenhNhan CHAR(10), -- Mã Bệnh Nhân
    NgayLapHoSo DATE, -- Ngày Lập Hồ Sơ
    MaBacSi CHAR(10), -- Mã Bác Sĩ
    NoiDungHoSo NVARCHAR(255), -- Nội Dung Hồ Sơ
    FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan), -- Khóa Ngoại
    FOREIGN KEY (MaBacSi) REFERENCES BACSI(MaBacSi) -- Khóa Ngoại
);
GO

INSERT INTO HOSOBENHAN (MaHoSo, MaBenhNhan, NgayLapHoSo, MaBacSi, NoiDungHoSo)
VALUES
    ('HS001', 'BN00000001', '2024-11-01', 'B002', N'Lập hồ sơ điều trị viêm họng cấp'),
    ('HS002', 'BN00000001', '2024-11-02', 'B003', N'Lập hồ sơ điều trị cảm cúm'),
    ('HS003', 'BN00000003', '2024-11-03', 'B004', N'Lập hồ sơ điều trị đau bụng'),
    ('HS004', 'BN00000004', '2024-11-04', 'B005', N'Lập hồ sơ điều trị viêm phổi'),
    ('HS005', 'BN00000005', '2024-11-05', 'B006', N'Lập hồ sơ điều trị viêm dạ dày'),
    ('HS006', 'BN00000006', '2024-11-06', 'B007', N'Lập hồ sơ điều trị chấn thương đầu gối'),
    ('HS007', 'BN00000008', '2024-11-07', 'B008', N'Lập hồ sơ điều trị viêm gan'),
    ('HS008', 'BN00000008', '2024-11-08', 'B009', N'Lập hồ sơ khám sức khỏe định kỳ'),
    ('HS009', 'BN00000005', '2024-01-15', 'B002', N'Lập hồ sơ nhập viện viêm phổi cấp'),
    ('HS010', 'BN00000001', '2024-01-10', 'B001', N'Lập hồ sơ nhập viện cảm cúm nặng');

CREATE TABLE CATRUC (
    MaCaTruc CHAR(10) PRIMARY KEY, -- Mã Ca Trực
    ThoiGianCa NVARCHAR(50) -- Thời Gian Ca: 'Ca Sáng', 'Ca Chiều', 'Ca Tối'
);
GO
CREATE TABLE LICHTRUC (
    MaLichTruc CHAR(10) PRIMARY KEY, -- Mã Lịch Trực
    MaBacSi CHAR(10), -- Mã Bác Sĩ
    NgayTruc DATE, -- Ngày Trực
    MaCaTruc CHAR(10), -- Ca Trực: Sáng, Chiều, Tối
    FOREIGN KEY (MaBacSi) REFERENCES BACSI(MaBacSi), -- Khóa Ngoại
    FOREIGN KEY (MaCaTruc) REFERENCES CATRUC(MaCaTruc) -- Khóa Ngoại
);
GO
CREATE TABLE CHIDINHXETNGHIEM (
    MaChiDinh CHAR(10) PRIMARY KEY, -- Mã Chỉ Định
    MaPhieuKham CHAR(10), -- Mã Phiếu Khám
    LoaiChiDinh NVARCHAR(255), -- Loại Chỉ Định
    NgayChiDinh DATE, -- Ngày Chỉ Định
    FOREIGN KEY (MaPhieuKham) REFERENCES PHIEUKHAM(MaPhieuKham) -- Khóa Ngoại
);
GO
INSERT INTO CHIDINHXETNGHIEM (MaChiDinh, MaPhieuKham, LoaiChiDinh, NgayChiDinh)
VALUES 
    ('CD001', 'PK001', N'Xét nghiệm máu', '2024-01-10'),
    ('CD002', 'PK002', N'Xét nghiệm nước tiểu', '2024-01-12'),
    ('CD003', 'PK003', N'Chụp X-quang', '2024-02-05'),
    ('CD004', 'PK004', N'Siêu âm', '2024-02-20'),
    ('CD005', 'PK005', N'Nội soi dạ dày', '2024-03-10'),
    ('CD006', 'PK006', N'Xét nghiệm đường huyết', '2024-04-01'),
    ('CD007', 'PK007', N'Soi cổ tử cung', '2024-05-15'),
    ('CD008', 'PK008', N'Điện tâm đồ', '2024-06-18');
  
GO


CREATE TABLE THANHTOAN (
    MaThanhToan CHAR(10) PRIMARY KEY, -- Mã Thanh Toán
    MaPhieuKham CHAR(10), -- Mã Phiếu Khám
	MaRaVien CHAR(10), -- Mã Ra Viện
    SoTien FLOAT, -- Số Tiền
    NgayThanhToan DATE, -- Ngày Thanh Toán
    FOREIGN KEY (MaPhieuKham) REFERENCES PHIEUKHAM(MaPhieuKham), -- Khóa Ngoại
	FOREIGN KEY (MaRaVien) REFERENCES RAVIEN(MaRaVien)
);
GO

INSERT INTO THANHTOAN (Mathanhtoan, MaPhieuKham, SoTien, NgayThanhToan) VALUES
('TT001', 'PK001', 500000, '2024-11-01'),
('TT002', 'PK002', 300000, '2024-11-02'),
('TT003', 'PK003', 450000, '2024-11-03'),
('TT004', 'PK004', 600000, '2024-11-04'),
('TT005', 'PK005', 700000, '2024-11-05'),
('TT006', 'PK006', 350000, '2024-11-06'),
('TT007', 'PK007', 800000, '2024-11-07');



CREATE TABLE LUUKHO (
    MaThuoc CHAR(10) PRIMARY KEY, -- Mã Thuốc
    TenThuoc NVARCHAR(50), -- Tên Thuốc
    SoLuongTon INT, -- Số Lượng Tồn
    DonViTinh NVARCHAR(20), -- Đơn Vị Tính
    NgayNhapKho DATE, -- Ngày Nhập Kho
    HanSuDung DATE, -- Hạn Sử Dụng
    FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc) -- Khóa Ngoại
);
GO

CREATE TABLE NHACCTHUOC (
    MaNCC CHAR(10) PRIMARY KEY, -- Mã Nhà Cung Cấp
    TenNCC NVARCHAR(50), -- Tên Nhà Cung Cấp
    DiaChi NVARCHAR(50) -- Địa Chỉ
);
GO

CREATE TABLE PHIEU_NHAP_THUOC (
    MaPN CHAR(10) PRIMARY KEY, -- Mã Phiếu Nhập
    MaNCC CHAR(10), -- Mã Nhà Cung Cấp
    NgayNhap DATE, -- Ngày Nhập
    ThanhTien FLOAT, -- Thành Tiền
    FOREIGN KEY (MaNCC) REFERENCES NHACCTHUOC(MaNCC) -- Khóa Ngoại
);
GO

CREATE TABLE CHITIET_PN_THUOC (
    MaPN CHAR(10) NOT NULL, -- Mã Phiếu Nhập
    MaThuoc CHAR(10) NOT NULL, -- Mã Thuốc
    SoLuong INT, -- Số Lượng
    Gia FLOAT, -- Giá
    PRIMARY KEY (MaPN, MaThuoc), -- Khóa Chính
    FOREIGN KEY (MaPN) REFERENCES PHIEU_NHAP_THUOC(MaPN), -- Khóa Ngoại
    FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc) -- Khóa Ngoại
);
GO
------------------------------------------------------------------------------------------------------------
-------------------------------------       TRIGGER      ---------------------------------------------------
------------------------------------------------------------------------------------------------------------
--// Tính tuổi dựa trên ngày tháng năm sinh (Trí)
CREATE TRIGGER TR_TinhTuoiBenhNhan
ON BENHNHAN
AFTER INSERT, UPDATE
AS
BEGIN
    BEGIN TRY
        UPDATE BENHNHAN
        SET Tuoi = DATEDIFF(YEAR, i.NgaySinh, GETDATE()) -
                   CASE WHEN MONTH(i.NgaySinh) > MONTH(GETDATE()) 
                             OR (MONTH(i.NgaySinh) = MONTH(GETDATE()) AND DAY(i.NgaySinh) > DAY(GETDATE()))
                        THEN 1
                        ELSE 0
                   END
        FROM BENHNHAN b
        INNER JOIN inserted i ON b.MaBenhNhan = i.MaBenhNhan;
    END TRY
    BEGIN CATCH       
        ROLLBACK TRANSACTION;
        RAISERROR('Lỗi khi tính tuổi bệnh nhân.', 16, 1);
    END CATCH
END;

--// Trigger kiểm tra số lượng thuốc trong toa khi kê toa (Trí)
CREATE TRIGGER TRG_KIEMTRA_SOLUONG_THUOC
ON CHITIETTOA
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaToa CHAR(10);
    
    SELECT @MaToa = i.MaToa
    FROM inserted i;

    -- Kiểm tra số loại thuốc trong toa
    IF (SELECT COUNT(*) FROM CHITIETTOA WHERE MaToa = @MaToa) > 10
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Số lượng thuốc trong toa không được vượt quá 10!', 16, 1);
    END
END;
GO

--// Trigger tự động cập nhật ngày kết thúc toa thuốc (Trí)
CREATE TRIGGER TRG_TINH_NGAYKETTHUC_TOATHUOC
ON TOATHUOC
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaToa CHAR(10), @SoNgayDung INT;

    SELECT @MaToa = i.MaToa, @SoNgayDung = i.SoNgayDung
    FROM inserted i;

    UPDATE TOATHUOC
    SET NgayKetThuc = DATEADD(DAY, @SoNgayDung, GETDATE())
    WHERE MaToa = @MaToa;
END;
GO
--// Trigger tự động cập nhật ngày kê toa thuốc là ngày hiện tại  (Trí)
CREATE TRIGGER TRG_TU_DONG_NHAP_NGAYKETOA
ON TOATHUOC
AFTER INSERT
AS
BEGIN
    
    UPDATE TOATHUOC
    SET NgayKeToa = GETDATE()
    WHERE MaToa IN (SELECT MaToa FROM inserted);
END;
GO

--// Trigger tự động cập nhật ngày Khám là ngày hiện tại  (Trí)
CREATE TRIGGER TRG_TU_DONG_NHAP_NGAYKHAM
ON PHIEUKHAM
AFTER INSERT
AS
BEGIN
    
    UPDATE PHIEUKHAM
    SET NgayKham = GETDATE()
    WHERE MaPhieuKham IN (SELECT MaPhieuKham FROM inserted);
END;
GO
--// Trigger kiểm tra bác sĩ kê toa không được trùng với bác sĩ khám bệnh (Trí)
CREATE TRIGGER TRG_KIEMTRA_BACSI_KETOAPHIEUKHAM
ON PHIEUKHAM
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaPhieuKham CHAR(10), @MaBacSi CHAR(10), @MaToa CHAR(10);

    SELECT @MaPhieuKham = i.MaPhieuKham, @MaBacSi = i.MaBacSi, @MaToa = i.MaToa
    FROM inserted i;

    IF EXISTS (SELECT 1 
               FROM TOATHUOC t
               WHERE t.MaToa = @MaToa AND t.MaBsKetoa = @MaBacSi)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Bác sĩ kê toa không được trùng với bác sĩ khám bệnh!', 16, 1);
    END
END;
GO

--// Trigger tự động xóa chi tiết toa thuốc khi xóa toa (Trí)
CREATE TRIGGER TRG_XOA_CHITIET_TOA
ON TOATHUOC
AFTER DELETE
AS
BEGIN
    DECLARE @MaToa CHAR(10);

    SELECT @MaToa = d.MaToa FROM deleted d;

    DELETE FROM CHITIETTOA WHERE MaToa = @MaToa;
END;
GO

--// Trigger kiểm tra tuổi bệnh nhân khi thêm bệnh nhân (ít nhất 1 tuổi)(Trí)
CREATE TRIGGER TR_KiemTraTuoiBenhNhan
ON BENHNHAN
AFTER INSERT
AS
BEGIN
    DECLARE @NgaySinh DATE;
    SELECT @NgaySinh = NgaySinh FROM inserted;
    
    IF DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 1
    BEGIN
        RAISERROR('Bệnh nhân phải ít nhất 1 tuổi.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--// Trigger kiểm tra khi thêm dữ liệu vào bảng HOSOBENHAN thì NgayLapHoSo là ngày hiện hành (Bảo Duy)
CREATE TRIGGER TRG_CHECK_NGAY_LAP_HOSO
ON HOSOBENHAN
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NgayLapHoSo <> CAST(GETDATE() AS DATE)
    )
    BEGIN
        -- Xóa bản ghi vừa thêm vì vi phạm quy tắc
        DELETE FROM HOSOBENHAN
        WHERE MaHoSo IN (SELECT MaHoSo FROM inserted);
        
        -- Thông báo lỗi
        RAISERROR(N'Ngày lập hồ sơ phải là ngày hiện hành!', 16, 1);
    END
END;
GO

--// Trigger kiểm tra khi thêm HOSOBENHAN thì bệnh nhân phải tồn tại (Bảo Duy)
CREATE TRIGGER TRG_CHECK_MABN_TONTAI
ON HOSOBENHAN
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN BENHNHAN b ON i.MaBenhNhan = b.MaBenhNhan
        WHERE b.MaBenhNhan IS NULL
    )
    BEGIN
        -- Xóa hồ sơ bệnh án vừa thêm vì mã bệnh nhân không tồn tại
        DELETE FROM HOSOBENHAN
        WHERE MaHoSo IN (SELECT MaHoSo FROM inserted);

        -- Thông báo lỗi
        RAISERROR(N'Mã bệnh nhân không tồn tại trong hệ thống!', 16, 1);
    END
END;
GO

--// Trigger kiểm tra khi thêm HOSOBENHAN thì bác sĩ phải tồn tại (Bảo Duy)
CREATE TRIGGER TRG_CHECK_MABS_TONTAI
ON HOSOBENHAN
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        LEFT JOIN BACSI b ON i.MaBacSi = b.MaBacSi
        WHERE b.MaBacSi IS NULL
    )
    BEGIN
        -- Xóa hồ sơ bệnh án vừa thêm vì mã bác sĩ không tồn tại
        DELETE FROM HOSOBENHAN
        WHERE MaHoSo IN (SELECT MaHoSo FROM inserted);

        -- Thông báo lỗi
        RAISERROR(N'Mã bác sĩ không tồn tại trong hệ thống!', 16, 1);
    END
END;
GO

--// Trigger cập nhật số lượng tồn khi nhập thuốc mới
CREATE TRIGGER TRG_UPDATE_SOLUONGTON
ON CHITIET_PN_THUOC
AFTER INSERT
AS
BEGIN
    -- Cập nhật SoLuongTon trong bảng LUUKHO
    UPDATE LUUKHO
    SET SoLuongTon = SoLuongTon + i.SoLuong
    FROM inserted i
    WHERE LUUKHO.MaThuoc = i.MaThuoc;
END;
GO

--// Trigger tính thành tiền phiếu nhập
CREATE TRIGGER TRG_THANHTIEN_PHIEUNHAP
ON CHITIET_PN_THUOC
AFTER INSERT
AS
BEGIN
    UPDATE PHIEU_NHAP_THUOC
    SET ThanhTien = ThanhTien + (SELECT SUM(SoLuong * Gia) FROM CHITIET_PN_THUOC WHERE MaPN = (SELECT MaPN FROM inserted))
    WHERE MaPN = (SELECT MaPN FROM inserted);
END;
GO

--// Trigger kiểm tra trạng thái bệnh nhân để tránh nhập viện hai lần
CREATE TRIGGER TRG_NHAPVIEN 
ON NHAPVIEN
AFTER INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10);
    SELECT @MaBenhNhan = MaBenhNhan FROM INSERTED;

    IF EXISTS (SELECT 1 FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan AND TrangThai = 'Đang điều trị')
    BEGIN
        RAISERROR('Bệnh nhân đang điều trị, không thể nhập viện hai lần.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        UPDATE BENHNHAN
        SET TrangThai = 'Đang điều trị'
        WHERE MaBenhNhan = @MaBenhNhan;
    END
END;
GO

--// Trigger kiểm tra thời gian nhập viện không được sau ngày hiện tại
CREATE TRIGGER TRG_KIEMTRA_NGAYNHAPVIEN
ON NHAPVIEN
AFTER INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10), @NgayNhapVien DATE;
    SELECT @MaBenhNhan = MaBenhNhan, @NgayNhapVien = NgayNhapVien FROM INSERTED;

    IF @NgayNhapVien > GETDATE()
    BEGIN
        RAISERROR('Ngày nhập viện không được sau ngày hiện tại.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--// Trigger tự động cập nhật NgàyRaVien khi bệnh nhân xuất viện
CREATE TRIGGER TRG_CAPNHAT_NGAYRAVIEN
ON RAVIEN
AFTER INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10), @NgayRaVien DATE;
    SELECT @MaBenhNhan = MaBenhNhan, @NgayRaVien = NgayRaVien FROM INSERTED;

    UPDATE RAVIEN
    SET NgayRaVien = @NgayRaVien
    WHERE MaBenhNhan = @MaBenhNhan AND NgayRaVien IS NULL;
END;
GO

--// Trigger kiểm tra số ngày nằm viện tối đa
CREATE TRIGGER TRG_KIEMTRA_SONGAYNAMVIEN
ON RAVIEN
AFTER INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10), @NgayNhapVien DATE, @NgayRaVien DATE;
    SELECT @MaBenhNhan = MaBenhNhan, @NgayRaVien = NgayRaVien FROM INSERTED;

    SELECT @NgayNhapVien = NgayNhapVien FROM NHAPVIEN WHERE MaBenhNhan = @MaBenhNhan;
    
    DECLARE @SoNgayNamVien INT = DATEDIFF(DAY, @NgayNhapVien, @NgayRaVien);

    IF @SoNgayNamVien > 180
    BEGIN
        RAISERROR('Số ngày nằm viện vượt quá số ngày tối đa cho phép.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--// Trigger tự động ghi nhận thời gian xuất viện hiện tại nếu không nhập ngày
CREATE TRIGGER TRG_TUDONG_CAPNHAT_NGAYRAVIEN
ON RAVIEN
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10), @NgayRaVien DATE;
    SELECT @MaBenhNhan = MaBenhNhan, @NgayRaVien = NgayRaVien FROM INSERTED;

    IF @NgayRaVien IS NULL
        SET @NgayRaVien = GETDATE();

    INSERT INTO RAVIEN (MaBenhNhan, NgayRaVien)
    VALUES (@MaBenhNhan, @NgayRaVien);
END;
GO

--// Trigger cập nhật trạng thái bệnh nhân thành "Chờ ra viện" nếu sắp tới ngày xuất viện
CREATE TRIGGER TRG_CAPNHAT_TRANGTHAI_CHO_RAVIEN
ON RAVIEN
AFTER INSERT
AS
BEGIN
    DECLARE @MaBenhNhan CHAR(10), @NgayRaVien DATE;
    SELECT @MaBenhNhan = MaBenhNhan, @NgayRaVien = NgayRaVien FROM INSERTED;

    IF DATEDIFF(DAY, GETDATE(), @NgayRaVien) = 1
    BEGIN
        UPDATE BENHNHAN
        SET TrangThai = 'Chờ ra viện'
        WHERE MaBenhNhan = @MaBenhNhan;
    END
END;
GO

--// Trigger cập nhật số ca khi thêm lịch trực mới
CREATE TRIGGER TRG_CAPNHAT_SOCA_ON_INSERT
ON LICHTRUC
AFTER INSERT
AS
BEGIN
    DECLARE @MaBacSi CHAR(10);
    SELECT @MaBacSi = MaBacSi FROM inserted;

    UPDATE BACSI 
    SET SoCaTruc = SoCaTruc + 1 
    WHERE MaBacSi = @MaBacSi;
END;
GO

--// Trigger kiểm tra trùng lịch trực
CREATE TRIGGER TRG_KIEMTRA_TRUNGLICH_TRUC
ON LICHTRUC
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN LICHTRUC lt ON i.MaBacSi = lt.MaBacSi AND i.NgayTruc = lt.NgayTruc
    )
    BEGIN
        RAISERROR('Bác sĩ đã có lịch trực trong ngày.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
-------------------------------------       PROCEDURE      -------------------------------------------------
------------------------------------------------------------------------------------------------------------

--// Procedure thêm bệnh nhân mới (Trí)
CREATE PROCEDURE PROC_THEMBENHNHAN
    @MaBenhNhan CHAR(10),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai NVARCHAR(15),
    @MaBHYT CHAR(15) = NULL,
	@TrangThai NVARCHAR(50),
	@Tukhoa NVARCHAR(50),
	@Denkhoa NVARCHAR(50)

AS
BEGIN
    IF EXISTS (SELECT * FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan)
    BEGIN
        RAISERROR ('Mã bệnh nhân đã tồn tại.', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO BENHNHAN (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaBHYT,TrangThai,Tukhoa,Denkhoa)
        VALUES (@MaBenhNhan, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @MaBHYT,@TrangThai,@Tukhoa,@Denkhoa);
    END
END;
GO
--///////// sửa bệnh nhân (Trí)
CREATE PROCEDURE PROC_SUABENHNHAN
    @MaBenhNhan CHAR(10),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai NVARCHAR(15),
    @MaBHYT CHAR(15) = NULL,
    @Tukhoa NVARCHAR(50),
    @Denkhoa NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem mã bệnh nhân có tồn tại trong bảng hay không
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan)
    BEGIN
        RAISERROR ('Mã bệnh nhân không tồn tại.', 16, 1);
    END
    ELSE
    BEGIN
        -- Nếu mã bệnh nhân tồn tại, tiến hành cập nhật thông tin
        UPDATE BENHNHAN
        SET HoTen = @HoTen,
            NgaySinh = @NgaySinh,
            GioiTinh = @GioiTinh,
            DiaChi = @DiaChi,
            SoDienThoai = @SoDienThoai,
            MaBHYT = @MaBHYT,
            Tukhoa = @Tukhoa,
            Denkhoa = @Denkhoa
        WHERE MaBenhNhan = @MaBenhNhan;
    END
END;
GO
--//////////////// xóa bệnh nhân (Trí)
CREATE PROCEDURE PROC_XOABENHNHAN
    @MaBenhNhan CHAR(10)
AS
BEGIN
    
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan)
    BEGIN
        RAISERROR ('Mã bệnh nhân không tồn tại.', 16, 1);
    END
    ELSE
    BEGIN
       
        DELETE FROM BENHNHAN
        WHERE MaBenhNhan = @MaBenhNhan;
    END
END;
GO
--////////xóa phiếu khám (Trí)
CREATE PROCEDURE PROC_XOAPHIEUKHAM		
    @MaPhieuKham CHAR(10)
AS
BEGIN
    
    IF NOT EXISTS (SELECT * FROM PHIEUKHAM WHERE MaPhieuKham = @MaPhieuKham)
    BEGIN
        RAISERROR ('Mã phiếu khám không tồn tại.', 16, 1);
    END
    ELSE
    BEGIN
        
        DELETE FROM PHIEUKHAM
        WHERE MaPhieuKham = @MaPhieuKham;
    END
END;
GO

--////////xóa toa thuốc (Trí)
CREATE PROCEDURE PROC_XOATOA	
    @MaToa CHAR(10)
AS
BEGIN
   
    IF NOT EXISTS (SELECT * FROM TOATHUOC WHERE MaToa = @MaToa)
    BEGIN
        RAISERROR (N'Mã toa không tồn tại.', 16, 1);
    END
    ELSE
    BEGIN
       
        DELETE FROM TOATHUOC
        WHERE MaToa = @MaToa;
    END
END;
GO

--// Procedure truy vấn bệnh án của một bệnh nhân (Trí)
CREATE PROCEDURE PROC_XEMHOSOBENHAN
    @MaBenhNhan CHAR(10)
AS
BEGIN
    SELECT * FROM HOSOBENHAN WHERE MaBenhNhan = @MaBenhNhan;
END;
GO

--// Procedure tiếp nhận bệnh nhân (Trí)
CREATE PROCEDURE PROC_TIEPNHANBENHNHAN
    @MaPhieuKham CHAR(10),
    @MaBenhNhan CHAR(10),
    @NgayKham DATE ,
    @ChanDoan NVARCHAR(255), 
    @MaBacSi CHAR(10), 
    @KetQua NVARCHAR(255), 
    @GiaKham FLOAT, 
    @MaToa CHAR(10)

AS
BEGIN
    INSERT INTO PHIEUKHAM (MaPhieuKham,MaBenhNhan, NgayKham,ChanDoan,MaBacSi,KetQua,GiaKham,MaToa)
    VALUES (@MaPhieuKham,@MaBenhNhan, @NgayKham,@ChanDoan,@MaBacSi,@KetQua,@GiaKham,@MaToa);

    PRINT 'Bệnh nhân đã được tiếp nhận';
END;
GO

--// Procedure phân bổ bác sĩ khám  (Trí)
CREATE PROCEDURE PROC_PHANBOBACSIKHAM
    @MaPhieuKham CHAR(10),
    @MaBacSi CHAR(10)
AS
BEGIN
    UPDATE PHIEUKHAM
    SET MaBacSi = @MaBacSi
    WHERE MaPhieuKham = @MaPhieuKham;

    PRINT 'Bác sĩ đã được phân bổ';
END;
GO

--// Procedure khám lâm sàng (Trí)
CREATE PROCEDURE PROC_KHAMLAMSANG
    @MaPhieuKham CHAR(10),
    @ChanDoan NVARCHAR(255),
    @KetQua NVARCHAR(255)
AS
BEGIN
    UPDATE PHIEUKHAM
    SET ChanDoan = @ChanDoan,
        KetQua = @KetQua
    WHERE MaPhieuKham = @MaPhieuKham;

    PRINT 'Khám lâm sàng hoàn tất';
END;
GO

--// Procedure chỉ định xét nghiệm hoặc chẩn đoán hình ảnh (Trí)
CREATE PROCEDURE PROC_CDXETNGHIEM
    @MaChiDinh CHAR(10),
    @MaPhieuKham CHAR(10),
    @LoaiChiDinh NVARCHAR(255),
    @NgayChiDinh DATE
AS
BEGIN
    INSERT INTO CHIDINHXETNGHIEM (MaChiDinh,MaPhieuKham, LoaiChiDinh, NgayChiDinh)
    VALUES (@MaChiDinh,@MaPhieuKham, @LoaiChiDinh, @NgayChiDinh);
	
    PRINT N'Chỉ định xét nghiệm/chẩn đoán chưa được tạo';
END;
GO

--// Procedure xử lý kết quả xét nghiệm, chẩn đoán (Trí)
CREATE PROCEDURE PROC_XULYKETQUAXETNGHIEM
    @MaPhieuKham CHAR(10),
    @KetQuaXetNghiem NVARCHAR(255)
AS
BEGIN
    UPDATE PHIEUKHAM
    SET KetQua = @KetQuaXetNghiem
    WHERE MaPhieuKham = @MaPhieuKham;

    PRINT 'Kết quả xét nghiệm/chẩn đoán đã được xử lý';
END;
GO

--// Procedure đưa ra phác đồ điều trị (Trí)
CREATE PROCEDURE PhacDoDieuTri
    @MaPhieuKham CHAR(10),
    @MaToa CHAR(10),
    @NgayKetToa DATE,
    @SoNgayDung INT,
	@NgayKetThuc DATE,
    @SoLoaiThuoc INT,
    @MaBacSi CHAR(10)
AS
BEGIN
    INSERT INTO TOATHUOC (MATOA, NGAYKETOA, SONGAYDUNG,NGAYKETTHUC, SOLOAITHUOC, MaBsKetoa)
    VALUES (@MaToa, @NgayKetToa, @SoNgayDung,@NgayKetThuc, @SoLoaiThuoc, @MaBacSi);

    UPDATE PHIEUKHAM
    SET MATOA = @MaToa
    WHERE MaPhieuKham = @MaPhieuKham;

    PRINT 'Phác đồ điều trị đã được đưa ra';
END;


--// Procedure thanh toán và hoàn tất thủ tục (Trí)
CREATE PROCEDURE PROC_THANHTOANTHUTUC
    @Mathanhtoan CHAR(10),
    @MaPhieuKham CHAR(10),
    @SoTien FLOAT
AS
BEGIN
    INSERT INTO THANHTOAN (Mathanhtoan,MaPhieuKham, SoTien, NgayThanhToan)
    VALUES (@Mathanhtoan,@MaPhieuKham, @SoTien, GETDATE());

    PRINT 'Thanh toán hoàn tất';
END;
GO


--// Procedure thêm hồ sơ bệnh án (Bảo Duy)
CREATE PROCEDURE PROC_THEMHOSOBENHAN
    @MaHoSo CHAR(10),
    @MaBenhNhan CHAR(10),
    @NgayLapHoSo DATE,
    @MaBacSi CHAR(10),
    @NoiDungHoSo NVARCHAR(255)
AS
BEGIN
    -- Kiểm tra xem mã hồ sơ bệnh án có bị trùng không
    IF EXISTS (SELECT 1 FROM HOSOBENHAN WHERE MaHoSo = @MaHoSo)
    BEGIN
        RAISERROR(N'Mã hồ sơ bệnh án đã tồn tại!', 16, 1);
        RETURN;
    END

    -- Thêm hồ sơ bệnh án mới
    INSERT INTO HOSOBENHAN (MaHoSo, MaBenhNhan, NgayLapHoSo, MaBacSi, NoiDungHoSo)
    VALUES (@MaHoSo, @MaBenhNhan, @NgayLapHoSo, @MaBacSi, @NoiDungHoSo);
END;
GO

--// Procedure cập nhật hồ sơ bệnh án (Bảo Duy)
CREATE PROCEDURE PROC_CAPNHATHOSOBENHAN
    @MaHoSo CHAR(10),
    @MaBenhNhan CHAR(10),
    @MaBacSi CHAR(10),
    @NoiDungHoSo NVARCHAR(255)
AS
BEGIN
    UPDATE HOSOBENHAN
    SET MaBenhNhan = @MaBenhNhan, MaBacSi = @MaBacSi, NoiDungHoSo = @NoiDungHoSo
    WHERE MaHoSo = @MaHoSo;
END;
GO

--// Procedure xóa hồ sơ bệnh án (Bảo Duy)
CREATE PROCEDURE PROC_XOAHOSOBENHAN
    @MaHoSo CHAR(10)
AS
BEGIN
    DELETE FROM HOSOBENHAN WHERE MaHoSo = @MaHoSo;
END;
GO

--// Procedure xuất danh sách hồ sơ bệnh án của bệnh nhân (Bảo Duy)
CREATE PROCEDURE PROC_LAYDANHSACHHOSOBENHAN
    @MaBenhNhan CHAR(10)
AS
BEGIN
    SELECT * FROM HOSOBENHAN WHERE MaBenhNhan = @MaBenhNhan;
END;
GO

--// Procedure đếm số hồ sơ của bệnh nhân (Bảo Duy)
CREATE PROCEDURE PROC_DEMHOSOBENHAN
    @MaBenhNhan CHAR(10),
    @SoHoSo INT OUTPUT
AS
BEGIN
    SELECT @SoHoSo = COUNT(*) FROM HOSOBENHAN WHERE MaBenhNhan = @MaBenhNhan;
END;
GO

--// Procedure xuất hồ sơ gần nhất (Bảo Duy)
CREATE PROCEDURE PROC_LAYHOSOGANNHAT
    @MaBenhNhan CHAR(10)
AS
BEGIN
    SELECT TOP 1 * FROM HOSOBENHAN 
    WHERE MaBenhNhan = @MaBenhNhan 
    ORDER BY NgayLapHoSo DESC;
END;
GO

--// Procedure xuất danh sách hồ sơ theo ngày (Bảo Duy)
CREATE PROCEDURE PROC_LAYDANHSACHHOSOTHEONGAY
    @NgayLapHoSo DATE
AS
BEGIN
    SELECT * FROM HOSOBENHAN WHERE NgayLapHoSo = @NgayLapHoSo;
END;
GO

--// Procedure thống kê số hồ sơ theo bác sĩ (Bảo Duy)
CREATE PROCEDURE PROC_THONGKEHOSOTHEOBACSI
AS
BEGIN
    SELECT MaBacSi, COUNT(*) AS SoHoSo
    FROM HOSOBENHAN
    GROUP BY MaBacSi;
END;
GO

--// Procedure thêm phiếu nhập thuốc mới
CREATE PROCEDURE PROC_THEMPHIENHAPTHUOC
    @MaPN CHAR(10),
    @MaNCC CHAR(10),
    @NgayNhap DATE,
    @ThanhTien FLOAT
AS
BEGIN
    -- Kiểm tra xem nhà cung cấp có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM NHACCTHUOC WHERE MaNCC = @MaNCC)
    BEGIN
        PRINT 'Nhà cung cấp không tồn tại.';
        RETURN;
    END

    -- Thêm phiếu nhập thuốc
    INSERT INTO PHIEU_NHAP_THUOC (MaPN, MaNCC, NgayNhap, ThanhTien)
    VALUES (@MaPN, @MaNCC, @NgayNhap, @ThanhTien);
END;
GO

--// Procedure thêm nhà cung cấp
CREATE PROCEDURE PROC_THEMNHACUNGCAP
    @MaNCC CHAR(10),
    @TenNCC NVARCHAR(50),
    @DiaChi NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem mã nhà cung cấp đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM NHACCTHUOC WHERE MaNCC = @MaNCC)
    BEGIN
        PRINT 'Mã nhà cung cấp đã tồn tại.';
        RETURN;
    END

    -- Thêm nhà cung cấp mới
    INSERT INTO NHACCTHUOC (MaNCC, TenNCC, DiaChi)
    VALUES (@MaNCC, @TenNCC, @DiaChi);
END;
GO

--// Procedure thêm chi tiết phiếu nhập thuốc
CREATE PROCEDURE PROC_THEMCHITIETPHIEUNHAPTHUOC
    @MaPN CHAR(10),
    @MaThuoc CHAR(10),
    @SoLuong INT,
    @Gia FLOAT
AS
BEGIN
    -- Kiểm tra xem phiếu nhập có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM PHIEU_NHAP_THUOC WHERE MaPN = @MaPN)
    BEGIN
        PRINT 'Phiếu nhập không tồn tại.';
        RETURN;
    END

    -- Kiểm tra xem thuốc có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM THUOC WHERE MaThuoc = @MaThuoc)
    BEGIN
        PRINT 'Thuốc không tồn tại.';
        RETURN;
    END

    -- Thêm chi tiết phiếu nhập thuốc
    INSERT INTO CHITIET_PN_THUOC (MaPN, MaThuoc, SoLuong, Gia)
    VALUES (@MaPN, @MaThuoc, @SoLuong, @Gia);
END;
GO

--// Procedure thêm thuốc mới
CREATE PROCEDURE PROC_THEMTHUOC
    @MaThuoc CHAR(10),
    @TenThuoc NVARCHAR(50),
    @ThanhPhan NVARCHAR(50),
    @Gia FLOAT
AS
BEGIN
    -- Kiểm tra xem mã thuốc đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM THUOC WHERE MaThuoc = @MaThuoc)
    BEGIN
        PRINT 'Mã thuốc đã tồn tại.';
        RETURN;
    END

    -- Thêm thuốc mới
    INSERT INTO THUOC 
    VALUES (@MaThuoc, @TenThuoc, @ThanhPhan, @Gia);
END;
GO

--// Procedure nhập viện bệnh nhân
CREATE PROCEDURE PROC_NHAPVIENBENHNHAN
    @MaBenhNhan INT,
    @NgayNhapVien DATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan AND TrangThai = 'Đang điều trị')
    BEGIN
        RAISERROR ('Bệnh nhân đang điều trị, không thể nhập viện hai lần.', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO NHAPVIEN (MaBenhNhan, NgayNhapVien) VALUES (@MaBenhNhan, @NgayNhapVien);
        UPDATE BENHNHAN SET TrangThai = 'Đang điều trị' WHERE MaBenhNhan = @MaBenhNhan;
    END
END;
GO

--// Procedure xuất viện bệnh nhân
CREATE PROCEDURE PROC_XUATVIENBENHNHAN
    @MaBenhNhan INT,
    @NgayRaVien DATE
AS
BEGIN
    DECLARE @NgayNhapVien DATE, @SoNgayNamVien INT;

    SELECT @NgayNhapVien = NgayNhapVien FROM NHAPVIEN WHERE MaBenhNhan = @MaBenhNhan;
    SET @SoNgayNamVien = DATEDIFF(DAY, @NgayNhapVien, @NgayRaVien);

    UPDATE BENHNHAN SET TrangThai = 'Đã xuất viện' WHERE MaBenhNhan = @MaBenhNhan;
    INSERT INTO RAVIEN (MaBenhNhan, NgayRaVien, SoNgayNamVien) VALUES (@MaBenhNhan, @NgayRaVien, @SoNgayNamVien);
END;
GO

--// Procedure tìm kiếm lịch sử nhập viện của bệnh nhân
CREATE PROCEDURE PROC_LICHSUNHAPVIEN
    @MaBenhNhan INT
AS
BEGIN
    SELECT NgayNhapVien, NgayRaVien, HOSOBENHAN.MaBacSi
    FROM NHAPVIEN, RAVIEN, HOSOBENHAN
    WHERE NHAPVIEN.MaBenhNhan = @MaBenhNhan
    ORDER BY NgayNhapVien;
END;
GO
--// Procedure thêm lịch trực cho bác sĩ
CREATE PROCEDURE PROC_THEMLICHTRUC
    @MaBacSi CHAR(10),
    @NgayTruc DATE,
    @MaCaTruc CHAR(10)
AS
BEGIN
    INSERT INTO LICHTRUC (MaLichTruc, MaBacSi, NgayTruc, MaCaTruc)
    VALUES (NEWID(), @MaBacSi, @NgayTruc, @MaCaTruc);
END;
GO

--// Procedure xóa lịch trực theo mã lịch
CREATE PROCEDURE PROC_XOALICHTRUC
    @MaLichTruc CHAR(10)
AS
BEGIN
    DELETE FROM LICHTRUC WHERE MaLichTruc = @MaLichTruc;
END;
GO

--// Procedure cập nhật ca trực
CREATE PROCEDURE PROC_CAPNHATLICHTRUC
    @MaLichTruc CHAR(10),
    @MaCaTruc CHAR(10)
AS
BEGIN
    UPDATE LICHTRUC SET MaCaTruc = @MaCaTruc WHERE MaLichTruc = @MaLichTruc;
END;
GO

--// Procedure thêm ca trực mới
CREATE PROCEDURE PROC_THEMCASTRUC
    @MaCaTruc CHAR(10),
    @ThoiGianCa NVARCHAR(50)
AS
BEGIN
    INSERT INTO CATRUC (MaCaTruc, ThoiGianCa) VALUES (@MaCaTruc, @ThoiGianCa);
END;
GO

--// Procedure lấy lịch trực của bác sĩ theo khoa
CREATE PROCEDURE PROC_LAYLICHTRUCBY_KHOA
    @MaKhoa CHAR(10)
AS
BEGIN
    SELECT LT.MaBacSi, BS.HoTen, LT.NgayTruc, CT.ThoiGianCa
    FROM LICHTRUC LT
    JOIN BACSI BS ON LT.MaBacSi = BS.MaBacSi
    JOIN CATRUC CT ON LT.MaCaTruc = CT.MaCaTruc
    WHERE BS.MaKhoa = @MaKhoa;
END;
GO
------------------------------------------------------------------------------------------------------------
-------------------------------------       FUNCTION      -------------------------------------------------
------------------------------------------------------------------------------------------------------------

--// Hàm kiểm tra lịch sử khám bệnh của bệnh nhân (Trí)
CREATE FUNCTION FUNC_LICH_SU_KHAM_BENH(
    @MaBenhNhan CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT PK.MaPhieuKham, PK.NgayKham, PK.ChanDoan, PK.KetQua, BS.HoTen AS TenBacSi,MaChiDinh,LoaiChiDinh,NgayChiDinh, MaKhoa
    FROM PHIEUKHAM PK
    JOIN BACSI BS ON PK.MaBacSi = BS.MaBacSi join CHIDINHXETNGHIEM CD on PK.MaPhieuKham=CD.MaPhieuKham
    WHERE PK.MaBenhNhan = @MaBenhNhan
);
GO
--// Hàm kiểm tra Thông tin của bệnh nhân (Trí)
CREATE FUNCTION FUNC_THONG_TIN_BENH_NHAN(
    @MaBenhNhan CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT BN.MaBenhNhan, BN.HoTen AS TenBenhNhan, BN.GioiTinh, BN.NgaySinh, BN.DiaChi, BN.SoDienThoai, MaBHYT, Tuoi
    FROM BENHNHAN BN
    WHERE BN.MaBenhNhan = @MaBenhNhan
);
GO

--// Hàm tính tổng số ngày sử dụng thuốc của bệnh nhân (Trí)
CREATE FUNCTION FUNC_TONG_SO_NGAY_DUNG_THUOC(
    @MaBenhNhan CHAR(10)
)
RETURNS INT
AS
BEGIN
    DECLARE @TongSoNgay INT;
    SELECT @TongSoNgay = SUM(TT.SONGAYDUNG)
    FROM PHIEUKHAM PK
    JOIN TOATHUOC TT ON PK.MATOA = TT.MATOA
    WHERE PK.MaBenhNhan = @MaBenhNhan;
    RETURN ISNULL(@TongSoNgay, 0);
END;
GO
--// Hàm xem chi tiết toa thuốc dựa trên mã toa (Trí)
CREATE FUNCTION FN_ChiTietToaThuoc(
    @MaToa CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
	    CT.MaToa,
        CT.MATHUOC, 
        TH.TENTHUOC, 
        CT.SOLUONG, 		
		THANHPHAN,
        CT.CACHDUNG
    FROM CHITIETTOA CT
    JOIN THUOC TH ON CT.MATHUOC = TH.MATHUOC
    WHERE CT.MATOA = @MaToa
);

--// Hàm lấy danh sách thuốc trong toa thuốc (Trí)
CREATE FUNCTION FUNC_CHI_TIET_TOA_THUOC(
    @MaToa CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT CT.MATHUOC, TH.TENTHUOC, CT.SOLUONG, CT.CACHDUNG
    FROM CHITIETTOA CT
    JOIN THUOC TH ON CT.MATHUOC = TH.MATHUOC
    WHERE CT.MATOA = @MaToa
);
GO
--// Hàm tính tuổi khi có ngày sinh ( Trí)
CREATE FUNCTION TINH_TUOI
(
    @NgaySinh DATE -- Tham số ngày sinh
)
RETURNS INT
AS
BEGIN
    DECLARE @Tuoi INT;

    -- Tính tuổi chính xác
    SET @Tuoi = DATEDIFF(YEAR, @NgaySinh, GETDATE()) -
                CASE 
                    WHEN MONTH(@NgaySinh) > MONTH(GETDATE()) 
                         OR (MONTH(@NgaySinh) = MONTH(GETDATE()) AND DAY(@NgaySinh) > DAY(GETDATE()))
                    THEN 1 
                    ELSE 0 
                END;

    RETURN @Tuoi; 
END;
GO

--// Hàm tính tổng số thuốc đã kê trong toa thuốc của bệnh nhân (Trí)
CREATE FUNCTION FUNC_TONG_SO_THUOC_TRONG_TOA(
    @MaToa CHAR(10)
)
RETURNS INT
AS
BEGIN
    DECLARE @TongSoLuong INT;
    SELECT @TongSoLuong = SUM(CT.SOLUONG)
    FROM CHITIETTOA CT
    WHERE CT.MATOA = @MaToa;
    RETURN ISNULL(@TongSoLuong, 0);
END;
GO

--// Hàm lấy danh sách bệnh nhân do một bác sĩ điều trị (Trí)
CREATE FUNCTION FUNC_DANH_SACH_BENH_NHAN_DIEU_TRI(
    @MaBacSi CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT BN.MaBenhNhan, BN.HoTen, BN.NgaySinh, BN.GioiTinh, BN.DiaChi,SoDienThoai,MaBHYT, Tuoi,Tukhoa,Denkhoa,TrangThai
    FROM BENHNHAN BN
    JOIN PHIEUKHAM PK ON BN.MaBenhNhan = PK.MaBenhNhan
    WHERE PK.MaBacSi = @MaBacSi
);
GO

--// Hàm lấy danh sách bệnh nhân theo mã bệnh nhân (Trí)
CREATE FUNCTION FUNC_DANH_SACH_BENH_NHAN(
    @MaBenhNhan CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT BN.MaBenhNhan, BN.HoTen, BN.NgaySinh, BN.GioiTinh, BN.DiaChi,SoDienThoai,MaBHYT, Tuoi,Tukhoa,Denkhoa,TrangThai
    FROM BENHNHAN BN
    WHERE BN.MaBenhNhan = @MaBenhNhan
);
GO
--//Hàm lấy danh sách phiếu khám theo mã (Trí)
CREATE FUNCTION FN_danhsachphieukham(
    @MaPhieuKham CHAR(15)
)
RETURNS TABLE
AS
RETURN
(
    SELECT*
    FROM PHIEUKHAM PK
    WHERE PK.MaPhieuKham = @MaPhieuKham
);
--//Hàm lấy danh sách phiếu khám theo ngày khám (Trí)
CREATE FUNCTION FN_danhsachphieukhamtheongay(
    @NgayKham DATE
)
RETURNS TABLE
AS
RETURN
(
    SELECT*
    FROM PHIEUKHAM PK
    WHERE PK.NgayKham = @NgayKham
);


--// Hàm kiểm tra tình trạng sức khỏe của bệnh nhân (Trí)
CREATE FUNCTION FUNC_TINH_TRANG_SUC_KHOE(
   @MaPhieuKham CHAR(10)
)
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @KetQua NVARCHAR(255);
    
    SELECT @KetQua = PK.KetQua
    FROM PHIEUKHAM PK
    WHERE PK.MaPhieuKham = @MaPhieuKham
    ORDER BY PK.NgayKham DESC
    OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY; -- Lấy kết quả khám gần nhất
    
    RETURN ISNULL(@KetQua, N'Chưa có kết quả khám');
	END;
--// Hàm lấy thông tin toa thuốc theo mã bệnh nhân (Trí)
CREATE FUNCTION FUNC_TOA_THUOC_THEO_BENH_NHAN(
    @MaBenhNhan CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT TT.MATOA, TT.NGAYKETOA, TT.SONGAYDUNG, BS.HoTen AS BacSiKeToa,NGAYKETTHUC,SOLOAITHUOC
    FROM TOATHUOC TT
    JOIN PHIEUKHAM PK ON TT.MATOA = PK.MATOA
    JOIN BACSI BS ON TT.MaBsKetoa = BS.MaBacSi
    WHERE PK.MaBenhNhan = @MaBenhNhan
);
GO
--// Hàm lấy thông tin toa thuốc theo mã Toa thuốc (Trí)
CREATE FUNCTION FUNC_TOA_THUOC_THEO_TOA_THUOC(
    @MATOA CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT TT.MATOA, TT.NGAYKETOA, TT.SONGAYDUNG, MaBsKetoa,NGAYKETTHUC,SOLOAITHUOC
    FROM TOATHUOC TT
    WHERE TT.MATOA = @MATOA
);
GO

--// Hàm kiểm tra xem bệnh nhân đã được nhập viện lần nào chưa (Trí)
CREATE FUNCTION FUNC_KIEM_TRA_NHAP_VIEN(
    @MaBenhNhan CHAR(10)
)
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @KetQua NVARCHAR(255);
    
    SELECT @KetQua = CASE 
                         WHEN COUNT(*) > 0 THEN N'Đã nhập viện' 
                         ELSE N'Chưa nhập viện' 
                      END
    FROM NHAPVIEN NV
    WHERE NV.MaBenhNhan = @MaBenhNhan;
    
    RETURN @KetQua;
END;
GO

--// Hàm xuất hồ sơ theo mã hồ sơ (Bảo Duy)
CREATE FUNCTION FUNC_LAY_HO_SO_THEO_MA_HO_SO(@MaHoSo CHAR(10))
RETURNS TABLE
AS
RETURN (
    SELECT * FROM HOSOBENHAN 
    WHERE MaHoSo = @MaHoSo
);
GO


--// Hàm xuất nội dung hồ sơ (Bảo Duy)
CREATE FUNCTION FUNC_LAY_NOI_DUNG_HO_SO(@MaHoSo CHAR(10))
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @NoiDung NVARCHAR(255);
    SELECT @NoiDung = NoiDungHoSo FROM HOSOBENHAN WHERE MaHoSo = @MaHoSo;
    RETURN @NoiDung;
END;
GO

--// Hàm tính tổng số hồ sơ (Bảo Duy)
CREATE FUNCTION FUNC_LAY_TONG_HO_SO()
RETURNS INT
AS
BEGIN
    DECLARE @TongHoSo INT;
    SELECT @TongHoSo = COUNT(*) FROM HOSOBENHAN;
    RETURN @TongHoSo;
END;
GO

--// Hàm xuất hồ sơ trong khoảng thời gian (Bảo Duy)
CREATE FUNCTION FUNC_LAY_HO_SO_BENH_AN_THEO_KHOANG_THOI_GIAN(@TuNgay DATE, @DenNgay DATE)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM HOSOBENHAN 
    WHERE NgayLapHoSo BETWEEN @TuNgay AND @DenNgay
);
GO

--// Hàm xuất danh sách hồ sơ có cùng bác sĩ (Bảo Duy)
CREATE FUNCTION FUNC_KIEM_TRA_HO_SO_CUNG_BAC_SI(@MaBacSi CHAR(10))
RETURNS TABLE
AS
RETURN (
    SELECT * FROM HOSOBENHAN 
    WHERE MaBacSi = @MaBacSi
);
GO

--// Hàm thống kê phiếu nhập theo tháng
CREATE FUNCTION FUNC_THONG_KE_PHIU_NHAP_THEO_THANG
(
    @Thang INT,
    @Nam INT
)
RETURNS @KetQua TABLE
(
    MAPN CHAR(10),
    MANCC CHAR(10),
    NGAYNHAP DATE,
    THANHTIEN FLOAT
)
AS
BEGIN
    INSERT INTO @KetQua
    SELECT MAPN, MANCC, NGAYNHAP, THANHTIEN
    FROM PHIEU_NHAP_THUOC
    WHERE MONTH(NGAYNHAP) = @Thang AND YEAR(NGAYNHAP) = @Nam;

    RETURN;
END;
GO

--// Hàm xem chi tiết phiếu nhập theo mã phiếu nhập
CREATE FUNCTION FUNC_XEM_CHI_TIET_PHIEU_NHAP
(
    @MAPN CHAR(10)
)
RETURNS @KetQua TABLE
(
    MATHUOC CHAR(10),
    SL INT,
    GIA FLOAT
)
AS
BEGIN
    INSERT INTO @KetQua
    SELECT MaThuoc, SoLuong, Gia
    FROM CHITIET_PN_THUOC
    WHERE MAPN = @MAPN;

    RETURN;
END;
GO

--// Hàm kiểm tra thông tin thuốc theo mã thuốc
CREATE FUNCTION FUNC_KIEM_TRA_THONG_TIN_THUOC
(
    @MATHUOC CHAR(10)
)
RETURNS @KetQua TABLE
(
    TENTHUOC NVARCHAR(50),
    THANHPHAN NVARCHAR(50),
    GIA FLOAT
)
AS
BEGIN
    INSERT INTO @KetQua
    SELECT TENTHUOC, THANHPHAN, GIA
    FROM THUOC
    WHERE MATHUOC = @MATHUOC;

    RETURN;
END;
GO

--// Hàm tính số ngày nằm viện của bệnh nhân
CREATE FUNCTION FUNC_SO_NGAY_NAM_VIEN
(
    @NgayNhapVien DATE,
    @NgayRaVien DATE
)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(DAY, @NgayNhapVien, @NgayRaVien);
END;
GO

--// Hàm tính tổng số bệnh nhân hiện đang nằm viện
CREATE FUNCTION FUNC_TONG_BENH_NHAN_DANG_NAM_VIEN()
RETURNS INT
AS
BEGIN
    RETURN (SELECT COUNT(*) FROM BENHNHAN WHERE TrangThai = 'Đang điều trị');
END;
GO

--// Hàm lấy ngày nhập viện của bệnh nhân
CREATE FUNCTION FUNC_HAM_LAY_NGAY_NHAP_VIEN
(
    @MaBenhNhan INT
)
RETURNS DATE
AS
BEGIN
    DECLARE @NgayNhapVien DATE;

    SELECT @NgayNhapVien = NgayNhapVien
    FROM NHAPVIEN
    WHERE MaBenhNhan = @MaBenhNhan;

    RETURN @NgayNhapVien;
END;
GO

--// Hàm kiểm tra tình trạng bảo hiểm
CREATE FUNCTION FUNC_HAM_KIEM_TRA_BAO_HIEM
(
    @MaBenhNhan INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @KetQua BIT;

    IF EXISTS (
        SELECT 1
        FROM BENHNHAN
        WHERE MaBenhNhan = @MaBenhNhan AND MaBHYT IS NOT NULL
    )
    BEGIN
        SET @KetQua = 1; -- Có bảo hiểm
    END
    ELSE
    BEGIN
        SET @KetQua = 0; -- Không có bảo hiểm
    END

    RETURN @KetQua;
END;
GO

--// Hàm kiểm tra bác sĩ có lịch trực trong ngày
CREATE FUNCTION FUNC_IS_DOCTOR_ON_SHIFT
    (@MaBacSi CHAR(10), @Ngay DATE)
RETURNS BIT
AS
BEGIN
    DECLARE @IsOnShift BIT;
    SELECT @IsOnShift = CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END
    FROM LICHTRUC WHERE MaBacSi = @MaBacSi AND NgayTruc = @Ngay;
    RETURN @IsOnShift;
END;
GO

--// Hàm lấy thời gian ca trực của bác sĩ
CREATE FUNCTION FUNC_GET_SHIFT_TIME
    (@MaCaTruc CHAR(10))
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @ThoiGianCa NVARCHAR(50);
    SELECT @ThoiGianCa = ThoiGianCa FROM CATRUC WHERE MaCaTruc = @MaCaTruc;
    RETURN @ThoiGianCa;
END;
GO

--// Hàm tính tổng số ca trực của bác sĩ trong tuần
CREATE FUNCTION FUNC_COUNT_DOCTOR_SHIFTS_IN_WEEK
    (@MaBacSi CHAR(10), @WeekStart DATE, @WeekEnd DATE)
RETURNS INT
AS
BEGIN
    DECLARE @ShiftCount INT;
    SELECT @ShiftCount = COUNT(*) 
    FROM LICHTRUC 
    WHERE MaBacSi = @MaBacSi AND NgayTruc BETWEEN @WeekStart AND @WeekEnd;
    RETURN @ShiftCount;
END;
GO

--// Hàm lấy lịch trực bác sĩ theo ngày
CREATE FUNCTION FUNC_GET_DOCTOR_SHIFT_BY_DATE
    (@MaBacSi CHAR(10), @Ngay DATE)
RETURNS TABLE
AS
RETURN
(
    SELECT MaLichTruc, NgayTruc, MaCaTruc
    FROM LICHTRUC
    WHERE MaBacSi = @MaBacSi AND NgayTruc = @Ngay
);
GO

--// Hàm lấy danh sách bác sĩ theo ca trực
CREATE FUNCTION FUNC_GET_DOCTORS_BY_SHIFT
    (@MaCaTruc CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT BS.MaBacSi, BS.HoTen
    FROM BACSI BS
    JOIN LICHTRUC LT ON BS.MaBacSi = LT.MaBacSi
    WHERE LT.MaCaTruc = @MaCaTruc
);
GO
------------------------------------------------------------------------------------------------------------
-------------------------------------       CURSOR      -------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
-- Xuất hồ sơ và thông tin bác sĩ (Bảo Duy)
DECLARE CURS_HO_SO_BAC_SI CURSOR FOR
SELECT h.*, b.HoTen AS TenBacSi
FROM HOSOBENHAN h
JOIN BACSI b ON h.MaBacSi = b.MaBacSi;

OPEN CURS_HO_SO_BAC_SI;
FETCH NEXT FROM CURS_HO_SO_BAC_SI;
-- Xử lý dữ liệu tại đây
CLOSE CURS_HO_SO_BAC_SI;
DEALLOCATE CURS_HO_SO_BAC_SI;

-- Xuất hồ sơ và thông tin bệnh nhân (Bảo Duy)
DECLARE CURS_HO_SO_BENH_NHAN CURSOR FOR
SELECT h.*, b.HoTen AS TenBenhNhan
FROM HOSOBENHAN h
JOIN BENHNHAN b ON h.MaBenhNhan = b.MaBenhNhan;

OPEN CURS_HO_SO_BENH_NHAN;
FETCH NEXT FROM CURS_HO_SO_BENH_NHAN;
-- Xử lý dữ liệu tại đây
CLOSE CURS_HO_SO_BENH_NHAN;
DEALLOCATE CURS_HO_SO_BENH_NHAN;

---------------------------------------------------------------------------------------------------------------
-- Cursor duyệt danh sách bệnh nhân theo bác sĩ
DECLARE @MaBacSi1 INT,
        @MaBenhNhan1 INT,
        @HoTen1 NVARCHAR(100),
        @NgayNhapVien1 DATE,
        @ChanDoan1 NVARCHAR(200);

-- Khởi tạo mã bác sĩ
SET @MaBacSi1 = 1; -- Thay thế với mã bác sĩ cần duyệt

DECLARE CURS_BENH_NHAN_THEO_BAC_SI CURSOR FOR
SELECT b.MaBenhNhan, b.HoTen, n.NgayNhapVien, pk.ChanDoan
FROM BENHNHAN b
JOIN NHAPVIEN n ON b.MaBenhNhan = n.MaBenhNhan
JOIN PHIEUKHAM pk ON n.MaBenhNhan = pk.MaBenhNhan
WHERE n.MaBacSi = @MaBacSi1;

OPEN CURS_BENH_NHAN_THEO_BAC_SI;

FETCH NEXT FROM CURS_BENH_NHAN_THEO_BAC_SI INTO @MaBenhNhan1, @HoTen1, @NgayNhapVien1, @ChanDoan1;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Mã Bệnh Nhân: ' + CAST(@MaBenhNhan1 AS NVARCHAR(10));
    PRINT 'Họ Tên: ' + @HoTen1;
    PRINT 'Ngày Nhập Viện: ' + CAST(@NgayNhapVien AS NVARCHAR(10));
    PRINT 'Chẩn Đoán: ' + @ChanDoan1;

    FETCH NEXT FROM CURS_BENH_NHAN_THEO_BAC_SI INTO @MaBenhNhan1, @HoTen1, @NgayNhapVien, @ChanDoan1;
END

CLOSE CURS_BENH_NHAN_THEO_BAC_SI;
DEALLOCATE CURS_BENH_NHAN_THEO_BAC_SI;

-- Cursor duyệt lịch sử nhập viện của bệnh nhân
DECLARE @MaBenhNhan2 INT,
        @NgayNhapVien2 DATE,
        @NgayRaVien2 DATE,
        @MaBacSi2 INT;

SET @MaBenhNhan2 = 1; -- Thay thế với mã bệnh nhân cần duyệt

DECLARE CURS_LICH_SU_NHAP_VIEN CURSOR FOR
SELECT n.NgayNhapVien, r.NgayRaVien, n.MaBacSi
FROM NHAPVIEN n
LEFT JOIN RAVIEN r ON n.MaBenhNhan = r.MaBenhNhan
WHERE n.MaBenhNhan = @MaBenhNhan2;

OPEN CURS_LICH_SU_NHAP_VIEN;

FETCH NEXT FROM CURS_LICH_SU_NHAP_VIEN INTO @NgayNhapVien2, @NgayRaVien2, @MaBacSi2;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Ngày Nhập Viện: ' + CAST(@NgayNhapVien2 AS NVARCHAR(10));
    PRINT 'Ngày Ra Viện: ' + ISNULL(CAST(@NgayRaVien2 AS NVARCHAR(10)), 'Chưa ra viện');
    PRINT 'Mã Bác Sĩ: ' + CAST(@MaBacSi2 AS NVARCHAR(10));

    FETCH NEXT FROM CURS_LICH_SU_NHAP_VIEN INTO @NgayNhapVien2, @NgayRaVien2, @MaBacSi2;
END

CLOSE CURS_LICH_SU_NHAP_VIEN;
DEALLOCATE CURS_LICH_SU_NHAP_VIEN;

-- Cursor Duyệt Danh Sách Bệnh Nhân Đang Điều Trị
DECLARE @MaBenhNhan3 INT,
        @HoTen3 NVARCHAR(100),
        @TrangThai3 NVARCHAR(50);

DECLARE CURS_BENH_NHAN_DANG_DIEU_TRI CURSOR FOR
SELECT MaBenhNhan, HoTen, TrangThai
FROM BENHNHAN
WHERE TrangThai = 'Đang điều trị';

OPEN CURS_BENH_NHAN_DANG_DIEU_TRI;

FETCH NEXT FROM CURS_BENH_NHAN_DANG_DIEU_TRI INTO @MaBenhNhan3, @HoTen3, @TrangThai3;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Mã Bệnh Nhân: ' + CAST(@MaBenhNhan3 AS NVARCHAR(10));
    PRINT 'Họ Tên: ' + @HoTen3;
    PRINT 'Trạng Thái: ' + @TrangThai3;

    FETCH NEXT FROM CURS_BENH_NHAN_DANG_DIEU_TRI INTO @MaBenhNhan3, @HoTen3, @TrangThai3;
END

CLOSE CURS_BENH_NHAN_DANG_DIEU_TRI;
DEALLOCATE CURS_BENH_NHAN_DANG_DIEU_TRI;

--// Con trỏ để truy xuất danh sách tất cả các bác sĩ
DECLARE @MaBacSi4 CHAR(10), 
		@HoTenBacSi4 NVARCHAR(100), 
		@SoCaTruc4 INT;
DECLARE CURS_DANH_SACH_BAC_SI CURSOR FOR 
SELECT MaBacSi, HoTen, SoCaTruc FROM BACSI;

OPEN CURS_DANH_SACH_BAC_SI;
FETCH NEXT FROM CURS_DANH_SACH_BAC_SI INTO @MaBacSi4, @HoTenBacSi4, @SoCaTruc4;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Bác sĩ: ' + @HoTenBacSi4 + ', Mã bác sĩ: ' + @MaBacSi4 + ', Số ca trực tuần: ' + CAST(@SoCaTruc4 AS NVARCHAR);
    FETCH NEXT FROM CURS_DANH_SACH_BAC_SI INTO @MaBacSi4, @HoTenBacSi4, @SoCaTruc4;
END

CLOSE CURS_DANH_SACH_BAC_SI;
DEALLOCATE CURS_DANH_SACH_BAC_SI;

------------------------------------------------------------------------------------------------------------

--// Con trỏ để kiểm tra lịch trực trùng lặp cho các bác sĩ
DECLARE @NgayTruc5 DATE,
		@MaBacSi5 CHAR(10)
DECLARE CURS_CHECK_LICH_TRUC CURSOR FOR
SELECT MaBacSi, NgayTruc FROM LICHTRUC;

OPEN CURS_CHECK_LICH_TRUC;

FETCH NEXT FROM CURS_CHECK_LICH_TRUC INTO @MaBacSi5, @NgayTruc5;
WHILE @@FETCH_STATUS = 0
BEGIN
    DECLARE @DuplicateCount INT;
    SET @DuplicateCount = (SELECT COUNT(*)
                           FROM LICHTRUC
                           WHERE MaBacSi = @MaBacSi5 AND NgayTruc = @NgayTruc5);

    IF @DuplicateCount > 1
    BEGIN
        PRINT 'Lịch trực bị trùng cho bác sĩ: ' + @MaBacSi5 + ' vào ngày: ' + CONVERT(VARCHAR, @NgayTruc5);
    END

    FETCH NEXT FROM CURS_CHECK_LICH_TRUC INTO @MaBacSi5, @NgayTruc5;
END;

CLOSE CURS_CHECK_LICH_TRUC;
DEALLOCATE CURS_CHECK_LICH_TRUC;

------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------

--// Con trỏ để phân chia ca trực cho bác sĩ
DECLARE @NgayTruc6 DATE, 
		@CaTruc6 NVARCHAR(50),
		@MaBacSi6 CHAR(10)
DECLARE CURS_CHIA_CA_TRUC CURSOR FOR
SELECT MaBacSi, NgayTruc, MaCaTruc FROM LICHTRUC;

OPEN CURS_CHIA_CA_TRUC;

FETCH NEXT FROM CURS_CHIA_CA_TRUC INTO @MaBacSi6, @NgayTruc6, @CaTruc6;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Bác sĩ: ' + @MaBacSi6 + ', Ngày trực: ' + CONVERT(VARCHAR, @NgayTruc6) + ', Ca trực: ' + @CaTruc6;
    FETCH NEXT FROM CURS_CHIA_CA_TRUC INTO @MaBacSi6, @NgayTruc6, @CaTruc6;
END;

CLOSE CURS_CHIA_CA_TRUC;
DEALLOCATE CURS_CHIA_CA_TRUC;

------------------------------------------------------------------------------------------------------------

--// Con trỏ để lấy thông tin ca trực theo bác sĩ
DECLARE @MaBacSi7 CHAR(10), 
        @HoTenBacSi7 NVARCHAR(100),
        @NgayTruc7 DATE,
        @MaCaTruc7 NVARCHAR(50);
DECLARE CURS_THONG_TIN_CA_TRUC CURSOR FOR
SELECT b.MaBacSi, b.HoTen, l.NgayTruc, l.MaCaTruc
FROM BACSI b
JOIN LICHTRUC l ON b.MaBacSi = l.MaBacSi;

OPEN CURS_THONG_TIN_CA_TRUC;

FETCH NEXT FROM CURS_THONG_TIN_CA_TRUC INTO @MaBacSi7, @HoTenBacSi7, @NgayTruc7, @MaCaTruc7;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Bác sĩ: ' + @HoTenBacSi7 + ', Mã bác sĩ: ' + @MaBacSi7 + ', Ngày trực: ' + CONVERT(VARCHAR, @NgayTruc7) + ', Ca trực: ' + @MaCaTruc7;
    FETCH NEXT FROM CURS_THONG_TIN_CA_TRUC INTO @MaBacSi7, @HoTenBacSi7, @NgayTruc7, @MaCaTruc7;
END;

CLOSE CURS_THONG_TIN_CA_TRUC;
DEALLOCATE CURS_THONG_TIN_CA_TRUC;

------------------------------------------------------------------------------------------------------------