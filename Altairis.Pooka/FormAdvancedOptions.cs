namespace Altairis.Pooka;

public partial class FormAdvancedOptions : Form {
    public FormAdvancedOptions() {
        this.InitializeComponent();
    }
    private void FormAdvancedOptions_Load(object sender, EventArgs e) {
        this.comboMethod.SelectedItem = Settings.Get(Settings.ShutdownMethod, Settings.ShutdownMethodDefault);
        this.numericInterval.Value = Settings.Get(Settings.WatchFileInterval, Settings.WatchFileIntervalDefault);
    }

    private void buttonSave_Click(object sender, EventArgs e) {
        Settings.Set(Settings.ShutdownMethod, this.comboMethod.SelectedItem?.ToString() ?? Settings.ShutdownMethodDefault);
        Settings.Set(Settings.WatchFileInterval, (int)this.numericInterval.Value);
        this.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e) {
        this.Close();
    }

}
