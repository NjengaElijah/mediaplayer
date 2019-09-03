using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace MediaPlayer
{
	
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trkVol.Value = 100;
            axWindowsMediaPlayer1.settings.volume = trkVol.Value;
            lblMinVol.Text = "100";
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = of.FileName;
            }
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            FileInfo fi = new FileInfo(axWindowsMediaPlayer1.URL);
            lblMedia.Text = fi.Name;
            lblFullTime.Text = axWindowsMediaPlayer1.currentMedia.durationString.ToString();
            timer2.Interval = 1000;
            timer2.Start();
            axWindowsMediaPlayer1.Ctlcontrols.play(); 
            this.btnPlayPause.Image = global::MediaPlayer.Properties.Resources.pause2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        double a, b;
        double c;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                a = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                b = axWindowsMediaPlayer1.currentMedia.duration;
                c = a / b;
                lblProgressTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                trkTrack.Value = Convert.ToInt32(c * 100);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //animation
            //collapse
            if (panelLeft.Width == 195)
            {
                label2.Visible = false;
                panelLeft.Visible = false;
                panelLeft.Width = 50;
                label2.Text = "MP";
                label2.TextAlign = ContentAlignment.MiddleLeft;
                bunifuTransition1.ShowSync(panelLeft);
                bunifuTransition2.ShowSync(label2);
            }
            //expand
            else if (panelLeft.Width == 50)
            {
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Visible = false;
                panelLeft.Visible = false; 
                label2.Text = "Media Player";
                panelLeft.Width = 195;
                bunifuTransition1.ShowSync(panelLeft);
                bunifuTransition2.ShowSync(label2);
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            lblMinVol.Text = (trkVol.Value).ToString();
            axWindowsMediaPlayer1.settings.volume = trkVol.Value / 4;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }
        bool play = false;
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                this.btnPlayPause.Image = global::MediaPlayer.Properties.Resources.play1;
            }
            else {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                this.btnPlayPause.Image = global::MediaPlayer.Properties.Resources.pause2;
            }

            
            
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            if (Height == Screen.PrimaryScreen.WorkingArea.Height - 7)
            {
                Size = new Size(921, 544);
                
            }
            else
            {
                Height = Screen.PrimaryScreen.WorkingArea.Height - 7;
                Width = Screen.PrimaryScreen.WorkingArea.Width-6;
                Location = new Point(3, 3);
            }
        }

        private void trkTrack_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(trkTrack.Value.ToString());
        }

        private void trkTrack_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trkTrack, trkTrack.Value.ToString());
        }
    }
}
