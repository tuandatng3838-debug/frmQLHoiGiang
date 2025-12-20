namespace FrmQLHoiGiang.Controls;

partial class UcHoiGiang
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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        btnRefreshHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        gridHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colTenBai = new DataGridViewTextBoxColumn();
        colGiangVien = new DataGridViewTextBoxColumn();
        colThoiGian = new DataGridViewTextBoxColumn();
        colCap = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        tabMain = new TabControl();
        tabDangKy = new TabPage();
        btnTaoMoiHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuuHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnXoaHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        cboCapThucHien = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        dtThoiGian = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
        txtLop = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtTenBai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboHocPhan = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtGiangVienChucDanh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienCapBac = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienDonVi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienDienThoai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtGiangVienEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        tabHoiDong = new TabPage();
        btnLuuHoiDong = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHoiDongLoad = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtTenHoiDong = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboThanhVien5 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboThanhVien4 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboThanhVien3 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboThanhVien2 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboThanhVien1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboHoiDongBai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        tabKetQua = new TabPage();
        btnLuuKetQua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnTinhKetQua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLoadKetQua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtXepLoai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtTongDiem = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThucHanh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemHoSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemHieuBiet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThanhVien1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThanhVien2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThanhVien3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThanhVien4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDiemThanhVien5 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboKetQuaBai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain = new TableLayoutPanel();
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHoiGiang).BeginInit();
        panelRight.SuspendLayout();
        tabMain.SuspendLayout();
        tabDangKy.SuspendLayout();
        tabHoiDong.SuspendLayout();
        tabKetQua.SuspendLayout();
        layoutMain.SuspendLayout();
        SuspendLayout();
        // 
        // panelLeft
        // 
        panelLeft.BorderRadius = 12;
        panelLeft.Controls.Add(btnRefreshHoiGiang);
        panelLeft.Controls.Add(gridHoiGiang);
        panelLeft.Dock = DockStyle.Fill;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(24, 24);
        panelLeft.Margin = new Padding(0, 0, 24, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(18, 22, 18, 22);
        panelLeft.Size = new Size(1073, 806);
        panelLeft.TabIndex = 0;
        panelLeft.Paint += panelLeft_Paint;
        // 
        // btnRefreshHoiGiang
        // 
        btnRefreshHoiGiang.BorderRadius = 8;
        btnRefreshHoiGiang.FillColor = Color.FromArgb(31, 122, 224);
        btnRefreshHoiGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnRefreshHoiGiang.ForeColor = Color.White;
        btnRefreshHoiGiang.Location = new Point(13, 13);
        btnRefreshHoiGiang.Margin = new Padding(3, 4, 3, 4);
        btnRefreshHoiGiang.Name = "btnRefreshHoiGiang";
        btnRefreshHoiGiang.Size = new Size(156, 52);
        btnRefreshHoiGiang.TabIndex = 1;
        btnRefreshHoiGiang.Text = "Làm mới";
        btnRefreshHoiGiang.Click += btnRefreshHoiGiang_Click;
        // 
        // gridHoiGiang
        // 
        gridHoiGiang.AllowUserToAddRows = false;
        gridHoiGiang.AllowUserToDeleteRows = false;
        gridHoiGiang.AllowUserToResizeColumns = false;
        gridHoiGiang.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 163);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridHoiGiang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridHoiGiang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridHoiGiang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 163);
        dataGridViewCellStyle2.ForeColor = Color.Black;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridHoiGiang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridHoiGiang.ColumnHeadersHeight = 45;
        gridHoiGiang.Columns.AddRange(new DataGridViewColumn[] { colTenBai, colGiangVien, colThoiGian, colCap });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 163);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridHoiGiang.DefaultCellStyle = dataGridViewCellStyle3;
        gridHoiGiang.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.Location = new Point(13, 82);
        gridHoiGiang.Margin = new Padding(3, 4, 3, 4);
        gridHoiGiang.MultiSelect = false;
        gridHoiGiang.Name = "gridHoiGiang";
        gridHoiGiang.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 163);
        dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        gridHoiGiang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        gridHoiGiang.RowHeadersVisible = false;
        gridHoiGiang.RowHeadersWidth = 62;
        gridHoiGiang.RowTemplate.Height = 32;
        gridHoiGiang.Size = new Size(1060, 736);
        gridHoiGiang.TabIndex = 0;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridHoiGiang.ThemeStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridHoiGiang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridHoiGiang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridHoiGiang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridHoiGiang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridHoiGiang.ThemeStyle.HeaderStyle.Height = 45;
        gridHoiGiang.ThemeStyle.ReadOnly = true;
        gridHoiGiang.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridHoiGiang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridHoiGiang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridHoiGiang.ThemeStyle.RowsStyle.Height = 32;
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridHoiGiang.CellClick += gridHoiGiang_CellClick;
        gridHoiGiang.CellContentClick += gridHoiGiang_CellContentClick;
        // 
        // colTenBai
        // 
        colTenBai.DataPropertyName = "TenBai";
        colTenBai.HeaderText = "TÊN BÀI";
        colTenBai.MinimumWidth = 50;
        colTenBai.Name = "colTenBai";
        colTenBai.ReadOnly = true;
        // 
        // colGiangVien
        // 
        colGiangVien.DataPropertyName = "GiangVien";
        colGiangVien.HeaderText = "GIẢNG VIÊN";
        colGiangVien.MinimumWidth = 50;
        colGiangVien.Name = "colGiangVien";
        colGiangVien.ReadOnly = true;
        // 
        // colThoiGian
        // 
        colThoiGian.DataPropertyName = "ThoiGian";
        colThoiGian.HeaderText = "THỜI GIAN";
        colThoiGian.MinimumWidth = 50;
        colThoiGian.Name = "colThoiGian";
        colThoiGian.ReadOnly = true;
        // 
        // colCap
        // 
        colCap.DataPropertyName = "CapThucHien";
        colCap.HeaderText = "CẤP";
        colCap.MinimumWidth = 50;
        colCap.Name = "colCap";
        colCap.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(tabMain);
        panelRight.Dock = DockStyle.Fill;
        panelRight.FillColor = Color.White;
        panelRight.Location = new Point(1145, 24);
        panelRight.Margin = new Padding(24, 0, 0, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(12);
        panelRight.Size = new Size(568, 806);
        panelRight.TabIndex = 2;
        panelRight.Paint += panelRight_Paint;
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabDangKy);
        tabMain.Controls.Add(tabHoiDong);
        tabMain.Controls.Add(tabKetQua);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
        tabMain.ItemSize = new Size(100, 40);
        tabMain.Location = new Point(12, 12);
        tabMain.Margin = new Padding(3, 4, 3, 4);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(544, 782);
        tabMain.TabIndex = 1;
        // 
        // tabDangKy
        // 
        tabDangKy.AllowDrop = true;
        tabDangKy.BackColor = Color.White;
        tabDangKy.AutoScroll = true;
        tabDangKy.Controls.Add(btnXoaHoiGiang);
        tabDangKy.Controls.Add(btnTaoMoiHoiGiang);
        tabDangKy.Controls.Add(btnLuuHoiGiang);
        tabDangKy.Controls.Add(cboCapThucHien);
        tabDangKy.Controls.Add(dtThoiGian);
        tabDangKy.Controls.Add(txtLop);
        tabDangKy.Controls.Add(txtTenBai);
        tabDangKy.Controls.Add(cboHocPhan);
        tabDangKy.Controls.Add(txtGiangVienNgaySinh);
        tabDangKy.Controls.Add(txtGiangVienDienThoai);
        tabDangKy.Controls.Add(txtGiangVienEmail);
        tabDangKy.Controls.Add(txtGiangVienChucDanh);
        tabDangKy.Controls.Add(txtGiangVienCapBac);
        tabDangKy.Controls.Add(txtGiangVienDonVi);
        tabDangKy.Controls.Add(cboGiangVien);
        tabDangKy.Location = new Point(4, 44);
        tabDangKy.Margin = new Padding(3, 4, 3, 4);
        tabDangKy.Name = "tabDangKy";
        tabDangKy.Padding = new Padding(18, 22, 18, 22);
        tabDangKy.Size = new Size(536, 734);
        tabDangKy.TabIndex = 0;
        tabDangKy.Text = "Đăng ký";
        tabDangKy.Click += tabDangKy_Click;
        // 
        // btnTaoMoiHoiGiang
        // 
        btnTaoMoiHoiGiang.BorderRadius = 8;
        btnTaoMoiHoiGiang.FillColor = Color.Gray;
        btnTaoMoiHoiGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
        btnTaoMoiHoiGiang.ForeColor = Color.White;
        btnTaoMoiHoiGiang.Location = new Point(195, 792);
        btnTaoMoiHoiGiang.Margin = new Padding(3, 4, 3, 4);
        btnTaoMoiHoiGiang.Name = "btnTaoMoiHoiGiang";
        btnTaoMoiHoiGiang.Size = new Size(160, 60);
        btnTaoMoiHoiGiang.TabIndex = 7;
        btnTaoMoiHoiGiang.Text = "Reset";
        btnTaoMoiHoiGiang.Click += btnTaoMoiHoiGiang_Click;
        // 
        // btnLuuHoiGiang
        // 
        btnLuuHoiGiang.BorderRadius = 8;
        btnLuuHoiGiang.FillColor = Color.FromArgb(31, 122, 224);
        btnLuuHoiGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
        btnLuuHoiGiang.ForeColor = Color.White;
        btnLuuHoiGiang.Location = new Point(21, 792);
        btnLuuHoiGiang.Margin = new Padding(3, 4, 3, 4);
        btnLuuHoiGiang.Name = "btnLuuHoiGiang";
        btnLuuHoiGiang.Size = new Size(160, 59);
        btnLuuHoiGiang.TabIndex = 6;
        btnLuuHoiGiang.Text = "Thêm mới";
        btnLuuHoiGiang.Click += btnLuuHoiGiang_Click;
        // 
        // btnXoaHoiGiang
        // 
        btnXoaHoiGiang.BorderRadius = 8;
        btnXoaHoiGiang.FillColor = Color.FromArgb(255, 76, 76);
        btnXoaHoiGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
        btnXoaHoiGiang.ForeColor = Color.White;
        btnXoaHoiGiang.Location = new Point(369, 792);
        btnXoaHoiGiang.Margin = new Padding(3, 4, 3, 4);
        btnXoaHoiGiang.Name = "btnXoaHoiGiang";
        btnXoaHoiGiang.Size = new Size(160, 60);
        btnXoaHoiGiang.TabIndex = 8;
        btnXoaHoiGiang.Text = "Xóa";
        btnXoaHoiGiang.Click += btnXoaHoiGiang_Click;
        // 
        // cboCapThucHien
        // 
        cboCapThucHien.BackColor = Color.Transparent;
        cboCapThucHien.BorderRadius = 8;
        cboCapThucHien.DrawMode = DrawMode.OwnerDrawFixed;
        cboCapThucHien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCapThucHien.FocusedColor = Color.Empty;
        cboCapThucHien.Font = new Font("Segoe UI", 16F);
        cboCapThucHien.ForeColor = Color.FromArgb(68, 88, 112);
        cboCapThucHien.FormattingEnabled = true;
        cboCapThucHien.ItemHeight = 30;
        cboCapThucHien.Items.AddRange(new object[] { "Học viện", "Bộ" });
        cboCapThucHien.Location = new Point(19, 728);
        cboCapThucHien.Margin = new Padding(3, 4, 3, 4);
        cboCapThucHien.Name = "cboCapThucHien";
        cboCapThucHien.Size = new Size(292, 36);
        cboCapThucHien.TabIndex = 5;
        // 
        // dtThoiGian
        // 
        dtThoiGian.BorderRadius = 8;
        dtThoiGian.Checked = true;
        dtThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
        dtThoiGian.Font = new Font("Segoe UI", 16F);
        dtThoiGian.Format = DateTimePickerFormat.Custom;
        dtThoiGian.Location = new Point(18, 656);
        dtThoiGian.Margin = new Padding(3, 4, 3, 4);
        dtThoiGian.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
        dtThoiGian.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
        dtThoiGian.Name = "dtThoiGian";
        dtThoiGian.Size = new Size(293, 48);
        dtThoiGian.TabIndex = 4;
        dtThoiGian.Value = new DateTime(2025, 12, 10, 21, 3, 16, 278);
        // 
        // txtLop
        // 
        txtLop.BorderRadius = 8;
        txtLop.DefaultText = "";
        txtLop.Font = new Font("Segoe UI", 16F);
        txtLop.Location = new Point(16, 586);
        txtLop.Margin = new Padding(5, 6, 5, 6);
        txtLop.Name = "txtLop";
        txtLop.PasswordChar = '\0';
        txtLop.PlaceholderText = "Thực hiện tại lớp";
        txtLop.SelectedText = "";
        txtLop.Size = new Size(402, 60);
        txtLop.TabIndex = 3;
        // 
        // txtTenBai
        // 
        txtTenBai.BorderRadius = 8;
        txtTenBai.DefaultText = "";
        txtTenBai.Font = new Font("Segoe UI", 16F);
        txtTenBai.Location = new Point(17, 514);
        txtTenBai.Margin = new Padding(5, 6, 5, 6);
        txtTenBai.Name = "txtTenBai";
        txtTenBai.PasswordChar = '\0';
        txtTenBai.PlaceholderText = "Tên bài";
        txtTenBai.SelectedText = "";
        txtTenBai.Size = new Size(402, 60);
        txtTenBai.TabIndex = 2;
        // 
        // cboHocPhan
        // 
        cboHocPhan.BackColor = Color.Transparent;
        cboHocPhan.BorderRadius = 8;
        cboHocPhan.DrawMode = DrawMode.OwnerDrawFixed;
        cboHocPhan.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHocPhan.FocusedColor = Color.Empty;
        cboHocPhan.Font = new Font("Segoe UI", 16F);
        cboHocPhan.ForeColor = Color.FromArgb(68, 88, 112);
        cboHocPhan.ItemHeight = 30;
        cboHocPhan.Location = new Point(16, 468);
        cboHocPhan.Margin = new Padding(3, 4, 3, 4);
        cboHocPhan.Name = "cboHocPhan";
        cboHocPhan.Size = new Size(292, 36);
        cboHocPhan.TabIndex = 1;
        cboHocPhan.SelectedIndexChanged += cboHocPhan_SelectedIndexChanged;
        // 
        // txtGiangVienChucDanh
        // 
        txtGiangVienChucDanh.BorderRadius = 8;
        txtGiangVienChucDanh.DefaultText = "";
        txtGiangVienChucDanh.Font = new Font("Segoe UI", 16F);
        txtGiangVienChucDanh.Location = new Point(17, 204);
        txtGiangVienChucDanh.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienChucDanh.Name = "txtGiangVienChucDanh";
        txtGiangVienChucDanh.PasswordChar = '\0';
        txtGiangVienChucDanh.PlaceholderText = "Chức danh giảng dạy";
        txtGiangVienChucDanh.SelectedText = "";
        txtGiangVienChucDanh.Size = new Size(402, 54);
        txtGiangVienChucDanh.TabIndex = 9;
        // 
        // txtGiangVienEmail
        // 
        txtGiangVienEmail.BorderRadius = 8;
        txtGiangVienEmail.DefaultText = "";
        txtGiangVienEmail.Font = new Font("Segoe UI", 16F);
        txtGiangVienEmail.Location = new Point(17, 270);
        txtGiangVienEmail.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienEmail.Name = "txtGiangVienEmail";
        txtGiangVienEmail.PasswordChar = '\0';
        txtGiangVienEmail.PlaceholderText = "Email";
        txtGiangVienEmail.ReadOnly = true;
        txtGiangVienEmail.SelectedText = "";
        txtGiangVienEmail.Size = new Size(402, 54);
        txtGiangVienEmail.TabIndex = 10;
        // 
        // txtGiangVienDienThoai
        // 
        txtGiangVienDienThoai.BorderRadius = 8;
        txtGiangVienDienThoai.DefaultText = "";
        txtGiangVienDienThoai.Font = new Font("Segoe UI", 16F);
        txtGiangVienDienThoai.Location = new Point(17, 336);
        txtGiangVienDienThoai.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienDienThoai.Name = "txtGiangVienDienThoai";
        txtGiangVienDienThoai.PasswordChar = '\0';
        txtGiangVienDienThoai.PlaceholderText = "So dien thoai";
        txtGiangVienDienThoai.ReadOnly = true;
        txtGiangVienDienThoai.SelectedText = "";
        txtGiangVienDienThoai.Size = new Size(402, 54);
        txtGiangVienDienThoai.TabIndex = 11;
        // 
        // txtGiangVienNgaySinh
        // 
        txtGiangVienNgaySinh.BorderRadius = 8;
        txtGiangVienNgaySinh.DefaultText = "";
        txtGiangVienNgaySinh.Font = new Font("Segoe UI", 16F);
        txtGiangVienNgaySinh.Location = new Point(17, 402);
        txtGiangVienNgaySinh.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienNgaySinh.Name = "txtGiangVienNgaySinh";
        txtGiangVienNgaySinh.PasswordChar = '\0';
        txtGiangVienNgaySinh.PlaceholderText = "Ngay sinh";
        txtGiangVienNgaySinh.ReadOnly = true;
        txtGiangVienNgaySinh.SelectedText = "";
        txtGiangVienNgaySinh.Size = new Size(402, 54);
        txtGiangVienNgaySinh.TabIndex = 12;
        // 
        // txtGiangVienCapBac
        // 
        txtGiangVienCapBac.BorderRadius = 8;
        txtGiangVienCapBac.DefaultText = "";
        txtGiangVienCapBac.Font = new Font("Segoe UI", 16F);
        txtGiangVienCapBac.Location = new Point(18, 138);
        txtGiangVienCapBac.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienCapBac.Name = "txtGiangVienCapBac";
        txtGiangVienCapBac.PasswordChar = '\0';
        txtGiangVienCapBac.PlaceholderText = "Cấp bậc";
        txtGiangVienCapBac.SelectedText = "";
        txtGiangVienCapBac.Size = new Size(402, 54);
        txtGiangVienCapBac.TabIndex = 8;
        // 
        // txtGiangVienDonVi
        // 
        txtGiangVienDonVi.BorderRadius = 8;
        txtGiangVienDonVi.DefaultText = "";
        txtGiangVienDonVi.Font = new Font("Segoe UI", 16F);
        txtGiangVienDonVi.Location = new Point(16, 72);
        txtGiangVienDonVi.Margin = new Padding(5, 6, 5, 6);
        txtGiangVienDonVi.Name = "txtGiangVienDonVi";
        txtGiangVienDonVi.PasswordChar = '\0';
        txtGiangVienDonVi.PlaceholderText = "Khoa";
        txtGiangVienDonVi.SelectedText = "";
        txtGiangVienDonVi.Size = new Size(402, 54);
        txtGiangVienDonVi.TabIndex = 7;
        txtGiangVienDonVi.TextChanged += txtGiangVienDonVi_TextChanged;
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
        cboGiangVien.Location = new Point(16, 26);
        cboGiangVien.Margin = new Padding(3, 4, 3, 4);
        cboGiangVien.Name = "cboGiangVien";
        cboGiangVien.Size = new Size(402, 36);
        cboGiangVien.TabIndex = 0;
        // 
        // tabHoiDong
        // 
        tabHoiDong.BackColor = Color.White;
        tabHoiDong.Controls.Add(btnLuuHoiDong);
        tabHoiDong.Controls.Add(btnHoiDongLoad);
        tabHoiDong.Controls.Add(txtTenHoiDong);
        tabHoiDong.Controls.Add(cboThanhVien5);
        tabHoiDong.Controls.Add(cboThanhVien4);
        tabHoiDong.Controls.Add(cboThanhVien3);
        tabHoiDong.Controls.Add(cboThanhVien2);
        tabHoiDong.Controls.Add(cboThanhVien1);
        tabHoiDong.Controls.Add(cboHoiDongBai);
        tabHoiDong.Location = new Point(4, 44);
        tabHoiDong.Margin = new Padding(3, 4, 3, 4);
        tabHoiDong.Name = "tabHoiDong";
        tabHoiDong.Padding = new Padding(18, 22, 18, 22);
        tabHoiDong.Size = new Size(536, 734);
        tabHoiDong.TabIndex = 1;
        tabHoiDong.Text = "Hội đồng";
        // 
        // btnLuuHoiDong
        // 
        btnLuuHoiDong.BorderRadius = 8;
        btnLuuHoiDong.FillColor = Color.FromArgb(31, 122, 224);
        btnLuuHoiDong.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLuuHoiDong.ForeColor = Color.White;
        btnLuuHoiDong.Location = new Point(18, 480);
        btnLuuHoiDong.Margin = new Padding(3, 4, 3, 4);
        btnLuuHoiDong.Name = "btnLuuHoiDong";
        btnLuuHoiDong.Size = new Size(160, 60);
        btnLuuHoiDong.TabIndex = 8;
        btnLuuHoiDong.Text = "Lưu";
        btnLuuHoiDong.Click += btnLuuHoiDong_Click;
        // 
        // btnHoiDongLoad
        // 
        btnHoiDongLoad.BorderRadius = 8;
        btnHoiDongLoad.FillColor = Color.Gray;
        btnHoiDongLoad.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHoiDongLoad.ForeColor = Color.White;
        btnHoiDongLoad.Location = new Point(21, 564);
        btnHoiDongLoad.Margin = new Padding(3, 4, 3, 4);
        btnHoiDongLoad.Name = "btnHoiDongLoad";
        btnHoiDongLoad.Size = new Size(157, 60);
        btnHoiDongLoad.TabIndex = 7;
        btnHoiDongLoad.Text = "Tải dữ liệu";
        btnHoiDongLoad.Click += btnHoiDongLoad_Click;
        // 
        // txtTenHoiDong
        // 
        txtTenHoiDong.BorderRadius = 8;
        txtTenHoiDong.DefaultText = "";
        txtTenHoiDong.Font = new Font("Segoe UI", 16F);
        txtTenHoiDong.Location = new Point(18, 94);
        txtTenHoiDong.Margin = new Padding(5, 6, 5, 6);
        txtTenHoiDong.Name = "txtTenHoiDong";
        txtTenHoiDong.PasswordChar = '\0';
        txtTenHoiDong.PlaceholderText = "Tên hội đồng";
        txtTenHoiDong.SelectedText = "";
        txtTenHoiDong.Size = new Size(375, 60);
        txtTenHoiDong.TabIndex = 6;
        // 
        // cboThanhVien5
        // 
        cboThanhVien5.BackColor = Color.Transparent;
        cboThanhVien5.BorderRadius = 8;
        cboThanhVien5.DrawMode = DrawMode.OwnerDrawFixed;
        cboThanhVien5.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien5.FocusedColor = Color.Empty;
        cboThanhVien5.Font = new Font("Segoe UI", 16F);
        cboThanhVien5.ForeColor = Color.FromArgb(68, 88, 112);
        cboThanhVien5.ItemHeight = 30;
        cboThanhVien5.Location = new Point(18, 410);
        cboThanhVien5.Margin = new Padding(3, 4, 3, 4);
        cboThanhVien5.Name = "cboThanhVien5";
        cboThanhVien5.Size = new Size(374, 36);
        cboThanhVien5.TabIndex = 5;
        // 
        // cboThanhVien4
        // 
        cboThanhVien4.BackColor = Color.Transparent;
        cboThanhVien4.BorderRadius = 8;
        cboThanhVien4.DrawMode = DrawMode.OwnerDrawFixed;
        cboThanhVien4.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien4.FocusedColor = Color.Empty;
        cboThanhVien4.Font = new Font("Segoe UI", 16F);
        cboThanhVien4.ForeColor = Color.FromArgb(68, 88, 112);
        cboThanhVien4.ItemHeight = 30;
        cboThanhVien4.Location = new Point(18, 354);
        cboThanhVien4.Margin = new Padding(3, 4, 3, 4);
        cboThanhVien4.Name = "cboThanhVien4";
        cboThanhVien4.Size = new Size(374, 36);
        cboThanhVien4.TabIndex = 4;
        // 
        // cboThanhVien3
        // 
        cboThanhVien3.BackColor = Color.Transparent;
        cboThanhVien3.BorderRadius = 8;
        cboThanhVien3.DrawMode = DrawMode.OwnerDrawFixed;
        cboThanhVien3.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien3.FocusedColor = Color.Empty;
        cboThanhVien3.Font = new Font("Segoe UI", 16F);
        cboThanhVien3.ForeColor = Color.FromArgb(68, 88, 112);
        cboThanhVien3.ItemHeight = 30;
        cboThanhVien3.Location = new Point(18, 298);
        cboThanhVien3.Margin = new Padding(3, 4, 3, 4);
        cboThanhVien3.Name = "cboThanhVien3";
        cboThanhVien3.Size = new Size(374, 36);
        cboThanhVien3.TabIndex = 3;
        // 
        // cboThanhVien2
        // 
        cboThanhVien2.BackColor = Color.Transparent;
        cboThanhVien2.BorderRadius = 8;
        cboThanhVien2.DrawMode = DrawMode.OwnerDrawFixed;
        cboThanhVien2.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien2.FocusedColor = Color.Empty;
        cboThanhVien2.Font = new Font("Segoe UI", 16F);
        cboThanhVien2.ForeColor = Color.FromArgb(68, 88, 112);
        cboThanhVien2.ItemHeight = 30;
        cboThanhVien2.Location = new Point(18, 242);
        cboThanhVien2.Margin = new Padding(3, 4, 3, 4);
        cboThanhVien2.Name = "cboThanhVien2";
        cboThanhVien2.Size = new Size(374, 36);
        cboThanhVien2.TabIndex = 2;
        // 
        // cboThanhVien1
        // 
        cboThanhVien1.BackColor = Color.Transparent;
        cboThanhVien1.BorderRadius = 8;
        cboThanhVien1.DrawMode = DrawMode.OwnerDrawFixed;
        cboThanhVien1.DropDownStyle = ComboBoxStyle.DropDownList;
        cboThanhVien1.FocusedColor = Color.Empty;
        cboThanhVien1.Font = new Font("Segoe UI", 16F);
        cboThanhVien1.ForeColor = Color.FromArgb(68, 88, 112);
        cboThanhVien1.ItemHeight = 30;
        cboThanhVien1.Location = new Point(18, 186);
        cboThanhVien1.Margin = new Padding(3, 4, 3, 4);
        cboThanhVien1.Name = "cboThanhVien1";
        cboThanhVien1.Size = new Size(374, 36);
        cboThanhVien1.TabIndex = 1;
        // 
        // cboHoiDongBai
        // 
        cboHoiDongBai.BackColor = Color.Transparent;
        cboHoiDongBai.BorderRadius = 8;
        cboHoiDongBai.DrawMode = DrawMode.OwnerDrawFixed;
        cboHoiDongBai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHoiDongBai.FocusedColor = Color.Empty;
        cboHoiDongBai.Font = new Font("Segoe UI", 16F);
        cboHoiDongBai.ForeColor = Color.FromArgb(68, 88, 112);
        cboHoiDongBai.ItemHeight = 30;
        cboHoiDongBai.Location = new Point(18, 22);
        cboHoiDongBai.Margin = new Padding(3, 4, 3, 4);
        cboHoiDongBai.Name = "cboHoiDongBai";
        cboHoiDongBai.Size = new Size(411, 36);
        cboHoiDongBai.TabIndex = 0;
        // 
        // tabKetQua
        // 
        tabKetQua.BackColor = Color.White;
        tabKetQua.Controls.Add(btnLuuKetQua);
        tabKetQua.Controls.Add(btnTinhKetQua);
        tabKetQua.Controls.Add(btnLoadKetQua);
        tabKetQua.Controls.Add(txtXepLoai);
        tabKetQua.Controls.Add(txtTongDiem);
        tabKetQua.Controls.Add(txtDiemThucHanh);
        tabKetQua.Controls.Add(txtDiemHoSo);
        tabKetQua.Controls.Add(txtDiemHieuBiet);
        tabKetQua.Controls.Add(txtDiemThanhVien1);
        tabKetQua.Controls.Add(txtDiemThanhVien2);
        tabKetQua.Controls.Add(txtDiemThanhVien3);
        tabKetQua.Controls.Add(txtDiemThanhVien4);
        tabKetQua.Controls.Add(txtDiemThanhVien5);
        tabKetQua.Controls.Add(cboKetQuaBai);
        tabKetQua.Location = new Point(4, 44);
        tabKetQua.Margin = new Padding(3, 4, 3, 4);
        tabKetQua.Name = "tabKetQua";
        tabKetQua.Padding = new Padding(18, 22, 18, 22);
        tabKetQua.Size = new Size(536, 734);
        tabKetQua.TabIndex = 2;
        tabKetQua.Text = "Kết quả";
        tabKetQua.Click += tabKetQua_Click;
        // 
        // btnLuuKetQua
        // 
        btnLuuKetQua.BorderRadius = 8;
        btnLuuKetQua.FillColor = Color.FromArgb(31, 122, 224);
        btnLuuKetQua.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLuuKetQua.ForeColor = Color.White;
        btnLuuKetQua.Location = new Point(190, 527);
        btnLuuKetQua.Margin = new Padding(3, 4, 3, 4);
        btnLuuKetQua.Name = "btnLuuKetQua";
        btnLuuKetQua.Size = new Size(137, 60);
        btnLuuKetQua.TabIndex = 8;
        btnLuuKetQua.Text = "Lưu";
        btnLuuKetQua.Click += btnLuuKetQua_Click;
        // 
        // btnTinhKetQua
        // 
        btnTinhKetQua.BorderRadius = 8;
        btnTinhKetQua.FillColor = Color.SeaGreen;
        btnTinhKetQua.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnTinhKetQua.ForeColor = Color.White;
        btnTinhKetQua.Location = new Point(18, 527);
        btnTinhKetQua.Margin = new Padding(3, 4, 3, 4);
        btnTinhKetQua.Name = "btnTinhKetQua";
        btnTinhKetQua.Size = new Size(150, 60);
        btnTinhKetQua.TabIndex = 7;
        btnTinhKetQua.Text = "Tính điểm";
        btnTinhKetQua.Click += btnTinhKetQua_Click;
        // 
        // btnLoadKetQua
        // 
        btnLoadKetQua.BorderRadius = 8;
        btnLoadKetQua.FillColor = Color.Gray;
        btnLoadKetQua.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLoadKetQua.ForeColor = Color.White;
        btnLoadKetQua.Location = new Point(18, 613);
        btnLoadKetQua.Margin = new Padding(3, 4, 3, 4);
        btnLoadKetQua.Name = "btnLoadKetQua";
        btnLoadKetQua.Size = new Size(150, 54);
        btnLoadKetQua.TabIndex = 6;
        btnLoadKetQua.Text = "Tải dữ liệu";
        btnLoadKetQua.Click += btnLoadKetQua_Click;
        // 
        // txtXepLoai
        // 
        txtXepLoai.BorderRadius = 8;
        txtXepLoai.DefaultText = "";
        txtXepLoai.Font = new Font("Segoe UI", 16F);
        txtXepLoai.Location = new Point(18, 427);
        txtXepLoai.Margin = new Padding(5, 6, 5, 6);
        txtXepLoai.Name = "txtXepLoai";
        txtXepLoai.PasswordChar = '\0';
        txtXepLoai.PlaceholderText = "Xếp loại";
        txtXepLoai.SelectedText = "";
        txtXepLoai.Size = new Size(265, 60);
        txtXepLoai.TabIndex = 5;
        // 
        // txtTongDiem
        // 
        txtTongDiem.BorderRadius = 8;
        txtTongDiem.DefaultText = "";
        txtTongDiem.Font = new Font("Segoe UI", 16F);
        txtTongDiem.Location = new Point(18, 338);
        txtTongDiem.Margin = new Padding(5, 6, 5, 6);
        txtTongDiem.Name = "txtTongDiem";
        txtTongDiem.PasswordChar = '\0';
        txtTongDiem.PlaceholderText = "Tổng điểm";
        txtTongDiem.SelectedText = "";
        txtTongDiem.Size = new Size(265, 60);
        txtTongDiem.TabIndex = 4;
        // 
        // txtDiemThucHanh
        // 
        txtDiemThucHanh.BorderRadius = 8;
        txtDiemThucHanh.DefaultText = "";
        txtDiemThucHanh.Font = new Font("Segoe UI", 16F);
        txtDiemThucHanh.Location = new Point(18, 248);
        txtDiemThucHanh.Margin = new Padding(5, 6, 5, 6);
        txtDiemThucHanh.Name = "txtDiemThucHanh";
        txtDiemThucHanh.PasswordChar = '\0';
        txtDiemThucHanh.PlaceholderText = "Điểm thực hành (TB 5 phiếu)";
        txtDiemThucHanh.SelectedText = "";
        txtDiemThucHanh.Size = new Size(265, 60);
        txtDiemThucHanh.TabIndex = 3;
        // 
        // txtDiemHoSo
        // 
        txtDiemHoSo.BorderRadius = 8;
        txtDiemHoSo.DefaultText = "";
        txtDiemHoSo.Font = new Font("Segoe UI", 16F);
        txtDiemHoSo.Location = new Point(18, 161);
        txtDiemHoSo.Margin = new Padding(5, 6, 5, 6);
        txtDiemHoSo.Name = "txtDiemHoSo";
        txtDiemHoSo.PasswordChar = '\0';
        txtDiemHoSo.PlaceholderText = "Điểm hồ sơ";
        txtDiemHoSo.SelectedText = "";
        txtDiemHoSo.Size = new Size(265, 60);
        txtDiemHoSo.TabIndex = 2;
        // 
        // txtDiemHieuBiet
        // 
        txtDiemHieuBiet.BorderRadius = 8;
        txtDiemHieuBiet.DefaultText = "";
        txtDiemHieuBiet.Font = new Font("Segoe UI", 16F);
        txtDiemHieuBiet.Location = new Point(18, 79);
        txtDiemHieuBiet.Margin = new Padding(5, 6, 5, 6);
        txtDiemHieuBiet.Name = "txtDiemHieuBiet";
        txtDiemHieuBiet.PasswordChar = '\0';
        txtDiemHieuBiet.PlaceholderText = "Điểm hiểu biết";
        txtDiemHieuBiet.SelectedText = "";
        txtDiemHieuBiet.Size = new Size(265, 60);
        txtDiemHieuBiet.TabIndex = 1;
        // 
        // txtDiemThanhVien1
        // 
        txtDiemThanhVien1.BorderRadius = 8;
        txtDiemThanhVien1.DefaultText = "";
        txtDiemThanhVien1.Font = new Font("Segoe UI", 16F);
        txtDiemThanhVien1.Location = new Point(308, 94);
        txtDiemThanhVien1.Margin = new Padding(5, 6, 5, 6);
        txtDiemThanhVien1.Name = "txtDiemThanhVien1";
        txtDiemThanhVien1.PasswordChar = '\0';
        txtDiemThanhVien1.PlaceholderText = "Diem TV 1";
        txtDiemThanhVien1.SelectedText = "";
        txtDiemThanhVien1.Size = new Size(232, 45);
        txtDiemThanhVien1.TabIndex = 9;
        // 
        // txtDiemThanhVien2
        // 
        txtDiemThanhVien2.BorderRadius = 8;
        txtDiemThanhVien2.DefaultText = "";
        txtDiemThanhVien2.Font = new Font("Segoe UI", 16F);
        txtDiemThanhVien2.Location = new Point(308, 161);
        txtDiemThanhVien2.Margin = new Padding(5, 6, 5, 6);
        txtDiemThanhVien2.Name = "txtDiemThanhVien2";
        txtDiemThanhVien2.PasswordChar = '\0';
        txtDiemThanhVien2.PlaceholderText = "Diem TV 2";
        txtDiemThanhVien2.SelectedText = "";
        txtDiemThanhVien2.Size = new Size(232, 45);
        txtDiemThanhVien2.TabIndex = 10;
        // 
        // txtDiemThanhVien3
        // 
        txtDiemThanhVien3.BorderRadius = 8;
        txtDiemThanhVien3.DefaultText = "";
        txtDiemThanhVien3.Font = new Font("Segoe UI", 16F);
        txtDiemThanhVien3.Location = new Point(308, 229);
        txtDiemThanhVien3.Margin = new Padding(5, 6, 5, 6);
        txtDiemThanhVien3.Name = "txtDiemThanhVien3";
        txtDiemThanhVien3.PasswordChar = '\0';
        txtDiemThanhVien3.PlaceholderText = "Diem TV 3";
        txtDiemThanhVien3.SelectedText = "";
        txtDiemThanhVien3.Size = new Size(232, 45);
        txtDiemThanhVien3.TabIndex = 11;
        // 
        // txtDiemThanhVien4
        // 
        txtDiemThanhVien4.BorderRadius = 8;
        txtDiemThanhVien4.DefaultText = "";
        txtDiemThanhVien4.Font = new Font("Segoe UI", 16F);
        txtDiemThanhVien4.Location = new Point(308, 296);
        txtDiemThanhVien4.Margin = new Padding(5, 6, 5, 6);
        txtDiemThanhVien4.Name = "txtDiemThanhVien4";
        txtDiemThanhVien4.PasswordChar = '\0';
        txtDiemThanhVien4.PlaceholderText = "Diem TV 4";
        txtDiemThanhVien4.SelectedText = "";
        txtDiemThanhVien4.Size = new Size(232, 45);
        txtDiemThanhVien4.TabIndex = 12;
        // 
        // txtDiemThanhVien5
        // 
        txtDiemThanhVien5.BorderRadius = 8;
        txtDiemThanhVien5.DefaultText = "";
        txtDiemThanhVien5.Font = new Font("Segoe UI", 16F);
        txtDiemThanhVien5.Location = new Point(308, 353);
        txtDiemThanhVien5.Margin = new Padding(5, 6, 5, 6);
        txtDiemThanhVien5.Name = "txtDiemThanhVien5";
        txtDiemThanhVien5.PasswordChar = '\0';
        txtDiemThanhVien5.PlaceholderText = "Diem TV 5";
        txtDiemThanhVien5.SelectedText = "";
        txtDiemThanhVien5.Size = new Size(232, 45);
        txtDiemThanhVien5.TabIndex = 13;
        // 
        // cboKetQuaBai
        // 
        cboKetQuaBai.BackColor = Color.Transparent;
        cboKetQuaBai.BorderRadius = 8;
        cboKetQuaBai.DrawMode = DrawMode.OwnerDrawFixed;
        cboKetQuaBai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKetQuaBai.FocusedColor = Color.Empty;
        cboKetQuaBai.Font = new Font("Segoe UI", 16F);
        cboKetQuaBai.ForeColor = Color.FromArgb(68, 88, 112);
        cboKetQuaBai.ItemHeight = 30;
        cboKetQuaBai.Location = new Point(18, 22);
        cboKetQuaBai.Margin = new Padding(3, 4, 3, 4);
        cboKetQuaBai.Name = "cboKetQuaBai";
        cboKetQuaBai.Size = new Size(411, 36);
        cboKetQuaBai.TabIndex = 0;
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
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        layoutMain.Controls.Add(panelLeft, 0, 0);
        layoutMain.Controls.Add(panelRight, 1, 0);
        layoutMain.Dock = DockStyle.Fill;
        layoutMain.Location = new Point(0, 0);
        layoutMain.Margin = new Padding(0);
        layoutMain.Name = "layoutMain";
        layoutMain.Padding = new Padding(24);
        layoutMain.RowCount = 1;
        layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutMain.Size = new Size(1737, 854);
        layoutMain.TabIndex = 3;
        // 
        // UcHoiGiang
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(245, 247, 250);
        Controls.Add(layoutMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcHoiGiang";
        Size = new Size(1737, 854);
        panelLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridHoiGiang).EndInit();
        panelRight.ResumeLayout(false);
        tabMain.ResumeLayout(false);
        tabDangKy.ResumeLayout(false);
        tabHoiDong.ResumeLayout(false);
        tabKetQua.ResumeLayout(false);
        layoutMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnRefreshHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridHoiGiang;
    private TableLayoutPanel layoutMain;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private TabControl tabMain;
    private TabPage tabDangKy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuuHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnTaoMoiHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoaHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboCapThucHien;
    private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtThoiGian;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLop;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenBai;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboHocPhan;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienDonVi;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienCapBac;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienChucDanh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienNgaySinh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienDienThoai;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGiangVienEmail;
    private TabPage tabHoiDong;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuuHoiDong;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHoiDongLoad;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenHoiDong;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboThanhVien5;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboThanhVien4;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboThanhVien3;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboThanhVien2;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboThanhVien1;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboHoiDongBai;
    private TabPage tabKetQua;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuuKetQua;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnTinhKetQua;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLoadKetQua;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtXepLoai;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTongDiem;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThucHanh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemHoSo;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemHieuBiet;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThanhVien1;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThanhVien2;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThanhVien3;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThanhVien4;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemThanhVien5;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboKetQuaBai;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private DataGridViewTextBoxColumn colTenBai;
    private DataGridViewTextBoxColumn colGiangVien;
    private DataGridViewTextBoxColumn colThoiGian;
    private DataGridViewTextBoxColumn colCap;
}
