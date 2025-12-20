using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;

namespace FrmQLHoiGiang.Forms;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
        dialog.Parent = this;
        WindowState = FormWindowState.Maximized;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            DialogHelper.ShowWarning(this, "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
            return;
        }

        var success = AppServices.Auth.Login(txtUsername.Text.Trim(), txtPassword.Text);
        if (!success)
        {
            DialogHelper.ShowWarning(this, "Thông tin đăng nhập không chính xác.");
            return;
        }

        Hide();
        using var main = new FrmMain();
        main.ShowDialog();
        Close();
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        ActiveControl = txtUsername;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void controlBoxClose_Click(object sender, EventArgs e)
    {

    }
}
