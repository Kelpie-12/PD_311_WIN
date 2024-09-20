using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class MainForm : Form
	{
		bool controlsVisible;
		MemoryStream fontStream;
		public MainForm()
		{
			InitializeComponent();
			//controlsVisible = true;
			SetControlsVisibility(false);
			StartPosition = FormStartPosition.Manual;
			int start_x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Right - Right - 25;
			int start_y = 75;
			Location = new Point(start_x, start_y);
			LoadSettings();
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
			if (WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				notifyIcon1.Visible = true;
				//notifyIcon1.ShowBalloonTip(1000);
			}
			else if (FormWindowState.Normal == this.WindowState)
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
			SaveSettings();
			Close();
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
			labelTime.BackColor = visible ? BackColor : Color.LightBlue;
			ShowInTaskbar = visible;
			TopMost = !visible;
			showControlToolStripMenuItem.Checked = visible;
			controlsVisible = visible;
		}



		private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cbShowDate.Checked = showDateToolStripMenuItem.Checked;
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			showDateToolStripMenuItem.Checked = cbShowDate.Checked;
		}

		private void showControlToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			SetControlsVisibility(!controlsVisible);
		}

		private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				labelTime.BackColor = dialog.Color;
			}
		}

		private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				labelTime.ForeColor = dialog.Color;
			}
		}

		void SetFonts(MemoryStream digital)
		{
			//PrivateFontCollection myFont = new PrivateFontCollection();
			//myFont.AddFontFile(font_file_name);
			//Font font = new Font(myFont.Families[0], 32);
			//labelTime.Font = font;
			//"C:\\Users\\roman\\source\\repos\\PD_311_WIN\\Windows Forms\\WindiwosForms\\WindiwosForms\\digital-7.ttf"	

			PrivateFontCollection myfont = new PrivateFontCollection();
			using (fontStream = digital/*new MemoryStream(Properties.Resources.digital_7)*/)
			{
				var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
				byte[] fontdata = new byte[fontStream.Length];
				fontStream.Read(fontdata, 0, (int)fontStream.Length);
				Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
				myfont.AddMemoryFont(data, (int)fontStream.Length);
				Marshal.FreeCoTaskMem(data);
			}

			labelTime.Font = new Font(myfont.Families[0], labelTime.Font.Size);
			labelTime.UseCompatibleTextRendering = true;


		}

		private void digital7ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts( new MemoryStream(Properties.Resources.digital_7));
		}

		private void fondeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts( new MemoryStream(Properties.Resources.fonde));
		}

		private void luneisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts(new MemoryStream(Properties.Resources.Luneis_Demo));
		}

		private void withesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts(new MemoryStream(Properties.Resources.Witches_Note_Free));
		}

		void SaveSettings()
		{
			Properties.Settings.Default.Fonts = labelTime.Font;
			Properties.Settings.Default.Fonts.Size = 32;
			Properties.Settings.Default.Save();
		}
		void LoadSettings()
		{
			labelTime.Font = Properties.Settings.Default.Fonts;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveSettings();
			Close();
		}
		

		private void busnessClockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Icon = Properties.Resources.business_color;
			notifyIcon1.Icon = Properties.Resources.business_color;
		}

		private void clockTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Icon = Properties.Resources.clock_time;
			notifyIcon1.Icon=Properties.Resources.clock_time;
		}

		private void historicalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Icon = Properties.Resources.Historical;
			notifyIcon1.Icon = Properties.Resources.Historical;
		}

		private void clockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Icon = Properties.Resources.IconClock;
			notifyIcon1.Icon = Properties.Resources.IconClock;
		}
	}
}
