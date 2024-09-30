using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmDialog : Form
	{
		MainForm owner;
		string filename;
		internal CheckedListBox CheckedListBoxPendingAlarms { get => checkedListBoxPendingAlarms; }
		public AlarmDialog()
		{
			InitializeComponent();

		}
		public AlarmDialog(MainForm owner) : this()
		{
			this.owner = owner;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			owner.AlarmTime = dateTimePickerAlarmTime.Value;
			Console.WriteLine(owner.AlarmTime);
			owner.AlarmFile = filename;
			owner.NotifyIcon.Text = $"{dateTimePickerAlarmTime.Value.TimeOfDay}";
			this.Close();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.ShowDialog();
			filename = dialog.FileName;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Alarm alarm = new Alarm(dateTimePickerAlarmTime.Value, filename);
				List<Alarm> all_alarms = new List<Alarm>(checkedListBoxPendingAlarms.Items.OfType<Alarm>().ToList());
				if (!all_alarms.Contains(alarm))
					checkedListBoxPendingAlarms.Items.Add(new Alarm(dateTimePickerAlarmTime.Value, filename), true);
				Console.WriteLine(all_alarms.Min());
				List<Alarm> activ_alarms = new List<Alarm> ( checkedListBoxPendingAlarms.CheckedItems.OfType<Alarm>().ToList());
				owner.Alarm = activ_alarms.Min();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
