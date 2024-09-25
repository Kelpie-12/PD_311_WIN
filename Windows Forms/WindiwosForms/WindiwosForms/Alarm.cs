using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class Alarm : Form
	{
		string hour = "";
		string minutes = "";
		string seconds = "";
		string hourNow = "";
		string minutesNow = "";
		string secondsNow = "";
		private string timerN;

		public string TimerN
		{
			get { return $"{hour}:{minutes}:{seconds}"; }
		}


		public Alarm()
		{
			InitializeComponent();
			timer.Interval = 500;
			timer.Tick += new EventHandler(Timer_Tick);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (buttonStart.Text == "Stop")
			{
				TextHour.ReadOnly = false;
				TextMin.ReadOnly = false;
				TextSec.ReadOnly = false;
				timer.Enabled = false;
				buttonStart.BackColor = Color.LightGreen;
				buttonStart.Text = "Start";
			}
			else
			{
				if (Convert.ToInt32(TextHour.Text) <= 0 && Convert.ToInt32(TextHour.Text) >= 23)
					{MessageBox.Show("Некоректоно указаны часы"); return; }
				if (Convert.ToInt32(TextMin.Text) <= 0 && Convert.ToInt32(TextMin.Text) >= 59)
					{ MessageBox.Show("Некоректоно указаны минуты"); return; }
				if (Convert.ToInt32(TextSec.Text) <= 0 && Convert.ToInt32(TextSec.Text) >= 59)
					{ MessageBox.Show("Некоректоно указаны секунды"); return; }
				

				if (TextHour.Text == "")
					{ MessageBox.Show("Установить часы"); return; }
				if (TextMin.Text == "")
					{ MessageBox.Show("Установить минуты"); return; }
				if (TextSec.Text == "")
					{ MessageBox.Show("Установить секунды"); return; }

				buttonStart.BackColor = Color.LavenderBlush;
				buttonStart.Text = "Stop";
				hour = TextHour.Text;
				minutes = TextMin.Text;
				seconds = TextSec.Text;
				TextHour.ReadOnly = true;
				TextMin.ReadOnly = true;
				TextSec.ReadOnly = true;
				timer.Enabled = true;
			}

		}

		void Timer_Tick(object sender, EventArgs e)
		{
			hourNow = DateTime.Now.Hour.ToString();
			minutesNow = DateTime.Now.Minute.ToString();
			secondsNow = DateTime.Now.Second.ToString();
			if (hourNow.Length == 1)
				hourNow = "0" + hourNow;
			if (minutesNow.Length == 1)
				minutesNow = "0" + minutesNow;
			if (secondsNow.Length == 1)
				secondsNow = "0" + secondsNow;
			if (hour == hourNow && minutes == minutesNow && seconds == secondsNow)
			{
				MessageBox.Show("БУДИЛЬНИК!!!");
				TextHour.ReadOnly = false;
				TextMin.ReadOnly = false;
				TextSec.ReadOnly = false;
				timer.Enabled = false;
				buttonStart.BackColor = Color.LightGreen;
				buttonStart.Text = "Start";
			}


		}

		private void Alarm_Load(object sender, EventArgs e)
		{
			hour = DateTime.Now.Hour.ToString();
			minutes = DateTime.Now.Minute.ToString();
			seconds = DateTime.Now.Second.ToString();
			if (hour.Length == 1)
				hour = "0" + hour;
			if (minutes.Length == 1)
				minutes = "0" + minutes;
			if (seconds.Length == 1)
				seconds = "0" + seconds;
			TextHour.Text = hour;
			TextMin.Text = minutes;
			TextSec.Text = seconds;
		}

		private void TextHour_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9')
				if (TextHour.Text.Length >= 0 && TextHour.Text.Length <= 1)
					return;
			if (Char.IsControl(e.KeyChar))
				if (e.KeyChar == (char)Keys.Back)
					return;
			e.Handled = true;
		}

		private void TextMin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9')
				if (TextMin.Text.Length >= 0 && TextMin.Text.Length <= 1)
					return;
			if (Char.IsControl(e.KeyChar))
				if (e.KeyChar == (char)Keys.Back)
					return;
			e.Handled = true;
		}

		private void TextSec_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9')
				if (TextSec.Text.Length >= 0 && TextSec.Text.Length <= 1)
					return;
			if (Char.IsControl(e.KeyChar))
				if (e.KeyChar == (char)Keys.Back)
					return;
			e.Handled = true;
		}

		private void TextHour_Leave(object sender, EventArgs e)
		{
			if (TextHour.Text.Length == 1)
				TextHour.Text = "0" + TextHour.Text;
		}

		private void TextMin_Leave(object sender, EventArgs e)
		{
			if (TextMin.Text.Length == 1)
				TextMin.Text = "0" + TextMin.Text;
		}

		private void TextSec_Leave(object sender, EventArgs e)
		{
			if (TextSec.Text.Length == 1)
				TextSec.Text = "0" + TextSec.Text;
		}
	}
}
