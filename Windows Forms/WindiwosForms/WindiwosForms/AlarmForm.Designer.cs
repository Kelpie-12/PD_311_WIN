namespace WindiwosForms
{
	partial class AlarmForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePickerAlarm = new System.Windows.Forms.DateTimePicker();
			this.bAlarmOk = new System.Windows.Forms.Button();
			this.bAlarmCansel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePickerAlarm
			// 
			this.dateTimePickerAlarm.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerAlarm.Location = new System.Drawing.Point(41, 12);
			this.dateTimePickerAlarm.Name = "dateTimePickerAlarm";
			this.dateTimePickerAlarm.Size = new System.Drawing.Size(215, 44);
			this.dateTimePickerAlarm.TabIndex = 0;
			// 
			// bAlarmOk
			// 
			this.bAlarmOk.AutoSize = true;
			this.bAlarmOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bAlarmOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bAlarmOk.Location = new System.Drawing.Point(12, 120);
			this.bAlarmOk.Name = "bAlarmOk";
			this.bAlarmOk.Size = new System.Drawing.Size(75, 35);
			this.bAlarmOk.TabIndex = 1;
			this.bAlarmOk.Text = "Ok";
			this.bAlarmOk.UseVisualStyleBackColor = true;
			this.bAlarmOk.Click += new System.EventHandler(this.bAlarmOk_Click);
			// 
			// bAlarmCansel
			// 
			this.bAlarmCansel.AutoSize = true;
			this.bAlarmCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bAlarmCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bAlarmCansel.Location = new System.Drawing.Point(197, 120);
			this.bAlarmCansel.Name = "bAlarmCansel";
			this.bAlarmCansel.Size = new System.Drawing.Size(89, 35);
			this.bAlarmCansel.TabIndex = 2;
			this.bAlarmCansel.Text = "Cansel";
			this.bAlarmCansel.UseVisualStyleBackColor = true;
			// 
			// AlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(298, 167);
			this.Controls.Add(this.bAlarmCansel);
			this.Controls.Add(this.bAlarmOk);
			this.Controls.Add(this.dateTimePickerAlarm);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AlarmForm";
			this.Text = "AlarmForm";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerAlarm;
		private System.Windows.Forms.Button bAlarmOk;
		private System.Windows.Forms.Button bAlarmCansel;
	}
}