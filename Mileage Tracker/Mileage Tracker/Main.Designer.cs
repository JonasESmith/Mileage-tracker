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
      this.mileagePanel = new System.Windows.Forms.Panel();
      this.tripButtonPanel = new System.Windows.Forms.Panel();
      this.tripSavePanel = new System.Windows.Forms.Panel();
      this.startButton = new System.Windows.Forms.Button();
      this.endButton = new System.Windows.Forms.Button();
      this.saveTripButton = new System.Windows.Forms.Button();
      this.navPanel = new System.Windows.Forms.Panel();
      this.newTripButton = new System.Windows.Forms.Button();
      this.viewTripsButton = new System.Windows.Forms.Button();
      this.backPanel = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.buttonIMC = new System.Windows.Forms.Button();
      this.buttonSTC = new System.Windows.Forms.Button();
      this.buttonOffice = new System.Windows.Forms.Button();
      this.buttonFV = new System.Windows.Forms.Button();
      this.buttonMT = new System.Windows.Forms.Button();
      this.buttonJH = new System.Windows.Forms.Button();
      this.buttonNTC = new System.Windows.Forms.Button();
      this.buttonST = new System.Windows.Forms.Button();
      this.buttonEC = new System.Windows.Forms.Button();
      this.buttonHS = new System.Windows.Forms.Button();
      this.buttonCO = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.titleBarPanel.SuspendLayout();
      this.mileagePanel.SuspendLayout();
      this.tripButtonPanel.SuspendLayout();
      this.tripSavePanel.SuspendLayout();
      this.navPanel.SuspendLayout();
      this.backPanel.SuspendLayout();
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
      this.titleBarPanel.Size = new System.Drawing.Size(637, 29);
      this.titleBarPanel.TabIndex = 0;
      this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseMove);
      // 
      // minButton
      // 
      this.minButton.BackColor = System.Drawing.Color.SeaGreen;
      this.minButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.minButton.Location = new System.Drawing.Point(577, 0);
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
      this.closeButton.Location = new System.Drawing.Point(607, 0);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(30, 29);
      this.closeButton.TabIndex = 0;
      this.closeButton.TabStop = false;
      this.closeButton.UseVisualStyleBackColor = false;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // mileagePanel
      // 
      this.mileagePanel.Controls.Add(this.tripSavePanel);
      this.mileagePanel.Controls.Add(this.tripButtonPanel);
      this.mileagePanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.mileagePanel.Location = new System.Drawing.Point(169, 29);
      this.mileagePanel.Name = "mileagePanel";
      this.mileagePanel.Size = new System.Drawing.Size(468, 325);
      this.mileagePanel.TabIndex = 1;
      // 
      // tripButtonPanel
      // 
      this.tripButtonPanel.Controls.Add(this.buttonST);
      this.tripButtonPanel.Controls.Add(this.buttonEC);
      this.tripButtonPanel.Controls.Add(this.buttonHS);
      this.tripButtonPanel.Controls.Add(this.buttonCO);
      this.tripButtonPanel.Controls.Add(this.buttonFV);
      this.tripButtonPanel.Controls.Add(this.buttonMT);
      this.tripButtonPanel.Controls.Add(this.buttonJH);
      this.tripButtonPanel.Controls.Add(this.buttonNTC);
      this.tripButtonPanel.Controls.Add(this.buttonOffice);
      this.tripButtonPanel.Controls.Add(this.buttonSTC);
      this.tripButtonPanel.Controls.Add(this.buttonIMC);
      this.tripButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.tripButtonPanel.Enabled = false;
      this.tripButtonPanel.Location = new System.Drawing.Point(0, 0);
      this.tripButtonPanel.Name = "tripButtonPanel";
      this.tripButtonPanel.Size = new System.Drawing.Size(313, 325);
      this.tripButtonPanel.TabIndex = 1;
      // 
      // tripSavePanel
      // 
      this.tripSavePanel.Controls.Add(this.panel2);
      this.tripSavePanel.Controls.Add(this.panel1);
      this.tripSavePanel.Controls.Add(this.saveTripButton);
      this.tripSavePanel.Controls.Add(this.endButton);
      this.tripSavePanel.Controls.Add(this.startButton);
      this.tripSavePanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.tripSavePanel.Location = new System.Drawing.Point(313, 0);
      this.tripSavePanel.Name = "tripSavePanel";
      this.tripSavePanel.Size = new System.Drawing.Size(152, 325);
      this.tripSavePanel.TabIndex = 2;
      // 
      // startButton
      // 
      this.startButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.startButton.Location = new System.Drawing.Point(0, 0);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(152, 42);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "Start Trip";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // endButton
      // 
      this.endButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.endButton.Location = new System.Drawing.Point(0, 42);
      this.endButton.Name = "endButton";
      this.endButton.Size = new System.Drawing.Size(152, 42);
      this.endButton.TabIndex = 2;
      this.endButton.Text = "End Trip";
      this.endButton.UseVisualStyleBackColor = true;
      this.endButton.Click += new System.EventHandler(this.endButton_Click);
      // 
      // saveTripButton
      // 
      this.saveTripButton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.saveTripButton.Location = new System.Drawing.Point(0, 283);
      this.saveTripButton.Name = "saveTripButton";
      this.saveTripButton.Size = new System.Drawing.Size(152, 42);
      this.saveTripButton.TabIndex = 3;
      this.saveTripButton.Text = "Save Trip";
      this.saveTripButton.UseVisualStyleBackColor = true;
      // 
      // navPanel
      // 
      this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.navPanel.Controls.Add(this.label1);
      this.navPanel.Controls.Add(this.viewTripsButton);
      this.navPanel.Controls.Add(this.newTripButton);
      this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.navPanel.Location = new System.Drawing.Point(0, 0);
      this.navPanel.Name = "navPanel";
      this.navPanel.Size = new System.Drawing.Size(166, 325);
      this.navPanel.TabIndex = 0;
      // 
      // newTripButton
      // 
      this.newTripButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.newTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.newTripButton.Location = new System.Drawing.Point(0, 0);
      this.newTripButton.Name = "newTripButton";
      this.newTripButton.Size = new System.Drawing.Size(164, 32);
      this.newTripButton.TabIndex = 0;
      this.newTripButton.Text = "New Trip";
      this.newTripButton.UseVisualStyleBackColor = true;
      this.newTripButton.Click += new System.EventHandler(this.newTripButton_Click);
      // 
      // viewTripsButton
      // 
      this.viewTripsButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.viewTripsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewTripsButton.Location = new System.Drawing.Point(0, 32);
      this.viewTripsButton.Name = "viewTripsButton";
      this.viewTripsButton.Size = new System.Drawing.Size(164, 32);
      this.viewTripsButton.TabIndex = 1;
      this.viewTripsButton.Text = "View Trips";
      this.viewTripsButton.UseVisualStyleBackColor = true;
      this.viewTripsButton.Click += new System.EventHandler(this.tripSetButton_Click);
      // 
      // backPanel
      // 
      this.backPanel.Controls.Add(this.navPanel);
      this.backPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.backPanel.Location = new System.Drawing.Point(0, 29);
      this.backPanel.Name = "backPanel";
      this.backPanel.Size = new System.Drawing.Size(169, 325);
      this.backPanel.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 84);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(152, 10);
      this.panel1.TabIndex = 4;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 94);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(152, 48);
      this.panel2.TabIndex = 5;
      // 
      // buttonIMC
      // 
      this.buttonIMC.Location = new System.Drawing.Point(26, 15);
      this.buttonIMC.Name = "buttonIMC";
      this.buttonIMC.Size = new System.Drawing.Size(60, 60);
      this.buttonIMC.TabIndex = 0;
      this.buttonIMC.Text = "IMC";
      this.buttonIMC.UseVisualStyleBackColor = true;
      // 
      // buttonSTC
      // 
      this.buttonSTC.Location = new System.Drawing.Point(26, 82);
      this.buttonSTC.Name = "buttonSTC";
      this.buttonSTC.Size = new System.Drawing.Size(60, 60);
      this.buttonSTC.TabIndex = 1;
      this.buttonSTC.Text = "STC";
      this.buttonSTC.UseVisualStyleBackColor = true;
      // 
      // buttonOffice
      // 
      this.buttonOffice.Location = new System.Drawing.Point(158, 16);
      this.buttonOffice.Name = "buttonOffice";
      this.buttonOffice.Size = new System.Drawing.Size(126, 60);
      this.buttonOffice.TabIndex = 3;
      this.buttonOffice.Text = "IT office";
      this.buttonOffice.UseVisualStyleBackColor = true;
      // 
      // buttonFV
      // 
      this.buttonFV.Location = new System.Drawing.Point(224, 82);
      this.buttonFV.Name = "buttonFV";
      this.buttonFV.Size = new System.Drawing.Size(60, 60);
      this.buttonFV.TabIndex = 7;
      this.buttonFV.Text = "FV";
      this.buttonFV.UseVisualStyleBackColor = true;
      // 
      // buttonMT
      // 
      this.buttonMT.Location = new System.Drawing.Point(158, 82);
      this.buttonMT.Name = "buttonMT";
      this.buttonMT.Size = new System.Drawing.Size(60, 60);
      this.buttonMT.TabIndex = 6;
      this.buttonMT.Text = "MT";
      this.buttonMT.UseVisualStyleBackColor = true;
      // 
      // buttonJH
      // 
      this.buttonJH.Location = new System.Drawing.Point(92, 82);
      this.buttonJH.Name = "buttonJH";
      this.buttonJH.Size = new System.Drawing.Size(60, 60);
      this.buttonJH.TabIndex = 5;
      this.buttonJH.Text = "JH";
      this.buttonJH.UseVisualStyleBackColor = true;
      // 
      // buttonNTC
      // 
      this.buttonNTC.Location = new System.Drawing.Point(92, 16);
      this.buttonNTC.Name = "buttonNTC";
      this.buttonNTC.Size = new System.Drawing.Size(60, 60);
      this.buttonNTC.TabIndex = 4;
      this.buttonNTC.Text = "NTC";
      this.buttonNTC.UseVisualStyleBackColor = true;
      // 
      // buttonST
      // 
      this.buttonST.Location = new System.Drawing.Point(224, 147);
      this.buttonST.Name = "buttonST";
      this.buttonST.Size = new System.Drawing.Size(60, 60);
      this.buttonST.TabIndex = 11;
      this.buttonST.Text = "ST";
      this.buttonST.UseVisualStyleBackColor = true;
      // 
      // buttonEC
      // 
      this.buttonEC.Location = new System.Drawing.Point(158, 147);
      this.buttonEC.Name = "buttonEC";
      this.buttonEC.Size = new System.Drawing.Size(60, 60);
      this.buttonEC.TabIndex = 10;
      this.buttonEC.Text = "EC";
      this.buttonEC.UseVisualStyleBackColor = true;
      // 
      // buttonHS
      // 
      this.buttonHS.Location = new System.Drawing.Point(92, 147);
      this.buttonHS.Name = "buttonHS";
      this.buttonHS.Size = new System.Drawing.Size(60, 60);
      this.buttonHS.TabIndex = 9;
      this.buttonHS.Text = "HS";
      this.buttonHS.UseVisualStyleBackColor = true;
      // 
      // buttonCO
      // 
      this.buttonCO.Location = new System.Drawing.Point(26, 146);
      this.buttonCO.Name = "buttonCO";
      this.buttonCO.Size = new System.Drawing.Size(60, 60);
      this.buttonCO.TabIndex = 8;
      this.buttonCO.Text = "CO";
      this.buttonCO.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Location = new System.Drawing.Point(0, 232);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(164, 91);
      this.label1.TabIndex = 2;
      this.label1.Text = "Created by JONAS SMITH";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 354);
      this.Controls.Add(this.mileagePanel);
      this.Controls.Add(this.backPanel);
      this.Controls.Add(this.titleBarPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Text = "Mileage";
      this.titleBarPanel.ResumeLayout(false);
      this.mileagePanel.ResumeLayout(false);
      this.tripButtonPanel.ResumeLayout(false);
      this.tripSavePanel.ResumeLayout(false);
      this.navPanel.ResumeLayout(false);
      this.backPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel titleBarPanel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button minButton;
    private System.Windows.Forms.Panel mileagePanel;
    private System.Windows.Forms.Panel tripSavePanel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button saveTripButton;
    private System.Windows.Forms.Button endButton;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Panel tripButtonPanel;
    private System.Windows.Forms.Panel navPanel;
    private System.Windows.Forms.Button viewTripsButton;
    private System.Windows.Forms.Button newTripButton;
    private System.Windows.Forms.Panel backPanel;
    private System.Windows.Forms.Button buttonOffice;
    private System.Windows.Forms.Button buttonSTC;
    private System.Windows.Forms.Button buttonIMC;
    private System.Windows.Forms.Button buttonST;
    private System.Windows.Forms.Button buttonEC;
    private System.Windows.Forms.Button buttonHS;
    private System.Windows.Forms.Button buttonCO;
    private System.Windows.Forms.Button buttonFV;
    private System.Windows.Forms.Button buttonMT;
    private System.Windows.Forms.Button buttonJH;
    private System.Windows.Forms.Button buttonNTC;
    private System.Windows.Forms.Label label1;
  }
}

