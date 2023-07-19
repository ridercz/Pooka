namespace Altairis.Pooka;

partial class FormMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        label1 = new Label();
        textBoxWatchFileName = new TextBox();
        buttonSave = new Button();
        buttonBrowse = new Button();
        openFileDialog = new OpenFileDialog();
        groupBoxPlugged = new GroupBox();
        radioButtonPluggedNothing = new RadioButton();
        textBoxPluggedCommand = new TextBox();
        radioButtonPluggedCustom = new RadioButton();
        radioButtonPluggedShutdown = new RadioButton();
        radioButtonPluggedLock = new RadioButton();
        this.timerCheck = new System.Windows.Forms.Timer(this.components);
        groupBoxUnplugged = new GroupBox();
        radioButtonUnpluggedNothing = new RadioButton();
        textBoxUnpluggedCommand = new TextBox();
        radioButtonUnpluggedCustom = new RadioButton();
        radioButtonUnpluggedShutdown = new RadioButton();
        radioButtonUnpluggedLock = new RadioButton();
        buttonCancel = new Button();
        contextMenuStrip = new ContextMenuStrip(this.components);
        activeToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripSeparator();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripSeparator();
        quitToolStripMenuItem = new ToolStripMenuItem();
        notifyIconInactive = new NotifyIcon(this.components);
        notifyIconPlugged = new NotifyIcon(this.components);
        notifyIconUnplugged = new NotifyIcon(this.components);
        buttonAdvanced = new Button();
        groupBoxPlugged.SuspendLayout();
        groupBoxUnplugged.SuspendLayout();
        contextMenuStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(96, 15);
        label1.TabIndex = 0;
        label1.Text = "Watch &file name:";
        // 
        // textBoxWatchFileName
        // 
        textBoxWatchFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxWatchFileName.Location = new Point(12, 27);
        textBoxWatchFileName.Name = "textBoxWatchFileName";
        textBoxWatchFileName.Size = new Size(510, 23);
        textBoxWatchFileName.TabIndex = 1;
        // 
        // buttonSave
        // 
        buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonSave.Location = new Point(399, 326);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 2;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += this.buttonSave_Click;
        // 
        // buttonBrowse
        // 
        buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonBrowse.Location = new Point(528, 27);
        buttonBrowse.Name = "buttonBrowse";
        buttonBrowse.Size = new Size(27, 23);
        buttonBrowse.TabIndex = 3;
        buttonBrowse.Text = "...";
        buttonBrowse.UseVisualStyleBackColor = true;
        buttonBrowse.Click += this.buttonBrowse_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.DefaultExt = "txt";
        openFileDialog.FileName = "watchme.txt";
        openFileDialog.Filter = "Text files|*.txt|All files|*.*";
        openFileDialog.SupportMultiDottedExtensions = true;
        // 
        // groupBoxPlugged
        // 
        groupBoxPlugged.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBoxPlugged.Controls.Add(radioButtonPluggedNothing);
        groupBoxPlugged.Controls.Add(textBoxPluggedCommand);
        groupBoxPlugged.Controls.Add(radioButtonPluggedCustom);
        groupBoxPlugged.Controls.Add(radioButtonPluggedShutdown);
        groupBoxPlugged.Controls.Add(radioButtonPluggedLock);
        groupBoxPlugged.Location = new Point(12, 56);
        groupBoxPlugged.Name = "groupBoxPlugged";
        groupBoxPlugged.Size = new Size(543, 129);
        groupBoxPlugged.TabIndex = 4;
        groupBoxPlugged.TabStop = false;
        groupBoxPlugged.Text = "What to do when &plugged";
        // 
        // radioButtonPluggedNothing
        // 
        radioButtonPluggedNothing.AutoSize = true;
        radioButtonPluggedNothing.Location = new Point(6, 97);
        radioButtonPluggedNothing.Name = "radioButtonPluggedNothing";
        radioButtonPluggedNothing.Size = new Size(84, 19);
        radioButtonPluggedNothing.TabIndex = 4;
        radioButtonPluggedNothing.TabStop = true;
        radioButtonPluggedNothing.Text = "do nothing";
        radioButtonPluggedNothing.UseVisualStyleBackColor = true;
        // 
        // textBoxPluggedCommand
        // 
        textBoxPluggedCommand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxPluggedCommand.Location = new Point(159, 68);
        textBoxPluggedCommand.Name = "textBoxPluggedCommand";
        textBoxPluggedCommand.Size = new Size(378, 23);
        textBoxPluggedCommand.TabIndex = 3;
        // 
        // radioButtonPluggedCustom
        // 
        radioButtonPluggedCustom.AutoSize = true;
        radioButtonPluggedCustom.Location = new Point(6, 72);
        radioButtonPluggedCustom.Name = "radioButtonPluggedCustom";
        radioButtonPluggedCustom.Size = new Size(147, 19);
        radioButtonPluggedCustom.TabIndex = 2;
        radioButtonPluggedCustom.TabStop = true;
        radioButtonPluggedCustom.Text = "run custom command:";
        radioButtonPluggedCustom.UseVisualStyleBackColor = true;
        // 
        // radioButtonPluggedShutdown
        // 
        radioButtonPluggedShutdown.AutoSize = true;
        radioButtonPluggedShutdown.Location = new Point(6, 47);
        radioButtonPluggedShutdown.Name = "radioButtonPluggedShutdown";
        radioButtonPluggedShutdown.Size = new Size(133, 19);
        radioButtonPluggedShutdown.TabIndex = 1;
        radioButtonPluggedShutdown.TabStop = true;
        radioButtonPluggedShutdown.Text = "shutdown computer";
        radioButtonPluggedShutdown.UseVisualStyleBackColor = true;
        // 
        // radioButtonPluggedLock
        // 
        radioButtonPluggedLock.AutoSize = true;
        radioButtonPluggedLock.Location = new Point(6, 22);
        radioButtonPluggedLock.Name = "radioButtonPluggedLock";
        radioButtonPluggedLock.Size = new Size(112, 19);
        radioButtonPluggedLock.TabIndex = 0;
        radioButtonPluggedLock.TabStop = true;
        radioButtonPluggedLock.Text = "lock workstation";
        radioButtonPluggedLock.UseVisualStyleBackColor = true;
        // 
        // timerCheck
        // 
        this.timerCheck.Interval = 1000;
        this.timerCheck.Tick += this.timerCheck_Tick;
        // 
        // groupBoxUnplugged
        // 
        groupBoxUnplugged.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBoxUnplugged.Controls.Add(radioButtonUnpluggedNothing);
        groupBoxUnplugged.Controls.Add(textBoxUnpluggedCommand);
        groupBoxUnplugged.Controls.Add(radioButtonUnpluggedCustom);
        groupBoxUnplugged.Controls.Add(radioButtonUnpluggedShutdown);
        groupBoxUnplugged.Controls.Add(radioButtonUnpluggedLock);
        groupBoxUnplugged.Location = new Point(12, 191);
        groupBoxUnplugged.Name = "groupBoxUnplugged";
        groupBoxUnplugged.Size = new Size(543, 129);
        groupBoxUnplugged.TabIndex = 5;
        groupBoxUnplugged.TabStop = false;
        groupBoxUnplugged.Text = "What to do when &unplugged";
        // 
        // radioButtonUnpluggedNothing
        // 
        radioButtonUnpluggedNothing.AutoSize = true;
        radioButtonUnpluggedNothing.Location = new Point(6, 97);
        radioButtonUnpluggedNothing.Name = "radioButtonUnpluggedNothing";
        radioButtonUnpluggedNothing.Size = new Size(84, 19);
        radioButtonUnpluggedNothing.TabIndex = 4;
        radioButtonUnpluggedNothing.TabStop = true;
        radioButtonUnpluggedNothing.Text = "do nothing";
        radioButtonUnpluggedNothing.UseVisualStyleBackColor = true;
        // 
        // textBoxUnpluggedCommand
        // 
        textBoxUnpluggedCommand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxUnpluggedCommand.Location = new Point(159, 68);
        textBoxUnpluggedCommand.Name = "textBoxUnpluggedCommand";
        textBoxUnpluggedCommand.Size = new Size(378, 23);
        textBoxUnpluggedCommand.TabIndex = 3;
        // 
        // radioButtonUnpluggedCustom
        // 
        radioButtonUnpluggedCustom.AutoSize = true;
        radioButtonUnpluggedCustom.Location = new Point(6, 72);
        radioButtonUnpluggedCustom.Name = "radioButtonUnpluggedCustom";
        radioButtonUnpluggedCustom.Size = new Size(147, 19);
        radioButtonUnpluggedCustom.TabIndex = 2;
        radioButtonUnpluggedCustom.TabStop = true;
        radioButtonUnpluggedCustom.Text = "run custom command:";
        radioButtonUnpluggedCustom.UseVisualStyleBackColor = true;
        // 
        // radioButtonUnpluggedShutdown
        // 
        radioButtonUnpluggedShutdown.AutoSize = true;
        radioButtonUnpluggedShutdown.Location = new Point(6, 47);
        radioButtonUnpluggedShutdown.Name = "radioButtonUnpluggedShutdown";
        radioButtonUnpluggedShutdown.Size = new Size(133, 19);
        radioButtonUnpluggedShutdown.TabIndex = 1;
        radioButtonUnpluggedShutdown.TabStop = true;
        radioButtonUnpluggedShutdown.Text = "shutdown computer";
        radioButtonUnpluggedShutdown.UseVisualStyleBackColor = true;
        // 
        // radioButtonUnpluggedLock
        // 
        radioButtonUnpluggedLock.AutoSize = true;
        radioButtonUnpluggedLock.Location = new Point(6, 22);
        radioButtonUnpluggedLock.Name = "radioButtonUnpluggedLock";
        radioButtonUnpluggedLock.Size = new Size(112, 19);
        radioButtonUnpluggedLock.TabIndex = 0;
        radioButtonUnpluggedLock.TabStop = true;
        radioButtonUnpluggedLock.Text = "lock workstation";
        radioButtonUnpluggedLock.UseVisualStyleBackColor = true;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Location = new Point(480, 326);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(75, 23);
        buttonCancel.TabIndex = 6;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += this.buttonCancel_Click;
        // 
        // contextMenuStrip
        // 
        contextMenuStrip.Items.AddRange(new ToolStripItem[] { activeToolStripMenuItem, toolStripMenuItem1, optionsToolStripMenuItem, aboutToolStripMenuItem, toolStripMenuItem2, quitToolStripMenuItem });
        contextMenuStrip.Name = "contextMenuStrip";
        contextMenuStrip.Size = new Size(126, 104);
        // 
        // activeToolStripMenuItem
        // 
        activeToolStripMenuItem.Name = "activeToolStripMenuItem";
        activeToolStripMenuItem.Size = new Size(125, 22);
        activeToolStripMenuItem.Text = "&Active";
        activeToolStripMenuItem.Click += this.activeToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(122, 6);
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(125, 22);
        optionsToolStripMenuItem.Text = "&Options...";
        optionsToolStripMenuItem.Click += this.optionsToolStripMenuItem_Click;
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(125, 22);
        aboutToolStripMenuItem.Text = "A&bout...";
        aboutToolStripMenuItem.Click += this.aboutToolStripMenuItem_Click;
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(122, 6);
        // 
        // quitToolStripMenuItem
        // 
        quitToolStripMenuItem.Name = "quitToolStripMenuItem";
        quitToolStripMenuItem.Size = new Size(125, 22);
        quitToolStripMenuItem.Text = "&Quit";
        quitToolStripMenuItem.Click += this.quitToolStripMenuItem_Click;
        // 
        // notifyIconInactive
        // 
        notifyIconInactive.ContextMenuStrip = contextMenuStrip;
        notifyIconInactive.Icon = (Icon)resources.GetObject("notifyIconInactive.Icon");
        notifyIconInactive.Text = "Pooka (inactive)";
        notifyIconInactive.Visible = true;
        // 
        // notifyIconPlugged
        // 
        notifyIconPlugged.ContextMenuStrip = contextMenuStrip;
        notifyIconPlugged.Icon = (Icon)resources.GetObject("notifyIconPlugged.Icon");
        notifyIconPlugged.Text = "Pooka (plugged)";
        // 
        // notifyIconUnplugged
        // 
        notifyIconUnplugged.ContextMenuStrip = contextMenuStrip;
        notifyIconUnplugged.Icon = (Icon)resources.GetObject("notifyIconUnplugged.Icon");
        notifyIconUnplugged.Text = "Pooka (unplugged)";
        // 
        // buttonAdvanced
        // 
        buttonAdvanced.Location = new Point(12, 327);
        buttonAdvanced.Name = "buttonAdvanced";
        buttonAdvanced.Size = new Size(75, 23);
        buttonAdvanced.TabIndex = 7;
        buttonAdvanced.Text = "&Advanced...";
        buttonAdvanced.UseVisualStyleBackColor = true;
        buttonAdvanced.Click += this.buttonAdvanced_Click;
        // 
        // FormMain
        // 
        this.AcceptButton = buttonSave;
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.CancelButton = buttonCancel;
        this.ClientSize = new Size(567, 362);
        this.ControlBox = false;
        this.Controls.Add(buttonAdvanced);
        this.Controls.Add(buttonCancel);
        this.Controls.Add(groupBoxUnplugged);
        this.Controls.Add(groupBoxPlugged);
        this.Controls.Add(buttonBrowse);
        this.Controls.Add(buttonSave);
        this.Controls.Add(textBoxWatchFileName);
        this.Controls.Add(label1);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FormMain";
        this.Text = "Pooka options";
        this.Load += this.FormMain_Load;
        groupBoxPlugged.ResumeLayout(false);
        groupBoxPlugged.PerformLayout();
        groupBoxUnplugged.ResumeLayout(false);
        groupBoxUnplugged.PerformLayout();
        contextMenuStrip.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxWatchFileName;
    private Button buttonSave;
    private Button buttonBrowse;
    private OpenFileDialog openFileDialog;
    private GroupBox groupBoxPlugged;
    private RadioButton radioButtonPluggedCustom;
    private RadioButton radioButtonPluggedShutdown;
    private RadioButton radioButtonPluggedLock;
    private TextBox textBoxPluggedCommand;
    private RadioButton radioButtonPluggedNothing;
    private System.Windows.Forms.Timer timerCheck;
    private GroupBox groupBoxUnplugged;
    private RadioButton radioButtonUnpluggedNothing;
    private TextBox textBoxUnpluggedCommand;
    private RadioButton radioButtonUnpluggedCustom;
    private RadioButton radioButtonUnpluggedShutdown;
    private RadioButton radioButtonUnpluggedLock;
    private Button buttonCancel;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem activeToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem quitToolStripMenuItem;
    private NotifyIcon notifyIconInactive;
    private NotifyIcon notifyIconPlugged;
    private NotifyIcon notifyIconUnplugged;
    private Button buttonAdvanced;
}
