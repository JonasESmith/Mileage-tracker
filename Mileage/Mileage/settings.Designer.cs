﻿namespace Mileage
{
  partial class Settings
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
      this.labelPath = new System.Windows.Forms.Label();
      this.filePathBox = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.darkTheme = new System.Windows.Forms.CheckBox();
      this.styleLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelPath
      // 
      this.labelPath.AutoSize = true;
      this.labelPath.Location = new System.Drawing.Point(9, 20);
      this.labelPath.Name = "labelPath";
      this.labelPath.Size = new System.Drawing.Size(151, 13);
      this.labelPath.TabIndex = 0;
      this.labelPath.Text = "path to the mileage storage file";
      // 
      // filePathBox
      // 
      this.filePathBox.Location = new System.Drawing.Point(12, 44);
      this.filePathBox.Name = "filePathBox";
      this.filePathBox.Size = new System.Drawing.Size(302, 20);
      this.filePathBox.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(323, 44);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // darkTheme
      // 
      this.darkTheme.AutoSize = true;
      this.darkTheme.Location = new System.Drawing.Point(16, 116);
      this.darkTheme.Name = "darkTheme";
      this.darkTheme.Size = new System.Drawing.Size(85, 17);
      this.darkTheme.TabIndex = 3;
      this.darkTheme.Text = "Dark Theme";
      this.darkTheme.UseVisualStyleBackColor = true;
      this.darkTheme.Click += new System.EventHandler(this.darkTheme_Click);
      // 
      // styleLabel
      // 
      this.styleLabel.AutoSize = true;
      this.styleLabel.Location = new System.Drawing.Point(13, 89);
      this.styleLabel.Name = "styleLabel";
      this.styleLabel.Size = new System.Drawing.Size(28, 13);
      this.styleLabel.TabIndex = 4;
      this.styleLabel.Text = "style";
      // 
      // Settings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 161);
      this.Controls.Add(this.styleLabel);
      this.Controls.Add(this.darkTheme);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.filePathBox);
      this.Controls.Add(this.labelPath);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Settings";
      this.Text = "settings";
      this.Load += new System.EventHandler(this.Settings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox filePathBox;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.CheckBox darkTheme;
    private System.Windows.Forms.Label styleLabel;
  }
}