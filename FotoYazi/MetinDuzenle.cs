using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoYazi
{
	public partial class MetinDuzenle : Form
	{
		public string s1;
		public string s2;
		public MetinDuzenle(string s1, string s2)
		{
			InitializeComponent();
			textBox1.Text = s1;
			textBox2.Text = s2;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.s1 = textBox1.Text;
			this.s2 = textBox2.Text;
			this.Close();
		}
	}
}
