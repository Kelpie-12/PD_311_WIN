using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class MainForm : Form
	{
		public System.Windows.Forms.Label LabelTime { get => labelTime; }
		bool controlsVisible;
		MemoryStream fontStream;
		ChooseFont ChooseFontdialog;
		Alarm alarm;

		public System.Windows.Forms.Label Label { get => labelTime; }
		public MainForm()
		{
			InitializeComponent();
			//controlsVisible = true;
			SetControlsVisibility(false);
			StartPosition = FormStartPosition.Manual;
			int start_x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Right - Right - 25;
			int start_y = 75;
			Location = new Point(start_x, start_y);

			ChooseFontdialog = new ChooseFont(this);
			alarm = new Alarm();
			
			AllocConsole();
			CreateCustomFont();
		}
		void TimerTic()
		{
			notifyIcon1.Text = alarm.TimerN;
		}
		void CreateCustomFont()
		{
			Console.WriteLine(Directory.GetCurrentDirectory());
			Directory.SetCurrentDirectory("..\\..\\Fonts");
			Console.WriteLine(Directory.GetCurrentDirectory());

			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile("Terminat.ttf");
			Font font = new Font(pfc.Families[0], labelTime.Font.Size);
			labelTime.Font = font;
			pfc.Dispose();
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
			OpenToolStripMenuItem.Checked = !controlsVisible;
			SetControlsVisibility(!controlsVisible);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
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
			cbPin.Visible = visible;
			cbPin.Checked = true;
			bAlarm.Visible = visible;

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
			SetFonts(new MemoryStream(Properties.Resources.digital_7));
		}

		private void fondeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts(new MemoryStream(Properties.Resources.fonde));
		}

		private void luneisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts(new MemoryStream(Properties.Resources.Luneis_Demo));
		}

		private void withesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFonts(new MemoryStream(Properties.Resources.Witches_Note_Free));
		}



		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{			
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
			notifyIcon1.Icon = Properties.Resources.clock_time;
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

		private const UInt32 StdOutputHandle = 0xfffffff5;
		[DllImport("kernel32.dll")]
		static extern IntPtr GetStdHandle(UInt32 handle);
		[DllImport("kernel32.dll")]
		static extern void SetStdHandle(UInt32 handle, IntPtr value);
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();

		private void pinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TopMost == true)
			{
				TopMost = pinToolStripMenuItem.Checked = cbPin.Checked = false;

			}
			else
			{
				TopMost = pinToolStripMenuItem.Checked = cbPin.Checked = true;
			}
		}

		private void chooseFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChooseFontdialog = new ChooseFont(this);
			ChooseFontdialog.ShowDialog();

		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void cbPin_CheckedChanged(object sender, EventArgs e)
		{

			if (cbPin.Checked)
			{
				cbPin.BackgroundImage = Properties.Resources.note_thepin;

			}
			else
			{
				cbPin.BackgroundImage = Properties.Resources.NeedleLeftYellow;
			}
			pinToolStripMenuItem.Checked = cbPin.Checked;
			TopMost = cbPin.Checked;
			//cbPin.BackgroundImage = Properties.Resources.NeedleLeftYellow;


		}

		private void bAlarm_Click(object sender, EventArgs e)
		{
			alarm.ShowDialog();			
		}


	}
}
