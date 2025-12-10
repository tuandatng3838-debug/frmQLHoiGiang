using FrmQLHoiGiang.DTOs;
using FrmQLHoiGiang.Repositories;

namespace FrmQLHoiGiang.Services;

public class ThongKeService
{
    private readonly ThongKeRepository _repository = new();

    public List<TietDayTheoGiangVienDto> GetTietDayTheoGiangVien(string namHoc) =>
        _repository.GetTietDayTheoGiangVien(namHoc);

    public List<TietDayTheoKhoaDto> GetTietDayTheoKhoa(string namHoc) =>
        _repository.GetTietDayTheoKhoa(namHoc);

    public List<SangKienTheoGiangVienDto> GetSangKienTheoGiangVien() =>
        _repository.GetSangKienTheoGiangVien();

    public List<GiaiThuongTheoKhoaDto> GetGiaiThuongTheoKhoa() => _repository.GetGiaiThuong();

    public List<ThamGiaHoiDongDto> GetThamGiaHoiDong() => _repository.GetThamGiaHoiDong();

    public List<TongHopHoiGiangDto> GetTongHopHoiGiang(string nam) => _repository.GetTongHopHoiGiang(nam);
}
