using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class KhoaRepository : RepositoryBase
{
    public List<LookupItem> GetAll()
    {
        const string sql = """
            SELECT KhoaId, TenKhoa
            FROM Khoa
            ORDER BY TenKhoa
            """;
        var results = new List<LookupItem>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            results.Add(new LookupItem
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            });
        }

        return results;
    }

    public int Insert(string tenKhoa)
    {
        const string sql = """
            INSERT INTO Khoa (TenKhoa)
            OUTPUT INSERTED.KhoaId
            VALUES (@TenKhoa)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenKhoa", tenKhoa);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(int khoaId, string tenKhoa)
    {
        const string sql = """
            UPDATE Khoa
            SET TenKhoa = @TenKhoa
            WHERE KhoaId = @KhoaId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenKhoa", tenKhoa);
        cmd.Parameters.AddWithValue("@KhoaId", khoaId);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int khoaId)
    {
        const string sql = "DELETE FROM Khoa WHERE KhoaId = @KhoaId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@KhoaId", khoaId);
        cmd.ExecuteNonQuery();
    }
}
