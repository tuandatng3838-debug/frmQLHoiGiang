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
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridLichGiang).BeginInit();
        panelRight.SuspendLayout();
        SuspendLayout();
        // 
        // panelLeft
        // 
        panelLeft.Controls.Add(lblTongTiet);
        panelLeft.Controls.Add(lstLichCaNhan);
        panelLeft.Controls.Add(btnXemLich);
        panelLeft.Controls.Add(cboLocGiangVien);
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.Controls.Add(gridLichGiang);
        panelLeft.Dock = DockStyle.Left;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(0, 0);
        panelLeft.Margin = new Padding(4, 5, 4, 5);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(23, 27, 23, 27);
        panelLeft.Size = new Size(780, 1184);
        panelLeft.TabIndex = 0;
        // 
        // lblTongTiet
        // 
        lblTongTiet.AutoSize = true;
        lblTongTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTongTiet.Location = new Point(23, 1016);
        lblTongTiet.Margin = new Padding(4, 0, 4, 0);
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
        lstLichCaNhan.Location = new Point(23, 736);
        lstLichCaNhan.Margin = new Padding(4, 5, 4, 5);
        lstLichCaNhan.Name = "lstLichCaNhan";
        lstLichCaNhan.Size = new Size(734, 254);
        lstLichCaNhan.TabIndex = 4;
        // 
        // btnXemLich
        // 
        btnXemLich.BorderRadius = 8;
        btnXemLich.FillColor = Color.Gray;
        btnXemLich.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnXemLich.ForeColor = Color.White;
        btnXemLich.Location = new Point(460, 996);
        btnXemLich.Margin = new Padding(4, 5, 4, 5);
        btnXemLich.Name = "btnXemLich";
        btnXemLich.Size = new Size(137, 60);
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
        cboLocGiangVien.Location = new Point(23, 996);
        cboLocGiangVien.Margin = new Padding(4, 5, 4, 5);
        cboLocGiangVien.Name = "cboLocGiangVien";
        cboLocGiangVien.Size = new Size(170, 36);
        cboLocGiangVien.TabIndex = 2;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BorderRadius = 8;
        btnLamMoi.FillColor = Color.FromArgb(31, 122, 224);
        btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(23, 27);
        btnLamMoi.Margin = new Padding(4, 5, 4, 5);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(171, 60);
        btnLamMoi.TabIndex = 1;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // gridLichGiang
        // 
        gridLichGiang.AllowUserToAddRows = false;
        gridLichGiang.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridLichGiang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridLichGiang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridLichGiang.ColumnHeadersHeight = 36;
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
        gridLichGiang.Location = new Point(23, 107);
        gridLichGiang.Margin = new Padding(4, 5, 4, 5);
        gridLichGiang.MultiSelect = false;
        gridLichGiang.Name = "gridLichGiang";
        gridLichGiang.ReadOnly = true;
        gridLichGiang.RowHeadersVisible = false;
        gridLichGiang.RowHeadersWidth = 62;
        gridLichGiang.RowTemplate.Height = 32;
        gridLichGiang.Size = new Size(734, 611);
        gridLichGiang.TabIndex = 0;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridLichGiang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridLichGiang.ThemeStyle.BackColor = Color.White;
        gridLichGiang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridLichGiang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridLichGiang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridLichGiang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridLichGiang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridLichGiang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridLichGiang.ThemeStyle.HeaderStyle.Height = 36;
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
        colNgay.HeaderText = "Ngày";
        colNgay.MinimumWidth = 8;
        colNgay.Name = "colNgay";
        colNgay.ReadOnly = true;
        // 
        // colBuoi
        // 
        colBuoi.DataPropertyName = "Buoi";
        colBuoi.HeaderText = "Buổi";
        colBuoi.MinimumWidth = 8;
        colBuoi.Name = "colBuoi";
        colBuoi.ReadOnly = true;
        // 
        // colMon
        // 
        colMon.DataPropertyName = "TenMon";
        colMon.HeaderText = "Môn";
        colMon.MinimumWidth = 8;
        colMon.Name = "colMon";
        colMon.ReadOnly = true;
        // 
        // colLop
        // 
        colLop.DataPropertyName = "TenLop";
        colLop.HeaderText = "Lớp";
        colLop.MinimumWidth = 8;
        colLop.Name = "colLop";
        colLop.ReadOnly = true;
        // 
        // panelRight
        // 
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
        panelRight.Location = new Point(780, 0);
        panelRight.Margin = new Padding(4, 5, 4, 5);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(23, 27, 23, 27);
        panelRight.Size = new Size(1143, 1184);
        panelRight.TabIndex = 1;
        panelRight.Paint += panelRight_Paint;
        // 
        // txtSiSo
        // 
        txtSiSo.BorderRadius = 8;
        txtSiSo.DefaultText = "";
        txtSiSo.Font = new Font("Segoe UI", 9F);
        txtSiSo.Location = new Point(314, 533);
        txtSiSo.Margin = new Padding(6, 8, 6, 8);
        txtSiSo.Name = "txtSiSo";
        txtSiSo.PasswordChar = '\0';
        txtSiSo.PlaceholderText = "Sĩ số";
        txtSiSo.SelectedText = "";
        txtSiSo.Size = new Size(257, 67);
        txtSiSo.TabIndex = 10;
        // 
        // txtSoTiet
        // 
        txtSoTiet.BorderRadius = 8;
        txtSoTiet.DefaultText = "";
        txtSoTiet.Font = new Font("Segoe UI", 9F);
        txtSoTiet.Location = new Point(23, 533);
        txtSoTiet.Margin = new Padding(6, 8, 6, 8);
        txtSoTiet.Name = "txtSoTiet";
        txtSoTiet.PasswordChar = '\0';
        txtSoTiet.PlaceholderText = "Số tiết";
        txtSoTiet.SelectedText = "";
        txtSoTiet.Size = new Size(257, 67);
        txtSoTiet.TabIndex = 9;
        // 
        // txtPhong
        // 
        txtPhong.BorderRadius = 8;
        txtPhong.DefaultText = "";
        txtPhong.Font = new Font("Segoe UI", 9F);
        txtPhong.Location = new Point(23, 445);
        txtPhong.Margin = new Padding(6, 8, 6, 8);
        txtPhong.Name = "txtPhong";
        txtPhong.PasswordChar = '\0';
        txtPhong.PlaceholderText = "Phòng học";
        txtPhong.SelectedText = "";
        txtPhong.Size = new Size(549, 75);
        txtPhong.TabIndex = 8;
        // 
        // dtNgayHoc
        // 
        dtNgayHoc.BorderRadius = 8;
        dtNgayHoc.Checked = true;
        dtNgayHoc.Font = new Font("Segoe UI", 9F);
        dtNgayHoc.Format = DateTimePickerFormat.Short;
        dtNgayHoc.Location = new Point(314, 357);
        dtNgayHoc.Margin = new Padding(4, 5, 4, 5);
        dtNgayHoc.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
        dtNgayHoc.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
        dtNgayHoc.Name = "dtNgayHoc";
        dtNgayHoc.Size = new Size(257, 60);
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
        cboBuoi.Location = new Point(23, 357);
        cboBuoi.Margin = new Padding(4, 5, 4, 5);
        cboBuoi.Name = "cboBuoi";
        cboBuoi.Size = new Size(255, 36);
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
        cboGiangVien.Location = new Point(23, 277);
        cboGiangVien.Margin = new Padding(4, 5, 4, 5);
        cboGiangVien.Name = "cboGiangVien";
        cboGiangVien.Size = new Size(547, 36);
        cboGiangVien.TabIndex = 5;
        // 
        // txtTenMon
        // 
        txtTenMon.BorderRadius = 8;
        txtTenMon.DefaultText = "";
        txtTenMon.Font = new Font("Segoe UI", 9F);
        txtTenMon.Location = new Point(23, 195);
        txtTenMon.Margin = new Padding(6, 8, 6, 8);
        txtTenMon.Name = "txtTenMon";
        txtTenMon.PasswordChar = '\0';
        txtTenMon.PlaceholderText = "Tên môn";
        txtTenMon.SelectedText = "";
        txtTenMon.Size = new Size(549, 75);
        txtTenMon.TabIndex = 4;
        // 
        // txtTenLop
        // 
        txtTenLop.BorderRadius = 8;
        txtTenLop.DefaultText = "";
        txtTenLop.Font = new Font("Segoe UI", 9F);
        txtTenLop.Location = new Point(23, 113);
        txtTenLop.Margin = new Padding(6, 8, 6, 8);
        txtTenLop.Name = "txtTenLop";
        txtTenLop.PasswordChar = '\0';
        txtTenLop.PlaceholderText = "Tên lớp";
        txtTenLop.SelectedText = "";
        txtTenLop.Size = new Size(549, 75);
        txtTenLop.TabIndex = 3;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.DefaultText = "";
        txtNamHoc.Font = new Font("Segoe UI", 9F);
        txtNamHoc.Location = new Point(23, 22);
        txtNamHoc.Margin = new Padding(6, 8, 6, 8);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PasswordChar = '\0';
        txtNamHoc.PlaceholderText = "Năm học";
        txtNamHoc.SelectedText = "";
        txtNamHoc.Size = new Size(257, 75);
        txtNamHoc.TabIndex = 2;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(250, 60, 76);
        btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(446, 733);
        btnXoa.Margin = new Padding(4, 5, 4, 5);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(126, 75);
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
        btnHuy.Location = new Point(297, 733);
        btnHuy.Margin = new Padding(4, 5, 4, 5);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(126, 75);
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
        btnLuu.Location = new Point(149, 733);
        btnLuu.Margin = new Padding(4, 5, 4, 5);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(126, 75);
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
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(panelRight);
        Controls.Add(panelLeft);
        Margin = new Padding(4, 5, 4, 5);
        Name = "UcLichGiang";
        Size = new Size(1923, 1184);
        panelLeft.ResumeLayout(false);
        panelLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridLichGiang).EndInit();
        panelRight.ResumeLayout(false);
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
    private DataGridViewTextBoxColumn colNgay;
    private DataGridViewTextBoxColumn colBuoi;
    private DataGridViewTextBoxColumn colMon;
    private DataGridViewTextBoxColumn colLop;
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
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
}
