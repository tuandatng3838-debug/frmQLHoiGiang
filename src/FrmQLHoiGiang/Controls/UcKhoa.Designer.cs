namespace FrmQLHoiGiang.Controls;

partial class UcKhoa
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
        gridKhoa = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colTenKhoa = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        txtTenKhoa = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain = new TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)gridKhoa).BeginInit();
        panelRight.SuspendLayout();
        panelLeft.SuspendLayout();
        layoutMain.SuspendLayout();
        SuspendLayout();
        // 
        // gridKhoa
        // 
        gridKhoa.AllowUserToAddRows = false;
        gridKhoa.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridKhoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridKhoa.ColumnHeadersHeight = 45;
        gridKhoa.Columns.AddRange(new DataGridViewColumn[] { colTenKhoa });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridKhoa.DefaultCellStyle = dataGridViewCellStyle3;
        gridKhoa.GridColor = Color.FromArgb(231, 229, 255);
        gridKhoa.Location = new Point(13, 82);
        gridKhoa.Margin = new Padding(3, 4, 3, 4);
        gridKhoa.MultiSelect = false;
        gridKhoa.Name = "gridKhoa";
        gridKhoa.ReadOnly = true;
        gridKhoa.RowHeadersVisible = false;
        gridKhoa.RowHeadersWidth = 51;
        gridKhoa.RowTemplate.Height = 32;
        gridKhoa.Size = new Size(1126, 736);
        gridKhoa.TabIndex = 0;
        gridKhoa.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridKhoa.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridKhoa.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridKhoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridKhoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridKhoa.ThemeStyle.BackColor = Color.White;
        gridKhoa.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridKhoa.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridKhoa.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridKhoa.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        gridKhoa.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridKhoa.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridKhoa.ThemeStyle.HeaderStyle.Height = 45;
        gridKhoa.ThemeStyle.ReadOnly = true;
        gridKhoa.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridKhoa.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridKhoa.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridKhoa.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridKhoa.ThemeStyle.RowsStyle.Height = 32;
        gridKhoa.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridKhoa.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridKhoa.CellClick += gridKhoa_CellClick;
        // 
        // colTenKhoa
        // 
        colTenKhoa.DataPropertyName = "Name";
        colTenKhoa.HeaderText = "KHOA";
        colTenKhoa.MinimumWidth = 6;
        colTenKhoa.Name = "colTenKhoa";
        colTenKhoa.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(txtTenKhoa);
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
        // txtTenKhoa
        // 
        txtTenKhoa.BorderRadius = 8;
        txtTenKhoa.DefaultText = "";
        txtTenKhoa.Font = new Font("Segoe UI", 16F);
        txtTenKhoa.Location = new Point(23, 48);
        txtTenKhoa.Margin = new Padding(5, 6, 5, 6);
        txtTenKhoa.Name = "txtTenKhoa";
        txtTenKhoa.PasswordChar = '\0';
        txtTenKhoa.PlaceholderText = "Tên khoa";
        txtTenKhoa.SelectedText = "";
        txtTenKhoa.Size = new Size(430, 56);
        txtTenKhoa.TabIndex = 0;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(255, 76, 76);
        btnXoa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(210, 130);
        btnXoa.Margin = new Padding(3, 4, 3, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(150, 60);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa";
        btnXoa.Click += btnXoa_Click;
        // 
        // btnHuy
        // 
        btnHuy.BorderRadius = 8;
        btnHuy.FillColor = Color.Gray;
        btnHuy.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(383, 130);
        btnHuy.Margin = new Padding(3, 4, 3, 4);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(150, 60);
        btnHuy.TabIndex = 3;
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
        btnLuu.Location = new Point(23, 130);
        btnLuu.Margin = new Padding(3, 4, 3, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(165, 60);
        btnLuu.TabIndex = 1;
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
        panelLeft.Controls.Add(gridKhoa);
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
        // UcKhoa
        // 
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        Controls.Add(layoutMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcKhoa";
        Size = new Size(1889, 1000);
        ((System.ComponentModel.ISupportInitialize)gridKhoa).EndInit();
        panelRight.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        layoutMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridKhoa;
    private DataGridViewTextBoxColumn colTenKhoa;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenKhoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private TableLayoutPanel layoutMain;
}
