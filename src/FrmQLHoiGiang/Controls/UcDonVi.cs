using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcDonVi : UserControl
{
    private readonly BindingSource _binding = new();
    private List<DonVi> _data = new();
    private DonVi? _current;

    public UcDonVi()
    {
        InitializeComponent();
        gridDonVi.AutoGenerateColumns = false;
        gridDonVi.DataSource = _binding;
        LoadKhoa();
        LoadData();
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void LoadKhoa()
    {
        cboKhoa.DataSource = AppServices.Lookup.GetKhoa();
        cboKhoa.DisplayMember = "Name";
        cboKhoa.ValueMember = "Id";
    }

    private void LoadData()
    {
        _data = AppServices.DonVi.GetAll();
        _binding.DataSource = _data;
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtTenDonVi.Text = string.Empty;
        cboKhoa.SelectedIndex = cboKhoa.Items.Count > 0 ? 0 : -1;
        btnLuu.Text = "Thêm mới";
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnHuy.Visible = false;
    }

    private void gridDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        _current = _data[e.RowIndex];
        txtTenDonVi.Text = _current.Name;
        cboKhoa.SelectedValue = _current.KhoaId;
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
        if (string.IsNullOrWhiteSpace(txtTenDonVi.Text) || cboKhoa.SelectedValue == null)
        {
            DialogHelper.ShowWarning(FindForm(), "Vui lòng nhập tên bộ môn và chọn khoa.");
            return;
        }

        var entity = _current ?? new DonVi();
        entity.Name = txtTenDonVi.Text.Trim();
        entity.KhoaId = (int)cboKhoa.SelectedValue;

        try
        {
            AppServices.DonVi.Save(entity);
            AppServices.Lookup.RefreshDonVi();
            LoadData();
        }
        catch (Exception ex)
        {
            DialogHelper.ShowWarning(FindForm(), $"Không thể lưu bộ môn: {ex.Message}");
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            DialogHelper.ShowWarning(FindForm(), "Chọn bộ môn cần xóa.");
            return;
        }

        var confirmed = DialogHelper.Confirm(FindForm(), "Xac nhan xoa?");
        if (!confirmed)
        {
            return;
        }

        try
        {
            AppServices.DonVi.Delete(_current.Id);
            AppServices.Lookup.RefreshDonVi();
            LoadData();
        }
        catch (Exception ex)
        {
            DialogHelper.ShowWarning(FindForm(), $"Không thể xóa: {ex.Message}");
        }
    }
}
