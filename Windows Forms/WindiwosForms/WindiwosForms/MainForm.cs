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
		public MainForm()
		{
			InitializeComponent();			
		}	
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
			if (cbShowDate.Checked)
			{
				label1.Text += $"\n{DateTime.Now.ToString("yyyy:MM:dd")}";
			}
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

		private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
			WindowState = FormWindowState.Normal;
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
