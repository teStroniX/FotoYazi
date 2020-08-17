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
	public partial class BoslukDuzenle : Form
	{
		public int i1;
		public int i2;
		public BoslukDuzenle(int i1, int i2)
		{
			InitializeComponent();
			numericUpDown1.Value = i1;
			numericUpDown2.Value = i2;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.i1 = Convert.ToInt32(numericUpDown1.Value);
			this.i2 = Convert.ToInt32(numericUpDown2.Value);
			this.Close();
		}
	}
}
