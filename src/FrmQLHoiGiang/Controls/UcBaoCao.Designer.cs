namespace FrmQLHoiGiang.Controls;

partial class UcBaoCao
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
        DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
        panelTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        btnTaiBaoCao = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtNamHoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        tabBaoCao = new TabControl();
        tabTiet = new TabPage();
        tableLayoutTiet = new TableLayoutPanel();
        gridTietGV = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        gridTietKhoa = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        tabSangKien = new TabPage();
        gridSangKien = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        tabGiaiThuong = new TabPage();
        gridGiaiThuong = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        tabHoiDong = new TabPage();
        gridHoiDong = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        tabHoiGiang = new TabPage();
        gridHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        panelTop.SuspendLayout();
        tabBaoCao.SuspendLayout();
        tabTiet.SuspendLayout();
        tableLayoutTiet.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTietGV).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridTietKhoa).BeginInit();
        tabSangKien.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridSangKien).BeginInit();
        tabGiaiThuong.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridGiaiThuong).BeginInit();
        tabHoiDong.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHoiDong).BeginInit();
        tabHoiGiang.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHoiGiang).BeginInit();
        SuspendLayout();
        // 
        // panelTop
        // 
        panelTop.Controls.Add(btnTaiBaoCao);
        panelTop.Controls.Add(txtNamHoc);
        panelTop.Dock = DockStyle.Top;
        panelTop.FillColor = Color.White;
        panelTop.Location = new Point(0, 0);
        panelTop.Margin = new Padding(4, 5, 4, 5);
        panelTop.Name = "panelTop";
        panelTop.Padding = new Padding(23, 27, 23, 27);
        panelTop.Size = new Size(2171, 147);
        panelTop.TabIndex = 0;
        panelTop.Paint += panelTop_Paint;
        // 
        // btnTaiBaoCao
        // 
        btnTaiBaoCao.BorderRadius = 8;
        btnTaiBaoCao.FillColor = Color.FromArgb(31, 122, 224);
        btnTaiBaoCao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnTaiBaoCao.ForeColor = Color.White;
        btnTaiBaoCao.Location = new Point(314, 27);
        btnTaiBaoCao.Margin = new Padding(4, 5, 4, 5);
        btnTaiBaoCao.Name = "btnTaiBaoCao";
        btnTaiBaoCao.Size = new Size(171, 67);
        btnTaiBaoCao.TabIndex = 1;
        btnTaiBaoCao.Text = "Tải báo cáo";
        btnTaiBaoCao.Click += btnTaiBaoCao_Click;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.DefaultText = "";
        txtNamHoc.Font = new Font("Segoe UI", 9F);
        txtNamHoc.Location = new Point(23, 27);
        txtNamHoc.Margin = new Padding(6, 8, 6, 8);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PasswordChar = '\0';
        txtNamHoc.PlaceholderText = "Năm học / Năm";
        txtNamHoc.SelectedText = "";
        txtNamHoc.Size = new Size(257, 67);
        txtNamHoc.TabIndex = 0;
        // 
        // tabBaoCao
        // 
        tabBaoCao.Controls.Add(tabTiet);
        tabBaoCao.Controls.Add(tabSangKien);
        tabBaoCao.Controls.Add(tabGiaiThuong);
        tabBaoCao.Controls.Add(tabHoiDong);
        tabBaoCao.Controls.Add(tabHoiGiang);
        tabBaoCao.Dock = DockStyle.Fill;
        tabBaoCao.Location = new Point(0, 147);
        tabBaoCao.Margin = new Padding(4, 5, 4, 5);
        tabBaoCao.Name = "tabBaoCao";
        tabBaoCao.SelectedIndex = 0;
        tabBaoCao.Size = new Size(2171, 920);
        tabBaoCao.TabIndex = 1;
        // 
        // tabTiet
        // 
        tabTiet.Controls.Add(tableLayoutTiet);
        tabTiet.Location = new Point(4, 34);
        tabTiet.Margin = new Padding(4, 5, 4, 5);
        tabTiet.Name = "tabTiet";
        tabTiet.Padding = new Padding(11, 13, 11, 13);
        tabTiet.Size = new Size(2163, 882);
        tabTiet.TabIndex = 0;
        tabTiet.Text = "Tiết";
        tabTiet.UseVisualStyleBackColor = true;
        // 
        // tableLayoutTiet
        // 
        tableLayoutTiet.ColumnCount = 2;
        tableLayoutTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutTiet.Controls.Add(gridTietGV, 0, 0);
        tableLayoutTiet.Controls.Add(gridTietKhoa, 1, 0);
        tableLayoutTiet.Dock = DockStyle.Fill;
        tableLayoutTiet.Location = new Point(11, 13);
        tableLayoutTiet.Margin = new Padding(4, 5, 4, 5);
        tableLayoutTiet.Name = "tableLayoutTiet";
        tableLayoutTiet.RowCount = 1;
        tableLayoutTiet.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutTiet.Size = new Size(2141, 856);
        tableLayoutTiet.TabIndex = 2;
        // 
        // gridTietGV
        // 
        gridTietGV.AllowUserToAddRows = false;
        gridTietGV.AllowUserToDeleteRows = false;
        dataGridViewCellStyle19.BackColor = Color.White;
        gridTietGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
        dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle20.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle20.ForeColor = Color.White;
        dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
        gridTietGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
        gridTietGV.ColumnHeadersHeight = 36;
        dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle21.BackColor = Color.White;
        dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle21.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle21.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
        gridTietGV.DefaultCellStyle = dataGridViewCellStyle21;
        gridTietGV.Dock = DockStyle.Fill;
        gridTietGV.GridColor = Color.FromArgb(231, 229, 255);
        gridTietGV.Location = new Point(4, 5);
        gridTietGV.Margin = new Padding(4, 5, 4, 5);
        gridTietGV.Name = "gridTietGV";
        gridTietGV.ReadOnly = true;
        gridTietGV.RowHeadersVisible = false;
        gridTietGV.RowHeadersWidth = 62;
        gridTietGV.RowTemplate.Height = 32;
        gridTietGV.Size = new Size(1062, 846);
        gridTietGV.TabIndex = 0;
        gridTietGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridTietGV.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridTietGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridTietGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridTietGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridTietGV.ThemeStyle.BackColor = Color.White;
        gridTietGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridTietGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridTietGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridTietGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridTietGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridTietGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridTietGV.ThemeStyle.HeaderStyle.Height = 36;
        gridTietGV.ThemeStyle.ReadOnly = true;
        gridTietGV.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridTietGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridTietGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridTietGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridTietGV.ThemeStyle.RowsStyle.Height = 32;
        gridTietGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridTietGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // gridTietKhoa
        // 
        gridTietKhoa.AllowUserToAddRows = false;
        gridTietKhoa.AllowUserToDeleteRows = false;
        dataGridViewCellStyle22.BackColor = Color.White;
        gridTietKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
        dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle23.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle23.ForeColor = Color.White;
        dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
        gridTietKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
        gridTietKhoa.ColumnHeadersHeight = 36;
        dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle24.BackColor = Color.White;
        dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle24.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle24.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
        gridTietKhoa.DefaultCellStyle = dataGridViewCellStyle24;
        gridTietKhoa.Dock = DockStyle.Fill;
        gridTietKhoa.GridColor = Color.FromArgb(231, 229, 255);
        gridTietKhoa.Location = new Point(1074, 5);
        gridTietKhoa.Margin = new Padding(4, 5, 4, 5);
        gridTietKhoa.Name = "gridTietKhoa";
        gridTietKhoa.ReadOnly = true;
        gridTietKhoa.RowHeadersVisible = false;
        gridTietKhoa.RowHeadersWidth = 62;
        gridTietKhoa.RowTemplate.Height = 32;
        gridTietKhoa.Size = new Size(1063, 846);
        gridTietKhoa.TabIndex = 1;
        gridTietKhoa.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridTietKhoa.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridTietKhoa.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridTietKhoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridTietKhoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridTietKhoa.ThemeStyle.BackColor = Color.White;
        gridTietKhoa.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridTietKhoa.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridTietKhoa.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridTietKhoa.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridTietKhoa.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridTietKhoa.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridTietKhoa.ThemeStyle.HeaderStyle.Height = 36;
        gridTietKhoa.ThemeStyle.ReadOnly = true;
        gridTietKhoa.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridTietKhoa.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridTietKhoa.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridTietKhoa.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridTietKhoa.ThemeStyle.RowsStyle.Height = 32;
        gridTietKhoa.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridTietKhoa.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabSangKien
        // 
        tabSangKien.Controls.Add(gridSangKien);
        tabSangKien.Location = new Point(4, 34);
        tabSangKien.Margin = new Padding(4, 5, 4, 5);
        tabSangKien.Name = "tabSangKien";
        tabSangKien.Padding = new Padding(11, 13, 11, 13);
        tabSangKien.Size = new Size(2163, 882);
        tabSangKien.TabIndex = 1;
        tabSangKien.Text = "Sáng kiến";
        tabSangKien.UseVisualStyleBackColor = true;
        // 
        // gridSangKien
        // 
        gridSangKien.AllowUserToAddRows = false;
        gridSangKien.AllowUserToDeleteRows = false;
        dataGridViewCellStyle25.BackColor = Color.White;
        gridSangKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
        dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle26.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle26.ForeColor = Color.White;
        dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
        gridSangKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
        gridSangKien.ColumnHeadersHeight = 36;
        dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle27.BackColor = Color.White;
        dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle27.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle27.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
        gridSangKien.DefaultCellStyle = dataGridViewCellStyle27;
        gridSangKien.Dock = DockStyle.Fill;
        gridSangKien.GridColor = Color.FromArgb(231, 229, 255);
        gridSangKien.Location = new Point(11, 13);
        gridSangKien.Margin = new Padding(4, 5, 4, 5);
        gridSangKien.Name = "gridSangKien";
        gridSangKien.ReadOnly = true;
        gridSangKien.RowHeadersVisible = false;
        gridSangKien.RowHeadersWidth = 62;
        gridSangKien.RowTemplate.Height = 32;
        gridSangKien.Size = new Size(2141, 856);
        gridSangKien.TabIndex = 0;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridSangKien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridSangKien.ThemeStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridSangKien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridSangKien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridSangKien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridSangKien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridSangKien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridSangKien.ThemeStyle.HeaderStyle.Height = 36;
        gridSangKien.ThemeStyle.ReadOnly = true;
        gridSangKien.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridSangKien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridSangKien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridSangKien.ThemeStyle.RowsStyle.Height = 32;
        gridSangKien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridSangKien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabGiaiThuong
        // 
        tabGiaiThuong.Controls.Add(gridGiaiThuong);
        tabGiaiThuong.Location = new Point(4, 34);
        tabGiaiThuong.Margin = new Padding(4, 5, 4, 5);
        tabGiaiThuong.Name = "tabGiaiThuong";
        tabGiaiThuong.Padding = new Padding(11, 13, 11, 13);
        tabGiaiThuong.Size = new Size(2163, 882);
        tabGiaiThuong.TabIndex = 2;
        tabGiaiThuong.Text = "Giải thưởng";
        tabGiaiThuong.UseVisualStyleBackColor = true;
        // 
        // gridGiaiThuong
        // 
        gridGiaiThuong.AllowUserToAddRows = false;
        gridGiaiThuong.AllowUserToDeleteRows = false;
        dataGridViewCellStyle28.BackColor = Color.White;
        gridGiaiThuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
        dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle29.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle29.ForeColor = Color.White;
        dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
        gridGiaiThuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
        gridGiaiThuong.ColumnHeadersHeight = 36;
        dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle30.BackColor = Color.White;
        dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle30.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle30.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
        gridGiaiThuong.DefaultCellStyle = dataGridViewCellStyle30;
        gridGiaiThuong.Dock = DockStyle.Fill;
        gridGiaiThuong.GridColor = Color.FromArgb(231, 229, 255);
        gridGiaiThuong.Location = new Point(11, 13);
        gridGiaiThuong.Margin = new Padding(4, 5, 4, 5);
        gridGiaiThuong.Name = "gridGiaiThuong";
        gridGiaiThuong.ReadOnly = true;
        gridGiaiThuong.RowHeadersVisible = false;
        gridGiaiThuong.RowHeadersWidth = 62;
        gridGiaiThuong.RowTemplate.Height = 32;
        gridGiaiThuong.Size = new Size(2141, 856);
        gridGiaiThuong.TabIndex = 0;
        gridGiaiThuong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridGiaiThuong.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridGiaiThuong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridGiaiThuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridGiaiThuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridGiaiThuong.ThemeStyle.BackColor = Color.White;
        gridGiaiThuong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridGiaiThuong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridGiaiThuong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridGiaiThuong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridGiaiThuong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridGiaiThuong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridGiaiThuong.ThemeStyle.HeaderStyle.Height = 36;
        gridGiaiThuong.ThemeStyle.ReadOnly = true;
        gridGiaiThuong.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridGiaiThuong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridGiaiThuong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridGiaiThuong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridGiaiThuong.ThemeStyle.RowsStyle.Height = 32;
        gridGiaiThuong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridGiaiThuong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabHoiDong
        // 
        tabHoiDong.Controls.Add(gridHoiDong);
        tabHoiDong.Location = new Point(4, 34);
        tabHoiDong.Margin = new Padding(4, 5, 4, 5);
        tabHoiDong.Name = "tabHoiDong";
        tabHoiDong.Padding = new Padding(11, 13, 11, 13);
        tabHoiDong.Size = new Size(2163, 882);
        tabHoiDong.TabIndex = 3;
        tabHoiDong.Text = "Hội đồng";
        tabHoiDong.UseVisualStyleBackColor = true;
        // 
        // gridHoiDong
        // 
        gridHoiDong.AllowUserToAddRows = false;
        gridHoiDong.AllowUserToDeleteRows = false;
        dataGridViewCellStyle31.BackColor = Color.White;
        gridHoiDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
        dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle32.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle32.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle32.ForeColor = Color.White;
        dataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
        gridHoiDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
        gridHoiDong.ColumnHeadersHeight = 36;
        dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle33.BackColor = Color.White;
        dataGridViewCellStyle33.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle33.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle33.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle33.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle33.WrapMode = DataGridViewTriState.False;
        gridHoiDong.DefaultCellStyle = dataGridViewCellStyle33;
        gridHoiDong.Dock = DockStyle.Fill;
        gridHoiDong.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiDong.Location = new Point(11, 13);
        gridHoiDong.Margin = new Padding(4, 5, 4, 5);
        gridHoiDong.Name = "gridHoiDong";
        gridHoiDong.ReadOnly = true;
        gridHoiDong.RowHeadersVisible = false;
        gridHoiDong.RowHeadersWidth = 62;
        gridHoiDong.RowTemplate.Height = 32;
        gridHoiDong.Size = new Size(2141, 856);
        gridHoiDong.TabIndex = 0;
        gridHoiDong.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridHoiDong.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridHoiDong.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridHoiDong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridHoiDong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridHoiDong.ThemeStyle.BackColor = Color.White;
        gridHoiDong.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiDong.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridHoiDong.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridHoiDong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridHoiDong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridHoiDong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridHoiDong.ThemeStyle.HeaderStyle.Height = 36;
        gridHoiDong.ThemeStyle.ReadOnly = true;
        gridHoiDong.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridHoiDong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridHoiDong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridHoiDong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridHoiDong.ThemeStyle.RowsStyle.Height = 32;
        gridHoiDong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridHoiDong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabHoiGiang
        // 
        tabHoiGiang.Controls.Add(gridHoiGiang);
        tabHoiGiang.Location = new Point(4, 34);
        tabHoiGiang.Margin = new Padding(4, 5, 4, 5);
        tabHoiGiang.Name = "tabHoiGiang";
        tabHoiGiang.Padding = new Padding(11, 13, 11, 13);
        tabHoiGiang.Size = new Size(2163, 882);
        tabHoiGiang.TabIndex = 4;
        tabHoiGiang.Text = "Hội giảng";
        tabHoiGiang.UseVisualStyleBackColor = true;
        // 
        // gridHoiGiang
        // 
        gridHoiGiang.AllowUserToAddRows = false;
        gridHoiGiang.AllowUserToDeleteRows = false;
        dataGridViewCellStyle34.BackColor = Color.White;
        gridHoiGiang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
        dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle35.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle35.ForeColor = Color.White;
        dataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
        gridHoiGiang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
        gridHoiGiang.ColumnHeadersHeight = 36;
        dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle36.BackColor = Color.White;
        dataGridViewCellStyle36.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle36.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle36.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle36.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
        gridHoiGiang.DefaultCellStyle = dataGridViewCellStyle36;
        gridHoiGiang.Dock = DockStyle.Fill;
        gridHoiGiang.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.Location = new Point(11, 13);
        gridHoiGiang.Margin = new Padding(4, 5, 4, 5);
        gridHoiGiang.Name = "gridHoiGiang";
        gridHoiGiang.ReadOnly = true;
        gridHoiGiang.RowHeadersVisible = false;
        gridHoiGiang.RowHeadersWidth = 62;
        gridHoiGiang.RowTemplate.Height = 32;
        gridHoiGiang.Size = new Size(2141, 856);
        gridHoiGiang.TabIndex = 0;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridHoiGiang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridHoiGiang.ThemeStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridHoiGiang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        gridHoiGiang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
        gridHoiGiang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridHoiGiang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridHoiGiang.ThemeStyle.HeaderStyle.Height = 36;
        gridHoiGiang.ThemeStyle.ReadOnly = true;
        gridHoiGiang.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridHoiGiang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
        gridHoiGiang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridHoiGiang.ThemeStyle.RowsStyle.Height = 32;
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // UcBaoCao
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabBaoCao);
        Controls.Add(panelTop);
        Margin = new Padding(4, 5, 4, 5);
        Name = "UcBaoCao";
        Size = new Size(2171, 1067);
        panelTop.ResumeLayout(false);
        tabBaoCao.ResumeLayout(false);
        tabTiet.ResumeLayout(false);
        tableLayoutTiet.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridTietGV).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridTietKhoa).EndInit();
        tabSangKien.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridSangKien).EndInit();
        tabGiaiThuong.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridGiaiThuong).EndInit();
        tabHoiDong.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridHoiDong).EndInit();
        tabHoiGiang.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridHoiGiang).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticonePanel panelTop;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnTaiBaoCao;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNamHoc;
    private TabControl tabBaoCao;
    private TabPage tabTiet;
    private TableLayoutPanel tableLayoutTiet;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridTietKhoa;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridTietGV;
    private TabPage tabSangKien;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridSangKien;
    private TabPage tabGiaiThuong;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridGiaiThuong;
    private TabPage tabHoiDong;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridHoiDong;
    private TabPage tabHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridHoiGiang;
}
