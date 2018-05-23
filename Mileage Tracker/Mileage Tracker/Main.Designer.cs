namespace Mileage_Tracker
{
  partial class MainForm
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
      this.titleBarPanel = new System.Windows.Forms.Panel();
      this.minButton = new System.Windows.Forms.Button();
      this.closeButton = new System.Windows.Forms.Button();
      this.backPanel = new System.Windows.Forms.Panel();
      this.tripSetPanel = new System.Windows.Forms.Panel();
      this.navPanel = new System.Windows.Forms.Panel();
      this.tripSetButton = new System.Windows.Forms.Button();
      this.mileagePanel = new System.Windows.Forms.Panel();
      this.newTripButton = new System.Windows.Forms.Button();
      this.titleBarPanel.SuspendLayout();
      this.backPanel.SuspendLayout();
      this.navPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // titleBarPanel
      // 
      this.titleBarPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.titleBarPanel.Controls.Add(this.minButton);
      this.titleBarPanel.Controls.Add(this.closeButton);
      this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
      this.titleBarPanel.Name = "titleBarPanel";
      this.titleBarPanel.Size = new System.Drawing.Size(765, 29);
      this.titleBarPanel.TabIndex = 0;
      this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseMove);
      // 
      // minButton
      // 
      this.minButton.BackColor = System.Drawing.Color.SeaGreen;
      this.minButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.minButton.Location = new System.Drawing.Point(705, 0);
      this.minButton.Name = "minButton";
      this.minButton.Size = new System.Drawing.Size(30, 29);
      this.minButton.TabIndex = 0;
      this.minButton.TabStop = false;
      this.minButton.UseVisualStyleBackColor = false;
      // 
      // closeButton
      // 
      this.closeButton.BackColor = System.Drawing.Color.OrangeRed;
      this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.closeButton.Location = new System.Drawing.Point(735, 0);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(30, 29);
      this.closeButton.TabIndex = 0;
      this.closeButton.TabStop = false;
      this.closeButton.UseVisualStyleBackColor = false;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // backPanel
      // 
      this.backPanel.Controls.Add(this.tripSetPanel);
      this.backPanel.Controls.Add(this.mileagePanel);
      this.backPanel.Controls.Add(this.navPanel);
      this.backPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.backPanel.Location = new System.Drawing.Point(0, 29);
      this.backPanel.Name = "backPanel";
      this.backPanel.Size = new System.Drawing.Size(753, 538);
      this.backPanel.TabIndex = 1;
      // 
      // tripSetPanel
      // 
      this.tripSetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tripSetPanel.Location = new System.Drawing.Point(166, 276);
      this.tripSetPanel.Name = "tripSetPanel";
      this.tripSetPanel.Size = new System.Drawing.Size(587, 262);
      this.tripSetPanel.TabIndex = 0;
      // 
      // navPanel
      // 
      this.navPanel.Controls.Add(this.tripSetButton);
      this.navPanel.Controls.Add(this.newTripButton);
      this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.navPanel.Location = new System.Drawing.Point(0, 0);
      this.navPanel.Name = "navPanel";
      this.navPanel.Size = new System.Drawing.Size(166, 538);
      this.navPanel.TabIndex = 0;
      // 
      // tripSetButton
      // 
      this.tripSetButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.tripSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.tripSetButton.Location = new System.Drawing.Point(0, 32);
      this.tripSetButton.Name = "tripSetButton";
      this.tripSetButton.Size = new System.Drawing.Size(166, 32);
      this.tripSetButton.TabIndex = 1;
      this.tripSetButton.Text = "Trip Settings";
      this.tripSetButton.UseVisualStyleBackColor = true;
      this.tripSetButton.Click += new System.EventHandler(this.tripSetButton_Click);
      // 
      // mileagePanel
      // 
      this.mileagePanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.mileagePanel.Location = new System.Drawing.Point(166, 0);
      this.mileagePanel.Name = "mileagePanel";
      this.mileagePanel.Size = new System.Drawing.Size(587, 276);
      this.mileagePanel.TabIndex = 1;
      // 
      // newTripButton
      // 
      this.newTripButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.newTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.newTripButton.Location = new System.Drawing.Point(0, 0);
      this.newTripButton.Name = "newTripButton";
      this.newTripButton.Size = new System.Drawing.Size(166, 32);
      this.newTripButton.TabIndex = 0;
      this.newTripButton.Text = "New Trip";
      this.newTripButton.UseVisualStyleBackColor = true;
      this.newTripButton.Click += new System.EventHandler(this.newTripButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(765, 567);
      this.Controls.Add(this.backPanel);
      this.Controls.Add(this.titleBarPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Text = "Mileage";
      this.titleBarPanel.ResumeLayout(false);
      this.backPanel.ResumeLayout(false);
      this.navPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel titleBarPanel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button minButton;
    private System.Windows.Forms.Panel backPanel;
    private System.Windows.Forms.Panel tripSetPanel;
    private System.Windows.Forms.Panel mileagePanel;
    private System.Windows.Forms.Panel navPanel;
    private System.Windows.Forms.Button tripSetButton;
    private System.Windows.Forms.Button newTripButton;
  }
}

