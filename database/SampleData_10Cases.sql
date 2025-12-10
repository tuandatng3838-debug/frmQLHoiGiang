/* 
    SampleData_10Cases.sql
    Tạo 10 mẫu dữ liệu nhỏ giúp kiểm tra nhanh toàn bộ chức năng (cán bộ, hội giảng,
    hội đồng, kết quả, sáng kiến, lịch giảng). Có thể chạy sau khi đã khởi tạo schema
    bằng file QLHoiGiang.sql.
*/
USE QLHoiGiang;
GO

/* SAMPLE 1 – thêm giảng viên CNTT */
IF NOT EXISTS (SELECT 1 FROM GiangVien WHERE MaSo = 'GV101')
BEGIN
    INSERT INTO GiangVien (MaSo, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao,
                           SoDienThoai, Email, TrinhDoCMId, TrinhDoLLCTId, DonViId,
                           ChucVu, CapBacId, HeSoLuong, ChucDanhId, HocHamId, HocViId,
                           LinhVucChuyenMon, NamGanNhatDayGioi)
    VALUES (
        'GV101', N'Phan Huu Khai', 1, '1986-04-18', N'Phuong Linh Tay|TP Thu Duc', N'Kinh', N'Khong',
        '0909000111', 'khai.phan@demo.edu.vn',
        (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Thac si'),
        (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Trung cap'),
        (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon CNTT'),
        N'Giang vien',
        (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Thieu ta'),
        3.55,
        (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien'),
        (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Khong'),
        (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Thac si'),
        N'Cong nghe giao duc', 2024
    );
END
GO

/* SAMPLE 2 – thêm giảng viên LLCT */
IF NOT EXISTS (SELECT 1 FROM GiangVien WHERE MaSo = 'GV102')
BEGIN
    INSERT INTO GiangVien (MaSo, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao,
                           SoDienThoai, Email, TrinhDoCMId, TrinhDoLLCTId, DonViId,
                           ChucVu, CapBacId, HeSoLuong, ChucDanhId, HocHamId, HocViId,
                           LinhVucChuyenMon, NamGanNhatDayGioi)
    VALUES (
        'GV102', N'Nguyen Thi Thanh Mai', 0, '1981-08-12', N'Phuong Trung Tu|Ha Noi', N'Kinh', N'Khong',
        '0918222666', 'mai.nguyen@demo.edu.vn',
        (SELECT TrinhDoCMId FROM TrinhDoChuyenMon WHERE TenTrinhDo = N'Tien si'),
        (SELECT TrinhDoLLCTId FROM TrinhDoLLCT WHERE TenTrinhDo = N'Cao cap'),
        (SELECT DonViId FROM DonVi WHERE TenDonVi = N'Bo mon Triet hoc'),
        N'Pho truong khoa',
        (SELECT CapBacId FROM CapBac WHERE TenCapBac = N'Thuong ta'),
        4.60,
        (SELECT ChucDanhId FROM ChucDanhGiangDay WHERE TenChucDanh = N'Giang vien chinh'),
        (SELECT HocHamId FROM HocHam WHERE TenHocHam = N'Pho giao su'),
        (SELECT HocViId FROM HocVi WHERE TenHocVi = N'Tien si'),
        N'Ly luan chinh tri', 2025
    );
END
GO

/* SAMPLE 3 – tạo bài hội giảng cho GV101 */
IF NOT EXISTS (SELECT 1 FROM BaiHoiGiang WHERE TenBai = N'Thiết kế học liệu số tương tác')
BEGIN
    DECLARE @Gv101 INT = (SELECT GiangVienId FROM GiangVien WHERE MaSo = 'GV101');
    INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai,
                             HocPhanId, LopThucHien, ThoiGian, CapThucHien, TrangThai)
    SELECT @Gv101, gv.CapBacId, gv.DonViId, gv.ChucDanhId,
           N'Thiết kế học liệu số tương tác',
           (SELECT HocPhanId FROM HocPhan WHERE TenHocPhan = N'Ky nang giang day so'),
           N'K45 CNTT', '2025-05-12T08:00:00', N'Hoc vien', N'Chua cham'
    FROM GiangVien gv WHERE gv.GiangVienId = @Gv101;
END
GO

/* SAMPLE 4 – tạo bài hội giảng cho GV102 */
IF NOT EXISTS (SELECT 1 FROM BaiHoiGiang WHERE TenBai = N'Vận dụng tư tưởng Hồ Chí Minh trong công tác giảng dạy')
BEGIN
    DECLARE @Gv102 INT = (SELECT GiangVienId FROM GiangVien WHERE MaSo = 'GV102');
    INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai,
                             HocPhanId, LopThucHien, ThoiGian, CapThucHien, TrangThai)
    SELECT @Gv102, gv.CapBacId, gv.DonViId, gv.ChucDanhId,
           N'Vận dụng tư tưởng Hồ Chí Minh trong công tác giảng dạy',
           (SELECT HocPhanId FROM HocPhan WHERE TenHocPhan = N'Tu tuong Ho Chi Minh'),
           N'LLCT 01', '2025-05-25T13:30:00', N'Cap Bo', N'Dang cham'
    FROM GiangVien gv WHERE gv.GiangVienId = @Gv102;
END
GO

/* SAMPLE 5 – lập hội đồng + thành viên cho bài CNTT */
DECLARE @BaiCNTT INT = (SELECT BaiHoiGiangId FROM BaiHoiGiang WHERE TenBai = N'Thiết kế học liệu số tương tác');
IF @BaiCNTT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM HoiDong WHERE BaiHoiGiangId = @BaiCNTT)
BEGIN
    INSERT INTO HoiDong (BaiHoiGiangId, TenHoiDong, NgayLap)
    VALUES (@BaiCNTT, N'Hội đồng CNTT số', '2025-05-01');
END

DECLARE @HoiDongCNTT INT = (SELECT HoiDongId FROM HoiDong WHERE BaiHoiGiangId = @BaiCNTT);
IF @HoiDongCNTT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM ThanhVienHoiDong WHERE HoiDongId = @HoiDongCNTT)
BEGIN
    INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
    SELECT @HoiDongCNTT, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, vaiTro
    FROM (VALUES
        ('GV102', N'Chu tich Hoi dong'),
        ('GV001', N'Thanh vien'),
        ('GV003', N'Thanh vien'),
        ('GV004', N'Thanh vien'),
        ('GV006', N'Thu ky')
    ) AS m(MaSo, vaiTro)
    JOIN GiangVien gv ON gv.MaSo = m.MaSo;
END
GO

/* SAMPLE 6 – lập hội đồng cho bài LLCT */
DECLARE @BaiLLCT INT = (SELECT BaiHoiGiangId FROM BaiHoiGiang WHERE TenBai = N'Vận dụng tư tưởng Hồ Chí Minh trong công tác giảng dạy');
IF @BaiLLCT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM HoiDong WHERE BaiHoiGiangId = @BaiLLCT)
BEGIN
    INSERT INTO HoiDong (BaiHoiGiangId, TenHoiDong, NgayLap)
    VALUES (@BaiLLCT, N'Hội đồng Lý luận', '2025-05-10');
END

DECLARE @HoiDongLLCT INT = (SELECT HoiDongId FROM HoiDong WHERE BaiHoiGiangId = @BaiLLCT);
IF @HoiDongLLCT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM ThanhVienHoiDong WHERE HoiDongId = @HoiDongLLCT)
BEGIN
    INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
    SELECT @HoiDongLLCT, gv.GiangVienId, gv.CapBacId, gv.ChucDanhId, vaiTro
    FROM (VALUES
        ('GV101', N'Chu tich Hoi dong'),
        ('GV002', N'Thanh vien'),
        ('GV003', N'Thanh vien'),
        ('GV004', N'Thanh vien'),
        ('GV005', N'Thu ky')
    ) AS m(MaSo, vaiTro)
    JOIN GiangVien gv ON gv.MaSo = m.MaSo;
END
GO

/* SAMPLE 7 – chấm điểm hội giảng CNTT */
IF @BaiCNTT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM KetQuaHoiGiang WHERE BaiHoiGiangId = @BaiCNTT)
BEGIN
    INSERT INTO KetQuaHoiGiang (BaiHoiGiangId, TongDiem, XepLoai)
    VALUES (@BaiCNTT, 91.25, N'Nhi');

    DECLARE @KetQuaCNTT INT = SCOPE_IDENTITY();
    INSERT INTO KetQuaThanhPhan (KetQuaHoiGiangId, TenPhanThi, Diem) VALUES
        (@KetQuaCNTT, N'Phan thi hieu biet', 30.25),
        (@KetQuaCNTT, N'Phan thi gioi thieu giang vien va ho so bai', 30.00),
        (@KetQuaCNTT, N'Phan thuc hanh giang (TB 5 phieu)', 31.00);
