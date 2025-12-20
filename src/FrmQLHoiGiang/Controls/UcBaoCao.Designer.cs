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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
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
        panelTop.Margin = new Padding(3, 4, 3, 4);
        panelTop.Name = "panelTop";
        panelTop.Padding = new Padding(18, 22, 18, 22);
        panelTop.Size = new Size(1737, 118);
        panelTop.TabIndex = 0;
        panelTop.Paint += panelTop_Paint;
        // 
        // btnTaiBaoCao
        // 
        btnTaiBaoCao.BorderRadius = 8;
        btnTaiBaoCao.FillColor = Color.FromArgb(31, 122, 224);
        btnTaiBaoCao.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnTaiBaoCao.ForeColor = Color.White;
        btnTaiBaoCao.Location = new Point(247, 22);
        btnTaiBaoCao.Margin = new Padding(3, 4, 3, 4);
        btnTaiBaoCao.Name = "btnTaiBaoCao";
        btnTaiBaoCao.Size = new Size(137, 54);
        btnTaiBaoCao.TabIndex = 1;
        btnTaiBaoCao.Text = "Tải báo cáo";
        btnTaiBaoCao.Click += btnTaiBaoCao_Click;
        // 
        // txtNamHoc
        // 
        txtNamHoc.BorderRadius = 8;
        txtNamHoc.DefaultText = "";
        txtNamHoc.Font = new Font("Segoe UI", 16F);
        txtNamHoc.Location = new Point(18, 22);
        txtNamHoc.Margin = new Padding(5, 6, 5, 6);
        txtNamHoc.Name = "txtNamHoc";
        txtNamHoc.PasswordChar = '\0';
        txtNamHoc.PlaceholderText = "Năm học / Năm";
        txtNamHoc.SelectedText = "";
        txtNamHoc.Size = new Size(206, 54);
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
        tabBaoCao.Location = new Point(0, 118);
        tabBaoCao.Margin = new Padding(3, 4, 3, 4);
        tabBaoCao.Name = "tabBaoCao";
        tabBaoCao.SelectedIndex = 0;
        tabBaoCao.Size = new Size(1737, 736);
        tabBaoCao.TabIndex = 1;
        // 
        // tabTiet
        // 
        tabTiet.Controls.Add(tableLayoutTiet);
        tabTiet.Location = new Point(4, 29);
        tabTiet.Margin = new Padding(3, 4, 3, 4);
        tabTiet.Name = "tabTiet";
        tabTiet.Padding = new Padding(9, 10, 9, 10);
        tabTiet.Size = new Size(1729, 703);
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
        tableLayoutTiet.Location = new Point(9, 10);
        tableLayoutTiet.Margin = new Padding(3, 4, 3, 4);
        tableLayoutTiet.Name = "tableLayoutTiet";
        tableLayoutTiet.RowCount = 1;
        tableLayoutTiet.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutTiet.Size = new Size(1711, 683);
        tableLayoutTiet.TabIndex = 2;
        // 
        // gridTietGV
        // 
        gridTietGV.AllowUserToAddRows = false;
        gridTietGV.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridTietGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridTietGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridTietGV.ColumnHeadersHeight = 36;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridTietGV.DefaultCellStyle = dataGridViewCellStyle3;
        gridTietGV.Dock = DockStyle.Fill;
        gridTietGV.GridColor = Color.FromArgb(231, 229, 255);
        gridTietGV.Location = new Point(3, 4);
        gridTietGV.Margin = new Padding(3, 4, 3, 4);
        gridTietGV.Name = "gridTietGV";
        gridTietGV.ReadOnly = true;
        gridTietGV.RowHeadersVisible = false;
        gridTietGV.RowHeadersWidth = 62;
        gridTietGV.RowTemplate.Height = 32;
        gridTietGV.Size = new Size(849, 675);
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
        gridTietGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridTietGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridTietGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridTietGV.ThemeStyle.HeaderStyle.Height = 36;
        gridTietGV.ThemeStyle.ReadOnly = true;
        gridTietGV.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridTietGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridTietGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridTietGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridTietGV.ThemeStyle.RowsStyle.Height = 32;
        gridTietGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridTietGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridTietGV.CellContentClick += gridTietGV_CellContentClick;
        // 
        // gridTietKhoa
        // 
        gridTietKhoa.AllowUserToAddRows = false;
        gridTietKhoa.AllowUserToDeleteRows = false;
        dataGridViewCellStyle4.BackColor = Color.White;
        gridTietKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle5.ForeColor = Color.White;
        dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
        gridTietKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        gridTietKhoa.ColumnHeadersHeight = 36;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.White;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        gridTietKhoa.DefaultCellStyle = dataGridViewCellStyle6;
        gridTietKhoa.Dock = DockStyle.Fill;
        gridTietKhoa.GridColor = Color.FromArgb(231, 229, 255);
        gridTietKhoa.Location = new Point(858, 4);
        gridTietKhoa.Margin = new Padding(3, 4, 3, 4);
        gridTietKhoa.Name = "gridTietKhoa";
        gridTietKhoa.ReadOnly = true;
        gridTietKhoa.RowHeadersVisible = false;
        gridTietKhoa.RowHeadersWidth = 62;
        gridTietKhoa.RowTemplate.Height = 32;
        gridTietKhoa.Size = new Size(850, 675);
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
        gridTietKhoa.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridTietKhoa.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridTietKhoa.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridTietKhoa.ThemeStyle.HeaderStyle.Height = 36;
        gridTietKhoa.ThemeStyle.ReadOnly = true;
        gridTietKhoa.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridTietKhoa.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridTietKhoa.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridTietKhoa.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridTietKhoa.ThemeStyle.RowsStyle.Height = 32;
        gridTietKhoa.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridTietKhoa.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabSangKien
        // 
        tabSangKien.Controls.Add(gridSangKien);
        tabSangKien.Location = new Point(4, 29);
        tabSangKien.Margin = new Padding(3, 4, 3, 4);
        tabSangKien.Name = "tabSangKien";
        tabSangKien.Padding = new Padding(9, 10, 9, 10);
        tabSangKien.Size = new Size(1729, 703);
        tabSangKien.TabIndex = 1;
        tabSangKien.Text = "Sáng kiến";
        tabSangKien.UseVisualStyleBackColor = true;
        // 
        // gridSangKien
        // 
        gridSangKien.AllowUserToAddRows = false;
        gridSangKien.AllowUserToDeleteRows = false;
        dataGridViewCellStyle7.BackColor = Color.White;
        gridSangKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
        dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle8.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle8.ForeColor = Color.White;
        dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
        gridSangKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
        gridSangKien.ColumnHeadersHeight = 36;
        dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle9.BackColor = Color.White;
        dataGridViewCellStyle9.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
        gridSangKien.DefaultCellStyle = dataGridViewCellStyle9;
        gridSangKien.Dock = DockStyle.Fill;
        gridSangKien.GridColor = Color.FromArgb(231, 229, 255);
        gridSangKien.Location = new Point(9, 10);
        gridSangKien.Margin = new Padding(3, 4, 3, 4);
        gridSangKien.Name = "gridSangKien";
        gridSangKien.ReadOnly = true;
        gridSangKien.RowHeadersVisible = false;
        gridSangKien.RowHeadersWidth = 62;
        gridSangKien.RowTemplate.Height = 32;
        gridSangKien.Size = new Size(1711, 683);
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
        gridSangKien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridSangKien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridSangKien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridSangKien.ThemeStyle.HeaderStyle.Height = 36;
        gridSangKien.ThemeStyle.ReadOnly = true;
        gridSangKien.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridSangKien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridSangKien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridSangKien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridSangKien.ThemeStyle.RowsStyle.Height = 32;
        gridSangKien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridSangKien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabGiaiThuong
        // 
        tabGiaiThuong.Controls.Add(gridGiaiThuong);
        tabGiaiThuong.Location = new Point(4, 29);
        tabGiaiThuong.Margin = new Padding(3, 4, 3, 4);
        tabGiaiThuong.Name = "tabGiaiThuong";
        tabGiaiThuong.Padding = new Padding(9, 10, 9, 10);
        tabGiaiThuong.Size = new Size(1729, 703);
        tabGiaiThuong.TabIndex = 2;
        tabGiaiThuong.Text = "Giải thưởng";
        tabGiaiThuong.UseVisualStyleBackColor = true;
        // 
        // gridGiaiThuong
        // 
        gridGiaiThuong.AllowUserToAddRows = false;
        gridGiaiThuong.AllowUserToDeleteRows = false;
        dataGridViewCellStyle10.BackColor = Color.White;
        gridGiaiThuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
        dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle11.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle11.ForeColor = Color.White;
        dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
        gridGiaiThuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
        gridGiaiThuong.ColumnHeadersHeight = 36;
        dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle12.BackColor = Color.White;
        dataGridViewCellStyle12.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
        gridGiaiThuong.DefaultCellStyle = dataGridViewCellStyle12;
        gridGiaiThuong.Dock = DockStyle.Fill;
        gridGiaiThuong.GridColor = Color.FromArgb(231, 229, 255);
        gridGiaiThuong.Location = new Point(9, 10);
        gridGiaiThuong.Margin = new Padding(3, 4, 3, 4);
        gridGiaiThuong.Name = "gridGiaiThuong";
        gridGiaiThuong.ReadOnly = true;
        gridGiaiThuong.RowHeadersVisible = false;
        gridGiaiThuong.RowHeadersWidth = 62;
        gridGiaiThuong.RowTemplate.Height = 32;
        gridGiaiThuong.Size = new Size(1711, 683);
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
        gridGiaiThuong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridGiaiThuong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridGiaiThuong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridGiaiThuong.ThemeStyle.HeaderStyle.Height = 36;
        gridGiaiThuong.ThemeStyle.ReadOnly = true;
        gridGiaiThuong.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridGiaiThuong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridGiaiThuong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridGiaiThuong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridGiaiThuong.ThemeStyle.RowsStyle.Height = 32;
        gridGiaiThuong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridGiaiThuong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabHoiDong
        // 
        tabHoiDong.Controls.Add(gridHoiDong);
        tabHoiDong.Location = new Point(4, 29);
        tabHoiDong.Margin = new Padding(3, 4, 3, 4);
        tabHoiDong.Name = "tabHoiDong";
        tabHoiDong.Padding = new Padding(9, 10, 9, 10);
        tabHoiDong.Size = new Size(1729, 703);
        tabHoiDong.TabIndex = 3;
        tabHoiDong.Text = "Hội đồng";
        tabHoiDong.UseVisualStyleBackColor = true;
        // 
        // gridHoiDong
        // 
        gridHoiDong.AllowUserToAddRows = false;
        gridHoiDong.AllowUserToDeleteRows = false;
        dataGridViewCellStyle13.BackColor = Color.White;
        gridHoiDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
        dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle14.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle14.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle14.ForeColor = Color.White;
        dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
        gridHoiDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
        gridHoiDong.ColumnHeadersHeight = 36;
        dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle15.BackColor = Color.White;
        dataGridViewCellStyle15.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
        gridHoiDong.DefaultCellStyle = dataGridViewCellStyle15;
        gridHoiDong.Dock = DockStyle.Fill;
        gridHoiDong.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiDong.Location = new Point(9, 10);
        gridHoiDong.Margin = new Padding(3, 4, 3, 4);
        gridHoiDong.Name = "gridHoiDong";
        gridHoiDong.ReadOnly = true;
        gridHoiDong.RowHeadersVisible = false;
        gridHoiDong.RowHeadersWidth = 62;
        gridHoiDong.RowTemplate.Height = 32;
        gridHoiDong.Size = new Size(1711, 683);
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
        gridHoiDong.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridHoiDong.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridHoiDong.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridHoiDong.ThemeStyle.HeaderStyle.Height = 36;
        gridHoiDong.ThemeStyle.ReadOnly = true;
        gridHoiDong.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridHoiDong.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridHoiDong.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridHoiDong.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridHoiDong.ThemeStyle.RowsStyle.Height = 32;
        gridHoiDong.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridHoiDong.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // tabHoiGiang
        // 
        tabHoiGiang.Controls.Add(gridHoiGiang);
        tabHoiGiang.Location = new Point(4, 29);
        tabHoiGiang.Margin = new Padding(3, 4, 3, 4);
        tabHoiGiang.Name = "tabHoiGiang";
        tabHoiGiang.Padding = new Padding(9, 10, 9, 10);
        tabHoiGiang.Size = new Size(1729, 703);
        tabHoiGiang.TabIndex = 4;
        tabHoiGiang.Text = "Hội giảng";
        tabHoiGiang.UseVisualStyleBackColor = true;
        // 
        // gridHoiGiang
        // 
        gridHoiGiang.AllowUserToAddRows = false;
        gridHoiGiang.AllowUserToDeleteRows = false;
        dataGridViewCellStyle16.BackColor = Color.White;
        gridHoiGiang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
        dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle17.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle17.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle17.ForeColor = Color.White;
        dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
        gridHoiGiang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
        gridHoiGiang.ColumnHeadersHeight = 36;
        dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle18.BackColor = Color.White;
        dataGridViewCellStyle18.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle18.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
        gridHoiGiang.DefaultCellStyle = dataGridViewCellStyle18;
        gridHoiGiang.Dock = DockStyle.Fill;
        gridHoiGiang.GridColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.Location = new Point(9, 10);
        gridHoiGiang.Margin = new Padding(3, 4, 3, 4);
        gridHoiGiang.Name = "gridHoiGiang";
        gridHoiGiang.ReadOnly = true;
        gridHoiGiang.RowHeadersVisible = false;
        gridHoiGiang.RowHeadersWidth = 62;
        gridHoiGiang.RowTemplate.Height = 32;
        gridHoiGiang.Size = new Size(1711, 683);
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
        gridHoiGiang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridHoiGiang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridHoiGiang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridHoiGiang.ThemeStyle.HeaderStyle.Height = 36;
        gridHoiGiang.ThemeStyle.ReadOnly = true;
        gridHoiGiang.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridHoiGiang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridHoiGiang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridHoiGiang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridHoiGiang.ThemeStyle.RowsStyle.Height = 32;
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridHoiGiang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        // 
        // UcBaoCao
        // 
        AutoScaleMode = AutoScaleMode.None;
        Controls.Add(tabBaoCao);
        Controls.Add(panelTop);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcBaoCao";
        Size = new Size(1737, 854);
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
