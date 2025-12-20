using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcKhoa : UserControl
{
    private readonly BindingSource _binding = new();
    private List<LookupItem> _data = new();
    private LookupItem? _current;

    public UcKhoa()
    {
        InitializeComponent();
        gridKhoa.AutoGenerateColumns = false;
        gridKhoa.DataSource = _binding;
        LoadData();
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void LoadData()
    {
        _data = AppServices.Khoa.GetAll();
        _binding.DataSource = _data;
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtTenKhoa.Text = string.Empty;
        btnLuu.Text = "Thêm mới";
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnHuy.Visible = false;
    }

    private void gridKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        _current = _data[e.RowIndex];
        txtTenKhoa.Text = _current.Name;
        btnLuu.Text = "Cập nhật";
        btnLuu.FillColor = Color.SeaGreen;
        btnHuy.Visible = true;
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
        {
            dialog.Show("Vui lòng nhập tên khoa.");
            return;
        }

        var entity = _current ?? new LookupItem();
        entity.Name = txtTenKhoa.Text.Trim();

        try
        {
            AppServices.Khoa.Save(entity);
            AppServices.Lookup.RefreshKhoa();
            AppServices.Lookup.RefreshDonVi();
            LoadData();
        }
        catch (Exception ex)
        {
            dialog.Icon = MessageDialogIcon.Error;
            dialog.Show($"Không thể lưu khoa: {ex.Message}");
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            dialog.Show("Chọn khoa cần xóa.");
            return;
        }

        var confirm = new SiticoneMessageDialog
        {
            Caption = "Xác nhận",
            Text = $"Xóa khoa {_current.Name}?",
            Buttons = MessageDialogButtons.YesNo,
            Icon = MessageDialogIcon.Warning
        };

        if (confirm.Show() != DialogResult.Yes)
        {
            return;
        }

        try
        {
            AppServices.Khoa.Delete(_current.Id);
            AppServices.Lookup.RefreshKhoa();
            AppServices.Lookup.RefreshDonVi();
            LoadData();
        }
        catch (Exception ex)
        {
            dialog.Icon = MessageDialogIcon.Error;
            dialog.Show($"Không thể xóa: {ex.Message}");
        }
    }
}
