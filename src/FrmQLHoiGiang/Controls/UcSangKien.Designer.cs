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
        components = new System.ComponentModel.Container();
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
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        ((System.ComponentModel.ISupportInitialize)gridSangKien).BeginInit();
        panelRight.SuspendLayout();
        SuspendLayout();
        // 
        // gridSangKien
        // 
        gridSangKien.AllowUserToAddRows = false;
        gridSangKien.AllowUserToDeleteRows = false;
        gridSangKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridSangKien.BackgroundColor = Color.White;
        gridSangKien.BorderStyle = BorderStyle.None;
        gridSangKien.ColumnHeadersHeight = 36;
        gridSangKien.Columns.AddRange(new DataGridViewColumn[] { colTenSangKien, colGiangVien, colNamHoc, colLoai });
        gridSangKien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridSangKien.Location = new Point(16, 88);
        gridSangKien.MultiSelect = false;
        gridSangKien.Name = "gridSangKien";
        gridSangKien.ReadOnly = true;
        gridSangKien.RowHeadersVisible = false;
        gridSangKien.RowTemplate.Height = 32;
        gridSangKien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridSangKien.Size = new Size(608, 536);
        gridSangKien.TabIndex = 0;
        gridSangKien.CellClick += gridSangKien_CellClick;
        // 
        // colTenSangKien
        // 
        colTenSangKien.DataPropertyName = "TenSangKien";
        colTenSangKien.HeaderText = "Tên sáng kiến";
        colTenSangKien.Name = "colTenSangKien";
        colTenSangKien.ReadOnly = true;
        // 
        // colGiangVien
        // 
        colGiangVien.DataPropertyName = "GiangVien";
        colGiangVien.HeaderText = "Giảng viên";
        colGiangVien.Name = "colGiangVien";
        colGiangVien.ReadOnly = true;
        // 
        // colNamHoc
        // 
        colNamHoc.DataPropertyName = "NamHoc";
        colNamHoc.HeaderText = "Năm học";
        colNamHoc.Name = "colNamHoc";
        colNamHoc.ReadOnly = true;
        // 
        // colLoai
        // 
        colLoai.DataPropertyName = "Loai";
        colLoai.HeaderText = "Loại";
        colLoai.Name = "colLoai";
        colLoai.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.Controls.Add(cboXepLoai);
        panelRight.Controls.Add(txtDiaDiem);
        panelRight.Controls.Add(txtThoiGian);
        panelRight.Controls.Add(txtNamHoc);
        panelRight.Controls.Add(txtLinhVuc);
        panelRight.Controls.Add(cboLoai);
        panelRight.Controls.Add(cboTuCach);
        panelRight.Controls.Add(cboGiangVien);
        panelRight.Controls.Add(txtTenSangKien);
        panelRight.Controls.Add(btnXoa);
        panelRight.Controls.Add(btnHuy);
        panelRight.Controls.Add(btnLuu);
        panelRight.Dock = DockStyle.Fill;
        panelRight.FillColor = Color.White;
        panelRight.Location = new Point(640, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(16);
        panelRight.Size = new Size(880, 640);
        panelRight.TabIndex = 1;
        // 
        // cboXepLoai
        // 
        cboXepLoai.BackColor = Color.Transparent;
        cboXepLoai.BorderRadius = 8;
        cboXepLoai.DrawMode = DrawMode.OwnerDrawFixed;
        cboXepLoai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboXepLoai.ItemHeight = 30;
        cboXepLoai.Items.AddRange(new object[] { "Khá", "Tốt", "Xuất sắc" });
        cboXepLoai.Location = new Point(16, 376);
        cboXepLoai.Name = "cboXepLoai";
        cboXepLoai.Size = new Size(280, 36);
        cboXepLoai.TabIndex = 10;
        // 
        // txtDiaDiem
        // 
        txtDiaDiem.BorderRadius = 8;
        txtDiaDiem.Location = new Point(16, 323);
        txtDiaDiem.Name = "txtDiaDiem";
        txtDiaDiem.PlaceholderText = "Địa điểm / phạm vi";
        txtDiaDiem.Size = new Size(360, 45);
        txtDiaDiem.TabIndex = 9;
        // 
        // txtThoiGian
        // 
        txtThoiGian.BorderRadius = 8;
        txtThoiGian.Location = new Point(16, 270);
        txtThoiGian.Name = "txtThoiGian";
        txtThoiGian.PlaceholderText = "Thời gian thực hiện";
        txtThoiGian.Size = new Size(360, 45);
        txtThoiGian.TabIndex = 8;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.Location = new Point(16, 217);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PlaceholderText = "Năm học";
        txtNamHoc.Size = new Size(168, 45);
        txtNamHoc.TabIndex = 7;
        // 
        // txtLinhVuc
        // 
        txtLinhVuc.BorderRadius = 8;
        txtLinhVuc.Location = new Point(16, 164);
        txtLinhVuc.Name = "txtLinhVuc";
        txtLinhVuc.PlaceholderText = "Lĩnh vực";
        txtLinhVuc.Size = new Size(360, 45);
        txtLinhVuc.TabIndex = 6;
        // 
        // cboLoai
        // 
        cboLoai.BackColor = Color.Transparent;
        cboLoai.BorderRadius = 8;
        cboLoai.DrawMode = DrawMode.OwnerDrawFixed;
        cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoai.ItemHeight = 30;
        cboLoai.Items.AddRange(new object[] { "Sáng kiến", "Cải tiến" });
        cboLoai.Location = new Point(220, 118);
        cboLoai.Name = "cboLoai";
        cboLoai.Size = new Size(156, 36);
        cboLoai.TabIndex = 5;
        // 
        // cboTuCach
        // 
        cboTuCach.BackColor = Color.Transparent;
        cboTuCach.BorderRadius = 8;
        cboTuCach.DrawMode = DrawMode.OwnerDrawFixed;
        cboTuCach.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTuCach.ItemHeight = 30;
        cboTuCach.Items.AddRange(new object[] { "Tác giả", "Đồng tác giả" });
        cboTuCach.Location = new Point(16, 118);
        cboTuCach.Name = "cboTuCach";
        cboTuCach.Size = new Size(180, 36);
        cboTuCach.TabIndex = 4;
        // 
        // cboGiangVien
        // 
        cboGiangVien.BackColor = Color.Transparent;
        cboGiangVien.BorderRadius = 8;
        cboGiangVien.DrawMode = DrawMode.OwnerDrawFixed;
        cboGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGiangVien.ItemHeight = 30;
        cboGiangVien.Location = new Point(16, 70);
        cboGiangVien.Name = "cboGiangVien";
        cboGiangVien.Size = new Size(360, 36);
        cboGiangVien.TabIndex = 3;
        // 
        // txtTenSangKien
        // 
        txtTenSangKien.BorderRadius = 8;
        txtTenSangKien.Location = new Point(16, 17);
        txtTenSangKien.Name = "txtTenSangKien";
        txtTenSangKien.PlaceholderText = "Tên sáng kiến";
        txtTenSangKien.Size = new Size(360, 45);
        txtTenSangKien.TabIndex = 2;
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(250, 60, 76);
        btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(288, 440);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(88, 45);
        btnXoa.TabIndex = 1;
        btnXoa.Text = "Xóa";
        btnXoa.Click += btnXoa_Click;
        // 
        // btnHuy
        // 
        btnHuy.BorderRadius = 8;
        btnHuy.FillColor = Color.Gray;
        btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(184, 440);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(88, 45);
        btnHuy.TabIndex = 0;
        btnHuy.Text = "Hủy";
        btnHuy.Visible = false;
        btnHuy.Click += btnHuy_Click;
        // 
        // btnLuu
        // 
        btnLuu.BorderRadius = 8;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnLuu.ForeColor = Color.White;
        btnLuu.Location = new Point(80, 440);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(88, 45);
        btnLuu.TabIndex = 0;
        btnLuu.Text = "Thêm mới";
        btnLuu.Click += btnLuu_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BorderRadius = 8;
        btnLamMoi.FillColor = Color.FromArgb(31, 122, 224);
        btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(16, 4);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(120, 40);
        btnLamMoi.TabIndex = 2;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // panelLeft
        // 
        panelLeft.Controls.Add(gridSangKien);
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.Dock = DockStyle.Left;
        panelLeft.FillColor = Color.FromArgb(245, 247, 250);
        panelLeft.Location = new Point(0, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Size = new Size(640, 640);
        panelLeft.TabIndex = 3;
        // 
        // dialog
        // 
        dialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
        dialog.Caption = "Thông báo";
        dialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning;
        dialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
        dialog.Text = "message";
        // 
        // UcSangKien
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(panelRight);
        Controls.Add(panelLeft);
        Name = "UcSangKien";
        Size = new Size(1520, 640);
        ((System.ComponentModel.ISupportInitialize)gridSangKien).EndInit();
        panelRight.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridSangKien;
    private DataGridViewTextBoxColumn colTenSangKien;
    private DataGridViewTextBoxColumn colGiangVien;
    private DataGridViewTextBoxColumn colNamHoc;
    private DataGridViewTextBoxColumn colLoai;
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
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
}
