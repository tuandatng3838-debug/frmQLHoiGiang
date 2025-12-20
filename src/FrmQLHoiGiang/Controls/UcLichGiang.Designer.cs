namespace FrmQLHoiGiang.Controls;

partial class UcLichGiang
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
        layoutMain = new TableLayoutPanel();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        lblTongTiet = new Label();
        lstLichCaNhan = new ListBox();
        btnXemLich = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        cboLocGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        gridLichGiang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colNgay = new DataGridViewTextBoxColumn();
        colBuoi = new DataGridViewTextBoxColumn();
        colMon = new DataGridViewTextBoxColumn();
        colLop = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        labelDetail = new Label();
        txtSiSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtSoTiet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtPhong = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        dtNgayHoc = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
        cboBuoi = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtTenMon = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtTenLop = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtNamHoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain.SuspendLayout();
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridLichGiang).BeginInit();
        panelRight.SuspendLayout();
        SuspendLayout();
        // 
        // layoutMain
        // 
        layoutMain.BackColor = Color.FromArgb(245, 247, 250);
        layoutMain.ColumnCount = 2;
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.74867F));
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2513313F));
        layoutMain.Controls.Add(panelLeft, 0, 0);
        layoutMain.Controls.Add(panelRight, 1, 0);
        layoutMain.Dock = DockStyle.Fill;
        layoutMain.Location = new Point(0, 0);
        layoutMain.Margin = new Padding(0);
        layoutMain.Name = "layoutMain";
        layoutMain.Padding = new Padding(24);
        layoutMain.RowCount = 1;
        layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutMain.Size = new Size(1739, 947);
        layoutMain.TabIndex = 0;
        // 
        // panelLeft
        // 
        panelLeft.BorderRadius = 12;
        panelLeft.Controls.Add(lblTongTiet);
        panelLeft.Controls.Add(lstLichCaNhan);
        panelLeft.Controls.Add(btnXemLich);
        panelLeft.Controls.Add(cboLocGiangVien);
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.Controls.Add(gridLichGiang);
        panelLeft.Dock = DockStyle.Fill;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(24, 24);
        panelLeft.Margin = new Padding(0);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(18, 22, 18, 22);
        panelLeft.Size = new Size(1264, 899);
        panelLeft.TabIndex = 0;
        // 
        // lblTongTiet
        // 
        lblTongTiet.AutoSize = true;
        lblTongTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTongTiet.Location = new Point(18, 813);
        lblTongTiet.Name = "lblTongTiet";
        lblTongTiet.Size = new Size(155, 25);
        lblTongTiet.TabIndex = 5;
        lblTongTiet.Text = "Tổng tiết/năm: 0";
        // 
        // lstLichCaNhan
        // 
        lstLichCaNhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstLichCaNhan.FormattingEnabled = true;
        lstLichCaNhan.ItemHeight = 25;
        lstLichCaNhan.Location = new Point(18, 595);
        lstLichCaNhan.Margin = new Padding(3, 4, 3, 4);
        lstLichCaNhan.Name = "lstLichCaNhan";
        lstLichCaNhan.Size = new Size(1255, 204);
        lstLichCaNhan.TabIndex = 4;
        // 
        // btnXemLich
        // 
        btnXemLich.BorderRadius = 8;
        btnXemLich.FillColor = Color.Gray;
        btnXemLich.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnXemLich.ForeColor = Color.White;
        btnXemLich.Location = new Point(224, 809);
        btnXemLich.Margin = new Padding(3, 4, 3, 4);
        btnXemLich.Name = "btnXemLich";
        btnXemLich.Size = new Size(160, 60);
        btnXemLich.TabIndex = 3;
        btnXemLich.Text = "Xem lịch";
        btnXemLich.Click += btnXemLich_Click;
        // 
        // cboLocGiangVien
        // 
        cboLocGiangVien.BackColor = Color.Transparent;
        cboLocGiangVien.BorderRadius = 8;
        cboLocGiangVien.DrawMode = DrawMode.OwnerDrawFixed;
        cboLocGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocGiangVien.FocusedColor = Color.Empty;
        cboLocGiangVien.Font = new Font("Segoe UI", 10F);
        cboLocGiangVien.ForeColor = Color.FromArgb(68, 88, 112);
        cboLocGiangVien.ItemHeight = 30;
        cboLocGiangVien.Location = new Point(18, 809);
        cboLocGiangVien.Margin = new Padding(3, 4, 3, 4);
        cboLocGiangVien.Name = "cboLocGiangVien";
        cboLocGiangVien.Size = new Size(169, 36);
        cboLocGiangVien.TabIndex = 2;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BorderRadius = 8;
        btnLamMoi.FillColor = Color.FromArgb(31, 122, 224);
        btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(13, 13);
        btnLamMoi.Margin = new Padding(3, 4, 3, 4);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.RightToLeft = RightToLeft.No;
        btnLamMoi.Size = new Size(156, 52);
        btnLamMoi.TabIndex = 1;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // gridLichGiang
        // 
        gridLichGiang.AllowUserToAddRows = false;
        gridLichGiang.AllowUserToDeleteRows = false;
        gridLichGiang.AllowUserToResizeColumns = false;
        gridLichGiang.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridLichGiang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridLichGiang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridLichGiang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridLichGiang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridLichGiang.ColumnHeadersHeight = 45;
        gridLichGiang.Columns.AddRange(new DataGridViewColumn[] { colNgay, colBuoi, colMon, colLop });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridLichGiang.DefaultCellStyle = dataGridViewCellStyle3;
        gridLichGiang.GridColor = Color.FromArgb(231, 229, 255);
        gridLichGiang.Location = new Point(13, 82);
        gridLichGiang.Margin = new Padding(3, 4, 3, 4);
        gridLichGiang.MultiSelect = false;
        gridLichGiang.Name = "gridLichGiang";
        gridLichGiang.ReadOnly = true;
        gridLichGiang.RowHeadersVisible = false;
        gridLichGiang.RowHeadersWidth = 62;
        gridLichGiang.RowTemplate.Height = 32;
        gridLichGiang.Size = new Size(1213, 742);
        gridLichGiang.TabIndex = 0;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridLichGiang.ThemeStyle.BackColor = Color.White;
        gridLichGiang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridLichGiang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridLichGiang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridLichGiang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridLichGiang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridLichGiang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridLichGiang.ThemeStyle.HeaderStyle.Height = 45;
        gridLichGiang.ThemeStyle.ReadOnly = true;
        gridLichGiang.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridLichGiang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridLichGiang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridLichGiang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridLichGiang.ThemeStyle.RowsStyle.Height = 32;
        gridLichGiang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridLichGiang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridLichGiang.CellClick += gridLichGiang_CellClick;
        // 
        // colNgay
        // 
        colNgay.DataPropertyName = "NgayHoc";
        colNgay.HeaderText = "NGÀY";
        colNgay.MinimumWidth = 8;
        colNgay.Name = "colNgay";
        colNgay.ReadOnly = true;
        // 
        // colBuoi
        // 
        colBuoi.DataPropertyName = "Buoi";
        colBuoi.HeaderText = "BUỔI";
        colBuoi.MinimumWidth = 8;
        colBuoi.Name = "colBuoi";
        colBuoi.ReadOnly = true;
        // 
        // colMon
        // 
        colMon.DataPropertyName = "TenMon";
        colMon.HeaderText = "MÔN";
        colMon.MinimumWidth = 8;
        colMon.Name = "colMon";
        colMon.ReadOnly = true;
        // 
        // colLop
        // 
        colLop.DataPropertyName = "TenLop";
        colLop.HeaderText = "LỚP";
        colLop.MinimumWidth = 8;
        colLop.Name = "colLop";
        colLop.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(labelDetail);
        panelRight.Controls.Add(txtSiSo);
        panelRight.Controls.Add(txtSoTiet);
        panelRight.Controls.Add(txtPhong);
        panelRight.Controls.Add(dtNgayHoc);
        panelRight.Controls.Add(cboBuoi);
        panelRight.Controls.Add(cboGiangVien);
        panelRight.Controls.Add(txtTenMon);
        panelRight.Controls.Add(txtTenLop);
        panelRight.Controls.Add(txtNamHoc);
        panelRight.Controls.Add(btnXoa);
        panelRight.Controls.Add(btnHuy);
        panelRight.Controls.Add(btnLuu);
        panelRight.Dock = DockStyle.Fill;
        panelRight.FillColor = Color.White;
        panelRight.Location = new Point(1312, 24);
        panelRight.Margin = new Padding(24, 0, 0, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(18, 22, 18, 22);
        panelRight.Size = new Size(403, 899);
        panelRight.TabIndex = 1;
        panelRight.Paint += panelRight_Paint;
        // 
        // labelDetail
        // 
        labelDetail.AutoSize = true;
        labelDetail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        labelDetail.Location = new Point(23, 22);
        labelDetail.Name = "labelDetail";
        labelDetail.Size = new Size(201, 32);
        labelDetail.TabIndex = 11;
        labelDetail.Text = "Thong tin chi tiet";
        // 
        // txtSiSo
        // 
        txtSiSo.BorderRadius = 8;
        txtSiSo.DefaultText = "";
        txtSiSo.Font = new Font("Segoe UI", 9F);
        txtSiSo.Location = new Point(256, 494);
        txtSiSo.Margin = new Padding(5, 6, 5, 6);
        txtSiSo.Name = "txtSiSo";
        txtSiSo.PasswordChar = '\0';
        txtSiSo.PlaceholderText = "Sĩ số";
        txtSiSo.SelectedText = "";
        txtSiSo.Size = new Size(206, 54);
        txtSiSo.TabIndex = 10;
        // 
        // txtSoTiet
        // 
        txtSoTiet.BorderRadius = 8;
        txtSoTiet.DefaultText = "";
        txtSoTiet.Font = new Font("Segoe UI", 9F);
        txtSoTiet.Location = new Point(23, 494);
        txtSoTiet.Margin = new Padding(5, 6, 5, 6);
        txtSoTiet.Name = "txtSoTiet";
        txtSoTiet.PasswordChar = '\0';
        txtSoTiet.PlaceholderText = "Số tiết";
        txtSoTiet.SelectedText = "";
        txtSoTiet.Size = new Size(206, 54);
        txtSoTiet.TabIndex = 9;
        // 
        // txtPhong
        // 
        txtPhong.BorderRadius = 8;
        txtPhong.DefaultText = "";
        txtPhong.Font = new Font("Segoe UI", 9F);
        txtPhong.Location = new Point(23, 424);
        txtPhong.Margin = new Padding(5, 6, 5, 6);
        txtPhong.Name = "txtPhong";
        txtPhong.PasswordChar = '\0';
        txtPhong.PlaceholderText = "Phòng học";
        txtPhong.SelectedText = "";
        txtPhong.Size = new Size(439, 60);
        txtPhong.TabIndex = 8;
        // 
        // dtNgayHoc
        // 
        dtNgayHoc.BorderRadius = 8;
        dtNgayHoc.Checked = true;
        dtNgayHoc.Font = new Font("Segoe UI", 9F);
        dtNgayHoc.Format = DateTimePickerFormat.Short;
        dtNgayHoc.Location = new Point(256, 354);
        dtNgayHoc.Margin = new Padding(3, 4, 3, 4);
        dtNgayHoc.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
        dtNgayHoc.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
        dtNgayHoc.Name = "dtNgayHoc";
        dtNgayHoc.Size = new Size(206, 48);
        dtNgayHoc.TabIndex = 7;
        dtNgayHoc.Value = new DateTime(2025, 12, 10, 0, 0, 0, 0);
        // 
        // cboBuoi
        // 
        cboBuoi.BackColor = Color.Transparent;
        cboBuoi.BorderRadius = 8;
        cboBuoi.DrawMode = DrawMode.OwnerDrawFixed;
        cboBuoi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboBuoi.FocusedColor = Color.Empty;
        cboBuoi.Font = new Font("Segoe UI", 10F);
        cboBuoi.ForeColor = Color.FromArgb(68, 88, 112);
        cboBuoi.ItemHeight = 30;
        cboBuoi.Items.AddRange(new object[] { "Sáng", "Chiều", "Tối" });
        cboBuoi.Location = new Point(23, 354);
        cboBuoi.Margin = new Padding(3, 4, 3, 4);
        cboBuoi.Name = "cboBuoi";
        cboBuoi.Size = new Size(205, 36);
        cboBuoi.TabIndex = 6;
        // 
        // cboGiangVien
        // 
        cboGiangVien.BackColor = Color.Transparent;
        cboGiangVien.BorderRadius = 8;
        cboGiangVien.DrawMode = DrawMode.OwnerDrawFixed;
        cboGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGiangVien.FocusedColor = Color.Empty;
        cboGiangVien.Font = new Font("Segoe UI", 10F);
        cboGiangVien.ForeColor = Color.FromArgb(68, 88, 112);
        cboGiangVien.ItemHeight = 30;
        cboGiangVien.Location = new Point(23, 290);
        cboGiangVien.Margin = new Padding(3, 4, 3, 4);
        cboGiangVien.Name = "cboGiangVien";
        cboGiangVien.Size = new Size(438, 36);
        cboGiangVien.TabIndex = 5;
        // 
        // txtTenMon
        // 
        txtTenMon.BorderRadius = 8;
        txtTenMon.DefaultText = "";
        txtTenMon.Font = new Font("Segoe UI", 9F);
        txtTenMon.Location = new Point(23, 224);
        txtTenMon.Margin = new Padding(5, 6, 5, 6);
        txtTenMon.Name = "txtTenMon";
        txtTenMon.PasswordChar = '\0';
        txtTenMon.PlaceholderText = "Tên môn";
        txtTenMon.SelectedText = "";
        txtTenMon.Size = new Size(439, 60);
        txtTenMon.TabIndex = 4;
        // 
        // txtTenLop
        // 
        txtTenLop.BorderRadius = 8;
        txtTenLop.DefaultText = "";
        txtTenLop.Font = new Font("Segoe UI", 9F);
        txtTenLop.Location = new Point(23, 158);
        txtTenLop.Margin = new Padding(5, 6, 5, 6);
        txtTenLop.Name = "txtTenLop";
        txtTenLop.PasswordChar = '\0';
        txtTenLop.PlaceholderText = "Tên lớp";
        txtTenLop.SelectedText = "";
        txtTenLop.Size = new Size(439, 60);
        txtTenLop.TabIndex = 3;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.DefaultText = "";
        txtNamHoc.Font = new Font("Segoe UI", 9F);
        txtNamHoc.Location = new Point(23, 86);
        txtNamHoc.Margin = new Padding(5, 6, 5, 6);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PasswordChar = '\0';
        txtNamHoc.PlaceholderText = "Năm học";
        txtNamHoc.SelectedText = "";
        txtNamHoc.Size = new Size(206, 60);
        txtNamHoc.TabIndex = 2;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(250, 60, 76);
        btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(201, 572);
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
        btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(383, 572);
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
        btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLuu.ForeColor = Color.White;
        btnLuu.Location = new Point(18, 572);
        btnLuu.Margin = new Padding(3, 4, 3, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(160, 60);
        btnLuu.TabIndex = 0;
        btnLuu.Text = "Thêm mới";
        btnLuu.Click += btnLuu_Click;
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
        // UcLichGiang
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(245, 247, 250);
        Controls.Add(layoutMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcLichGiang";
        Size = new Size(1739, 947);
        layoutMain.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        panelLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridLichGiang).EndInit();
        panelRight.ResumeLayout(false);
        panelRight.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Label lblTongTiet;
    private ListBox lstLichCaNhan;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXemLich;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboLocGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridLichGiang;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSiSo;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoTiet;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPhong;
    private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtNgayHoc;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboBuoi;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenMon;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenLop;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNamHoc;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Label labelDetail;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private DataGridViewTextBoxColumn colNgay;
    private DataGridViewTextBoxColumn colBuoi;
    private DataGridViewTextBoxColumn colMon;
    private DataGridViewTextBoxColumn colLop;
    private TableLayoutPanel layoutMain;
}
