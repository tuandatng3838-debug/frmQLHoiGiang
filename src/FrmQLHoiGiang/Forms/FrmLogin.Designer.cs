namespace FrmQLHoiGiang.Forms;

partial class FrmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
        panelRoot = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        controlBoxMinimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        controlBoxClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        label3 = new Label();
        label2 = new Label();
        panelLogin = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        label1 = new Label();
        btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        panelRoot.SuspendLayout();
        panelLogin.SuspendLayout();
        SuspendLayout();
        // 
        // siticoneBorderlessForm1
        // 
        siticoneBorderlessForm1.BorderRadius = 12;
        siticoneBorderlessForm1.ContainerControl = this;
        siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
        siticoneBorderlessForm1.TransparentWhileDrag = true;
        // 
        // panelRoot
        // 
        panelRoot.Controls.Add(controlBoxMinimize);
        panelRoot.Controls.Add(controlBoxClose);
        panelRoot.Controls.Add(label3);
        panelRoot.Controls.Add(label2);
        panelRoot.Controls.Add(panelLogin);
        panelRoot.Dock = DockStyle.Fill;
        panelRoot.Location = new Point(0, 0);
        panelRoot.Margin = new Padding(4, 5, 4, 5);
        panelRoot.Name = "panelRoot";
        panelRoot.Padding = new Padding(58, 68, 58, 68);
        panelRoot.Size = new Size(1065, 700);
        panelRoot.TabIndex = 0;
        panelRoot.Paint += panelRoot_Paint;
        // 
        // controlBoxMinimize
        // 
        controlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxMinimize.BorderRadius = 4;
        controlBoxMinimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
        controlBoxMinimize.FillColor = Color.White;
        controlBoxMinimize.HoverState.FillColor = Color.FromArgb(236, 242, 255);
        controlBoxMinimize.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxMinimize.Location = new Point(910, 14);
        controlBoxMinimize.Margin = new Padding(2);
        controlBoxMinimize.Name = "controlBoxMinimize";
        controlBoxMinimize.Size = new Size(45, 35);
        controlBoxMinimize.TabIndex = 5;
        // 
        // controlBoxClose
        // 
        controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxClose.BorderRadius = 4;
        controlBoxClose.FillColor = Color.White;
        controlBoxClose.HoverState.FillColor = Color.FromArgb(240, 85, 68);
        controlBoxClose.HoverState.IconColor = Color.White;
        controlBoxClose.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxClose.Location = new Point(960, 14);
        controlBoxClose.Margin = new Padding(2);
        controlBoxClose.Name = "controlBoxClose";
        controlBoxClose.Size = new Size(45, 35);
        controlBoxClose.TabIndex = 4;
        controlBoxClose.Click += controlBoxClose_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.ForeColor = Color.FromArgb(64, 64, 64);
        label3.Location = new Point(61, 168);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(453, 32);
        label3.TabIndex = 2;
        label3.Text = "Quản lý hội giảng, sáng kiến và thống kê";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        label2.ForeColor = Color.FromArgb(31, 122, 224);
        label2.Location = new Point(15, 99);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(519, 54);
        label2.TabIndex = 1;
        label2.Text = "Học viện An ninh Nhân dân";
        label2.Click += label2_Click;
        // 
        // panelLogin
        // 
        panelLogin.BorderColor = Color.Gainsboro;
        panelLogin.BorderRadius = 16;
        panelLogin.BorderThickness = 1;
        panelLogin.Controls.Add(label1);
        panelLogin.Controls.Add(btnLogin);
        panelLogin.Controls.Add(txtPassword);
        panelLogin.Controls.Add(txtUsername);
        panelLogin.FillColor = Color.White;
        panelLogin.Location = new Point(572, 72);
        panelLogin.Margin = new Padding(4, 5, 4, 5);
        panelLogin.Name = "panelLogin";
        panelLogin.Padding = new Padding(34, 40, 34, 40);
        panelLogin.Size = new Size(421, 562);
        panelLogin.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(31, 122, 224);
        label1.Location = new Point(34, 40);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(157, 38);
        label1.TabIndex = 3;
        label1.Text = "Đăng nhập";
        // 
        // btnLogin
        // 
        btnLogin.BorderRadius = 8;
        btnLogin.DisabledState.BorderColor = Color.DarkGray;
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
        btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnLogin.FillColor = Color.FromArgb(31, 122, 224);
        btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(34, 356);
        btnLogin.Margin = new Padding(4, 5, 4, 5);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(349, 75);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Đăng nhập";
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.BorderRadius = 8;
        txtPassword.Cursor = Cursors.IBeam;
        txtPassword.DefaultText = "";
        txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPassword.Font = new Font("Segoe UI", 10F);
        txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPassword.Location = new Point(35, 230);
        txtPassword.Margin = new Padding(4, 8, 4, 8);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "Mật khẩu";
        txtPassword.SelectedText = "";
        txtPassword.Size = new Size(349, 75);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUsername
        // 
        txtUsername.BorderRadius = 8;
        txtUsername.Cursor = Cursors.IBeam;
        txtUsername.DefaultText = "";
        txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtUsername.Font = new Font("Segoe UI", 10F);
        txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtUsername.Location = new Point(34, 115);
        txtUsername.Margin = new Padding(4, 8, 4, 8);
        txtUsername.Name = "txtUsername";
        txtUsername.PasswordChar = '\0';
        txtUsername.PlaceholderText = "Tên đăng nhập";
        txtUsername.SelectedText = "";
        txtUsername.Size = new Size(349, 75);
        txtUsername.TabIndex = 0;
        // 
        // dialog
        // 
        dialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
        dialog.Caption = "Thông báo";
        dialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning;
        dialog.Parent = null;
        dialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
        dialog.Text = "message";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1065, 700);
        Controls.Add(panelRoot);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmLogin";
        Load += FrmLogin_Load;
        panelRoot.ResumeLayout(false);
        panelRoot.PerformLayout();
        panelLogin.ResumeLayout(false);
        panelLogin.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRoot;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxMinimize;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxClose;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLogin;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private Label label1;
    private Label label2;
    private Label label3;
}
