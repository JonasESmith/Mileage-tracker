// <Summary>
//    Programmer  : Jonas Smith
//    Purpose     : Mileage application for my coworkers
// </Summary> 

using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Mileage
{
  public partial class mileageForm : Form
  {
    public int topMargin = 0;
    public List<Trip>   tripList = new List<Trip>();
    public List<string> destinationList = new List<string>();

    #region Mileage Matrix 

    double[,] mileageMatrix = {   { 0  , 2.4, 1  , 1.6, 3.9, 1.2, 2.7, 1.8, 2.8, 1.9, 2.4},
                                  { 2.4, 0  , 1.4, 0.8, 6  , 2.2, 0.9, 1.6, 3.5, 0.5, 3.1},
                                  { 1  , 1.4, 0  , 0.6, 5.3, 0.7, 1.8, 1.3, 3.2, 0.9, 2.8},
                                  { 1.6, 0.8, 0.6, 0  , 5.7, 1.3, 1.2, 0.8, 3.6, 0.8, 3.2},
                                  { 3.9, 6  , 5.3, 5.7, 0  , 4.3, 6.6, 5.2, 4.8, 5.7, 5.2},
                                  { 1.2, 2.2, 0.7, 1.3, 4.3, 0  , 2.6, 0.7, 3.9, 1.7, 3.5},
                                  { 2.7, 0.9, 1.8, 1.2, 6.6, 2.6, 0  ,   2, 2.9, 0.9, 2.5},
                                  { 1.8, 1.6, 1.3, 0.8, 5.2, 0.7, 2  ,   0, 4.5, 1.6, 4.1},
                                  { 2.8, 3.5, 3.2, 3.6, 4.8, 3.9, 2.9, 4.5, 0  ,   3, 0.5},
                                  { 1.9, 0.5, 0.9, 0.8, 5.7, 1.7, 0.9, 1.6, 3  ,   0, 2.5},
                                  { 2.4, 3.1, 2.8, 3.2, 5.2, 3.5, 2.5, 4.1, 0.5, 2.5, 0  } };
#endregion

    public mileageForm()
    {
      StartPosition = FormStartPosition.CenterScreen;
      InitializeComponent();
      LoadStyles();
    }

    public void LoadStyles()
    {
      newTripPanel.BackColor = Color.FromArgb(102, 102, 102);


      closeButton.BackColor = Color.FromArgb(244, 83, 66);
      closeButton.FlatAppearance.BorderSize = 0;
      closeButton.BackColorChanged += (s, e) => {
        closeButton.FlatAppearance.MouseOverBackColor = closeButton.BackColor;
      };

      newTripButton.Font = new Font(newTripButton.Font.Name, 13, newTripButton.Font.Style);
      newTripButton.FlatAppearance.BorderSize = 0;
      newTripButton.ForeColor = SystemColors.AppWorkspace;

      viewReportButton.ForeColor = SystemColors.AppWorkspace;
      viewReportButton.FlatAppearance.BorderSize = 0;
      viewReportButton.Font = new Font(newTripButton.Font.Name, 13, newTripButton.Font.Style);

      editReportButton.ForeColor = SystemColors.AppWorkspace;
      editReportButton.FlatAppearance.BorderSize = 0;
      editReportButton.Font = new Font(newTripButton.Font.Name, 13, newTripButton.Font.Style);

      settingsButton.ForeColor = Color.FromArgb(221, 221, 221);
      settingsButton.FlatAppearance.BorderSize = 0;
      settingsButton.TextAlign = ContentAlignment.MiddleCenter;
      settingsButton.Font = new Font(newTripButton.Font.Name, 11, newTripButton.Font.Style);

      leftPanel.BackColor = Color.FromArgb(81, 81, 81);

      customDGVPanel.AutoScroll = false;
      customDGVPanel.HorizontalScroll.Enabled = false;
      customDGVPanel.HorizontalScroll.Visible = false;
      customDGVPanel.HorizontalScroll.Maximum = 0;
      customDGVPanel.AutoScroll = true;

      titleBarPanel.BackColor = Color.FromArgb(40, 40, 40);

      startButton.FlatAppearance.BorderSize = 0;
      cancleButton.FlatAppearance.BorderSize = 0;
      officeBtn.FlatAppearance.BorderSize = 0;
      fvBtn.FlatAppearance.BorderSize = 0;
      msBtn.FlatAppearance.BorderSize = 0;
      coBtn.FlatAppearance.BorderSize = 0;
      stBtn.FlatAppearance.BorderSize = 0;
      mtBtn.FlatAppearance.BorderSize = 0;
      jhBtn.FlatAppearance.BorderSize = 0;
      pvBt.FlatAppearance.BorderSize = 0;
      imcBtn.FlatAppearance.BorderSize = 0;
      hsBtn.FlatAppearance.BorderSize = 0;
      echBtn.FlatAppearance.BorderSize = 0;
      endButton.FlatAppearance.BorderSize = 0;
      saveButton.FlatAppearance.BorderSize = 0;

      startButton.BackColor  = Color.FromArgb(54, 99, 40);
      //startButton.ForeColor = Color.FromArgb(66, 66, 66);


      pvBt.BackColor         = Color.FromArgb(81,81,81);
      fvBtn.BackColor        = Color.FromArgb(81,81,81);
      msBtn.BackColor        = Color.FromArgb(81,81,81);
      coBtn.BackColor        = Color.FromArgb(81,81,81);
      stBtn.BackColor        = Color.FromArgb(81,81,81);
      mtBtn.BackColor        = Color.FromArgb(81,81,81);
      jhBtn.BackColor        = Color.FromArgb(81,81,81);
      hsBtn.BackColor        = Color.FromArgb(81,81,81);
      imcBtn.BackColor       = Color.FromArgb(81,81,81);
      echBtn.BackColor       = Color.FromArgb(81,81,81);
      officeBtn.BackColor    = Color.FromArgb(81,81,81);
      endButton.BackColor    = Color.FromArgb(81,81,81);
      saveButton.BackColor   = Color.FromArgb(81,81,81);
      cancleButton.BackColor = Color.FromArgb(81,81,81);

      startButton.BackColorChanged += (s, e) => {
        startButton.FlatAppearance.MouseOverBackColor = startButton.BackColor;
      };
    }

    #region Button Events & Calculations

    #region de/en-nableing buttons

    private void enableBtns(bool value)
    {
      if(value)
      {
        endButton.Visible  = true;
        endButton.Enabled  = true;
        endButton.Location = startButton.Location;

        cancleButton.Enabled = true;
        startButton.Enabled  = false;
        officeBtn.Enabled    = true;
        echBtn.Enabled       = true;
        imcBtn.Enabled       = true;
        fvBtn.Enabled        = true;
        mtBtn.Enabled        = true;
        msBtn.Enabled        = true;
        coBtn.Enabled        = true;
        jhBtn.Enabled        = true;
        stBtn.Enabled        = true;
        hsBtn.Enabled        = true;
        pvBt.Enabled         = true;
      }
      else
      {
        startButton.Enabled = true;
        startButton.Visible = true; 

        endButton.Visible    = false;
        endButton.Enabled    = false;
        cancleButton.Enabled = false;
        startButton.Enabled  = true;
        officeBtn.Enabled    = false;
        echBtn.Enabled       = false;
        imcBtn.Enabled       = false;
        fvBtn.Enabled        = false;
        mtBtn.Enabled        = false;
        msBtn.Enabled        = false;
        coBtn.Enabled        = false;
        jhBtn.Enabled        = false;
        stBtn.Enabled        = false;
        hsBtn.Enabled        = false;
        pvBt.Enabled         = false;
      }
    }

    #endregion

    #region GetDistance()
    private double GetDistance(string firstpos, string secondpos)
    {
      double value;
      int i = 0, j = 0;
      switch (firstpos.ToLower())
      {
        case "co": i = 0; break;
        case "fv": i = 1; break;
        case "mt": i = 2; break;
        case "ms": i = 3; break;
        case "pv": i = 4; break;
        case "jh": i = 5; break;
        case "hs": i = 6; break;
        case "office": i = 7; break;
        case "st": i = 8; break;
        case "ech": i = 9; break;
        case "imc": i = 10; break;
      }
      switch (secondpos.ToLower())
      {
        case "co": j = 0; break;
        case "fv": j = 1; break;
        case "mt": j = 2; break;
        case "ms": j = 3; break;
        case "pv": j = 4; break;
        case "jh": j = 5; break;
        case "hs": j = 6; break;
        case "office": j = 7; break;
        case "st": j = 8; break;
        case "ech": j = 9; break;
        case "imc": j = 10; break;
      }
      return value = mileageMatrix[i, j];
    }

    #endregion

    private void startButton_Click(object sender, EventArgs e)
    {
      destinationList.Clear();
      enableBtns(true);
      tripList.Add(new Trip());
    }

    private void endButton_Click(object sender, EventArgs e)
    {
      double distance;
      string finalDest;

      if (destinationList.Count > 0) // list is not empty and contains at least two destinations
      {
        // finds both entire string of trip & trip length in miles 
        finalDest = DestinationString();
        if (!String.IsNullOrEmpty(finalDest))
        {
          distance = CalcDistance();

          // updates variable for tripList. For the save functionality
          tripList[tripList.Count - 1].Destination = finalDest;
          tripList[tripList.Count - 1].TripDist = distance;

          // updates row for DGV. 
          updateDGV(distance);
        }
      }
      else
      {
        tripList.RemoveAt(tripList.Count - 1);
      }

      // turns off all buttons after trip has been finished. 
      enableBtns(false);

      if(tripList.Count != 0)
      {
        saveButton.Enabled = true;
      }
      else
      {
        saveButton.Enabled = false;
      }
    }

    private void finishTrip()
    {
      double distance;
      string finalDest;

      if (destinationList.Count >= 1) 
      {
        // finds both entire string of trip & trip length in miles 
        finalDest = DestinationString();
        distance = CalcDistance();

        // updates variable for tripList. For the save functionality
        tripList[tripList.Count - 1].Destination = finalDest;
        tripList[tripList.Count - 1].TripDist = distance;
      }

    }

    private string DestinationString()
    {
      string finalDest = "";
      for (int i = 1; i <= destinationList.Count; i++)
      {
        finalDest += destinationList[i - 1];
        if (i < destinationList.Count)
          finalDest += " -> ";
      }
      return finalDest;
    }

    private double CalcDistance()
    {
      double totalDistance = 0.0;
      string firstPos;
      string secondPos;

      for (int i = 0; i <= destinationList.Count - 2; i++)
      {
        firstPos = destinationList.ElementAt(i);
        secondPos = destinationList.ElementAt(i + 1);
        totalDistance += GetDistance(firstPos, secondPos);
      }
      return totalDistance; 
    }

    private void cancleButton_Click(object sender, EventArgs e)
    {
      enableBtns(false);

      finishTrip();
      // I do this to remove the "false" item/object
      // when saving the data to this local file this makes it much easier. 
      tripList.RemoveAt(tripList.Count - 1);
    }

    private void updateDGV(double distance)
    {
      int distBTNWidth = customDGVPanel.Width / 3;
      int buttonWidth = customDGVPanel.Width - distBTNWidth;
      int left = 10;

      Button button = new Button();
      button.Left = left;
      button.Top = topMargin;
      button.Width = buttonWidth - 20;
      button.Height = 30;
      button.Text = tripList[tripList.Count - 1].Destination;
      button.TextAlign = ContentAlignment.MiddleLeft;
      customDGVPanel.Controls.Add(button);
      ToolTip tolltip = new ToolTip();
      tolltip.SetToolTip(button, tripList[tripList.Count - 1].Destination);
      button.FlatStyle = FlatStyle.Flat;
      button.BackColor = Color.FromArgb(66, 66, 66);
      button.ForeColor = SystemColors.Window;
      button.FlatAppearance.BorderSize = 0;


      Button distBTN = new Button();
      distBTN.Left = left + button.Width + 5;
      distBTN.Top = topMargin;
      distBTN.Width = distBTNWidth - 20;
      distBTN.Height = 30;
      distBTN.Text = distance.ToString() + " miles";
      customDGVPanel.Controls.Add(distBTN);
      distBTN.FlatStyle = FlatStyle.Flat;
      distBTN.ForeColor = SystemColors.Window;
      distBTN.BackColor = Color.FromArgb(66, 66, 66);
      distBTN.FlatAppearance.BorderSize = 0;


      topMargin += distBTN.Height + 2;
    }

    private void mileageForm_Click(object sender, EventArgs e)
    {
      // get button text 
      string btnText = (sender as Button).Text;

      // add button text to class wide list
      destinationList.Add(btnText);
    }

    #endregion

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void newTripButton_Click(object sender, EventArgs e)
    {
      newTripPanel.Visible = true;
      ReportPanel.Visible = false;
      newTripPanel.Dock = DockStyle.Fill;
    }

    private void viewReportButton_Click(object sender, EventArgs e)
    {
      newTripPanel.Visible = false;
      ReportPanel.Visible = true;
      ReportPanel.Dock = DockStyle.Fill;

      reportBox.Text = File.ReadAllText(Properties.Settings.Default.savePath);
    }

    private void Save()
    {
      // Create StreamWriter
      StreamWriter sw;

      // if the savePath is empty the user needs to set a new value for their savepath
      if (String.IsNullOrEmpty(Properties.Settings.Default.savePath.ToString()))
      {
        MessageBox.Show("please select a path for mileage.csv", "Prompt");

        string documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // SaveFileDialog to browse to path
        // This also sets the default derectory to the user documents. 
        Stream myStream;
        SaveFileDialog SaveFileDiagBrowser = new SaveFileDialog();

        SaveFileDiagBrowser.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        SaveFileDiagBrowser.FilterIndex = 2;
        SaveFileDiagBrowser.RestoreDirectory = true;
        SaveFileDiagBrowser.InitialDirectory = documentsPath;

        if (SaveFileDiagBrowser.ShowDialog() == DialogResult.OK)
        {
          if ((myStream = SaveFileDiagBrowser.OpenFile()) != null)
          {
            // Save local path 
            Properties.Settings.Default.savePath = SaveFileDiagBrowser.FileName;
            Properties.Settings.Default.Save();
            myStream.Close();
          }
        }
      }

      if (!String.IsNullOrEmpty(Properties.Settings.Default.savePath.ToString()) && tripList.Count > 0)
      {
        string path = Properties.Settings.Default.savePath.ToString();
        sw = File.AppendText(Properties.Settings.Default.savePath);

        if (new FileInfo(Properties.Settings.Default.savePath).Length == 0)
        {
          sw.WriteLine("Date, Trip, Mileage");
        }

        for (int i = 0; i < tripList.Count; i++)
        {
          sw.Write(tripList[i].DateCreated); sw.Write(" ,");
          sw.Write(tripList[i].Destination); sw.Write(" ,");
          sw.Write(tripList[i].TripDist); sw.WriteLine();
        }
        tripList.Clear();
        sw.Close();
      }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      Save();
      saveButton.Enabled = false;
    }

    private void settingsButton_Click(object sender, EventArgs e)
    {
      Settings setting = new Settings();
      setting.Show();
    }

    private void editReportButton_Click(object sender, EventArgs e)
    {
      string path = Properties.Settings.Default.savePath.ToString();
      if (File.Exists(path))
        System.Diagnostics.Process.Start("notepad", path);
      else
        MessageBox.Show(path + " does not exist", "Invalid File Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
  #region Trip-Class
  // Having this class local helped with editing and the speed at which I could create this application. 
  public class Trip
  {
    string destinations;
    string date = DateTime.Today.ToShortDateString().ToString();
    double destDist = 0.0;

    public string DateCreated
    {
      get
      {
        return date;
      }
    }

    public double TripDist
    {
      set
      {
        destDist = value;
      }
      get
      {
        return destDist;
      }
    }

    public string Destination
    {
      set
      {
        destinations = value;
      }
      get
      {
        return destinations;
      }
    }
  }
  #endregion
}
