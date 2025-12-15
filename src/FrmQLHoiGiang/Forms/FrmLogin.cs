using FrmQLHoiGiang.Services;

namespace FrmQLHoiGiang.Forms;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            dialog.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
            dialog.Show();
            return;
        }

        var success = AppServices.Auth.Login(txtUsername.Text.Trim(), txtPassword.Text);
        if (!success)
        {
            dialog.Text = "Thông tin đăng nhập không chính xác.";
            dialog.Show();
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
