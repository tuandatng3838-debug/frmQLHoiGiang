-- QLHoiGiang database schema + sample data
IF DB_ID('QLHoiGiang') IS NULL
BEGIN
    CREATE DATABASE QLHoiGiang;
END
GO
USE QLHoiGiang;
GO

IF OBJECT_ID('dbo.ThanhVienHoiDong', 'U') IS NOT NULL DROP TABLE dbo.ThanhVienHoiDong;
IF OBJECT_ID('dbo.HoiDong', 'U') IS NOT NULL DROP TABLE dbo.HoiDong;
IF OBJECT_ID('dbo.KetQuaThanhPhan', 'U') IS NOT NULL DROP TABLE dbo.KetQuaThanhPhan;
IF OBJECT_ID('dbo.KetQuaHoiGiang', 'U') IS NOT NULL DROP TABLE dbo.KetQuaHoiGiang;
IF OBJECT_ID('dbo.BaiHoiGiang', 'U') IS NOT NULL DROP TABLE dbo.BaiHoiGiang;
IF OBJECT_ID('dbo.LichGiang', 'U') IS NOT NULL DROP TABLE dbo.LichGiang;
IF OBJECT_ID('dbo.SangKien', 'U') IS NOT NULL DROP TABLE dbo.SangKien;
IF OBJECT_ID('dbo.GiangVien', 'U') IS NOT NULL DROP TABLE dbo.GiangVien;
IF OBJECT_ID('dbo.HocPhan', 'U') IS NOT NULL DROP TABLE dbo.HocPhan;
IF OBJECT_ID('dbo.DonVi', 'U') IS NOT NULL DROP TABLE dbo.DonVi;
IF OBJECT_ID('dbo.Khoa', 'U') IS NOT NULL DROP TABLE dbo.Khoa;
IF OBJECT_ID('dbo.HocHam', 'U') IS NOT NULL DROP TABLE dbo.HocHam;
IF OBJECT_ID('dbo.HocVi', 'U') IS NOT NULL DROP TABLE dbo.HocVi;
IF OBJECT_ID('dbo.TrinhDoChuyenMon', 'U') IS NOT NULL DROP TABLE dbo.TrinhDoChuyenMon;
IF OBJECT_ID('dbo.TrinhDoLLCT', 'U') IS NOT NULL DROP TABLE dbo.TrinhDoLLCT;
IF OBJECT_ID('dbo.ChucDanhGiangDay', 'U') IS NOT NULL DROP TABLE dbo.ChucDanhGiangDay;
IF OBJECT_ID('dbo.CapBac', 'U') IS NOT NULL DROP TABLE dbo.CapBac;
IF OBJECT_ID('dbo.NguoiDung', 'U') IS NOT NULL DROP TABLE dbo.NguoiDung;
GO

