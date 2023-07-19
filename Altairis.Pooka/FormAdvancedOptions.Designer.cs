namespace Altairis.Pooka;

partial class FormAdvancedOptions {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        label1 = new Label();
        label2 = new Label();
        comboMethod = new ComboBox();
        label4 = new Label();
        numericInterval = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericInterval).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(423, 36);
        label1.TabIndex = 0;
        label1.Text = "Modify these options at your own risk! Application must be restarted for some of the changes to have effect.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 45);
        label2.Name = "label2";
        label2.Size = new Size(109, 15);
        label2.TabIndex = 1;
        label2.Text = "Shutdown &method:";
        // 
        // comboMethod
        // 
        comboMethod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        comboMethod.FormattingEnabled = true;
        comboMethod.Items.AddRange(new object[] { "PowerOff", "PowerOff_ForceIfHung", "PowerOff_Force", "Shutdown", "Shutdown_ForceIfHung", "Shutdown_Force" });
        comboMethod.Location = new Point(158, 42);
        comboMethod.Name = "comboMethod";
        comboMethod.Size = new Size(274, 23);
        comboMethod.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(11, 73);
        label4.Name = "label4";
        label4.Size = new Size(112, 15);
        label4.TabIndex = 5;
        label4.Text = "Check &interval (ms):";
        // 
        // numericInterval
        // 
        numericInterval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        numericInterval.Increment = new decimal(new int[] { 100, 0, 0, 0 });
        numericInterval.Location = new Point(158, 71);
        numericInterval.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
        numericInterval.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
        numericInterval.Name = "numericInterval";
        numericInterval.Size = new Size(273, 23);
        numericInterval.TabIndex = 6;
        numericInterval.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // buttonSave
        // 
        buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonSave.Location = new Point(276, 102);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 7;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += this.buttonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Location = new Point(357, 102);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(75, 23);
        buttonCancel.TabIndex = 8;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += this.buttonCancel_Click;
        // 
        // FormAdvancedOptions
        // 
        this.AcceptButton = buttonSave;
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.CancelButton = buttonCancel;
        this.ClientSize = new Size(444, 135);
        this.Controls.Add(buttonCancel);
        this.Controls.Add(buttonSave);
        this.Controls.Add(numericInterval);
        this.Controls.Add(label4);
        this.Controls.Add(comboMethod);
        this.Controls.Add(label2);
        this.Controls.Add(label1);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FormAdvancedOptions";
        this.Text = "Advanced options";
        this.Load += this.FormAdvancedOptions_Load;
        ((System.ComponentModel.ISupportInitialize)numericInterval).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private ComboBox comboMethod;
    private Label label4;
    private NumericUpDown numericInterval;
    private Button buttonSave;
    private Button buttonCancel;
}