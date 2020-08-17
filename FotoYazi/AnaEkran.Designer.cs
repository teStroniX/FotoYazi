namespace FotoYazi
{
	partial class AnaEkran
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.önizlemeMetinleriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_font1 = new System.Windows.Forms.TextBox();
			this.btn_font1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txb_font2 = new System.Windows.Forms.TextBox();
			this.btn_font2 = new System.Windows.Forms.Button();
			this.btn_preview = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.boşluklarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tamamlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(444, 331);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(450, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.önizlemeMetinleriniDüzenleToolStripMenuItem,
            this.boşluklarıDüzenleToolStripMenuItem,
            this.tamamlaToolStripMenuItem,
            this.çToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
			this.toolStripDropDownButton1.Text = "Menü";
			// 
			// önizlemeMetinleriniDüzenleToolStripMenuItem
			// 
			this.önizlemeMetinleriniDüzenleToolStripMenuItem.Name = "önizlemeMetinleriniDüzenleToolStripMenuItem";
			this.önizlemeMetinleriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.önizlemeMetinleriniDüzenleToolStripMenuItem.Text = "Önizleme Metinlerini Düzenle";
			this.önizlemeMetinleriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.önizlemeMetinleriniDüzenleToolStripMenuItem_Click);
			// 
			// çToolStripMenuItem
			// 
			this.çToolStripMenuItem.Name = "çToolStripMenuItem";
			this.çToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.çToolStripMenuItem.Text = "Çıkış";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
			this.toolStripButton1.Text = "Yardım";
			// 
			// hakkındaToolStripMenuItem
			// 
			this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
			this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.hakkındaToolStripMenuItem.Text = "Hakkında";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_preview, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 430);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txb_font1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_font1, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txb_font2, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.btn_font2, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.button2, 3, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 369);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 58);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ana Metin Stili:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_font1
			// 
			this.txb_font1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_font1.Location = new System.Drawing.Point(107, 3);
			this.txb_font1.Name = "txb_font1";
			this.txb_font1.Size = new System.Drawing.Size(272, 20);
			this.txb_font1.TabIndex = 1;
			// 
			// btn_font1
			// 
			this.btn_font1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_font1.Location = new System.Drawing.Point(385, 3);
			this.btn_font1.Name = "btn_font1";
			this.btn_font1.Size = new System.Drawing.Size(25, 23);
			this.btn_font1.TabIndex = 2;
			this.btn_font1.Text = "...";
			this.btn_font1.UseVisualStyleBackColor = true;
			this.btn_font1.Click += new System.EventHandler(this.btn_font1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Yardımcı Metin Stili:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txb_font2
			// 
			this.txb_font2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_font2.Location = new System.Drawing.Point(107, 32);
			this.txb_font2.Name = "txb_font2";
			this.txb_font2.Size = new System.Drawing.Size(272, 20);
			this.txb_font2.TabIndex = 1;
			// 
			// btn_font2
			// 
			this.btn_font2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_font2.Location = new System.Drawing.Point(385, 32);
			this.btn_font2.Name = "btn_font2";
			this.btn_font2.Size = new System.Drawing.Size(25, 23);
			this.btn_font2.TabIndex = 2;
			this.btn_font2.Text = "...";
			this.btn_font2.UseVisualStyleBackColor = true;
			this.btn_font2.Click += new System.EventHandler(this.btn_font2_Click);
			// 
			// btn_preview
			// 
			this.btn_preview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_preview.Location = new System.Drawing.Point(3, 3);
			this.btn_preview.Name = "btn_preview";
			this.btn_preview.Size = new System.Drawing.Size(444, 23);
			this.btn_preview.TabIndex = 2;
			this.btn_preview.Text = "Önizle";
			this.btn_preview.UseVisualStyleBackColor = true;
			this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(416, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 23);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(416, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(25, 23);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// boşluklarıDüzenleToolStripMenuItem
			// 
			this.boşluklarıDüzenleToolStripMenuItem.Name = "boşluklarıDüzenleToolStripMenuItem";
			this.boşluklarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.boşluklarıDüzenleToolStripMenuItem.Text = "Boşlukları Düzenle";
			this.boşluklarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.boşluklarıDüzenleToolStripMenuItem_Click);
			// 
			// tamamlaToolStripMenuItem
			// 
			this.tamamlaToolStripMenuItem.Name = "tamamlaToolStripMenuItem";
			this.tamamlaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.tamamlaToolStripMenuItem.Text = "Çıktı Al";
			this.tamamlaToolStripMenuItem.Click += new System.EventHandler(this.tamamlaToolStripMenuItem_Click);
			// 
			// AnaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 455);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "AnaEkran";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem önizlemeMetinleriniDüzenleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_font1;
		private System.Windows.Forms.Button btn_font1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txb_font2;
		private System.Windows.Forms.Button btn_font2;
		private System.Windows.Forms.Button btn_preview;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem boşluklarıDüzenleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tamamlaToolStripMenuItem;
	}
}

