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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tripDGV = new System.Windows.Forms.DataGridView();
      this.tripCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.travelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.saveLabel = new System.Windows.Forms.Label();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.tripDGV)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tripDGV
      // 
      this.tripDGV.AllowUserToAddRows = false;
      this.tripDGV.AllowUserToResizeColumns = false;
      this.tripDGV.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.tripDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.tripDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tripDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripCol,
            this.travelCol});
      this.tripDGV.Location = new System.Drawing.Point(12, 27);
      this.tripDGV.Name = "tripDGV";
      this.tripDGV.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.tripDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.tripDGV.RowHeadersVisible = false;
      this.tripDGV.Size = new System.Drawing.Size(300, 239);
      this.tripDGV.TabIndex = 0;
      // 
      // tripCol
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.tripCol.DefaultCellStyle = dataGridViewCellStyle2;
      this.tripCol.HeaderText = "Destinations";
      this.tripCol.Name = "tripCol";
      this.tripCol.ReadOnly = true;
      this.tripCol.Width = 230;
      // 
      // travelCol
      // 
      this.travelCol.HeaderText = "Trip";
      this.travelCol.Name = "travelCol";
      this.travelCol.ReadOnly = true;
      this.travelCol.Width = 50;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(496, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewReportToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // viewReportToolStripMenuItem
      // 
      this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
      this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.viewReportToolStripMenuItem.Text = "View Report";
      this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.RightToLeftAutoMirrorImage = true;
      this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
      this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.aboutToolStripMenuItem.Text = "About....";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(323, 33);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(108, 45);
      this.startButton.TabIndex = 2;
      this.startButton.Text = "Start Trip";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // endButton
      // 
      this.endButton.Location = new System.Drawing.Point(101, 78);
      this.endButton.Name = "endButton";
      this.endButton.Size = new System.Drawing.Size(108, 45);
      this.endButton.TabIndex = 3;
      this.endButton.Text = "End Trip";
      this.endButton.UseVisualStyleBackColor = true;
      this.endButton.Visible = false;
      this.endButton.Click += new System.EventHandler(this.endButton_Click);
      // 
      // cancleButton
      // 
      this.cancleButton.Enabled = false;
      this.cancleButton.Location = new System.Drawing.Point(434, 33);
      this.cancleButton.Name = "cancleButton";
      this.cancleButton.Size = new System.Drawing.Size(50, 45);
      this.cancleButton.TabIndex = 4;
      this.cancleButton.Text = "Cancel Trip";
      this.cancleButton.UseVisualStyleBackColor = true;
      this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
      // 
      // mtBtn
      // 
      this.mtBtn.Enabled = false;
      this.mtBtn.Location = new System.Drawing.Point(434, 125);
      this.mtBtn.Name = "mtBtn";
      this.mtBtn.Size = new System.Drawing.Size(50, 45);
      this.mtBtn.TabIndex = 7;
      this.mtBtn.Text = "MT";
      this.mtBtn.UseVisualStyleBackColor = true;
      this.mtBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // fvBtn
      // 
      this.fvBtn.Enabled = false;
      this.fvBtn.Location = new System.Drawing.Point(434, 79);
      this.fvBtn.Name = "fvBtn";
      this.fvBtn.Size = new System.Drawing.Size(50, 45);
      this.fvBtn.TabIndex = 6;
      this.fvBtn.Text = "FV";
      this.fvBtn.UseVisualStyleBackColor = true;
      this.fvBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // officeBtn
      // 
      this.officeBtn.Enabled = false;
      this.officeBtn.Location = new System.Drawing.Point(323, 79);
      this.officeBtn.Name = "officeBtn";
      this.officeBtn.Size = new System.Drawing.Size(108, 45);
      this.officeBtn.TabIndex = 5;
      this.officeBtn.Text = "Office";
      this.officeBtn.UseVisualStyleBackColor = true;
      this.officeBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // jhBtn
      // 
      this.jhBtn.Enabled = false;
      this.jhBtn.Location = new System.Drawing.Point(434, 172);
      this.jhBtn.Name = "jhBtn";
      this.jhBtn.Size = new System.Drawing.Size(50, 45);
      this.jhBtn.TabIndex = 10;
      this.jhBtn.Text = "JH/AD";
      this.jhBtn.UseVisualStyleBackColor = true;
      this.jhBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // coBtn
      // 
      this.coBtn.Enabled = false;
      this.coBtn.Location = new System.Drawing.Point(379, 126);
      this.coBtn.Name = "coBtn";
      this.coBtn.Size = new System.Drawing.Size(50, 45);
      this.coBtn.TabIndex = 9;
      this.coBtn.Text = "CO";
      this.coBtn.UseVisualStyleBackColor = true;
      this.coBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // msBtn
      // 
      this.msBtn.Enabled = false;
      this.msBtn.Location = new System.Drawing.Point(323, 126);
      this.msBtn.Name = "msBtn";
      this.msBtn.Size = new System.Drawing.Size(50, 45);
      this.msBtn.TabIndex = 8;
      this.msBtn.Text = "MS";
      this.msBtn.UseVisualStyleBackColor = true;
      this.msBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // imcBtn
      // 
      this.imcBtn.Enabled = false;
      this.imcBtn.Location = new System.Drawing.Point(434, 219);
      this.imcBtn.Name = "imcBtn";
      this.imcBtn.Size = new System.Drawing.Size(50, 45);
      this.imcBtn.TabIndex = 13;
      this.imcBtn.Text = "IMC";
      this.imcBtn.UseVisualStyleBackColor = true;
      this.imcBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // stBtn
      // 
      this.stBtn.Enabled = false;
      this.stBtn.Location = new System.Drawing.Point(379, 173);
      this.stBtn.Name = "stBtn";
      this.stBtn.Size = new System.Drawing.Size(50, 45);
      this.stBtn.TabIndex = 12;
      this.stBtn.Text = "ST";
      this.stBtn.UseVisualStyleBackColor = true;
      this.stBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // hsBtn
      // 
      this.hsBtn.Enabled = false;
      this.hsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hsBtn.Location = new System.Drawing.Point(323, 173);
      this.hsBtn.Name = "hsBtn";
      this.hsBtn.Size = new System.Drawing.Size(50, 45);
      this.hsBtn.TabIndex = 11;
      this.hsBtn.Text = "HS";
      this.hsBtn.UseVisualStyleBackColor = true;
      this.hsBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // pvBt
      // 
      this.pvBt.Enabled = false;
      this.pvBt.Location = new System.Drawing.Point(379, 220);
      this.pvBt.Name = "pvBt";
      this.pvBt.Size = new System.Drawing.Size(50, 45);
      this.pvBt.TabIndex = 15;
      this.pvBt.Text = "PV";
      this.pvBt.UseVisualStyleBackColor = true;
      this.pvBt.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // echBtn
      // 
      this.echBtn.Enabled = false;
      this.echBtn.Location = new System.Drawing.Point(323, 220);
      this.echBtn.Name = "echBtn";
      this.echBtn.Size = new System.Drawing.Size(50, 45);
      this.echBtn.TabIndex = 14;
      this.echBtn.Text = "ECH";
      this.echBtn.UseVisualStyleBackColor = true;
      this.echBtn.Click += new System.EventHandler(this.mileageForm_Click);
      // 
      // saveLabel
      // 
      this.saveLabel.AutoSize = true;
      this.saveLabel.Location = new System.Drawing.Point(273, 7);
      this.saveLabel.Name = "saveLabel";
      this.saveLabel.Size = new System.Drawing.Size(0, 13);
      this.saveLabel.TabIndex = 16;
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.settingsToolStripMenuItem.Text = "Settings...";
      this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
      // 
      // mileageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 277);
      this.Controls.Add(this.saveLabel);
      this.Controls.Add(this.pvBt);
      this.Controls.Add(this.echBtn);
      this.Controls.Add(this.imcBtn);
      this.Controls.Add(this.stBtn);
      this.Controls.Add(this.hsBtn);
      this.Controls.Add(this.jhBtn);
      this.Controls.Add(this.coBtn);
      this.Controls.Add(this.msBtn);
      this.Controls.Add(this.mtBtn);
      this.Controls.Add(this.fvBtn);
      this.Controls.Add(this.officeBtn);
      this.Controls.Add(this.cancleButton);
      this.Controls.Add(this.endButton);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.tripDGV);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "mileageForm";
      this.Text = "Mileage";
      ((System.ComponentModel.ISupportInitialize)(this.tripDGV)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView tripDGV;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
    private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn tripCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn travelCol;
    private System.Windows.Forms.Label saveLabel;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
  }
}

