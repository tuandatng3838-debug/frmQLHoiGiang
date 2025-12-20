using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class BaiHoiGiangRepository : RepositoryBase
{
    public List<string> GetCapThucHienValues()
    {
        const string sql = """
            SELECT DISTINCT CapThucHien
            FROM BaiHoiGiang
            WHERE CapThucHien IS NOT NULL
            ORDER BY CapThucHien
            """;
        var values = new List<string>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            values.Add(reader.GetString(0));
        }

        return values;
    }

    public List<BaiHoiGiang> GetAll()
    {
        const string sql = """
            SELECT b.BaiHoiGiangId, b.GiangVienId, gv.HoTen, b.CapBacId, cb.TenCapBac,
                   b.DonViId, dv.TenDonVi, b.ChucDanhId, cd.TenChucDanh, b.TenBai,
                   b.HocPhanId, hp.TenHocPhan, b.LopThucHien, b.ThoiGian, b.CapThucHien,
                   b.TrangThai
            FROM BaiHoiGiang b
            INNER JOIN GiangVien gv ON b.GiangVienId = gv.GiangVienId
            LEFT JOIN CapBac cb ON b.CapBacId = cb.CapBacId
            LEFT JOIN DonVi dv ON b.DonViId = dv.DonViId
            LEFT JOIN ChucDanhGiangDay cd ON b.ChucDanhId = cd.ChucDanhId
            LEFT JOIN HocPhan hp ON b.HocPhanId = hp.HocPhanId
            ORDER BY b.ThoiGian DESC
            """;
        var list = new List<BaiHoiGiang>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(Map(reader));
        }

        return list;
    }

    public int Insert(BaiHoiGiang entity)
    {
        const string sql = """
            INSERT INTO BaiHoiGiang (GiangVienId, CapBacId, DonViId, ChucDanhId, TenBai, HocPhanId,
                                     LopThucHien, ThoiGian, CapThucHien, TrangThai)
            OUTPUT INSERTED.BaiHoiGiangId
            VALUES (@GiangVienId, @CapBacId, @DonViId, @ChucDanhId, @TenBai, @HocPhanId,
                    @LopThucHien, @ThoiGian, @CapThucHien, @TrangThai)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(BaiHoiGiang entity)
    {
        const string sql = """
            UPDATE BaiHoiGiang
            SET GiangVienId=@GiangVienId, CapBacId=@CapBacId, DonViId=@DonViId, ChucDanhId=@ChucDanhId,
                TenBai=@TenBai, HocPhanId=@HocPhanId, LopThucHien=@LopThucHien, ThoiGian=@ThoiGian,
                CapThucHien=@CapThucHien, TrangThai=@TrangThai
            WHERE BaiHoiGiangId=@BaiHoiGiangId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        cmd.Parameters.AddWithValue("@BaiHoiGiangId", entity.BaiHoiGiangId);
        cmd.ExecuteNonQuery();
    }

    public void UpdateTrangThai(int baiHoiGiangId, string trangThai)
    {
        const string sql = "UPDATE BaiHoiGiang SET TrangThai=@TrangThai WHERE BaiHoiGiangId=@BaiHoiGiangId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
        cmd.Parameters.AddWithValue("@BaiHoiGiangId", baiHoiGiangId);
        cmd.ExecuteNonQuery();
    }

    private static void AddParameters(SqlCommand cmd, BaiHoiGiang entity)
    {
        cmd.Parameters.AddWithValue("@GiangVienId", entity.GiangVienId);
        cmd.Parameters.AddWithValue("@CapBacId", (object?)entity.CapBacId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@DonViId", (object?)entity.DonViId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ChucDanhId", (object?)entity.ChucDanhId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@TenBai", entity.TenBai);
        cmd.Parameters.AddWithValue("@HocPhanId", (object?)entity.HocPhanId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@LopThucHien", (object?)entity.LopThucHien ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ThoiGian", entity.ThoiGian);
        cmd.Parameters.AddWithValue("@CapThucHien", entity.CapThucHien);
        cmd.Parameters.AddWithValue("@TrangThai", entity.TrangThai);
    }

    public bool HasHoiGiangTrongNgay(int giangVienId, DateTime ngayThucHien, int? excludeBaiHoiGiangId = null)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM BaiHoiGiang
            WHERE GiangVienId = @GiangVienId
              AND CAST(ThoiGian AS DATE) = @Ngay
              AND (@ExcludeId IS NULL OR BaiHoiGiangId <> @ExcludeId)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@GiangVienId", giangVienId);
        cmd.Parameters.AddWithValue("@Ngay", ngayThucHien.Date);
        cmd.Parameters.AddWithValue("@ExcludeId", (object?)excludeBaiHoiGiangId ?? DBNull.Value);
        var count = (int)cmd.ExecuteScalar()!;
        return count > 0;
    }

    private static BaiHoiGiang Map(SqlDataReader reader) => new()
    {
        BaiHoiGiangId = reader.GetInt32(0),
        GiangVienId = reader.GetInt32(1),
        GiangVien = reader.GetString(2),
        CapBacId = reader.IsDBNull(3) ? null : reader.GetInt32(3),
        CapBac = reader.IsDBNull(4) ? null : reader.GetString(4),
        DonViId = reader.IsDBNull(5) ? null : reader.GetInt32(5),
        DonVi = reader.IsDBNull(6) ? null : reader.GetString(6),
        ChucDanhId = reader.IsDBNull(7) ? null : reader.GetInt32(7),
        ChucDanh = reader.IsDBNull(8) ? null : reader.GetString(8),
        TenBai = reader.GetString(9),
        HocPhanId = reader.IsDBNull(10) ? null : reader.GetInt32(10),
        HocPhan = reader.IsDBNull(11) ? null : reader.GetString(11),
        LopThucHien = reader.IsDBNull(12) ? null : reader.GetString(12),
        ThoiGian = reader.GetDateTime(13),
        CapThucHien = reader.GetString(14),
        TrangThai = reader.GetString(15)
    };
}
