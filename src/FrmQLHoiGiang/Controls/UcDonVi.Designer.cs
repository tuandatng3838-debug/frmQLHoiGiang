namespace FrmQLHoiGiang.Controls;

partial class UcDonVi
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        gridDonVi = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colTenDonVi = new DataGridViewTextBoxColumn();
        colKhoa = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        cboKhoa = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtTenDonVi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain = new TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)gridDonVi).BeginInit();
        panelRight.SuspendLayout();
        panelLeft.SuspendLayout();
        layoutMain.SuspendLayout();
        SuspendLayout();
        // 
        // gridDonVi
        // 
        gridDonVi.AllowUserToAddRows = false;
        gridDonVi.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridDonVi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridDonVi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridDonVi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridDonVi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridDonVi.ColumnHeadersHeight = 45;
        gridDonVi.Columns.AddRange(new DataGridViewColumn[] { colTenDonVi, colKhoa });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridDonVi.DefaultCellStyle = dataGridViewCellStyle3;
        gridDonVi.GridColor = Color.FromArgb(231, 229, 255);
        gridDonVi.Location = new Point(13, 82);
        gridDonVi.Margin = new Padding(3, 4, 3, 4);
        gridDonVi.MultiSelect = false;
        gridDonVi.Name = "gridDonVi";
        gridDonVi.ReadOnly = true;
        gridDonVi.RowHeadersVisible = false;
        gridDonVi.RowHeadersWidth = 51;
        gridDonVi.RowTemplate.Height = 32;
        gridDonVi.Size = new Size(1126, 736);
        gridDonVi.TabIndex = 0;
        gridDonVi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridDonVi.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridDonVi.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridDonVi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridDonVi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridDonVi.ThemeStyle.BackColor = Color.White;
        gridDonVi.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridDonVi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridDonVi.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridDonVi.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        gridDonVi.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridDonVi.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridDonVi.ThemeStyle.HeaderStyle.Height = 45;
        gridDonVi.ThemeStyle.ReadOnly = true;
        gridDonVi.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridDonVi.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridDonVi.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridDonVi.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridDonVi.ThemeStyle.RowsStyle.Height = 32;
        gridDonVi.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridDonVi.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridDonVi.CellClick += gridDonVi_CellClick;
        // 
        // colTenDonVi
        // 
        colTenDonVi.DataPropertyName = "Name";
        colTenDonVi.HeaderText = "BỘ MÔN";
        colTenDonVi.MinimumWidth = 6;
        colTenDonVi.Name = "colTenDonVi";
        colTenDonVi.ReadOnly = true;
        // 
        // colKhoa
        // 
        colKhoa.DataPropertyName = "Khoa";
        colKhoa.HeaderText = "KHOA";
        colKhoa.MinimumWidth = 6;
        colKhoa.Name = "colKhoa";
        colKhoa.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(cboKhoa);
        panelRight.Controls.Add(txtTenDonVi);
        panelRight.Controls.Add(btnXoa);
        panelRight.Controls.Add(btnHuy);
        panelRight.Controls.Add(btnLuu);
        panelRight.Dock = DockStyle.Fill;
        panelRight.FillColor = Color.White;
        panelRight.Location = new Point(1208, 24);
        panelRight.Margin = new Padding(24, 0, 0, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(18, 22, 18, 22);
        panelRight.Size = new Size(657, 952);
        panelRight.TabIndex = 2;
        // 
        // cboKhoa
        // 
        cboKhoa.BackColor = Color.Transparent;
        cboKhoa.BorderRadius = 8;
        cboKhoa.DrawMode = DrawMode.OwnerDrawFixed;
        cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhoa.FocusedColor = Color.Empty;
        cboKhoa.Font = new Font("Segoe UI", 16F);
        cboKhoa.ForeColor = Color.FromArgb(68, 88, 112);
        cboKhoa.FormattingEnabled = true;
        cboKhoa.ItemHeight = 30;
        cboKhoa.Location = new Point(23, 124);
        cboKhoa.Margin = new Padding(3, 4, 3, 4);
        cboKhoa.Name = "cboKhoa";
        cboKhoa.Size = new Size(430, 36);
        cboKhoa.TabIndex = 1;
        // 
        // txtTenDonVi
        // 
        txtTenDonVi.BorderRadius = 8;
        txtTenDonVi.DefaultText = "";
        txtTenDonVi.Font = new Font("Segoe UI", 16F);
        txtTenDonVi.Location = new Point(23, 48);
        txtTenDonVi.Margin = new Padding(5, 6, 5, 6);
        txtTenDonVi.Name = "txtTenDonVi";
        txtTenDonVi.PasswordChar = '\0';
        txtTenDonVi.PlaceholderText = "Tên bộ môn";
        txtTenDonVi.SelectedText = "";
        txtTenDonVi.Size = new Size(430, 56);
        txtTenDonVi.TabIndex = 0;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(255, 76, 76);
        btnXoa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(210, 190);
        btnXoa.Margin = new Padding(3, 4, 3, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(150, 60);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.Click += btnXoa_Click;
        // 
        // btnHuy
        // 
        btnHuy.BorderRadius = 8;
        btnHuy.FillColor = Color.Gray;
        btnHuy.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(383, 190);
        btnHuy.Margin = new Padding(3, 4, 3, 4);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(150, 60);
        btnHuy.TabIndex = 4;
        btnHuy.Text = "Hủy";
        btnHuy.Visible = false;
        btnHuy.Click += btnHuy_Click;
        // 
        // btnLuu
        // 
        btnLuu.BorderRadius = 8;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLuu.ForeColor = Color.White;
        btnLuu.Location = new Point(23, 190);
        btnLuu.Margin = new Padding(3, 4, 3, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(165, 60);
        btnLuu.TabIndex = 2;
        btnLuu.Text = "Thêm mới";
        btnLuu.Click += btnLuu_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BorderRadius = 8;
        btnLamMoi.FillColor = Color.FromArgb(31, 122, 224);
        btnLamMoi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(13, 13);
        btnLamMoi.Margin = new Padding(3, 4, 3, 4);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(156, 52);
        btnLamMoi.TabIndex = 1;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // panelLeft
        // 
        panelLeft.BorderRadius = 12;
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.Controls.Add(gridDonVi);
        panelLeft.Dock = DockStyle.Fill;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(24, 24);
        panelLeft.Margin = new Padding(0, 0, 24, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(18, 22, 18, 22);
        panelLeft.Size = new Size(1160, 952);
        panelLeft.TabIndex = 0;
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
        // layoutMain
        // 
        layoutMain.BackColor = Color.FromArgb(245, 247, 250);
        layoutMain.ColumnCount = 2;
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
        layoutMain.Controls.Add(panelLeft, 0, 0);
        layoutMain.Controls.Add(panelRight, 1, 0);
        layoutMain.Dock = DockStyle.Fill;
        layoutMain.Location = new Point(0, 0);
        layoutMain.Margin = new Padding(0);
        layoutMain.Name = "layoutMain";
        layoutMain.Padding = new Padding(24);
        layoutMain.RowCount = 1;
        layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutMain.Size = new Size(1889, 1000);
        layoutMain.TabIndex = 4;
        // 
        // UcDonVi
        // 
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        Controls.Add(layoutMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcDonVi";
        Size = new Size(1889, 1000);
        ((System.ComponentModel.ISupportInitialize)gridDonVi).EndInit();
        panelRight.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        layoutMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridDonVi;
    private DataGridViewTextBoxColumn colTenDonVi;
    private DataGridViewTextBoxColumn colKhoa;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboKhoa;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenDonVi;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private TableLayoutPanel layoutMain;
}
