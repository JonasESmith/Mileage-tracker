namespace Mileage
{
  partial class mileageForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.startButton = new System.Windows.Forms.Button();
      this.endButton = new System.Windows.Forms.Button();
      this.cancleButton = new System.Windows.Forms.Button();
      this.mtBtn = new System.Windows.Forms.Button();
      this.fvBtn = new System.Windows.Forms.Button();
      this.officeBtn = new System.Windows.Forms.Button();
      this.jhBtn = new System.Windows.Forms.Button();
      this.coBtn = new System.Windows.Forms.Button();
      this.msBtn = new System.Windows.Forms.Button();
      this.imcBtn = new System.Windows.Forms.Button();
      this.stBtn = new System.Windows.Forms.Button();
      this.hsBtn = new System.Windows.Forms.Button();
      this.pvBt = new System.Windows.Forms.Button();
      this.echBtn = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.closeButton = new System.Windows.Forms.Button();
      this.rightPanel = new System.Windows.Forms.Panel();
      this.newTripPanel = new System.Windows.Forms.Panel();
      this.customDGVPanel = new System.Windows.Forms.Panel();
      this.saveButton = new System.Windows.Forms.Button();
      this.ReportPanel = new System.Windows.Forms.Panel();
      this.reportBox = new System.Windows.Forms.TextBox();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.editReportButton = new System.Windows.Forms.Button();
      this.createdByLabel = new System.Windows.Forms.Label();
      this.viewReportButton = new System.Windows.Forms.Button();
      this.newTripButton = new System.Windows.Forms.Button();
      this.settingsButton = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.newTripPanel.SuspendLayout();
      this.ReportPanel.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(323, 19);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(164, 50);
      this.startButton.TabIndex = 2;
      this.startButton.Text = "Start Trip";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // endButton
      // 
      this.endButton.Location = new System.Drawing.Point(323, 252);
      this.endButton.Name = "endButton";
      this.endButton.Size = new System.Drawing.Size(164, 50);
      this.endButton.TabIndex = 3;
      this.endButton.Text = "End Trip";
      this.endButton.UseVisualStyleBackColor = true;
      this.endButton.Visible = false;
      this.endButton.Click += new System.EventHandler(this.endButton_Click);
      // 
      // cancleButton
      // 
      this.cancleButton.Enabled = false;
      this.cancleButton.Location = new System.Drawing.Point(493, 19);
      this.cancleButton.Name = "cancleButton";
      this.cancleButton.Size = new System.Drawing.Size(50, 50);
      this.cancleButton.TabIndex = 4;
      this.cancleButton.Text = "Cancel Trip";
      this.cancleButton.UseVisualStyleBackColor = true;
      this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
      // 
      // mtBtn
      // 
      this.mtBtn.Enabled = false;
      this.mtBtn.Location = new System.Drawing.Point(437, 131);
      this.mtBtn.Name = "mtBtn";
      this.mtBtn.Size = new System.Drawing.Size(50, 50);
      this.mtBtn.TabIndex = 7;
      this.mtBtn.Text = "MT";
      this.mtBtn.UseVisualStyleBackColor = true;
      this.mtBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // fvBtn
      // 
      this.fvBtn.Enabled = false;
      this.fvBtn.Location = new System.Drawing.Point(493, 75);
      this.fvBtn.Name = "fvBtn";
      this.fvBtn.Size = new System.Drawing.Size(50, 50);
      this.fvBtn.TabIndex = 6;
      this.fvBtn.Text = "FV";
      this.fvBtn.UseVisualStyleBackColor = true;
      this.fvBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // officeBtn
      // 
      this.officeBtn.Enabled = false;
      this.officeBtn.Location = new System.Drawing.Point(323, 75);
      this.officeBtn.Name = "officeBtn";
      this.officeBtn.Size = new System.Drawing.Size(108, 50);
      this.officeBtn.TabIndex = 5;
      this.officeBtn.Text = "Office";
      this.officeBtn.UseVisualStyleBackColor = true;
      this.officeBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // jhBtn
      // 
      this.jhBtn.Enabled = false;
      this.jhBtn.Location = new System.Drawing.Point(493, 131);
      this.jhBtn.Name = "jhBtn";
      this.jhBtn.Size = new System.Drawing.Size(50, 50);
      this.jhBtn.TabIndex = 10;
      this.jhBtn.Text = "JH/AD";
      this.jhBtn.UseVisualStyleBackColor = true;
      this.jhBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // coBtn
      // 
      this.coBtn.Enabled = false;
      this.coBtn.Location = new System.Drawing.Point(323, 131);
      this.coBtn.Name = "coBtn";
      this.coBtn.Size = new System.Drawing.Size(50, 50);
      this.coBtn.TabIndex = 9;
      this.coBtn.Text = "CO";
      this.coBtn.UseVisualStyleBackColor = true;
      this.coBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // msBtn
      // 
      this.msBtn.Enabled = false;
      this.msBtn.Location = new System.Drawing.Point(437, 75);
      this.msBtn.Name = "msBtn";
      this.msBtn.Size = new System.Drawing.Size(50, 50);
      this.msBtn.TabIndex = 8;
      this.msBtn.Text = "MS";
      this.msBtn.UseVisualStyleBackColor = true;
      this.msBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // imcBtn
      // 
      this.imcBtn.Enabled = false;
      this.imcBtn.Location = new System.Drawing.Point(379, 187);
      this.imcBtn.Name = "imcBtn";
      this.imcBtn.Size = new System.Drawing.Size(50, 50);
      this.imcBtn.TabIndex = 13;
      this.imcBtn.Text = "IMC";
      this.imcBtn.UseVisualStyleBackColor = true;
      this.imcBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // stBtn
      // 
      this.stBtn.Enabled = false;
      this.stBtn.Location = new System.Drawing.Point(379, 131);
      this.stBtn.Name = "stBtn";
      this.stBtn.Size = new System.Drawing.Size(50, 50);
      this.stBtn.TabIndex = 12;
      this.stBtn.Text = "ST";
      this.stBtn.UseVisualStyleBackColor = true;
      this.stBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // hsBtn
      // 
      this.hsBtn.Enabled = false;
      this.hsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hsBtn.Location = new System.Drawing.Point(437, 187);
      this.hsBtn.Name = "hsBtn";
      this.hsBtn.Size = new System.Drawing.Size(50, 50);
      this.hsBtn.TabIndex = 11;
      this.hsBtn.Text = "HS";
      this.hsBtn.UseVisualStyleBackColor = true;
      this.hsBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // pvBt
      // 
      this.pvBt.Enabled = false;
      this.pvBt.Location = new System.Drawing.Point(323, 187);
      this.pvBt.Name = "pvBt";
      this.pvBt.Size = new System.Drawing.Size(50, 50);
      this.pvBt.TabIndex = 15;
      this.pvBt.Text = "PV";
      this.pvBt.UseVisualStyleBackColor = true;
      this.pvBt.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // echBtn
      // 
      this.echBtn.Enabled = false;
      this.echBtn.Location = new System.Drawing.Point(493, 187);
      this.echBtn.Name = "echBtn";
      this.echBtn.Size = new System.Drawing.Size(50, 50);
      this.echBtn.TabIndex = 14;
      this.echBtn.Text = "ECH";
      this.echBtn.UseVisualStyleBackColor = true;
      this.echBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel1.Controls.Add(this.closeButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(705, 30);
      this.panel1.TabIndex = 17;
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // closeButton
      // 
      this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.closeButton.Location = new System.Drawing.Point(675, 0);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(30, 30);
      this.closeButton.TabIndex = 2;
      this.closeButton.Text = "X";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // rightPanel
      // 
      this.rightPanel.Controls.Add(this.newTripPanel);
      this.rightPanel.Controls.Add(this.ReportPanel);
      this.rightPanel.Controls.Add(this.leftPanel);
      this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rightPanel.Location = new System.Drawing.Point(0, 30);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.Size = new System.Drawing.Size(705, 337);
      this.rightPanel.TabIndex = 18;
      // 
      // newTripPanel
      // 
      this.newTripPanel.Controls.Add(this.customDGVPanel);
      this.newTripPanel.Controls.Add(this.saveButton);
      this.newTripPanel.Controls.Add(this.endButton);
      this.newTripPanel.Controls.Add(this.coBtn);
      this.newTripPanel.Controls.Add(this.msBtn);
      this.newTripPanel.Controls.Add(this.jhBtn);
      this.newTripPanel.Controls.Add(this.mtBtn);
      this.newTripPanel.Controls.Add(this.startButton);
      this.newTripPanel.Controls.Add(this.hsBtn);
      this.newTripPanel.Controls.Add(this.pvBt);
      this.newTripPanel.Controls.Add(this.fvBtn);
      this.newTripPanel.Controls.Add(this.stBtn);
      this.newTripPanel.Controls.Add(this.echBtn);
      this.newTripPanel.Controls.Add(this.officeBtn);
      this.newTripPanel.Controls.Add(this.cancleButton);
      this.newTripPanel.Controls.Add(this.imcBtn);
      this.newTripPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.newTripPanel.Location = new System.Drawing.Point(153, 0);
      this.newTripPanel.Name = "newTripPanel";
      this.newTripPanel.Size = new System.Drawing.Size(552, 327);
      this.newTripPanel.TabIndex = 18;
      this.newTripPanel.Visible = false;
      // 
      // customDGVPanel
      // 
      this.customDGVPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.customDGVPanel.Location = new System.Drawing.Point(0, 0);
      this.customDGVPanel.Name = "customDGVPanel";
      this.customDGVPanel.Size = new System.Drawing.Size(306, 327);
      this.customDGVPanel.TabIndex = 17;
      // 
      // saveButton
      // 
      this.saveButton.Enabled = false;
      this.saveButton.Location = new System.Drawing.Point(437, 281);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(106, 39);
      this.saveButton.TabIndex = 16;
      this.saveButton.Text = "Save Trips";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // ReportPanel
      // 
      this.ReportPanel.Controls.Add(this.reportBox);
      this.ReportPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ReportPanel.Location = new System.Drawing.Point(153, 327);
      this.ReportPanel.Name = "ReportPanel";
      this.ReportPanel.Size = new System.Drawing.Size(552, 10);
      this.ReportPanel.TabIndex = 19;
      this.ReportPanel.Visible = false;
      // 
      // reportBox
      // 
      this.reportBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportBox.Location = new System.Drawing.Point(0, 0);
      this.reportBox.Multiline = true;
      this.reportBox.Name = "reportBox";
      this.reportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.reportBox.Size = new System.Drawing.Size(552, 10);
      this.reportBox.TabIndex = 0;
      // 
      // leftPanel
      // 
      this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.leftPanel.Controls.Add(this.editReportButton);
      this.leftPanel.Controls.Add(this.createdByLabel);
      this.leftPanel.Controls.Add(this.viewReportButton);
      this.leftPanel.Controls.Add(this.newTripButton);
      this.leftPanel.Controls.Add(this.settingsButton);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 0);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(153, 337);
      this.leftPanel.TabIndex = 17;
      // 
      // editReportButton
      // 
      this.editReportButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.editReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.editReportButton.Location = new System.Drawing.Point(0, 78);
      this.editReportButton.Name = "editReportButton";
      this.editReportButton.Size = new System.Drawing.Size(151, 39);
      this.editReportButton.TabIndex = 4;
      this.editReportButton.Text = "Edit Report";
      this.editReportButton.UseVisualStyleBackColor = true;
      this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
      // 
      // createdByLabel
      // 
      this.createdByLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.createdByLabel.Location = new System.Drawing.Point(0, 280);
      this.createdByLabel.Name = "createdByLabel";
      this.createdByLabel.Size = new System.Drawing.Size(151, 21);
      this.createdByLabel.TabIndex = 2;
      this.createdByLabel.Text = "Created by : Jonas Smith";
      this.createdByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // viewReportButton
      // 
      this.viewReportButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.viewReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewReportButton.Location = new System.Drawing.Point(0, 39);
      this.viewReportButton.Name = "viewReportButton";
      this.viewReportButton.Size = new System.Drawing.Size(151, 39);
      this.viewReportButton.TabIndex = 1;
      this.viewReportButton.Text = "View Repot";
      this.viewReportButton.UseVisualStyleBackColor = true;
      this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
      // 
      // newTripButton
      // 
      this.newTripButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.newTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.newTripButton.Location = new System.Drawing.Point(0, 0);
      this.newTripButton.Name = "newTripButton";
      this.newTripButton.Size = new System.Drawing.Size(151, 39);
      this.newTripButton.TabIndex = 0;
      this.newTripButton.Text = "New Trip";
      this.newTripButton.UseVisualStyleBackColor = true;
      this.newTripButton.Click += new System.EventHandler(this.newTripButton_Click);
      // 
      // settingsButton
      // 
      this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.settingsButton.Location = new System.Drawing.Point(0, 301);
      this.settingsButton.Name = "settingsButton";
      this.settingsButton.Size = new System.Drawing.Size(151, 34);
      this.settingsButton.TabIndex = 3;
      this.settingsButton.Text = "Settings";
      this.settingsButton.UseVisualStyleBackColor = true;
      this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
      // 
      // mileageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(705, 367);
      this.Controls.Add(this.rightPanel);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "mileageForm";
      this.Text = "Mileage";
      this.panel1.ResumeLayout(false);
      this.rightPanel.ResumeLayout(false);
      this.newTripPanel.ResumeLayout(false);
      this.ReportPanel.ResumeLayout(false);
      this.ReportPanel.PerformLayout();
      this.leftPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button endButton;
    private System.Windows.Forms.Button cancleButton;
    private System.Windows.Forms.Button mtBtn;
    private System.Windows.Forms.Button fvBtn;
    private System.Windows.Forms.Button officeBtn;
    private System.Windows.Forms.Button jhBtn;
    private System.Windows.Forms.Button coBtn;
    private System.Windows.Forms.Button msBtn;
    private System.Windows.Forms.Button imcBtn;
    private System.Windows.Forms.Button stBtn;
    private System.Windows.Forms.Button hsBtn;
    private System.Windows.Forms.Button pvBt;
    private System.Windows.Forms.Button echBtn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Panel rightPanel;
    private System.Windows.Forms.Panel newTripPanel;
    private System.Windows.Forms.Panel leftPanel;
    private System.Windows.Forms.Button viewReportButton;
    private System.Windows.Forms.Button newTripButton;
    private System.Windows.Forms.Panel ReportPanel;
    private System.Windows.Forms.TextBox reportBox;
    private System.Windows.Forms.Label createdByLabel;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button settingsButton;
    private System.Windows.Forms.Button editReportButton;
    private System.Windows.Forms.Panel customDGVPanel;
  }
}

