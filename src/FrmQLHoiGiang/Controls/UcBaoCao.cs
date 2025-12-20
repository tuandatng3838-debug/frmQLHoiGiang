using FrmQLHoiGiang.Services;

namespace FrmQLHoiGiang.Controls;

public partial class UcBaoCao : UserControl
{
    public UcBaoCao()
    {
        InitializeComponent();
        txtNamHoc.Text = DateTime.Now.Year.ToString();
        LoadThongKe();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    private void btnTaiBaoCao_Click(object sender, EventArgs e)
    {
        LoadThongKe();
    }

    private void LoadThongKe()
    {
        var namHoc = txtNamHoc.Text.Trim();
        if (string.IsNullOrWhiteSpace(namHoc))
        {
            namHoc = DateTime.Now.Year.ToString();
        }

        gridTietGV.DataSource = AppServices.ThongKe.GetTietDayTheoGiangVien(namHoc);
        gridTietKhoa.DataSource = AppServices.ThongKe.GetTietDayTheoKhoa(namHoc);
        gridSangKien.DataSource = AppServices.ThongKe.GetSangKienTheoGiangVien();
        gridGiaiThuong.DataSource = AppServices.ThongKe.GetGiaiThuongTheoKhoa();
        gridHoiDong.DataSource = AppServices.ThongKe.GetThamGiaHoiDong();
        gridHoiGiang.DataSource = AppServices.ThongKe.GetTongHopHoiGiang(namHoc);
    }

    private void HandleGiangVienChanged()
    {
        LoadThongKe();
    }

    private void panelTop_Paint(object sender, PaintEventArgs e)
    {

    }

    private void gridTietGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
