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
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.btnHideControls = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(106, 146);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(144, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "label1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.showControlToolStripMenuItem,
            this.showDateToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Checked = true;
			this.OpenToolStripMenuItem.CheckOnClick = true;
			this.OpenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.OpenToolStripMenuItem.Text = "Open";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// showControlToolStripMenuItem
			// 
			this.showControlToolStripMenuItem.Name = "showControlToolStripMenuItem";
			this.showControlToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.showControlToolStripMenuItem.Text = "Show control";
			this.showControlToolStripMenuItem.Click += new System.EventHandler(this.showControlToolStripMenuItem_Click);
			// 
			// showDateToolStripMenuItem
			// 
			this.showDateToolStripMenuItem.CheckOnClick = true;
			this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
			this.showDateToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.showDateToolStripMenuItem.Text = "Show date";
			this.showDateToolStripMenuItem.Click += new System.EventHandler(this.showDateToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
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
			this.cbShowDate.Location = new System.Drawing.Point(115, 295);
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
			this.btnHideControls.Location = new System.Drawing.Point(154, 361);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(231, 57);
			this.btnHideControls.TabIndex = 2;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 441);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MainForm";
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
	}
}

