using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class MainForm : Form
	{
		bool controlsVisible;
	
		public MainForm()
		{
			InitializeComponent();
			controlsVisible = true;
		}	
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
			if (cbShowDate.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy:MM:dd")}";
			}
			notifyIcon1.Visible = true;
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			notifyIcon1.BalloonTipTitle = "Clock";
			notifyIcon1.BalloonTipText = "Приложение Clock было свернуто";
			notifyIcon1.Text = "Clock";
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Show();
			notifyIcon1.Visible = false;
			WindowState = FormWindowState.Normal;
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (WindowState==FormWindowState.Minimized)
			{
				this.Hide();
				notifyIcon1.Visible = true;
				//notifyIcon1.ShowBalloonTip(1000);
			}
			else if (FormWindowState.Normal==this.WindowState)
			{
				notifyIcon1.Visible = false;
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.Show();
			//WindowState = FormWindowState.Normal;
			controlsVisible = showControlToolStripMenuItem.Checked;
			SetControlsVisibility(!controlsVisible);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetControlsVisibility(false);
		}
		void SetControlsVisibility(bool visible)
		{
			FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;
			TransparencyKey = visible ? Color.Empty : BackColor;
			cbShowDate.Visible = visible;
			btnHideControls.Visible = visible;
			labelTime.BackColor = visible ? BackColor: Color.LightBlue;
			ShowInTaskbar = visible;
			TopMost = !visible;
		}

		

		private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cbShowDate.Checked = showDateToolStripMenuItem.Checked;

		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			showDateToolStripMenuItem.Checked=cbShowDate.Checked;
		}

		private void showControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}
	}
}
