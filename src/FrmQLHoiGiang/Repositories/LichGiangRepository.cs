using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class LichGiangRepository : RepositoryBase
{
    public List<LichGiang> GetAll()
    {
        const string sql = """
            SELECT l.LichGiangId, l.NamHoc, l.TenLop, l.TenMon, l.GiangVienId, gv.HoTen,
                   l.Buoi, l.NgayHoc, l.PhongHoc, l.SoTiet, l.SoSinhVien
            FROM LichGiang l
            INNER JOIN GiangVien gv ON l.GiangVienId = gv.GiangVienId
            ORDER BY l.NgayHoc DESC, l.Buoi
            """;
        var list = new List<LichGiang>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(Map(reader));
        }

        return list;
    }

    public bool CheckConflict(int giangVienId, DateTime ngayHoc, string buoi, int? excludeId = null)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM LichGiang
            WHERE GiangVienId = @GiangVienId AND NgayHoc = @NgayHoc AND Buoi = @Buoi
                  AND (@ExcludeId IS NULL OR LichGiangId <> @ExcludeId)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@GiangVienId", giangVienId);
        cmd.Parameters.AddWithValue("@NgayHoc", ngayHoc.Date);
        cmd.Parameters.AddWithValue("@Buoi", buoi);
        cmd.Parameters.AddWithValue("@ExcludeId", (object?)excludeId ?? DBNull.Value);
        var count = (int)cmd.ExecuteScalar()!;
        return count > 0;
    }

    public int Insert(LichGiang entity)
    {
        const string sql = """
            INSERT INTO LichGiang (NamHoc, TenLop, TenMon, GiangVienId, Buoi, NgayHoc, PhongHoc, SoTiet, SoSinhVien)
            OUTPUT INSERTED.LichGiangId
            VALUES (@NamHoc, @TenLop, @TenMon, @GiangVienId, @Buoi, @NgayHoc, @PhongHoc, @SoTiet, @SoSinhVien)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(LichGiang entity)
    {
        const string sql = """
            UPDATE LichGiang
            SET NamHoc=@NamHoc, TenLop=@TenLop, TenMon=@TenMon, GiangVienId=@GiangVienId, Buoi=@Buoi,
                NgayHoc=@NgayHoc, PhongHoc=@PhongHoc, SoTiet=@SoTiet, SoSinhVien=@SoSinhVien
            WHERE LichGiangId=@LichGiangId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        cmd.Parameters.AddWithValue("@LichGiangId", entity.LichGiangId);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int lichGiangId)
    {
        const string sql = "DELETE FROM LichGiang WHERE LichGiangId=@LichGiangId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@LichGiangId", lichGiangId);
        cmd.ExecuteNonQuery();
    }

    private static void AddParameters(SqlCommand cmd, LichGiang entity)
    {
        cmd.Parameters.AddWithValue("@NamHoc", entity.NamHoc);
        cmd.Parameters.AddWithValue("@TenLop", entity.TenLop);
        cmd.Parameters.AddWithValue("@TenMon", entity.TenMon);
        cmd.Parameters.AddWithValue("@GiangVienId", entity.GiangVienId);
        cmd.Parameters.AddWithValue("@Buoi", entity.Buoi);
        cmd.Parameters.AddWithValue("@NgayHoc", entity.NgayHoc.Date);
        cmd.Parameters.AddWithValue("@PhongHoc", (object?)entity.PhongHoc ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@SoTiet", entity.SoTiet);
        cmd.Parameters.AddWithValue("@SoSinhVien", (object?)entity.SoSinhVien ?? DBNull.Value);
    }

    private static LichGiang Map(SqlDataReader reader) => new()
    {
        LichGiangId = reader.GetInt32(0),
        NamHoc = reader.GetString(1),
        TenLop = reader.GetString(2),
        TenMon = reader.GetString(3),
        GiangVienId = reader.GetInt32(4),
        GiangVien = reader.GetString(5),
        Buoi = reader.GetString(6),
        NgayHoc = reader.GetDateTime(7),
        PhongHoc = reader.IsDBNull(8) ? null : reader.GetString(8),
        SoTiet = reader.GetInt32(9),
        SoSinhVien = reader.IsDBNull(10) ? null : reader.GetInt32(10)
    };
}
