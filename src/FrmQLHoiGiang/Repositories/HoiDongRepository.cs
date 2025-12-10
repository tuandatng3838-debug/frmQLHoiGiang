using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class HoiDongRepository : RepositoryBase
{
    public HoiDong? GetByBaiHoiGiangId(int baiHoiGiangId)
    {
        const string sql = "SELECT HoiDongId, BaiHoiGiangId, TenHoiDong, NgayLap FROM HoiDong WHERE BaiHoiGiangId=@BaiHoiGiangId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@BaiHoiGiangId", baiHoiGiangId);
        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        var hoiDong = new HoiDong
        {
            HoiDongId = reader.GetInt32(0),
            BaiHoiGiangId = reader.GetInt32(1),
            TenHoiDong = reader.GetString(2),
            NgayLap = reader.GetDateTime(3)
        };

        hoiDong.ThanhVien = GetThanhVien(hoiDong.HoiDongId);
        return hoiDong;
    }

    public int InsertHoiDong(HoiDong hoiDong)
    {
        const string sql = """
            INSERT INTO HoiDong (BaiHoiGiangId, TenHoiDong, NgayLap)
            OUTPUT INSERTED.HoiDongId
            VALUES (@BaiHoiGiangId, @TenHoiDong, @NgayLap)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@BaiHoiGiangId", hoiDong.BaiHoiGiangId);
        cmd.Parameters.AddWithValue("@TenHoiDong", hoiDong.TenHoiDong);
        cmd.Parameters.AddWithValue("@NgayLap", hoiDong.NgayLap);
        return (int)cmd.ExecuteScalar()!;
    }

    public void ReplaceThanhVien(int hoiDongId, IEnumerable<ThanhVienHoiDong> thanhVien)
    {
        using var conn = OpenConnection();
        using var trans = conn.BeginTransaction();
        try
        {
            using (var deleteCmd = new SqlCommand("DELETE FROM ThanhVienHoiDong WHERE HoiDongId=@HoiDongId", conn, trans))
            {
                deleteCmd.Parameters.AddWithValue("@HoiDongId", hoiDongId);
                deleteCmd.ExecuteNonQuery();
            }

            const string insertSql = """
                INSERT INTO ThanhVienHoiDong (HoiDongId, GiangVienId, CapBacId, ChucDanhGiangDayId, VaiTro)
                VALUES (@HoiDongId, @GiangVienId, @CapBacId, @ChucDanhGiangDayId, @VaiTro)
                """;

            foreach (var tv in thanhVien)
            {
                using var insertCmd = new SqlCommand(insertSql, conn, trans);
                insertCmd.Parameters.AddWithValue("@HoiDongId", hoiDongId);
                insertCmd.Parameters.AddWithValue("@GiangVienId", tv.GiangVienId);
                insertCmd.Parameters.AddWithValue("@CapBacId", (object?)tv.CapBacId ?? DBNull.Value);
                insertCmd.Parameters.AddWithValue("@ChucDanhGiangDayId", (object?)tv.ChucDanhGiangDayId ?? DBNull.Value);
                insertCmd.Parameters.AddWithValue("@VaiTro", tv.VaiTro);
                insertCmd.ExecuteNonQuery();
            }

            trans.Commit();
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    private List<ThanhVienHoiDong> GetThanhVien(int hoiDongId)
    {
        const string sql = """
            SELECT t.ThanhVienHoiDongId, t.HoiDongId, t.GiangVienId, gv.HoTen,
                   t.CapBacId, cb.TenCapBac, t.ChucDanhGiangDayId, cd.TenChucDanh,
                   t.VaiTro
            FROM ThanhVienHoiDong t
            INNER JOIN GiangVien gv ON t.GiangVienId = gv.GiangVienId
            LEFT JOIN CapBac cb ON t.CapBacId = cb.CapBacId
            LEFT JOIN ChucDanhGiangDay cd ON t.ChucDanhGiangDayId = cd.ChucDanhId
            WHERE t.HoiDongId = @HoiDongId
            ORDER BY
                CASE t.VaiTro
                    WHEN N'Chủ tịch' THEN 1
                    WHEN N'Thư ký' THEN 5
                    ELSE 3
                END
            """;
        var list = new List<ThanhVienHoiDong>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@HoiDongId", hoiDongId);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new ThanhVienHoiDong
            {
                ThanhVienHoiDongId = reader.GetInt32(0),
                HoiDongId = reader.GetInt32(1),
                GiangVienId = reader.GetInt32(2),
                HoTen = reader.GetString(3),
                CapBacId = reader.IsDBNull(4) ? null : reader.GetInt32(4),
                CapBac = reader.IsDBNull(5) ? null : reader.GetString(5),
                ChucDanhGiangDayId = reader.IsDBNull(6) ? null : reader.GetInt32(6),
                ChucDanhGiangDay = reader.IsDBNull(7) ? null : reader.GetString(7),
                VaiTro = reader.GetString(8)
            });
        }

        return list;
    }
}
