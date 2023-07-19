using System.Diagnostics;

namespace Altairis.Pooka;

public partial class FormMain : Form {
    private string watchFileName = string.Empty;
    bool? lastFileExists = null;

    public FormMain() {
        this.InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e) {
        // Read configuration
        this.watchFileName = Settings.Get(Settings.WatchFileName, string.Empty);
        this.textBoxWatchFileName.Text = this.watchFileName;

        var plugAction = Settings.Get(Settings.OnPlugAction, Settings.OnPlugActionDefault);
        switch (plugAction.ToLower()) {
            case "lock":
                this.radioButtonPluggedLock.Checked = true;
                break;
            case "shutdown":
                this.radioButtonPluggedShutdown.Checked = true;
                break;
            case "":
                this.radioButtonPluggedNothing.Checked = true;
                break;
            default:
                this.radioButtonPluggedCustom.Checked = true;
                this.textBoxPluggedCommand.Text = plugAction;
                break;
        }

        var unplugAction = Settings.Get(Settings.OnUnplugAction, Settings.OnUnplugActionDefault);
        switch (unplugAction.ToLower()) {
            case "lock":
                this.radioButtonUnpluggedLock.Checked = true;
                break;
            case "shutdown":
                this.radioButtonUnpluggedShutdown.Checked = true;
                break;
            case "":
                this.radioButtonUnpluggedNothing.Checked = true;
                break;
            default:
                this.radioButtonUnpluggedCustom.Checked = true;
                this.textBoxUnpluggedCommand.Text = plugAction;
                break;
        }

        // Configure timer
        this.timerCheck.Interval = Settings.Get(Settings.WatchFileInterval, Settings.WatchFileIntervalDefault);
        this.timerCheck.Enabled = Settings.Get(Settings.Active, true);
        this.activeToolStripMenuItem.Checked = this.timerCheck.Enabled;
    }

    // Control event handlers

    private void buttonSave_Click(object sender, EventArgs e) {
        // Save configuration
        this.watchFileName = this.textBoxWatchFileName.Text;
        Settings.Set(Settings.WatchFileName, this.watchFileName);
        Settings.Set(Settings.WatchFileInterval, this.timerCheck.Interval);

        if (this.radioButtonPluggedCustom.Checked) {
            Settings.Set(Settings.OnPlugAction, this.textBoxPluggedCommand.Text);
        } else if (this.radioButtonPluggedLock.Checked) {
            Settings.Set(Settings.OnPlugAction, "lock");
        } else if (this.radioButtonPluggedShutdown.Checked) {
            Settings.Set(Settings.OnPlugAction, "shutdown");
        } else {
            Settings.Set(Settings.OnPlugAction, "");
        }

        if (this.radioButtonUnpluggedCustom.Checked) {
            Settings.Set(Settings.OnUnplugAction, this.textBoxUnpluggedCommand.Text);
        } else if (this.radioButtonUnpluggedLock.Checked) {
            Settings.Set(Settings.OnUnplugAction, "lock");
        } else if (this.radioButtonUnpluggedShutdown.Checked) {
            Settings.Set(Settings.OnUnplugAction, "shutdown");
        } else {
            Settings.Set(Settings.OnUnplugAction, "");
        }

        // Hide form
        this.Hide();
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
        this.Hide();
    }

    private void buttonBrowse_Click(object sender, EventArgs e) {
        if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
            this.textBoxWatchFileName.Text = this.openFileDialog.FileName;
        }
    }

    private void buttonAdvanced_Click(object sender, EventArgs e) {
        var f = new FormAdvancedOptions();
        f.ShowDialog();
    }

    private void timerCheck_Tick(object sender, EventArgs e) {
        // Do nothing if file name is not set
        if (string.IsNullOrEmpty(this.watchFileName)) return;

        // Check if file exists
        var fileExists = false;
        try {
            fileExists = File.Exists(this.watchFileName);
        } catch (Exception) {
            // Ignore
        }

        // Do nothing if status has not changed
        if (fileExists == this.lastFileExists) return;

        if (fileExists) {
            // USB device plugged
            this.notifyIconInactive.Visible = false;
            this.notifyIconPlugged.Visible = true;
            this.notifyIconUnplugged.Visible = false;
            this.notifyIconPlugged.ShowBalloonTip(5000, "Pooka", "USB drive plugged", ToolTipIcon.Info);
            PerformConfiguredAction(Settings.Get(Settings.OnPlugAction, ""));

        } else {
            // USB device unplugged
            this.notifyIconInactive.Visible = false;
            this.notifyIconPlugged.Visible = false;
            this.notifyIconUnplugged.Visible = true;
            this.notifyIconUnplugged.ShowBalloonTip(5000, "Pooka", "USB drive unplugged", ToolTipIcon.Info);
            PerformConfiguredAction(Settings.Get(Settings.OnUnplugAction, ""));
        }

        // Update status
        this.lastFileExists = fileExists;
    }

    // Context menu event handlers

    private void activeToolStripMenuItem_Click(object sender, EventArgs e) {
        if (this.timerCheck.Enabled) {
            // Deactivate
            this.timerCheck.Enabled = false;
            this.activeToolStripMenuItem.Checked = false;
            this.notifyIconInactive.Visible = true;
            this.notifyIconPlugged.Visible = false;
            this.notifyIconUnplugged.Visible = false;
            this.lastFileExists = null;
            Settings.Set(Settings.Active, false);
        } else {
            // Activate
            this.timerCheck.Enabled = true;
            this.activeToolStripMenuItem.Checked = true;
            Settings.Set(Settings.Active, true);
        }
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
        this.Show();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
        using var about = new FormAbout();
        about.ShowDialog();
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
        if (MessageBox.Show("Are you sure you want to quit Pooka?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
    }

    // Helper methods

    private static void PerformConfiguredAction(string command) {
        switch (command.ToLower()) {
            case "lock":
                // Lock workstation
                WindowsOperations.LockWorkStation();
                break;
            case "shutdown":
                // Shutdown computer
                WindowsOperations.Shutdown(Settings.Get(Settings.ShutdownMethod, Settings.ShutdownMethodDefault));
                break;
            case "":
                // Do nothing
                break;
            default:
                // Execute command
                try {
                    Process.Start(command);
                } catch (Exception) {
                    // Ignore
                }
                break;
        }
    }

}
