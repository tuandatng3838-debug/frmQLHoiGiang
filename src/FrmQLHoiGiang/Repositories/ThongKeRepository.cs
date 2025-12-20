using FrmQLHoiGiang.DTOs;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class ThongKeRepository : RepositoryBase
{
    public List<TietDayTheoGiangVienDto> GetTietDayTheoGiangVien(string namHoc)
    {
        const string sql = """
            SELECT gv.HoTen, SUM(l.SoTiet) AS TongTiet
            FROM LichGiang l
            INNER JOIN GiangVien gv ON l.GiangVienId = gv.GiangVienId
            WHERE l.NamHoc = @NamHoc OR l.NamHoc LIKE @NamHocLike
            GROUP BY gv.HoTen
            ORDER BY gv.HoTen
            """;
        var namHocLike = $"%{namHoc}%";
        return Query(sql, reader => new TietDayTheoGiangVienDto
        {
            GiangVien = reader.GetString(0),
            TongTiet = reader.GetInt32(1)
        }, new SqlParameter("@NamHoc", namHoc), new SqlParameter("@NamHocLike", namHocLike));
    }

    public List<TietDayTheoKhoaDto> GetTietDayTheoKhoa(string namHoc)
    {
        const string sql = """
            SELECT k.TenKhoa, SUM(l.SoTiet) AS TongTiet
            FROM LichGiang l
            INNER JOIN GiangVien gv ON l.GiangVienId = gv.GiangVienId
            INNER JOIN DonVi d ON gv.DonViId = d.DonViId
            INNER JOIN Khoa k ON d.KhoaId = k.KhoaId
            WHERE l.NamHoc = @NamHoc OR l.NamHoc LIKE @NamHocLike
            GROUP BY k.TenKhoa
            ORDER BY k.TenKhoa
            """;
        var namHocLike = $"%{namHoc}%";
        return Query(sql, reader => new TietDayTheoKhoaDto
        {
            Khoa = reader.GetString(0),
            TongTiet = reader.GetInt32(1)
        }, new SqlParameter("@NamHoc", namHoc), new SqlParameter("@NamHocLike", namHocLike));
    }

    public List<SangKienTheoGiangVienDto> GetSangKienTheoGiangVien()
    {
        const string sql = """
            SELECT gv.HoTen, COUNT(*) AS SoSangKien
            FROM SangKien s
            INNER JOIN GiangVien gv ON s.GiangVienId = gv.GiangVienId
            GROUP BY gv.HoTen
            ORDER BY SoSangKien DESC
            """;
        return Query(sql, reader => new SangKienTheoGiangVienDto
        {
            GiangVien = reader.GetString(0),
            SoSangKien = reader.GetInt32(1)
        });
    }

    public List<GiaiThuongTheoKhoaDto> GetGiaiThuong()
    {
        const string sql = """
            SELECT k.TenKhoa,
                   SUM(CASE WHEN kq.XepLoai = N'Nhat' THEN 1 ELSE 0 END) AS Nhat,
                   SUM(CASE WHEN kq.XepLoai = N'Nhi' THEN 1 ELSE 0 END) AS Nhi,
                   SUM(CASE WHEN kq.XepLoai = N'Ba' THEN 1 ELSE 0 END) AS Ba,
                   SUM(CASE WHEN kq.XepLoai NOT IN (N'Nhat', N'Nhi', N'Ba') THEN 1 ELSE 0 END) AS KhuyenKhich
            FROM KetQuaHoiGiang kq
            INNER JOIN BaiHoiGiang bhg ON kq.BaiHoiGiangId = bhg.BaiHoiGiangId
            INNER JOIN DonVi d ON bhg.DonViId = d.DonViId
            INNER JOIN Khoa k ON d.KhoaId = k.KhoaId
            GROUP BY k.TenKhoa
            """;
        return Query(sql, reader => new GiaiThuongTheoKhoaDto
        {
            Khoa = reader.GetString(0),
            Nhat = reader.GetInt32(1),
            Nhi = reader.GetInt32(2),
            Ba = reader.GetInt32(3),
            KhuyenKhich = reader.GetInt32(4)
        });
    }

    public List<ThamGiaHoiDongDto> GetThamGiaHoiDong()
    {
        const string sql = """
            SELECT gv.HoTen, COUNT(*) AS SoLan
            FROM ThanhVienHoiDong tv
            INNER JOIN GiangVien gv ON tv.GiangVienId = gv.GiangVienId
            GROUP BY gv.HoTen
            ORDER BY SoLan DESC
            """;
        return Query(sql, reader => new ThamGiaHoiDongDto
        {
            ThanhVien = reader.GetString(0),
            SoLan = reader.GetInt32(1)
        });
    }

    public List<TongHopHoiGiangDto> GetTongHopHoiGiang(string nam)
    {
        if (!TryParseYear(nam, out var year))
        {
            return new List<TongHopHoiGiangDto>();
        }

        const string sql = """
            SELECT bhg.CapThucHien, COUNT(*) AS SoBai
            FROM BaiHoiGiang bhg
            WHERE YEAR(bhg.ThoiGian) = @Nam
            GROUP BY bhg.CapThucHien
            """;
        return Query(sql, reader => new TongHopHoiGiangDto
        {
            CapThucHien = reader.GetString(0),
            SoBai = reader.GetInt32(1)
        }, new SqlParameter("@Nam", year));
    }

    private static bool TryParseYear(string value, out int year)
    {
        if (int.TryParse(value, out year))
        {
            return true;
        }

        var parts = value.Split('-', '–', '—');
        if (parts.Length > 0 && int.TryParse(parts[0].Trim(), out year))
        {
            return true;
        }

        year = 0;
        return false;
    }

    private List<T> Query<T>(string sql, Func<SqlDataReader, T> map, params SqlParameter[] parameters)
    {
        var list = new List<T>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        if (parameters?.Length > 0)
        {
            cmd.Parameters.AddRange(parameters);
        }

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(map(reader));
        }

        return list;
    }
}
