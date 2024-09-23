using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindiwosForms
{
	public partial class ChooseFont : Form
	{
		public ChooseFont()
		{
			InitializeComponent();
			string[] ttf_files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.ttf");
			string[] otf_files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.otf");
			string[] files = new string[ttf_files.Length + otf_files.Length];
			ttf_files.CopyTo(files, 0);
			otf_files.CopyTo(files, ttf_files.Length);
			for (int i = 0; i < files.Length; i++)
			{
				comboBoxFont.Items.Add(files[i].Split('\\').Last());
			}




		}

		private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
			Font font = new Font(pfc.Families[0], Convert.ToInt32(numericUpDown.Value));
			pfc.Dispose();
			labelSample.Font = font;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			
		}
	}
}
