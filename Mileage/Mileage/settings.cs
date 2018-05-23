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
  }
}
