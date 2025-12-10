using FrmQLHoiGiang.Models;
using Microsoft.Data.SqlClient;

namespace FrmQLHoiGiang.Repositories;

public class KetQuaRepository : RepositoryBase
{
    public KetQuaHoiGiang? GetByBaiHoiGiang(int baiHoiGiangId)
    {
        const string sql = "SELECT KetQuaHoiGiangId, BaiHoiGiangId, TongDiem, XepLoai FROM KetQuaHoiGiang WHERE BaiHoiGiangId=@BaiHoiGiangId";
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@BaiHoiGiangId", baiHoiGiangId);
        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
        {
            return null;
        }

        var ketQua = new KetQuaHoiGiang
        {
            KetQuaHoiGiangId = reader.GetInt32(0),
            BaiHoiGiangId = reader.GetInt32(1),
            TongDiem = reader.GetDecimal(2),
            XepLoai = reader.GetString(3)
        };

        ketQua.ThanhPhan = GetThanhPhan(ketQua.KetQuaHoiGiangId);
        return ketQua;
    }

    public int Upsert(KetQuaHoiGiang ketQua)
    {
        using var conn = OpenConnection();
        using var trans = conn.BeginTransaction();
        try
        {
            int ketQuaId;
            if (ketQua.KetQuaHoiGiangId == 0)
            {
                const string insertSql = """
                    INSERT INTO KetQuaHoiGiang (BaiHoiGiangId, TongDiem, XepLoai)
                    OUTPUT INSERTED.KetQuaHoiGiangId
                    VALUES (@BaiHoiGiangId, @TongDiem, @XepLoai)
                    """;
                using var insertCmd = new SqlCommand(insertSql, conn, trans);
                insertCmd.Parameters.AddWithValue("@BaiHoiGiangId", ketQua.BaiHoiGiangId);
                insertCmd.Parameters.AddWithValue("@TongDiem", ketQua.TongDiem);
                insertCmd.Parameters.AddWithValue("@XepLoai", ketQua.XepLoai);
                ketQuaId = (int)insertCmd.ExecuteScalar()!;
            }
            else
            {
                const string updateSql = "UPDATE KetQuaHoiGiang SET TongDiem=@TongDiem, XepLoai=@XepLoai WHERE KetQuaHoiGiangId=@KetQuaHoiGiangId";
                using var updateCmd = new SqlCommand(updateSql, conn, trans);
                updateCmd.Parameters.AddWithValue("@KetQuaHoiGiangId", ketQua.KetQuaHoiGiangId);
                updateCmd.Parameters.AddWithValue("@TongDiem", ketQua.TongDiem);
                updateCmd.Parameters.AddWithValue("@XepLoai", ketQua.XepLoai);
                updateCmd.ExecuteNonQuery();
                ketQuaId = ketQua.KetQuaHoiGiangId;

                using var deleteCmd = new SqlCommand("DELETE FROM KetQuaThanhPhan WHERE KetQuaHoiGiangId=@KetQuaHoiGiangId", conn, trans);
                deleteCmd.Parameters.AddWithValue("@KetQuaHoiGiangId", ketQuaId);
                deleteCmd.ExecuteNonQuery();
            }

            const string insertThanhPhanSql = """
                INSERT INTO KetQuaThanhPhan (KetQuaHoiGiangId, TenPhanThi, Diem)
                VALUES (@KetQuaHoiGiangId, @TenPhanThi, @Diem)
                """;

            foreach (var tp in ketQua.ThanhPhan)
            {
                using var insertTpCmd = new SqlCommand(insertThanhPhanSql, conn, trans);
                insertTpCmd.Parameters.AddWithValue("@KetQuaHoiGiangId", ketQuaId);
                insertTpCmd.Parameters.AddWithValue("@TenPhanThi", tp.TenPhanThi);
                insertTpCmd.Parameters.AddWithValue("@Diem", tp.Diem);
                insertTpCmd.ExecuteNonQuery();
            }

            trans.Commit();
            return ketQuaId;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    private List<KetQuaThanhPhan> GetThanhPhan(int ketQuaHoiGiangId)
    {
        const string sql = "SELECT KetQuaThanhPhanId, KetQuaHoiGiangId, TenPhanThi, Diem FROM KetQuaThanhPhan WHERE KetQuaHoiGiangId=@KetQuaHoiGiangId";
        var list = new List<KetQuaThanhPhan>();
        using var conn = OpenConnection();
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@KetQuaHoiGiangId", ketQuaHoiGiangId);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new KetQuaThanhPhan
            {
                KetQuaThanhPhanId = reader.GetInt32(0),
                KetQuaHoiGiangId = reader.GetInt32(1),
                TenPhanThi = reader.GetString(2),
                Diem = reader.GetDecimal(3)
            });
        }

        return list;
    }
}
