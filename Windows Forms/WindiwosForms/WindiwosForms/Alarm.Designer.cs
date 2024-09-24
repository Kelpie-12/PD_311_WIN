namespace WindiwosForms
{
	partial class Alarm
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
			this.components = new System.ComponentModel.Container();
			this.labelStop = new System.Windows.Forms.Label();
			this.TextHour = new System.Windows.Forms.TextBox();
			this.TextSec = new System.Windows.Forms.TextBox();
			this.TextMin = new System.Windows.Forms.TextBox();
			this.labelH = new System.Windows.Forms.Label();
			this.labelM = new System.Windows.Forms.Label();
			this.labelS = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// labelStop
			// 
			this.labelStop.AutoSize = true;
			this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStop.Location = new System.Drawing.Point(75, 20);
			this.labelStop.Name = "labelStop";
			this.labelStop.Size = new System.Drawing.Size(228, 29);
			this.labelStop.TabIndex = 0;
			this.labelStop.Text = "Установить время";
			// 
			// TextHour
			// 
			this.TextHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextHour.Location = new System.Drawing.Point(25, 101);
			this.TextHour.Name = "TextHour";
			this.TextHour.Size = new System.Drawing.Size(55, 31);
			this.TextHour.TabIndex = 1;
			this.TextHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextHour_KeyPress);
			this.TextHour.Leave += new System.EventHandler(this.TextHour_Leave);
			// 
			// TextSec
			// 
			this.TextSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextSec.Location = new System.Drawing.Point(273, 101);
			this.TextSec.Name = "TextSec";
			this.TextSec.Size = new System.Drawing.Size(55, 31);
			this.TextSec.TabIndex = 2;
			this.TextSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSec_KeyPress);
			this.TextSec.Leave += new System.EventHandler(this.TextSec_Leave);
			// 
			// TextMin
			// 
			this.TextMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextMin.Location = new System.Drawing.Point(144, 101);
			this.TextMin.Name = "TextMin";
			this.TextMin.Size = new System.Drawing.Size(71, 31);
			this.TextMin.TabIndex = 3;
			this.TextMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMin_KeyPress);
			this.TextMin.Leave += new System.EventHandler(this.TextMin_Leave);
			// 
			// labelH
			// 
			this.labelH.AutoSize = true;
			this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelH.Location = new System.Drawing.Point(86, 104);
			this.labelH.Name = "labelH";
			this.labelH.Size = new System.Drawing.Size(27, 25);
			this.labelH.TabIndex = 4;
			this.labelH.Text = "H";
			// 
			// labelM
			// 
			this.labelM.AutoSize = true;
			this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelM.Location = new System.Drawing.Point(221, 104);
			this.labelM.Name = "labelM";
			this.labelM.Size = new System.Drawing.Size(30, 25);
			this.labelM.TabIndex = 5;
			this.labelM.Text = "M";
			// 
			// labelS
			// 
			this.labelS.AutoSize = true;
			this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelS.Location = new System.Drawing.Point(334, 104);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(26, 25);
			this.labelS.TabIndex = 6;
			this.labelS.Text = "S";
			// 
			// buttonStart
			// 
			this.buttonStart.AutoSize = true;
			this.buttonStart.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonStart.FlatAppearance.BorderSize = 0;
			this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonStart.Location = new System.Drawing.Point(131, 172);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(99, 43);
			this.buttonStart.TabIndex = 7;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = false;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.labelS);
			this.Controls.Add(this.labelM);
			this.Controls.Add(this.labelH);
			this.Controls.Add(this.TextMin);
			this.Controls.Add(this.TextSec);
			this.Controls.Add(this.TextHour);
			this.Controls.Add(this.labelStop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Alarm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Alarm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStop;
		private System.Windows.Forms.TextBox TextHour;
		private System.Windows.Forms.TextBox TextSec;
		private System.Windows.Forms.TextBox TextMin;
		private System.Windows.Forms.Label labelH;
		private System.Windows.Forms.Label labelM;
		private System.Windows.Forms.Label labelS;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Timer timer;
	}
}