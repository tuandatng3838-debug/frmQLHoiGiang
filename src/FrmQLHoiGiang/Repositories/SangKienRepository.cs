using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class SangKienRepository : RepositoryBase
{
    public List<SangKien> GetAll()
    {
        const string sql = """
            SELECT s.SangKienId, s.TenSangKien, s.GiangVienId, gv.HoTen,
                   s.TuCach, s.Loai, s.LinhVuc, s.NamHoc, s.ThoiGianThucHien,
                   s.DiaDiemPhamVi, s.XepLoai
            FROM SangKien s
            INNER JOIN GiangVien gv ON s.GiangVienId = gv.GiangVienId
            ORDER BY s.NamHoc DESC, s.TenSangKien
            """;
        var list = new List<SangKien>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(Map(reader));
        }

        return list;
    }

    public int Insert(SangKien entity)
    {
        const string sql = """
            INSERT INTO SangKien (TenSangKien, GiangVienId, TuCach, Loai, LinhVuc, NamHoc,
                                  ThoiGianThucHien, DiaDiemPhamVi, XepLoai)
            OUTPUT INSERTED.SangKienId
            VALUES (@TenSangKien, @GiangVienId, @TuCach, @Loai, @LinhVuc, @NamHoc,
                    @ThoiGianThucHien, @DiaDiemPhamVi, @XepLoai)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(SangKien entity)
    {
        const string sql = """
            UPDATE SangKien
            SET TenSangKien=@TenSangKien, GiangVienId=@GiangVienId, TuCach=@TuCach, Loai=@Loai,
                LinhVuc=@LinhVuc, NamHoc=@NamHoc, ThoiGianThucHien=@ThoiGianThucHien,
                DiaDiemPhamVi=@DiaDiemPhamVi, XepLoai=@XepLoai
            WHERE SangKienId=@SangKienId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        cmd.Parameters.AddWithValue("@SangKienId", entity.SangKienId);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int sangKienId)
    {
        const string sql = "DELETE FROM SangKien WHERE SangKienId=@SangKienId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@SangKienId", sangKienId);
        cmd.ExecuteNonQuery();
    }

    private static void AddParameters(SqlCommand cmd, SangKien entity)
    {
        cmd.Parameters.AddWithValue("@TenSangKien", entity.TenSangKien);
        cmd.Parameters.AddWithValue("@GiangVienId", entity.GiangVienId);
        cmd.Parameters.AddWithValue("@TuCach", entity.TuCach);
        cmd.Parameters.AddWithValue("@Loai", entity.Loai);
        cmd.Parameters.AddWithValue("@LinhVuc", (object?)entity.LinhVuc ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@NamHoc", entity.NamHoc);
        cmd.Parameters.AddWithValue("@ThoiGianThucHien", (object?)entity.ThoiGianThucHien ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@DiaDiemPhamVi", (object?)entity.DiaDiemPhamVi ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@XepLoai", (object?)entity.XepLoai ?? DBNull.Value);
    }

    private static SangKien Map(SqlDataReader reader) => new()
    {
        SangKienId = reader.GetInt32(0),
        TenSangKien = reader.GetString(1),
        GiangVienId = reader.GetInt32(2),
        GiangVien = reader.GetString(3),
        TuCach = reader.GetString(4),
        Loai = reader.GetString(5),
        LinhVuc = reader.IsDBNull(6) ? null : reader.GetString(6),
        NamHoc = reader.GetString(7),
        ThoiGianThucHien = reader.IsDBNull(8) ? null : reader.GetString(8),
        DiaDiemPhamVi = reader.IsDBNull(9) ? null : reader.GetString(9),
        XepLoai = reader.IsDBNull(10) ? null : reader.GetString(10)
    };
}
