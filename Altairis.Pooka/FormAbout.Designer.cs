namespace Altairis.Pooka;

partial class FormAbout {
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
        buttonClose = new Button();
        pictureBox1 = new PictureBox();
        labelTitle = new Label();
        linkLabelProjectUrl = new LinkLabel();
        panel1 = new Panel();
        labelLicense = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // buttonClose
        // 
        buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonClose.Location = new Point(713, 12);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new Size(75, 23);
        buttonClose.TabIndex = 0;
        buttonClose.Text = "Close";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += this.buttonClose_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.pooka_icon_black;
        pictureBox1.Location = new Point(12, 77);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(239, 284);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        labelTitle.Location = new Point(12, 12);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(197, 30);
        labelTitle.TabIndex = 2;
        labelTitle.Text = "Pooka version {0:4}";
        // 
        // linkLabelProjectUrl
        // 
        linkLabelProjectUrl.AutoSize = true;
        linkLabelProjectUrl.Location = new Point(12, 42);
        linkLabelProjectUrl.Name = "linkLabelProjectUrl";
        linkLabelProjectUrl.Size = new Size(187, 15);
        linkLabelProjectUrl.TabIndex = 4;
        linkLabelProjectUrl.TabStop = true;
        linkLabelProjectUrl.Text = "https://github.com/ridercz/Pooka";
        linkLabelProjectUrl.LinkClicked += this.linkLabelProjectUrl_LinkClicked;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ControlLightLight;
        panel1.Controls.Add(labelTitle);
        panel1.Controls.Add(linkLabelProjectUrl);
        panel1.Controls.Add(buttonClose);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 71);
        panel1.TabIndex = 6;
        // 
        // labelLicense
        // 
        labelLicense.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelLicense.Location = new Point(257, 77);
        labelLicense.Name = "labelLicense";
        labelLicense.Size = new Size(531, 287);
        labelLicense.TabIndex = 7;
        labelLicense.Text = resources.GetString("labelLicense.Text");
        // 
        // FormAbout
        // 
        this.AcceptButton = buttonClose;
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.CancelButton = buttonClose;
        this.ClientSize = new Size(800, 373);
        this.ControlBox = false;
        this.Controls.Add(labelLicense);
        this.Controls.Add(panel1);
        this.Controls.Add(pictureBox1);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Name = "FormAbout";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "About Pooka";
        this.Load += this.FormAbout_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Button buttonClose;
    private PictureBox pictureBox1;
    private Label labelTitle;
    private LinkLabel linkLabelProjectUrl;
    private Panel panel1;
    private Label labelLicense;
}