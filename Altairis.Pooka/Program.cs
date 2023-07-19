namespace Altairis.Pooka;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var f = new FormMain();
        f.Show();
        if (!string.IsNullOrEmpty(Settings.Get(Settings.WatchFileName, string.Empty))) f.Hide();
        Application.Run();
    }
}