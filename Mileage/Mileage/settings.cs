using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage
{
  public partial class Settings : Form
  {
    public Settings()
    {
      InitializeComponent();

      darkTheme.Checked = Properties.Settings.Default.Theme;

      LoadPath();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    public void LoadPath()
    {
      filePathBox.Text = Properties.Settings.Default.savePath;
    }

    private void Settings_Load(object sender, EventArgs e)
    {

    }

    private void darkTheme_Click(object sender, EventArgs e)
    {
      bool userSet = Properties.Settings.Default.Theme;
      if (userSet)
      {
        userSet = false;
      }
      else
      {
        userSet = true;
      }

      Properties.Settings.Default.Theme = userSet;
      Properties.Settings.Default.Save();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.savePath = filePathBox.Text;
      Properties.Settings.Default.Save();
    }
  }
}
