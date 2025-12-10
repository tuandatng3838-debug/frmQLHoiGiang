using FrmQLHoiGiang.Forms;

namespace FrmQLHoiGiang;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmMain());
    }
}
