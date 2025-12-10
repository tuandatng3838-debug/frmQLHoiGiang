using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class LookupRepository : RepositoryBase
{
    public List<LookupItem> GetLookup(string table, string idColumn = "Id", string nameColumn = "Name")
    {
        var results = new List<LookupItem>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand($"SELECT {idColumn}, {nameColumn} FROM {table} ORDER BY {nameColumn}", conn);
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

    public List<DonVi> GetDonVi()
    {
        var results = new List<DonVi>();
        const string sql = """
            SELECT d.DonViId, d.TenDonVi, d.KhoaId, k.TenKhoa
            FROM DonVi d
            INNER JOIN Khoa k ON d.KhoaId = k.KhoaId
            ORDER BY k.TenKhoa, d.TenDonVi
            """;

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

    public List<HocPhan> GetHocPhan()
    {
        var results = new List<HocPhan>();
        const string sql = "SELECT HocPhanId, TenHocPhan, SoTinChi FROM HocPhan ORDER BY TenHocPhan";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            results.Add(new HocPhan
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                SoTinChi = reader.GetInt32(2)
            });
        }

        return results;
    }
}
