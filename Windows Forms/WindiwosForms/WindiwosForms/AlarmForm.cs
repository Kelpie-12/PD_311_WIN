using System;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Linq;

namespace WindiwosForms
{
	public partial class AlarmForm : Form
	{
		MainForm owner;
		string filename;
		public AlarmForm()
		{
			InitializeComponent();
		}
		public AlarmForm(MainForm owner):this()
		{
			this.owner = owner;
		}

		private void bAlarmOk_Click(object sender, System.EventArgs e)
		{
			owner.alarmTime = dateTimePickerAlarm.Value;
			Console.WriteLine(owner.alarmTime);
			owner.AlarmFile = filename;
			owner.NotifyIcon.Text = $"{dateTimePickerAlarm.Value}-{filename.Split('\\').Last()}";
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.ShowDialog();
			filename= dialog.FileName;
		}
	}
}