END
GO

/* SAMPLE 8 – chấm điểm hội giảng LLCT */
IF @BaiLLCT IS NOT NULL AND NOT EXISTS (SELECT 1 FROM KetQuaHoiGiang WHERE BaiHoiGiangId = @BaiLLCT)
BEGIN
    INSERT INTO KetQuaHoiGiang (BaiHoiGiangId, TongDiem, XepLoai)
    VALUES (@BaiLLCT, 97.40, N'Nhat');

    DECLARE @KetQuaLLCT INT = SCOPE_IDENTITY();
    INSERT INTO KetQuaThanhPhan (KetQuaHoiGiangId, TenPhanThi, Diem) VALUES
        (@KetQuaLLCT, N'Phan thi hieu biet', 31.40),
        (@KetQuaLLCT, N'Phan thi gioi thieu giang vien va ho so bai', 33.00),
        (@KetQuaLLCT, N'Phan thuc hanh giang (TB 5 phieu)', 33.00);
END
GO

/* SAMPLE 9 – sáng kiến cho giảng viên mới */
IF NOT EXISTS (SELECT 1 FROM SangKien WHERE TenSangKien = N'Tự động hóa đánh giá học liệu')
BEGIN
    INSERT INTO SangKien (TenSangKien, GiangVienId, TuCach, Loai, LinhVuc,
                          NamHoc, ThoiGianThucHien, DiaDiemPhamVi, XepLoai)
    SELECT N'Tự động hóa đánh giá học liệu', gv.GiangVienId, N'Tac gia', N'Sang kien',
           N'CNTT giáo dục', '2024-2025', N'10/2024 - 03/2025', N'Học viện', N'Tot'
    FROM GiangVien gv WHERE gv.MaSo = 'GV101';
END
GO

/* SAMPLE 10 – lịch giảng minh họa cho GV102 */
IF NOT EXISTS (SELECT 1 FROM LichGiang WHERE GiangVienId = (SELECT GiangVienId FROM GiangVien WHERE MaSo = 'GV102') 
               AND NgayHoc = '2025-05-18' AND Buoi = N'Sang')
BEGIN
    INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc,
                           PhongHoc, SoTiet, SoSinhVien)
    SELECT '2024-2025', N'LLCT 01', N'Triet hoc Mac - Lenin',
           gv.GiangVienId, N'Sang', '2025-05-18', N'A305', 4, 95
    FROM GiangVien gv WHERE gv.MaSo = 'GV102';
END
GO

PRINT N'Da nap 10 mau du lieu thu nghiem.';
