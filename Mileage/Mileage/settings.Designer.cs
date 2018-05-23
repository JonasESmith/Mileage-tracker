namespace Mileage
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
      this.SuspendLayout();
      // 
      // labelPath
      // 
      this.labelPath.AutoSize = true;
      this.labelPath.Location = new System.Drawing.Point(9, 7);
      this.labelPath.Name = "labelPath";
      this.labelPath.Size = new System.Drawing.Size(47, 13);
      this.labelPath.TabIndex = 0;
      this.labelPath.Text = "File path";
      // 
      // filePathBox
      // 
      this.filePathBox.Location = new System.Drawing.Point(12, 23);
      this.filePathBox.Name = "filePathBox";
      this.filePathBox.Size = new System.Drawing.Size(382, 20);
      this.filePathBox.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(319, 57);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // Settings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 92);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.filePathBox);
      this.Controls.Add(this.labelPath);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Settings";
      this.Text = "settings";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox filePathBox;
    private System.Windows.Forms.Button btnSave;
  }
}