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
using Exc=Microsoft.Office.Interop.Excel;

namespace FotoYazi
{
	public partial class AlanSec : Form
	{
		DataTable dt;
		bool select1 = false;
		bool select2 = false;

		AnaEkran form;
		public AlanSec(AnaEkran form)
		{
			InitializeComponent();
			this.form = form;
		}

		private void dbGetir()
		{
			Exc.Application _Application = new Exc.Application();
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					Exc.Workbook _Workbook = _Application.Workbooks.Open(dialog.FileName);
					Exc.Worksheet _Worksheet = _Workbook.Worksheets[1];
					Exc.Range _Range = _Worksheet.UsedRange;

					int rowCount = _Range.Rows.Count;
					int colCount = _Range.Columns.Count;

					dt = new DataTable();

					for (int i = 1; i < colCount + 1; i++)
					{
						string val = _Range.Cells[1, i].Value2 + "" ?? "";
						dt.Columns.Add(val);
					}

					for (int i = 2; i <= rowCount; i++)
					{
						List<object> data = new List<object>();
						for (int j = 1; j <= colCount; j++)
						{
							string val = _Range.Cells[i, j].Value2 + "" ?? "";
							data.Add(val);
						}
						dt.Rows.Add(data.ToArray());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				_Application.Workbooks.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dbGetir();

			if(dt != null)
			{
				List<string> data = new List<string>();
				List<string> data2 = new List<string>();
				foreach (DataColumn dr in dt.Columns)
				{
					data.Add(dr.Caption);
					data2.Add(dr.Caption);
				}
				comboBox1.DataSource = data;
				comboBox2.DataSource = data2;
				comboBox1.Enabled = true;
				comboBox2.Enabled = true;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			select1 = true;
			if (select1 && select2)
				GetirData();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			select2 = true;
			if (select1 && select2)
				GetirData();
		}

		private void GetirData()
		{
			dataGridView1.Rows.Clear();

			foreach(DataRow dr in dt.Rows)
			{
				dataGridView1.Rows.Add(dr[comboBox1.Text], dr[comboBox2.Text]);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				int i = 0;
				foreach (DataGridViewRow dr in dataGridView1.Rows)
				{
					Bitmap bitmap = (Bitmap)form.bmp.Clone();
					int w = bitmap.Width;
					int h = bitmap.Height;

					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						Size s = bitmap.Size;
						s.Width -= 2 * form.kenarBosluk;
						SizeF s1 = graphics.MeasureString(dr.Cells["ANAMETIN"].Value.ToString(), form.font1, s, form.stringFormat);
						SizeF s2 = graphics.MeasureString(dr.Cells["YARDIMCIMETIN"].Value.ToString(), form.font2, s, form.stringFormat);

						Rectangle rect1 = new Rectangle(form.kenarBosluk, h / 2 - Convert.ToInt32(s1.Height) / 2 - Convert.ToInt32(s2.Height) / 2, w - 2 * form.kenarBosluk, Convert.ToInt32(s1.Height));
						Rectangle rect2 = new Rectangle(form.kenarBosluk, h / 2 + Convert.ToInt32(s1.Height) / 2 - Convert.ToInt32(s2.Height) / 2 + form.araBosluk, w - 2 * form.kenarBosluk, Convert.ToInt32(s2.Height));

						graphics.DrawString(dr.Cells["ANAMETIN"].Value.ToString(), form.font1, new SolidBrush(form.color1), rect1, form.stringFormat);
						graphics.DrawString(dr.Cells["YARDIMCIMETIN"].Value.ToString(), form.font2, new SolidBrush(form.color2), rect2, form.stringFormat);

						bitmap.Save(dialog.SelectedPath + @"\Image" + (++i).ToString("000") + ".jpg");
					}
				}
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
	}
}
