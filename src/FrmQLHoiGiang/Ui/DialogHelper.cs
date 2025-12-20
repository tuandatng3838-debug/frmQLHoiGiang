using System.Windows.Forms;

namespace FrmQLHoiGiang.Ui;

public static class DialogHelper
{
    public static void ShowInfo(IWin32Window? owner, string message, string caption = "Thong bao")
    {
        MessageBox.Show(owner, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void ShowWarning(IWin32Window? owner, string message, string caption = "Thong bao")
    {
        MessageBox.Show(owner, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void ShowError(IWin32Window? owner, string message, string caption = "Thong bao")
    {
        MessageBox.Show(owner, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static bool Confirm(IWin32Window? owner, string message, string caption = "Xac nhan")
    {
        return MessageBox.Show(owner, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            == DialogResult.Yes;
    }
}
