using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoYazi
{
	public partial class FotoSec : Form
	{
		//390,344
		Bitmap bmp;
		public FotoSec()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();

			if(dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Bitmap bmp = new Bitmap(dialog.FileName);
					this.bmp = bmp;
					textBox1.Text = dialog.FileName;
					pictureBox1.Image = bmp;
					pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
					this.Size = new Size(390, 344);
				}catch(Exception ex)
				{
					MessageBox.Show("Fotoğraf Yüklenemedi. \n" + ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AnaEkran form = new AnaEkran(bmp);
			this.Hide();
			form.ShowDialog();
			this.Close();
		}
	}
}
