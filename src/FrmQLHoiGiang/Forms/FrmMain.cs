using FrmQLHoiGiang.Controls;
using FrmQLHoiGiang.Services;

namespace FrmQLHoiGiang.Forms;

public partial class FrmMain : Form
{
    private readonly Dictionary<string, UserControl> _modules = new();

    public FrmMain()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
        lblUser.Text = AppServices.Auth.CurrentUser?.HoTen ?? "test";
        RegisterModules();
        LoadModule("GV");
    }

    private void RegisterModules()
    {
        _modules["GV"] = new UcGiangVien();
        _modules["KHOA"] = new UcKhoa();
        _modules["BM"] = new UcDonVi();
        _modules["HG"] = new UcHoiGiang();
        _modules["SK"] = new UcSangKien();
        _modules["LG"] = new UcLichGiang();
        _modules["TK"] = new UcBaoCao();
    }

    private void LoadModule(string key)
    {
        if (!_modules.TryGetValue(key, out var control))
        {
            return;
        }

        panelContainer.Controls.Clear();
        control.Dock = DockStyle.Fill;
        panelContainer.Controls.Add(control);
        HighlightButton(key);
    }

    private void HighlightButton(string key)
    {
        foreach (Control ctrl in panelMenu.Controls)
        {
            if (ctrl is Siticone.Desktop.UI.WinForms.SiticoneButton btn)
            {
                btn.FillColor = btn.Tag?.ToString() == key
                    ? Color.FromArgb(31, 122, 224)
                    : Color.White;
                btn.ForeColor = btn.Tag?.ToString() == key
                    ? Color.White
                    : Color.FromArgb(64, 64, 64);
            }
        }
    }

    private void btnGiangVien_Click(object sender, EventArgs e) => LoadModule("GV");
    private void btnKhoa_Click(object sender, EventArgs e) => LoadModule("KHOA");
    private void btnBoMon_Click(object sender, EventArgs e) => LoadModule("BM");
    private void btnHoiGiang_Click(object sender, EventArgs e) => LoadModule("HG");
    private void btnSangKien_Click(object sender, EventArgs e) => LoadModule("SK");
    private void btnLichGiang_Click(object sender, EventArgs e) => LoadModule("LG");
    private void btnThongKe_Click(object sender, EventArgs e) => LoadModule("TK");

    private void panelContainer_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panelMenu_Paint(object sender, PaintEventArgs e)
    {

    }
}
