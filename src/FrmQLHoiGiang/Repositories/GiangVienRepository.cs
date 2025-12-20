using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class GiangVienRepository : RepositoryBase
{
    public List<GiangVien> GetAll()
    {
        var sql = """
            SELECT GiangVienId, MaSo, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao,
                   SoDienThoai, Email, TrinhDoCMId, TrinhDoLLCTId, DonViId, KhoaId, ChucVu,
                   CapBacId, HeSoLuong, ChucDanhId, HocHamId, HocViId, LinhVucChuyenMon,
                   NamGanNhatDayGioi
            FROM GiangVien
            ORDER BY HoTen
            """;
        var list = new List<GiangVien>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(Map(reader));
        }

        return list;
    }

    public GiangVien? GetById(int giangVienId)
    {
        var sql = "SELECT * FROM GiangVien WHERE GiangVienId = @GiangVienId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@GiangVienId", giangVienId);
        using var reader = cmd.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public int Insert(GiangVien entity)
    {
        var sql = """
            INSERT INTO GiangVien (MaSo, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao,
                                   SoDienThoai, Email, TrinhDoCMId, TrinhDoLLCTId, DonViId, KhoaId, ChucVu,
                                   CapBacId, HeSoLuong, ChucDanhId, HocHamId, HocViId, LinhVucChuyenMon,
                                   NamGanNhatDayGioi)
            OUTPUT INSERTED.GiangVienId
            VALUES (@MaSo, @HoTen, @GioiTinh, @NgaySinh, @QueQuan, @DanToc, @TonGiao, @SoDienThoai,
                    @Email, @TrinhDoCMId, @TrinhDoLLCTId, @DonViId, @KhoaId, @ChucVu, @CapBacId, @HeSoLuong,
                    @ChucDanhId, @HocHamId, @HocViId, @LinhVucChuyenMon, @NamGanNhatDayGioi)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(GiangVien entity)
    {
        var sql = """
            UPDATE GiangVien
            SET MaSo=@MaSo, HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh,
                QueQuan=@QueQuan, DanToc=@DanToc, TonGiao=@TonGiao, SoDienThoai=@SoDienThoai,
                Email=@Email, TrinhDoCMId=@TrinhDoCMId, TrinhDoLLCTId=@TrinhDoLLCTId, DonViId=@DonViId,
                KhoaId=@KhoaId,
                ChucVu=@ChucVu, CapBacId=@CapBacId, HeSoLuong=@HeSoLuong, ChucDanhId=@ChucDanhId,
                HocHamId=@HocHamId, HocViId=@HocViId, LinhVucChuyenMon=@LinhVucChuyenMon,
                NamGanNhatDayGioi=@NamGanNhatDayGioi
            WHERE GiangVienId=@GiangVienId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        AddParameters(cmd, entity);
        cmd.Parameters.AddWithValue("@GiangVienId", entity.GiangVienId);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int giangVienId)
    {
        const string sql = "DELETE FROM GiangVien WHERE GiangVienId=@GiangVienId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@GiangVienId", giangVienId);
        cmd.ExecuteNonQuery();
    }

    private static void AddParameters(SqlCommand cmd, GiangVien entity)
    {
        cmd.Parameters.AddWithValue("@MaSo", entity.MaSo);
        cmd.Parameters.AddWithValue("@HoTen", entity.HoTen);
        cmd.Parameters.AddWithValue("@GioiTinh", entity.GioiTinh);
        cmd.Parameters.AddWithValue("@NgaySinh", entity.NgaySinh);
        cmd.Parameters.AddWithValue("@QueQuan", (object?)entity.QueQuan ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@DanToc", (object?)entity.DanToc ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@TonGiao", (object?)entity.TonGiao ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@SoDienThoai", (object?)entity.SoDienThoai ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@Email", (object?)entity.Email ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@TrinhDoCMId", (object?)entity.TrinhDoCMId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@TrinhDoLLCTId", (object?)entity.TrinhDoLLCTId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@DonViId", (object?)entity.DonViId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@KhoaId", (object?)entity.KhoaId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ChucVu", (object?)entity.ChucVu ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@CapBacId", (object?)entity.CapBacId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@HeSoLuong", (object?)entity.HeSoLuong ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ChucDanhId", (object?)entity.ChucDanhId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@HocHamId", (object?)entity.HocHamId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@HocViId", (object?)entity.HocViId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@LinhVucChuyenMon", (object?)entity.LinhVucChuyenMon ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@NamGanNhatDayGioi", (object?)entity.NamGanNhatDayGioi ?? DBNull.Value);
    }

    private static GiangVien Map(SqlDataReader reader) => new()
    {
        GiangVienId = reader.GetInt32(reader.GetOrdinal("GiangVienId")),
        MaSo = reader.GetString(reader.GetOrdinal("MaSo")),
        HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
        GioiTinh = Convert.ToInt32(reader["GioiTinh"]) == 1,
        NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh")),
        QueQuan = reader["QueQuan"] as string,
        DanToc = reader["DanToc"] as string,
        TonGiao = reader["TonGiao"] as string,
        SoDienThoai = reader["SoDienThoai"] as string,
        Email = reader["Email"] as string,
        TrinhDoCMId = reader["TrinhDoCMId"] as int?,
        TrinhDoLLCTId = reader["TrinhDoLLCTId"] as int?,
        DonViId = reader["DonViId"] as int?,
        KhoaId = reader["KhoaId"] as int?,
        ChucVu = reader["ChucVu"] as string,
        CapBacId = reader["CapBacId"] as int?,
        HeSoLuong = reader["HeSoLuong"] as decimal?,
        ChucDanhId = reader["ChucDanhId"] as int?,
        HocHamId = reader["HocHamId"] as int?,
        HocViId = reader["HocViId"] as int?,
        LinhVucChuyenMon = reader["LinhVucChuyenMon"] as string,
        NamGanNhatDayGioi = reader["NamGanNhatDayGioi"] as int?
    };
}
