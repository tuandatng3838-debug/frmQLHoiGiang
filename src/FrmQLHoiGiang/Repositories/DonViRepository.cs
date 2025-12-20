using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class DonViRepository : RepositoryBase
{
    public List<DonVi> GetAll()
    {
        const string sql = """
            SELECT d.DonViId, d.TenDonVi, d.KhoaId, k.TenKhoa
            FROM DonVi d
            INNER JOIN Khoa k ON d.KhoaId = k.KhoaId
            ORDER BY k.TenKhoa, d.TenDonVi
            """;
        var results = new List<DonVi>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            results.Add(new DonVi
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                KhoaId = reader.GetInt32(2),
                Khoa = reader.GetString(3)
            });
        }

        return results;
    }

    public int Insert(DonVi entity)
    {
        const string sql = """
            INSERT INTO DonVi (TenDonVi, KhoaId)
            OUTPUT INSERTED.DonViId
            VALUES (@TenDonVi, @KhoaId)
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenDonVi", entity.Name);
        cmd.Parameters.AddWithValue("@KhoaId", entity.KhoaId);
        return (int)cmd.ExecuteScalar()!;
    }

    public void Update(DonVi entity)
    {
        const string sql = """
            UPDATE DonVi
            SET TenDonVi = @TenDonVi, KhoaId = @KhoaId
            WHERE DonViId = @DonViId
            """;
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenDonVi", entity.Name);
        cmd.Parameters.AddWithValue("@KhoaId", entity.KhoaId);
        cmd.Parameters.AddWithValue("@DonViId", entity.Id);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int donViId)
    {
        const string sql = "DELETE FROM DonVi WHERE DonViId = @DonViId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@DonViId", donViId);
        cmd.ExecuteNonQuery();
    }
}
