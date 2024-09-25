using System;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class AlarmForm : Form
	{
		MainForm owner;
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
			this.Close();
		}
	}
}