CREATE TABLE Khoa (
    KhoaId INT IDENTITY PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE DonVi (
    DonViId INT IDENTITY PRIMARY KEY,
    TenDonVi NVARCHAR(100) NOT NULL,
    KhoaId INT NOT NULL REFERENCES Khoa(KhoaId),
    UNIQUE (TenDonVi, KhoaId)
);

CREATE TABLE HocHam (
    HocHamId INT IDENTITY PRIMARY KEY,
    TenHocHam NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE HocVi (
    HocViId INT IDENTITY PRIMARY KEY,
    TenHocVi NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE TrinhDoChuyenMon (
    TrinhDoCMId INT IDENTITY PRIMARY KEY,
    TenTrinhDo NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE TrinhDoLLCT (
    TrinhDoLLCTId INT IDENTITY PRIMARY KEY,
    TenTrinhDo NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE ChucDanhGiangDay (
    ChucDanhId INT IDENTITY PRIMARY KEY,
    TenChucDanh NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE CapBac (
    CapBacId INT IDENTITY PRIMARY KEY,
    TenCapBac NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE GiangVien (
    GiangVienId INT IDENTITY PRIMARY KEY,
    MaSo NVARCHAR(20) NOT NULL UNIQUE,
    HoTen NVARCHAR(150) NOT NULL,
    GioiTinh BIT NOT NULL,
    NgaySinh DATE NOT NULL,
    QueQuan NVARCHAR(200),
    DanToc NVARCHAR(50),
    TonGiao NVARCHAR(50),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(120),
    TrinhDoCMId INT REFERENCES TrinhDoChuyenMon(TrinhDoCMId),
    TrinhDoLLCTId INT REFERENCES TrinhDoLLCT(TrinhDoLLCTId),
    DonViId INT REFERENCES DonVi(DonViId),
    ChucVu NVARCHAR(100),
    CapBacId INT REFERENCES CapBac(CapBacId),
    HeSoLuong DECIMAL(4,2),
    ChucDanhId INT REFERENCES ChucDanhGiangDay(ChucDanhId),
    HocHamId INT REFERENCES HocHam(HocHamId),
    HocViId INT REFERENCES HocVi(HocViId),
    LinhVucChuyenMon NVARCHAR(200),
    NamGanNhatDayGioi INT
);

CREATE TABLE HocPhan (
    HocPhanId INT IDENTITY PRIMARY KEY,
    TenHocPhan NVARCHAR(150) NOT NULL,
    SoTinChi INT NOT NULL DEFAULT 3
);

CREATE TABLE BaiHoiGiang (
    BaiHoiGiangId INT IDENTITY PRIMARY KEY,
    GiangVienId INT NOT NULL REFERENCES GiangVien(GiangVienId),
    CapBacId INT REFERENCES CapBac(CapBacId),
    DonViId INT REFERENCES DonVi(DonViId),
    ChucDanhId INT REFERENCES ChucDanhGiangDay(ChucDanhId),
    TenBai NVARCHAR(200) NOT NULL,
    HocPhanId INT REFERENCES HocPhan(HocPhanId),
    LopThucHien NVARCHAR(100),
    ThoiGian DATETIME NOT NULL,
    CapThucHien NVARCHAR(20) NOT NULL CHECK (CapThucHien IN (N'Hoc vien', N'Cap Bo')),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chua cham'
);

CREATE TABLE HoiDong (
    HoiDongId INT IDENTITY PRIMARY KEY,
    BaiHoiGiangId INT NOT NULL UNIQUE REFERENCES BaiHoiGiang(BaiHoiGiangId),
    TenHoiDong NVARCHAR(200) NOT NULL,
    NgayLap DATE NOT NULL DEFAULT GETDATE()
);

CREATE TABLE ThanhVienHoiDong (
    ThanhVienHoiDongId INT IDENTITY PRIMARY KEY,
    HoiDongId INT NOT NULL REFERENCES HoiDong(HoiDongId),
    GiangVienId INT NOT NULL REFERENCES GiangVien(GiangVienId),
    CapBacId INT REFERENCES CapBac(CapBacId),
    ChucDanhGiangDayId INT REFERENCES ChucDanhGiangDay(ChucDanhId),
    VaiTro NVARCHAR(50) NOT NULL CHECK (VaiTro IN (N'Chu tich Hoi dong', N'Thanh vien', N'Thu ky')),
    UNIQUE (HoiDongId, GiangVienId)
);

CREATE TABLE KetQuaHoiGiang (
    KetQuaHoiGiangId INT IDENTITY PRIMARY KEY,
    BaiHoiGiangId INT NOT NULL UNIQUE REFERENCES BaiHoiGiang(BaiHoiGiangId),
    TongDiem DECIMAL(5,2) NOT NULL,
    XepLoai NVARCHAR(20) NOT NULL
);

CREATE TABLE KetQuaThanhPhan (
    KetQuaThanhPhanId INT IDENTITY PRIMARY KEY,
    KetQuaHoiGiangId INT NOT NULL REFERENCES KetQuaHoiGiang(KetQuaHoiGiangId),
    TenPhanThi NVARCHAR(100) NOT NULL,
    Diem DECIMAL(4,2) NOT NULL
);

CREATE TABLE SangKien (
    SangKienId INT IDENTITY PRIMARY KEY,
    TenSangKien NVARCHAR(200) NOT NULL,
    GiangVienId INT NOT NULL REFERENCES GiangVien(GiangVienId),
    TuCach NVARCHAR(20) NOT NULL CHECK (TuCach IN (N'Tac gia', N'Dong tac gia')),
    Loai NVARCHAR(20) NOT NULL CHECK (Loai IN (N'Sang kien', N'Cai tien')),
    LinhVuc NVARCHAR(100),
    NamHoc NVARCHAR(20) NOT NULL,
    ThoiGianThucHien NVARCHAR(100),
    DiaDiemPhamVi NVARCHAR(200),
    XepLoai NVARCHAR(20) CHECK (XepLoai IN (N'Kha', N'Tot', N'Xuat sac'))
);

CREATE TABLE LichGiang (
    LichGiangId INT IDENTITY PRIMARY KEY,
    NamHoc NVARCHAR(20) NOT NULL,
    TenLop NVARCHAR(100) NOT NULL,
    TenMon NVARCHAR(100) NOT NULL,
    GiangVienId INT NOT NULL REFERENCES GiangVien(GiangVienId),
    Buoi NVARCHAR(20) NOT NULL CHECK (Buoi IN (N'Sang', N'Chieu', N'Toi')),
    NgayHoc DATE NOT NULL,
    PhongHoc NVARCHAR(50),
    SoTiet INT NOT NULL,
    SoSinhVien INT,
    UNIQUE (GiangVienId, NgayHoc, Buoi)
);

CREATE TABLE NguoiDung (
    NguoiDungId INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(200) NOT NULL,
    HoTen NVARCHAR(150),
    Role NVARCHAR(20) NOT NULL DEFAULT 'Admin'
);
GO

-- Lookup data
INSERT INTO Khoa (TenKhoa) VALUES
(N'Khoa Ly luan Chinh tri'),
(N'Khoa Quan tri Giao duc'),
(N'Khoa Cong nghe va Ngoai ngu');

INSERT INTO DonVi (TenDonVi, KhoaId)
SELECT v.TenDonVi, k.KhoaId
FROM (VALUES
    (N'Bo mon Triet hoc', N'Khoa Ly luan Chinh tri'),
    (N'Bo mon Tu tuong Ho Chi Minh', N'Khoa Ly luan Chinh tri'),
    (N'Bo mon Quan tri dao tao', N'Khoa Quan tri Giao duc'),
    (N'Bo mon Thanh tra - Khao thi', N'Khoa Quan tri Giao duc'),
    (N'Bo mon CNTT', N'Khoa Cong nghe va Ngoai ngu'),
    (N'Bo mon Ngoai ngu', N'Khoa Cong nghe va Ngoai ngu')
) AS v(TenDonVi, TenKhoa)
JOIN Khoa k ON k.TenKhoa = v.TenKhoa;

INSERT INTO HocHam (TenHocHam) VALUES (N'Giao su'), (N'Pho giao su'), (N'Khong');
INSERT INTO HocVi (TenHocVi) VALUES (N'Tien si'), (N'Thac si'), (N'Cu nhan');
INSERT INTO TrinhDoChuyenMon (TenTrinhDo) VALUES (N'Tien si'), (N'Thac si'), (N'Cu nhan'), (N'Cao dang');
INSERT INTO TrinhDoLLCT (TenTrinhDo) VALUES (N'Cao cap'), (N'Trung cap'), (N'So cap');
INSERT INTO ChucDanhGiangDay (TenChucDanh) VALUES (N'Chua co chuc danh'), (N'Tro giang'), (N'Giang vien'), (N'Giang vien chinh');
INSERT INTO CapBac (TenCapBac) VALUES (N'Dai uy'), (N'Thieu ta'), (N'Trung ta'), (N'Thuong ta');
GO

-- Sample giang vien
INSERT INTO GiangVien (MaSo, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao, SoDienThoai, Email,
                       TrinhDoCMId, TrinhDoLLCTId, DonViId, ChucVu, CapBacId, HeSoLuong, ChucDanhId,
                       HocHamId, HocViId, LinhVucChuyenMon, NamGanNhatDayGioi)
VALUES
('GV001', N'Nguyen Van An', 1, '1978-01-12', N'Phuong Trung Tu|Ha Noi', N'Kinh', N'Khong', '0912345678', 'an.nguyen@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Tien si'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Cao cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Triet hoc'),
 N'Truong bo mon',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Thuong ta'),
 4.50,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien chinh'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Pho giao su'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Tien si'),
 N'Ly luan chinh tri',
 2024),
('GV002', N'Tran Thi Binh', 0, '1984-05-23', N'Xa Hoa Phong|Da Nang', N'Kinh', N'Khong', '0902233444', 'binh.tran@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Thac si'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Cao cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Tu tuong Ho Chi Minh'),
 N'Pho truong bo mon',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Trung ta'),
 4.10,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien chinh'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Khong'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Thac si'),
 N'Tu tuong Ho Chi Minh',
 2023),
('GV003', N'Le Quoc Cuong', 1, '1988-11-02', N'Phuong Linh Trung|TP Thu Duc', N'Kinh', N'Khong', '0988777666', 'cuong.le@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Thac si'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Trung cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon CNTT'),
 N'Giang vien',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Thieu ta'),
 3.60,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Khong'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Thac si'),
 N'Cong nghe giao duc',
 2022),
('GV004', N'Pham Thu Ha', 0, '1990-03-14', N'Huyen Yen Lac|Vinh Phuc', N'Kinh', N'Khong', '0973123456', 'ha.pham@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Tien si'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Cao cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Quan tri dao tao'),
 N'Truong phong dao tao',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Trung ta'),
 4.30,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien chinh'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Pho giao su'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Tien si'),
 N'Quan tri giao duc',
 2024),
('GV005', N'Do Minh Khoi', 1, '1985-07-30', N'Phuong 7|TP Vung Tau', N'Kinh', N'Khong', '0905123000', 'khoi.do@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Cu nhan'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Trung cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Thanh tra - Khao thi'),
 N'Chuyen vien',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Dai uy'),
 3.20,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Tro giang'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Khong'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Cu nhan'),
 N'Dam bao chat luong',
 2021),
('GV006', N'Vu Hai Long', 1, '1982-09-09', N'Thi tran Chuc Son|Ha Noi', N'Kinh', N'Khong', '0908111000', 'long.vu@demo.edu.vn',
 (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Tien si'),
 (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Cao cap'),
 (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Ngoai ngu'),
 N'Truong bo mon',
 (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Thuong ta'),
 4.20,
 (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien chinh'),
 (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Khong'),
 (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Tien si'),
 N'Ngoai ngu quan su',
 2023);
GO

INSERT INTO HocPhan (TenHocPhan, SoTinChi) VALUES
(N'Triet hoc Mac - Lenin', 3),
(N'Tu tuong Ho Chi Minh', 2),
(N'Ky nang giang day so', 2),
(N'Quan tri lop hoc', 3);
GO

-- Bai hoi giang
INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai, HocPhanId, LopThucHien, ThoiGian, CapThucHien, TrangThai)
SELECT gv.GiangVienId, gv.CapBacId, gv.DonViId, gv.ChucDanhId,
       N'Nang cao chat luong giang day Triet hoc',
       (SELECT HocPhanId FROM HocPhan WHERE TenHocPhan = N'Triet hoc Mac - Lenin'),
       N'CT01', '2025-03-15T08:00:00', N'Hoc vien', N'Dang cham'
FROM GiangVien gv WHERE gv.MaSo = 'GV001';

INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai, HocPhanId, LopThucHien, ThoiGian, CapThucHien, TrangThai)
SELECT gv.GiangVienId, gv.CapBacId, gv.DonViId, gv.ChucDanhId,
       N'Ung dung CNTT trong dao tao',
       (SELECT HocPhanId FROM HocPhan WHERE TenHocPhan = N'Ky nang giang day so'),
       N'CN02', '2025-03-20T13:30:00', N'Cap Bo', N'Chua cham'
FROM GiangVien gv WHERE gv.MaSo = 'GV003';

INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai, HocPhanId, LopThucHien, ThoiGian, CapThucHien, TrangThai)
SELECT gv.GiangVienId, gv.CapBacId, gv.DonViId, gv.ChucDanhId,
       N'Quan tri hoat dong dao tao hien dai',
       (SELECT HocPhanId FROM HocPhan WHERE TenHocPhan = N'Quan tri lop hoc'),
       N'QT01', '2025-04-05T09:30:00', N'Hoc vien', N'Da cham'
FROM GiangVien gv WHERE gv.MaSo = 'GV004';
GO

-- Hoi dong
INSERT INTO HoiDong (BaiHoiGiangId, TenHoiDong, NgayLap)
SELECT b.BaiHoiGiangId, N'Hoi dong Khoa Ly luan', '2025-03-05'
FROM BaiHoiGiang b WHERE b.TenBai = N'Nang cao chat luong giang day Triet hoc';

INSERT INTO HoiDong (BaiHoiGiangId, TenHoiDong, NgayLap)
SELECT b.BaiHoiGiangId, N'Hoi dong Khoa Quan tri', '2025-03-25'
FROM BaiHoiGiang b WHERE b.TenBai = N'Quan tri hoat dong dao tao hien dai';

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Chu tich Hoi dong'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Nang cao chat luong giang day Triet hoc'
JOIN GiangVien gv ON gv.MaSo = 'GV002';

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Thanh vien'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Nang cao chat luong giang day Triet hoc'
JOIN GiangVien gv ON gv.MaSo IN ('GV003', 'GV004', 'GV005');

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Thu ky'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Nang cao chat luong giang day Triet hoc'
JOIN GiangVien gv ON gv.MaSo = 'GV006';

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Chu tich Hoi dong'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Quan tri hoat dong dao tao hien dai'
JOIN GiangVien gv ON gv.MaSo = 'GV001';

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Thanh vien'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Quan tri hoat dong dao tao hien dai'
JOIN GiangVien gv ON gv.MaSo IN ('GV002', 'GV003', 'GV005');

INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
SELECT hd.HoiDongId, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, N'Thu ky'
FROM HoiDong hd
JOIN BaiHoiGiang b ON hd.BaiHoiGiangId = b.BaiHoiGiangId AND b.TenBai = N'Quan tri hoat dong dao tao hien dai'
JOIN GiangVien gv ON gv.MaSo = 'GV004';
GO

-- Ket qua hoi giang
INSERT INTO KetQuaHoiGiang (BaiHoiGiangId, TongDiem, XepLoai)
SELECT b.BaiHoiGiangId, 96.50, N'Nhat' FROM BaiHoiGiang b WHERE b.TenBai = N'Quan tri hoat dong dao tao hien dai';
DECLARE @KetQua1 INT = (SELECT KetQuaHoiGiangId FROM KetQuaHoiGiang WHERE BaiHoiGiangId = (SELECT BaiHoiGiangId FROM BaiHoiGiang WHERE TenBai = N'Quan tri hoat dong dao tao hien dai'));
INSERT INTO KetQuaThanhPhan (KetQuaHoiGiangId, TenPhanThi, Diem) VALUES
(@KetQua1, N'Phan thi hieu biet', 30.00),
(@KetQua1, N'Phan thi gioi thieu giang vien va ho so bai', 32.50),
(@KetQua1, N'Phan thuc hanh giang (TB 5 phieu)', 34.00);

INSERT INTO KetQuaHoiGiang (BaiHoiGiangId, TongDiem, XepLoai)
SELECT b.BaiHoiGiangId, 89.00, N'Nhi' FROM BaiHoiGiang b WHERE b.TenBai = N'Nang cao chat luong giang day Triet hoc';
DECLARE @KetQua2 INT = (SELECT KetQuaHoiGiangId FROM KetQuaHoiGiang WHERE BaiHoiGiangId = (SELECT BaiHoiGiangId FROM BaiHoiGiang WHERE TenBai = N'Nang cao chat luong giang day Triet hoc'));
INSERT INTO KetQuaThanhPhan (KetQuaHoiGiangId, TenPhanThi, Diem) VALUES
(@KetQua2, N'Phan thi hieu biet', 28.00),
(@KetQua2, N'Phan thi gioi thieu giang vien va ho so bai', 30.00),
(@KetQua2, N'Phan thuc hanh giang (TB 5 phieu)', 31.00);
GO

-- Sang kien
INSERT INTO SangKien (TenSangKien, GiangVienId, TuCach, Loai, LinhVuc, NamHoc, ThoiGianThucHien, DiaDiemPhamVi, XepLoai)
SELECT N'Chuyen doi so trong quan tri dao tao', gv.GiangVienId, N'Tac gia', N'Sang kien', N'Quan tri', '2024-2025', N'09/2024 - 03/2025', N'Toan hoc vien', N'Xuat sac'
FROM GiangVien gv WHERE gv.MaSo = 'GV004';

INSERT INTO SangKien (TenSangKien, GiangVienId, TuCach, Loai, LinhVuc, NamHoc, ThoiGianThucHien, DiaDiemPhamVi, XepLoai)
SELECT N'Thiet ke hoc lieu so cho mon Triet hoc', gv.GiangVienId, N'Dong tac gia', N'Cai tien', N'Ly luan', '2023-2024', N'01/2024 - 05/2024', N'Khoa Ly luan', N'Tot'
FROM GiangVien gv WHERE gv.MaSo = 'GV001';

INSERT INTO SangKien (TenSangKien, GiangVienId, TuCach, Loai, LinhVuc, NamHoc, ThoiGianThucHien, DiaDiemPhamVi, XepLoai)
SELECT N'Chuan hoa quy trinh khao thi', gv.GiangVienId, N'Tac gia', N'Cai tien', N'Dam bao chat luong', '2022-2023', N'08/2022 - 03/2023', N'Hoc vien', N'Kha'
FROM GiangVien gv WHERE gv.MaSo = 'GV005';
GO

-- Lich giang mau
INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc, PhongHoc, SoTiet, SoSinhVien)
SELECT '2024-2025', N'CT01', N'Triet hoc Mac - Lenin', gv.GiangVienId, N'Sang', '2025-03-10', N'A101', 4, 80
FROM GiangVien gv WHERE gv.MaSo = 'GV001';

INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc, PhongHoc, SoTiet, SoSinhVien)
SELECT '2024-2025', N'CN02', N'Ky nang giang day so', gv.GiangVienId, N'Chieu', '2025-03-18', N'Lab 02', 3, 45
FROM GiangVien gv WHERE gv.MaSo = 'GV003';

INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc, PhongHoc, SoTiet, SoSinhVien)
SELECT '2024-2025', N'QT01', N'Quan tri lop hoc', gv.GiangVienId, N'Sang', '2025-04-01', N'B202', 4, 60
FROM GiangVien gv WHERE gv.MaSo = 'GV004';

INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc, PhongHoc, SoTiet, SoSinhVien)
SELECT '2024-2025', N'TA01', N'Ngoai ngu quan su', gv.GiangVienId, N'Toi', '2025-03-22', N'C103', 3, 35
FROM GiangVien gv WHERE gv.MaSo = 'GV006';
GO

-- Default admin (username/password = 1)
INSERT INTO NguoiDung (Username, PasswordHash, HoTen, Role)
VALUES ('1', CONVERT(VARCHAR(200), HASHBYTES('SHA2_256', N'1'), 1), N'Quan tri vien demo', 'Admin');
GO

PRINT 'Khoi tao du lieu QLHoiGiang hoan tat.';
