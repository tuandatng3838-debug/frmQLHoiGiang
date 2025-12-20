namespace FrmQLHoiGiang.Controls;

partial class UcSangKien
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
        gridSangKien = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colTenSangKien = new DataGridViewTextBoxColumn();
        colGiangVien = new DataGridViewTextBoxColumn();
        colNamHoc = new DataGridViewTextBoxColumn();
        colLoai = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        cboXepLoai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtDiaDiem = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtThoiGian = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtNamHoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtLinhVuc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboLoai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboTuCach = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtTenSangKien = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienDienThoai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain = new TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)gridSangKien).BeginInit();
        panelRight.SuspendLayout();
        panelLeft.SuspendLayout();
        layoutMain.SuspendLayout();
        SuspendLayout();
        // 
        // gridSangKien
        // 
        gridSangKien.AllowUserToAddRows = false;
        gridSangKien.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridSangKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridSangKien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridSangKien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridSangKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridSangKien.ColumnHeadersHeight = 45;
        gridSangKien.Columns.AddRange(new DataGridViewColumn[] { colTenSangKien, colGiangVien, colNamHoc, colLoai });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridSangKien.DefaultCellStyle = dataGridViewCellStyle3;
        gridSangKien.GridColor = Color.FromArgb(231, 229, 255);
        gridSangKien.Location = new Point(13, 82);
        gridSangKien.Margin = new Padding(3, 4, 3, 4);
        gridSangKien.MultiSelect = false;
        gridSangKien.Name = "gridSangKien";
        gridSangKien.ReadOnly = true;
        gridSangKien.RowHeadersVisible = false;
        gridSangKien.RowHeadersWidth = 51;
        gridSangKien.RowTemplate.Height = 32;
        gridSangKien.Size = new Size(1126, 736);
        gridSangKien.TabIndex = 0;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridSangKien.ThemeStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridSangKien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridSangKien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridSangKien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridSangKien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridSangKien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridSangKien.ThemeStyle.HeaderStyle.Height = 45;
        gridSangKien.ThemeStyle.ReadOnly = true;
        gridSangKien.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridSangKien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridSangKien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridSangKien.ThemeStyle.RowsStyle.Height = 32;
        gridSangKien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridSangKien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridSangKien.CellClick += gridSangKien_CellClick;
        // 
        // colTenSangKien
        // 
        colTenSangKien.DataPropertyName = "TenSangKien";
        colTenSangKien.HeaderText = "TÊN SÁNG KIẾN";
        colTenSangKien.MinimumWidth = 6;
        colTenSangKien.Name = "colTenSangKien";
        colTenSangKien.ReadOnly = true;
        // 
        // colGiangVien
        // 
        colGiangVien.DataPropertyName = "GiangVien";
        colGiangVien.HeaderText = "GIẢNG VIÊN";
        colGiangVien.MinimumWidth = 6;
        colGiangVien.Name = "colGiangVien";
        colGiangVien.ReadOnly = true;
        // 
        // colNamHoc
        // 
        colNamHoc.DataPropertyName = "NamHoc";
        colNamHoc.HeaderText = "NĂM HỌC";
        colNamHoc.MinimumWidth = 6;
        colNamHoc.Name = "colNamHoc";
        colNamHoc.ReadOnly = true;
        // 
        // colLoai
        // 
        colLoai.DataPropertyName = "Loai";
        colLoai.HeaderText = "LOẠI";
        colLoai.MinimumWidth = 6;
        colLoai.Name = "colLoai";
        colLoai.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.AutoScroll = true;
        panelRight.AutoSize = false;
        panelRight.BackColor = Color.White;
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(cboXepLoai);
        panelRight.Controls.Add(txtDiaDiem);
        panelRight.Controls.Add(txtThoiGian);
        panelRight.Controls.Add(txtNamHoc);
        panelRight.Controls.Add(txtLinhVuc);
        panelRight.Controls.Add(cboLoai);
        panelRight.Controls.Add(cboTuCach);
        panelRight.Controls.Add(cboGiangVien);
        panelRight.Controls.Add(txtGiangVienNgaySinh);
        panelRight.Controls.Add(txtGiangVienDienThoai);
        panelRight.Controls.Add(txtGiangVienEmail);
        panelRight.Controls.Add(txtTenSangKien);
        panelRight.Controls.Add(btnXoa);
        panelRight.Controls.Add(btnHuy);
        panelRight.Controls.Add(btnLuu);
        panelRight.FillColor = Color.White;
        panelRight.Dock = DockStyle.Fill;
        panelRight.Location = new Point(0, 0);
        panelRight.Margin = new Padding(24, 0, 0, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(18, 21, 18, 21);
        panelRight.Size = new Size(681, 952);
        panelRight.TabIndex = 1;
        panelRight.Paint += panelRight_Paint;
        // 
        // cboXepLoai
        // 
        cboXepLoai.BackColor = Color.Transparent;
        cboXepLoai.BorderRadius = 8;
        cboXepLoai.DrawMode = DrawMode.OwnerDrawFixed;
        cboXepLoai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboXepLoai.FocusedColor = Color.Empty;
        cboXepLoai.Font = new Font("Segoe UI", 16F);
        cboXepLoai.ForeColor = Color.FromArgb(68, 88, 112);
        cboXepLoai.ItemHeight = 30;
        cboXepLoai.Items.AddRange(new object[] { "Khá", "Tốt", "Xuất sắc" });
        cboXepLoai.Location = new Point(21, 752);
        cboXepLoai.Margin = new Padding(3, 4, 3, 4);
        cboXepLoai.Name = "cboXepLoai";
        cboXepLoai.Size = new Size(319, 36);
        cboXepLoai.TabIndex = 10;
        // 
        // txtDiaDiem
        // 
        txtDiaDiem.BorderRadius = 8;
        txtDiaDiem.DefaultText = "";
        txtDiaDiem.Font = new Font("Segoe UI", 16F);
        txtDiaDiem.Location = new Point(21, 680);
        txtDiaDiem.Margin = new Padding(3, 5, 3, 5);
        txtDiaDiem.Name = "txtDiaDiem";
        txtDiaDiem.PasswordChar = '\0';
        txtDiaDiem.PlaceholderText = "Địa điểm / phạm vi";
        txtDiaDiem.SelectedText = "";
        txtDiaDiem.Size = new Size(411, 60);
        txtDiaDiem.TabIndex = 9;
        // 
        // txtThoiGian
        // 
        txtThoiGian.BorderRadius = 8;
        txtThoiGian.DefaultText = "";
        txtThoiGian.Font = new Font("Segoe UI", 16F);
        txtThoiGian.Location = new Point(21, 609);
        txtThoiGian.Margin = new Padding(3, 5, 3, 5);
        txtThoiGian.Name = "txtThoiGian";
        txtThoiGian.PasswordChar = '\0';
        txtThoiGian.PlaceholderText = "Thời gian thực hiện";
        txtThoiGian.SelectedText = "";
        txtThoiGian.Size = new Size(411, 60);
        txtThoiGian.TabIndex = 8;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.DefaultText = "";
        txtNamHoc.Font = new Font("Segoe UI", 16F);
        txtNamHoc.Location = new Point(21, 538);
        txtNamHoc.Margin = new Padding(3, 5, 3, 5);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PasswordChar = '\0';
        txtNamHoc.PlaceholderText = "Năm học";
        txtNamHoc.SelectedText = "";
        txtNamHoc.Size = new Size(192, 60);
        txtNamHoc.TabIndex = 7;
        // 
        // txtLinhVuc
        // 
        txtLinhVuc.BorderRadius = 8;
        txtLinhVuc.DefaultText = "";
        txtLinhVuc.Font = new Font("Segoe UI", 16F);
        txtLinhVuc.Location = new Point(21, 468);
        txtLinhVuc.Margin = new Padding(3, 5, 3, 5);
        txtLinhVuc.Name = "txtLinhVuc";
        txtLinhVuc.PasswordChar = '\0';
        txtLinhVuc.PlaceholderText = "Lĩnh vực";
        txtLinhVuc.SelectedText = "";
        txtLinhVuc.Size = new Size(411, 60);
        txtLinhVuc.TabIndex = 6;
        // 
        // cboLoai
        // 
        cboLoai.BackColor = Color.Transparent;
        cboLoai.BorderRadius = 8;
        cboLoai.DrawMode = DrawMode.OwnerDrawFixed;
        cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoai.FocusedColor = Color.Empty;
        cboLoai.Font = new Font("Segoe UI", 16F);
        cboLoai.ForeColor = Color.FromArgb(68, 88, 112);
        cboLoai.ItemHeight = 30;
        cboLoai.Items.AddRange(new object[] { "Sáng kiến", "Cải tiến" });
        cboLoai.Location = new Point(254, 406);
        cboLoai.Margin = new Padding(3, 4, 3, 4);
        cboLoai.Name = "cboLoai";
        cboLoai.Size = new Size(178, 36);
        cboLoai.TabIndex = 5;
        // 
        // cboTuCach
        // 
        cboTuCach.BackColor = Color.Transparent;
        cboTuCach.BorderRadius = 8;
        cboTuCach.DrawMode = DrawMode.OwnerDrawFixed;
        cboTuCach.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTuCach.FocusedColor = Color.Empty;
        cboTuCach.Font = new Font("Segoe UI", 16F);
        cboTuCach.ForeColor = Color.FromArgb(68, 88, 112);
        cboTuCach.ItemHeight = 30;
        cboTuCach.Items.AddRange(new object[] { "Tác giả", "Đồng tác giả" });
        cboTuCach.Location = new Point(21, 406);
        cboTuCach.Margin = new Padding(3, 4, 3, 4);
        cboTuCach.Name = "cboTuCach";
        cboTuCach.Size = new Size(205, 36);
        cboTuCach.TabIndex = 4;
        // 
        // cboGiangVien
        // 
        cboGiangVien.BackColor = Color.Transparent;
        cboGiangVien.BorderRadius = 8;
        cboGiangVien.DrawMode = DrawMode.OwnerDrawFixed;
        cboGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGiangVien.FocusedColor = Color.Empty;
        cboGiangVien.Font = new Font("Segoe UI", 16F);
        cboGiangVien.ForeColor = Color.FromArgb(68, 88, 112);
        cboGiangVien.ItemHeight = 30;
        cboGiangVien.Location = new Point(21, 152);
        cboGiangVien.Margin = new Padding(3, 4, 3, 4);
        cboGiangVien.Name = "cboGiangVien";
        cboGiangVien.Size = new Size(411, 36);
        cboGiangVien.TabIndex = 3;
        // 
        // txtGiangVienEmail
        // 
        txtGiangVienEmail.BorderRadius = 8;
        txtGiangVienEmail.DefaultText = "";
        txtGiangVienEmail.Font = new Font("Segoe UI", 16F);
        txtGiangVienEmail.Location = new Point(21, 208);
        txtGiangVienEmail.Margin = new Padding(3, 5, 3, 5);
        txtGiangVienEmail.Name = "txtGiangVienEmail";
        txtGiangVienEmail.PasswordChar = '\0';
        txtGiangVienEmail.PlaceholderText = "Email";
        txtGiangVienEmail.ReadOnly = true;
        txtGiangVienEmail.SelectedText = "";
        txtGiangVienEmail.Size = new Size(411, 54);
        txtGiangVienEmail.TabIndex = 11;
        // 
        // txtGiangVienDienThoai
        // 
        txtGiangVienDienThoai.BorderRadius = 8;
        txtGiangVienDienThoai.DefaultText = "";
        txtGiangVienDienThoai.Font = new Font("Segoe UI", 16F);
        txtGiangVienDienThoai.Location = new Point(21, 274);
        txtGiangVienDienThoai.Margin = new Padding(3, 5, 3, 5);
        txtGiangVienDienThoai.Name = "txtGiangVienDienThoai";
        txtGiangVienDienThoai.PasswordChar = '\0';
        txtGiangVienDienThoai.PlaceholderText = "So dien thoai";
        txtGiangVienDienThoai.ReadOnly = true;
        txtGiangVienDienThoai.SelectedText = "";
        txtGiangVienDienThoai.Size = new Size(411, 54);
        txtGiangVienDienThoai.TabIndex = 12;
        // 
        // txtGiangVienNgaySinh
        // 
        txtGiangVienNgaySinh.BorderRadius = 8;
        txtGiangVienNgaySinh.DefaultText = "";
        txtGiangVienNgaySinh.Font = new Font("Segoe UI", 16F);
        txtGiangVienNgaySinh.Location = new Point(21, 340);
        txtGiangVienNgaySinh.Margin = new Padding(3, 5, 3, 5);
        txtGiangVienNgaySinh.Name = "txtGiangVienNgaySinh";
        txtGiangVienNgaySinh.PasswordChar = '\0';
        txtGiangVienNgaySinh.PlaceholderText = "Ngay sinh";
        txtGiangVienNgaySinh.ReadOnly = true;
        txtGiangVienNgaySinh.SelectedText = "";
        txtGiangVienNgaySinh.Size = new Size(411, 54);
        txtGiangVienNgaySinh.TabIndex = 13;
        // 
        // txtTenSangKien
        // 
        txtTenSangKien.BorderRadius = 8;
        txtTenSangKien.DefaultText = "";
        txtTenSangKien.Font = new Font("Segoe UI", 16F);
        txtTenSangKien.Location = new Point(21, 82);
        txtTenSangKien.Margin = new Padding(3, 5, 3, 5);
        txtTenSangKien.Name = "txtTenSangKien";
        txtTenSangKien.PasswordChar = '\0';
        txtTenSangKien.PlaceholderText = "Tên sáng kiến";
        txtTenSangKien.SelectedText = "";
        txtTenSangKien.Size = new Size(411, 60);
        txtTenSangKien.TabIndex = 2;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(250, 60, 76);
        btnXoa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(202, 826);
        btnXoa.Margin = new Padding(3, 4, 3, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(160, 60);
        btnXoa.TabIndex = 1;
        btnXoa.Text = "Xóa";
        btnXoa.Click += btnXoa_Click;
        // 
        // btnHuy
        // 
        btnHuy.BorderRadius = 8;
        btnHuy.FillColor = Color.Gray;
        btnHuy.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(374, 826);
        btnHuy.Margin = new Padding(3, 4, 3, 4);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(160, 60);
        btnHuy.TabIndex = 0;
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
        btnLuu.Location = new Point(21, 826);
        btnLuu.Margin = new Padding(3, 4, 3, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(160, 60);
        btnLuu.TabIndex = 0;
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
        btnLamMoi.TabIndex = 2;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // panelLeft
        // 
        panelLeft.Controls.Add(gridSangKien);
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.BorderRadius = 12;
        panelLeft.Dock = DockStyle.Fill;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(24, 24);
        panelLeft.Margin = new Padding(0);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(18, 22, 18, 22);
        panelLeft.Size = new Size(1160, 952);
        panelLeft.TabIndex = 3;
        // 
        // layoutMain
        // 
        layoutMain.BackColor = Color.FromArgb(245, 247, 250);
        layoutMain.ColumnCount = 2;
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
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
        // dialog
        // 
        dialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
        dialog.Caption = "Thông báo";
        dialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning;
        dialog.Parent = null;
        dialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
        dialog.Text = "message";
        // 
        // UcSangKien
        // 
        AutoScaleMode = AutoScaleMode.None;
        layoutMain.Controls.Add(panelLeft, 0, 0);
        layoutMain.Controls.Add(panelRight, 1, 0);
        Controls.Add(layoutMain);
        BackColor = Color.FromArgb(245, 247, 250);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcSangKien";
        Size = new Size(1889, 1000);
        Load += UcSangKien_Load;
        ((System.ComponentModel.ISupportInitialize)gridSangKien).EndInit();
        panelRight.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        layoutMain.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridSangKien;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboXepLoai;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiaDiem;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtThoiGian;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNamHoc;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLinhVuc;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboLoai;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboTuCach;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenSangKien;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienNgaySinh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienDienThoai;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienEmail;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private DataGridViewTextBoxColumn colTenSangKien;
    private DataGridViewTextBoxColumn colGiangVien;
    private DataGridViewTextBoxColumn colNamHoc;
    private DataGridViewTextBoxColumn colLoai;
    private TableLayoutPanel layoutMain;
}
