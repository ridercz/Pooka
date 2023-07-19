using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Altairis.Pooka;

public partial class FormAbout : Form {
    public FormAbout() {
        this.InitializeComponent();
    }

    private void buttonClose_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void linkLabelProjectUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        OpenBrowser(this.linkLabelProjectUrl.Text);
    }

    public static void OpenBrowser(string url) {
        try {
            Process.Start(url);
        } catch {
            // hack because of this: https://github.com/dotnet/corefx/issues/10361
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                Process.Start("xdg-open", url);
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                Process.Start("open", url);
            } else {
                throw;
            }
        }
    }

    private void FormAbout_Load(object sender, EventArgs e) {
        var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        this.labelTitle.Text = string.Format(this.labelTitle.Text, version);
    }
}
