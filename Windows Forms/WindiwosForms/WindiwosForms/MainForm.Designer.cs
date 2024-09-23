namespace WindiwosForms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.fontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.digital7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fondeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.luneisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.withesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.busnessClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clockTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foregroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.btnHideControls = new System.Windows.Forms.Button();
			this.chooseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(89, 31);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(119, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "label";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.showControlToolStripMenuItem,
            this.showDateToolStripMenuItem,
            this.pinToolStripMenuItem,
            this.toolStripSeparator1,
            this.chooseFontToolStripMenuItem,
            this.fontsToolStripMenuItem,
            this.iconToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 236);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Checked = true;
			this.OpenToolStripMenuItem.CheckOnClick = true;
			this.OpenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.OpenToolStripMenuItem.Text = "Open";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// showControlToolStripMenuItem
			// 
			this.showControlToolStripMenuItem.Name = "showControlToolStripMenuItem";
			this.showControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.showControlToolStripMenuItem.Text = "Show control";
			this.showControlToolStripMenuItem.Click += new System.EventHandler(this.showControlToolStripMenuItem_Click);
			// 
			// showDateToolStripMenuItem
			// 
			this.showDateToolStripMenuItem.CheckOnClick = true;
			this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
			this.showDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.showDateToolStripMenuItem.Text = "Show date";
			this.showDateToolStripMenuItem.Click += new System.EventHandler(this.showDateToolStripMenuItem_Click);
			// 
			// pinToolStripMenuItem
			// 
			this.pinToolStripMenuItem.Checked = true;
			this.pinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pinToolStripMenuItem.Name = "pinToolStripMenuItem";
			this.pinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pinToolStripMenuItem.Text = "Pin";
			this.pinToolStripMenuItem.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// fontsToolStripMenuItem
			// 
			this.fontsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digital7ToolStripMenuItem,
            this.fondeToolStripMenuItem,
            this.luneisToolStripMenuItem,
            this.withesToolStripMenuItem});
			this.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
			this.fontsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fontsToolStripMenuItem.Text = "Fonts";
			// 
			// digital7ToolStripMenuItem
			// 
			this.digital7ToolStripMenuItem.Name = "digital7ToolStripMenuItem";
			this.digital7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.digital7ToolStripMenuItem.Text = "Digital-7";
			this.digital7ToolStripMenuItem.Click += new System.EventHandler(this.digital7ToolStripMenuItem_Click);
			// 
			// fondeToolStripMenuItem
			// 
			this.fondeToolStripMenuItem.Name = "fondeToolStripMenuItem";
			this.fondeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fondeToolStripMenuItem.Text = "Fonde";
			this.fondeToolStripMenuItem.Click += new System.EventHandler(this.fondeToolStripMenuItem_Click);
			// 
			// luneisToolStripMenuItem
			// 
			this.luneisToolStripMenuItem.Name = "luneisToolStripMenuItem";
			this.luneisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.luneisToolStripMenuItem.Text = "Luneis";
			this.luneisToolStripMenuItem.Click += new System.EventHandler(this.luneisToolStripMenuItem_Click);
			// 
			// withesToolStripMenuItem
			// 
			this.withesToolStripMenuItem.Name = "withesToolStripMenuItem";
			this.withesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.withesToolStripMenuItem.Text = "Withes";
			this.withesToolStripMenuItem.Click += new System.EventHandler(this.withesToolStripMenuItem_Click);
			// 
			// iconToolStripMenuItem
			// 
			this.iconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busnessClockToolStripMenuItem,
            this.clockTimeToolStripMenuItem,
            this.historicalToolStripMenuItem,
            this.clockToolStripMenuItem});
			this.iconToolStripMenuItem.Name = "iconToolStripMenuItem";
			this.iconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.iconToolStripMenuItem.Text = "Icon";
			// 
			// busnessClockToolStripMenuItem
			// 
			this.busnessClockToolStripMenuItem.Name = "busnessClockToolStripMenuItem";
			this.busnessClockToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.busnessClockToolStripMenuItem.Text = "Busness clock";
			this.busnessClockToolStripMenuItem.Click += new System.EventHandler(this.busnessClockToolStripMenuItem_Click);
			// 
			// clockTimeToolStripMenuItem
			// 
			this.clockTimeToolStripMenuItem.Name = "clockTimeToolStripMenuItem";
			this.clockTimeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.clockTimeToolStripMenuItem.Text = "Clock time";
			this.clockTimeToolStripMenuItem.Click += new System.EventHandler(this.clockTimeToolStripMenuItem_Click);
			// 
			// historicalToolStripMenuItem
			// 
			this.historicalToolStripMenuItem.Name = "historicalToolStripMenuItem";
			this.historicalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.historicalToolStripMenuItem.Text = "Historical ";
			this.historicalToolStripMenuItem.Click += new System.EventHandler(this.historicalToolStripMenuItem_Click);
			// 
			// clockToolStripMenuItem
			// 
			this.clockToolStripMenuItem.Name = "clockToolStripMenuItem";
			this.clockToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.clockToolStripMenuItem.Text = "Clock";
			this.clockToolStripMenuItem.Click += new System.EventHandler(this.clockToolStripMenuItem_Click);
			// 
			// colorsToolStripMenuItem
			// 
			this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.foregroundColorToolStripMenuItem});
			this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.colorsToolStripMenuItem.Text = "Colors";
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background Color";
			this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
			// 
			// foregroundColorToolStripMenuItem
			// 
			this.foregroundColorToolStripMenuItem.Name = "foregroundColorToolStripMenuItem";
			this.foregroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.foregroundColorToolStripMenuItem.Text = "Foreground Color";
			this.foregroundColorToolStripMenuItem.Click += new System.EventHandler(this.foregroundColorToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(61, 171);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(187, 29);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Покакзать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon1.BalloonTipText = "Clock";
			this.notifyIcon1.BalloonTipTitle = "Clock";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Clock";
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(37, 238);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(231, 57);
			this.btnHideControls.TabIndex = 2;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// chooseFontToolStripMenuItem
			// 
			this.chooseFontToolStripMenuItem.Name = "chooseFontToolStripMenuItem";
			this.chooseFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.chooseFontToolStripMenuItem.Text = "Choose Font";
			this.chooseFontToolStripMenuItem.Click += new System.EventHandler(this.chooseFontToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 331);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showControlToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem foregroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem fontsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem digital7ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fondeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem luneisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem busnessClockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clockTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historicalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chooseFontToolStripMenuItem;
	}
}

