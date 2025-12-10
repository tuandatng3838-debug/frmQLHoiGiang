namespace FrmQLHoiGiang.Forms;

partial class FrmMain
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
        panelMenu = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        btnThongKe = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLichGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnSangKien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        flowHeaderTools = new FlowLayoutPanel();
        controlBoxClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        controlBoxMinimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        lblUser = new Label();
        label1 = new Label();
        panelContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        panelMenu.SuspendLayout();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // siticoneBorderlessForm1
        // 
        siticoneBorderlessForm1.ContainerControl = this;
        siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
        siticoneBorderlessForm1.TransparentWhileDrag = true;
        // 
        // panelMenu
        // 
        panelMenu.BackColor = Color.White;
        panelMenu.Controls.Add(btnThongKe);
        panelMenu.Controls.Add(btnLichGiang);
        panelMenu.Controls.Add(btnSangKien);
        panelMenu.Controls.Add(btnHoiGiang);
        panelMenu.Controls.Add(btnGiangVien);
        panelMenu.Dock = DockStyle.Left;
        panelMenu.FillColor = Color.FromArgb(245, 247, 250);
        panelMenu.Location = new Point(0, 0);
        panelMenu.Margin = new Padding(4, 5, 4, 5);
        panelMenu.Name = "panelMenu";
        panelMenu.Padding = new Padding(23, 53, 23, 27);
        panelMenu.Size = new Size(314, 1067);
        panelMenu.TabIndex = 0;
        // 
        // btnThongKe
        // 
        btnThongKe.BorderRadius = 8;
        btnThongKe.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnThongKe.FillColor = Color.White;
        btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnThongKe.ForeColor = Color.FromArgb(64, 64, 64);
        btnThongKe.Location = new Point(23, 580);
        btnThongKe.Margin = new Padding(4, 5, 4, 5);
        btnThongKe.Name = "btnThongKe";
        btnThongKe.Size = new Size(269, 75);
        btnThongKe.TabIndex = 4;
        btnThongKe.Tag = "TK";
        btnThongKe.Text = "Thống kê";
        btnThongKe.Click += btnThongKe_Click;
        // 
        // btnLichGiang
        // 
        btnLichGiang.BorderRadius = 8;
        btnLichGiang.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnLichGiang.FillColor = Color.White;
        btnLichGiang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLichGiang.ForeColor = Color.FromArgb(64, 64, 64);
        btnLichGiang.Location = new Point(23, 475);
        btnLichGiang.Margin = new Padding(4, 5, 4, 5);
        btnLichGiang.Name = "btnLichGiang";
        btnLichGiang.Size = new Size(269, 75);
        btnLichGiang.TabIndex = 3;
        btnLichGiang.Tag = "LG";
        btnLichGiang.Text = "Lịch giảng dạy";
        btnLichGiang.Click += btnLichGiang_Click;
        // 
        // btnSangKien
        // 
        btnSangKien.BorderRadius = 8;
        btnSangKien.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnSangKien.FillColor = Color.White;
        btnSangKien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSangKien.ForeColor = Color.FromArgb(64, 64, 64);
        btnSangKien.Location = new Point(23, 370);
        btnSangKien.Margin = new Padding(4, 5, 4, 5);
        btnSangKien.Name = "btnSangKien";
        btnSangKien.Size = new Size(269, 75);
        btnSangKien.TabIndex = 2;
        btnSangKien.Tag = "SK";
        btnSangKien.Text = "Sáng kiến - cải tiến";
        btnSangKien.Click += btnSangKien_Click;
        // 
        // btnHoiGiang
        // 
        btnHoiGiang.BorderRadius = 8;
        btnHoiGiang.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnHoiGiang.FillColor = Color.White;
        btnHoiGiang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnHoiGiang.ForeColor = Color.FromArgb(64, 64, 64);
        btnHoiGiang.Location = new Point(23, 265);
        btnHoiGiang.Margin = new Padding(4, 5, 4, 5);
        btnHoiGiang.Name = "btnHoiGiang";
        btnHoiGiang.Size = new Size(269, 75);
        btnHoiGiang.TabIndex = 1;
        btnHoiGiang.Tag = "HG";
        btnHoiGiang.Text = "Hội giảng";
        btnHoiGiang.Click += btnHoiGiang_Click;
        // 
        // btnGiangVien
        // 
        btnGiangVien.BorderRadius = 8;
        btnGiangVien.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnGiangVien.Checked = true;
        btnGiangVien.FillColor = Color.White;
        btnGiangVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGiangVien.ForeColor = Color.FromArgb(64, 64, 64);
        btnGiangVien.Location = new Point(23, 160);
        btnGiangVien.Margin = new Padding(4, 5, 4, 5);
        btnGiangVien.Name = "btnGiangVien";
        btnGiangVien.Size = new Size(269, 75);
        btnGiangVien.TabIndex = 0;
        btnGiangVien.Tag = "GV";
        btnGiangVien.Text = "Cán bộ - giảng viên";
        btnGiangVien.Click += btnGiangVien_Click;
        // 
        // flowHeaderTools
        // 
        flowHeaderTools.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        flowHeaderTools.AutoSize = true;
        flowHeaderTools.BackColor = Color.Transparent;
        flowHeaderTools.FlowDirection = FlowDirection.RightToLeft;
        flowHeaderTools.Location = new Point(940, 33);
        flowHeaderTools.Margin = new Padding(0);
        flowHeaderTools.Name = "flowHeaderTools";
        flowHeaderTools.Padding = new Padding(0);
        flowHeaderTools.Size = new Size(0, 0);
        flowHeaderTools.TabIndex = 4;
        flowHeaderTools.WrapContents = false;
        flowHeaderTools.Controls.Add(controlBoxClose);
        flowHeaderTools.Controls.Add(controlBoxMinimize);
        flowHeaderTools.Controls.Add(lblUser);
        // 
        // panelHeader
        // 
        panelHeader.Controls.Add(flowHeaderTools);
        panelHeader.Controls.Add(label1);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.FillColor = Color.White;
        panelHeader.Location = new Point(314, 0);
        panelHeader.Margin = new Padding(4, 5, 4, 5);
        panelHeader.Name = "panelHeader";
        panelHeader.Padding = new Padding(34, 20, 34, 20);
        panelHeader.Size = new Size(1400, 131);
        panelHeader.TabIndex = 1;
        // 
        // controlBoxClose
        // 
        controlBoxClose.BorderRadius = 4;
        controlBoxClose.FillColor = Color.White;
        controlBoxClose.HoverState.FillColor = Color.FromArgb(240, 85, 68);
        controlBoxClose.HoverState.IconColor = Color.White;
        controlBoxClose.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxClose.Name = "controlBoxClose";
        controlBoxClose.Size = new Size(64, 60);
        controlBoxClose.TabIndex = 2;
        // 
        // controlBoxMinimize
        // 
        controlBoxMinimize.BorderRadius = 4;
        controlBoxMinimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
        controlBoxMinimize.FillColor = Color.White;
        controlBoxMinimize.HoverState.FillColor = Color.FromArgb(236, 242, 255);
        controlBoxMinimize.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxMinimize.Name = "controlBoxMinimize";
        controlBoxMinimize.Size = new Size(64, 60);
        controlBoxMinimize.TabIndex = 3;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblUser.ForeColor = Color.FromArgb(31, 122, 224);
        lblUser.Location = new Point(0, 20);
        lblUser.Margin = new Padding(0, 20, 16, 0);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(70, 28);
        lblUser.TabIndex = 1;
        lblUser.Text = "Admin";
        lblUser.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(31, 122, 224);
        label1.Location = new Point(69, 60);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(247, 38);
        label1.TabIndex = 0;
        label1.Text = "Quản lý Hội giảng";
        // 
        // panelContainer
        // 
        panelContainer.Dock = DockStyle.Fill;
        panelContainer.FillColor = Color.White;
        panelContainer.Location = new Point(314, 131);
        panelContainer.Margin = new Padding(4, 5, 4, 5);
        panelContainer.Name = "panelContainer";
        panelContainer.Size = new Size(1400, 936);
        panelContainer.TabIndex = 2;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1714, 1067);
        Controls.Add(panelContainer);
        Controls.Add(panelHeader);
        Controls.Add(panelMenu);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(1714, 1067);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmMain";
        panelMenu.ResumeLayout(false);
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelMenu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnThongKe;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLichGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnSangKien;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelHeader;
    private FlowLayoutPanel flowHeaderTools;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxClose;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxMinimize;
    private Label lblUser;
    private Label label1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelContainer;
}
