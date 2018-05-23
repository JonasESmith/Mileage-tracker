using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Tracker
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      LoadThemes();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void LoadThemes()
    {
      closeButton.BackColor = Color.FromArgb(244, 83, 66);
      closeButton.FlatAppearance.BorderColor = Color.FromArgb(244, 83, 66);
      closeButton.FlatAppearance.MouseOverBackColor = closeButton.BackColor;
      closeButton.BackColorChanged += (s, e) => {
        closeButton.FlatAppearance.MouseOverBackColor = closeButton.BackColor;
      };

      minButton.FlatAppearance.BorderColor = Color.Green;
      minButton.FlatAppearance.MouseOverBackColor = minButton.BackColor;
      minButton.BackColorChanged += (s, e) => {
        minButton.FlatAppearance.MouseOverBackColor = minButton.BackColor;
      };
    }

    #region Movable Title Bar

    private void titleBarPanel_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();
    #endregion

    private void numDestComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void newTripButton_Click(object sender, EventArgs e)
    {
      mileagePanel.Visible = true;
      tripSetPanel.Visible = false;
    }

    private void tripSetButton_Click(object sender, EventArgs e)
    {
      mileagePanel.Visible = false;
      tripSetPanel.Visible = true;
    }
  }
}
