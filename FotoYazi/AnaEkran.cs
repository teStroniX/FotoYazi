using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoYazi
{
	public partial class AnaEkran : Form
	{
		public StringFormat stringFormat;
		Rectangle rect1;
		Rectangle rect2;
		public Font font1 = new Font("Arial", 18);
		public Font font2 = new Font("Arial", 12);
		public Color color1 = Color.Black;
		public Color color2 = Color.Black;
		public Bitmap bmp;
		string onizleme1 = "Merhaba Ben Ana Önizleme Metniyim!";
		string onizleme2 = "Merhaba Ben Yardımcı Önizleme Metniyim!";
		public int kenarBosluk = 10;
		public int araBosluk = 10;
		public AnaEkran(Bitmap bmp)
		{
			InitializeComponent();
			this.bmp = bmp;
			pictureBox1.Image = bmp;

			txb_font1.Text = font1.ToString();
			txb_font2.Text = font2.ToString();
		}

		private void btn_font1_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			dialog.Font = font1;

			if(dialog.ShowDialog() == DialogResult.OK)
			{
				txb_font1.Text = dialog.Font.ToString();
				font1 = dialog.Font;
			}

		}

		private void btn_font2_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			dialog.Font = font2;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txb_font2.Text = dialog.Font.ToString();
				font2 = dialog.Font;
			}
		}

		private void btn_preview_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = bmp.Clone() as Bitmap;

			int w = bitmap.Width;
			int h = bitmap.Height;

			stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;

			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				Size s = bitmap.Size;
				s.Width -= 2*kenarBosluk;
				SizeF s1 = graphics.MeasureString(onizleme1, font1, s, stringFormat);
				SizeF s2 = graphics.MeasureString(onizleme2, font2, s, stringFormat);

				rect1 = new Rectangle(kenarBosluk, h / 2 - Convert.ToInt32(s1.Height) / 2 - Convert.ToInt32(s2.Height) / 2, w - 2 * kenarBosluk, Convert.ToInt32(s1.Height));
				rect2 = new Rectangle(kenarBosluk, h / 2 + Convert.ToInt32(s1.Height) / 2 - Convert.ToInt32(s2.Height) / 2 + araBosluk,  w - 2 * kenarBosluk, Convert.ToInt32(s2.Height));

				graphics.DrawString(onizleme1, font1, new SolidBrush(color1) , rect1, stringFormat);
				graphics.DrawString(onizleme2, font2, new SolidBrush(color2), rect2, stringFormat);
			}

			pictureBox1.Image = bitmap;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				color1 = dialog.Color;
				button1.BackColor = color1;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				color2 = dialog.Color;
				button2.BackColor = color2;
			}
		}

		private void önizlemeMetinleriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MetinDuzenle form = new MetinDuzenle(onizleme1,onizleme2);
			form.ShowDialog();
			onizleme1 = form.s1;
			onizleme2 = form.s2;
		}

		private void boşluklarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BoslukDuzenle form = new BoslukDuzenle(kenarBosluk, araBosluk);
			form.ShowDialog();
			kenarBosluk = form.i1;
			araBosluk = form.i2;
		}

		private void tamamlaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlanSec form = new AlanSec(this);

			if (form.ShowDialog() == DialogResult.OK)
				this.Close();
		}
	}
}
