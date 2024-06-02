namespace game
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonGameStart;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxAmountBet;
		private System.Windows.Forms.Button buttonRefuseBet;
		private System.Windows.Forms.Button buttonPlaceBet;
		private System.Windows.Forms.Label labelCardInfoTwo;
		private System.Windows.Forms.Label labelCardInfoOne;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label labelCardInfoThree;
		private System.Windows.Forms.Label labelinfo;
		private System.Windows.Forms.Label labelround;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonGameStart = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelinfo = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelCardInfoOne = new System.Windows.Forms.Label();
			this.labelCardInfoThree = new System.Windows.Forms.Label();
			this.labelCardInfoTwo = new System.Windows.Forms.Label();
			this.textBoxAmountBet = new System.Windows.Forms.TextBox();
			this.buttonRefuseBet = new System.Windows.Forms.Button();
			this.buttonPlaceBet = new System.Windows.Forms.Button();
			this.panelUp = new System.Windows.Forms.Panel();
			this.labelround = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(655, 374);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(647, 348);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.button1.Location = new System.Drawing.Point(233, 135);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Начать игру";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.StartClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(647, 348);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Location = new System.Drawing.Point(287, 18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 262);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Бот";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(30, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Количество";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(116, 19);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			7,
			0,
			0,
			0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonGameStart);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(18, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(252, 262);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Игрок";
			// 
			// buttonGameStart
			// 
			this.buttonGameStart.Location = new System.Drawing.Point(171, 233);
			this.buttonGameStart.Name = "buttonGameStart";
			this.buttonGameStart.Size = new System.Drawing.Size(75, 23);
			this.buttonGameStart.TabIndex = 6;
			this.buttonGameStart.Text = "Начать игру";
			this.buttonGameStart.UseVisualStyleBackColor = true;
			this.buttonGameStart.Click += new System.EventHandler(this.ButtonGameStartClick);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(146, 74);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Предварительная ставка";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(146, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Баланс";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(146, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Controls.Add(this.panel1);
			this.tabPage3.Controls.Add(this.panelUp);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(647, 348);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelinfo);
			this.panel2.Controls.Add(this.listBox1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(647, 111);
			this.panel2.TabIndex = 2;
			// 
			// labelinfo
			// 
			this.labelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelinfo.Location = new System.Drawing.Point(0, 43);
			this.labelinfo.Name = "labelinfo";
			this.labelinfo.Size = new System.Drawing.Size(647, 48);
			this.labelinfo.TabIndex = 2;
			this.labelinfo.Text = "labelinfo";
			this.labelinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(474, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(173, 111);
			this.listBox1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 111);
			this.label5.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.textBoxAmountBet);
			this.panel1.Controls.Add(this.buttonRefuseBet);
			this.panel1.Controls.Add(this.buttonPlaceBet);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 172);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(647, 176);
			this.panel1.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelCardInfoOne);
			this.groupBox3.Controls.Add(this.labelCardInfoThree);
			this.groupBox3.Controls.Add(this.labelCardInfoTwo);
			this.groupBox3.Location = new System.Drawing.Point(8, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(316, 176);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Карты";
			// 
			// labelCardInfoOne
			// 
			this.labelCardInfoOne.BackColor = System.Drawing.Color.Coral;
			this.labelCardInfoOne.Location = new System.Drawing.Point(6, 15);
			this.labelCardInfoOne.Name = "labelCardInfoOne";
			this.labelCardInfoOne.Size = new System.Drawing.Size(97, 152);
			this.labelCardInfoOne.TabIndex = 0;
			// 
			// labelCardInfoThree
			// 
			this.labelCardInfoThree.BackColor = System.Drawing.Color.IndianRed;
			this.labelCardInfoThree.Location = new System.Drawing.Point(212, 16);
			this.labelCardInfoThree.Name = "labelCardInfoThree";
			this.labelCardInfoThree.Size = new System.Drawing.Size(97, 152);
			this.labelCardInfoThree.TabIndex = 5;
			// 
			// labelCardInfoTwo
			// 
			this.labelCardInfoTwo.BackColor = System.Drawing.Color.Gray;
			this.labelCardInfoTwo.Location = new System.Drawing.Point(109, 15);
			this.labelCardInfoTwo.Name = "labelCardInfoTwo";
			this.labelCardInfoTwo.Size = new System.Drawing.Size(97, 152);
			this.labelCardInfoTwo.TabIndex = 1;
			// 
			// textBoxAmountBet
			// 
			this.textBoxAmountBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAmountBet.Location = new System.Drawing.Point(422, 105);
			this.textBoxAmountBet.Name = "textBoxAmountBet";
			this.textBoxAmountBet.Size = new System.Drawing.Size(100, 24);
			this.textBoxAmountBet.TabIndex = 4;
			// 
			// buttonRefuseBet
			// 
			this.buttonRefuseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.buttonRefuseBet.Location = new System.Drawing.Point(537, 135);
			this.buttonRefuseBet.Name = "buttonRefuseBet";
			this.buttonRefuseBet.Size = new System.Drawing.Size(110, 25);
			this.buttonRefuseBet.TabIndex = 3;
			this.buttonRefuseBet.Text = "Отказаться";
			this.buttonRefuseBet.UseVisualStyleBackColor = true;
			this.buttonRefuseBet.Click += new System.EventHandler(this.ButtonRefuseBetClick);
			// 
			// buttonPlaceBet
			// 
			this.buttonPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPlaceBet.Location = new System.Drawing.Point(537, 105);
			this.buttonPlaceBet.Name = "buttonPlaceBet";
			this.buttonPlaceBet.Size = new System.Drawing.Size(110, 24);
			this.buttonPlaceBet.TabIndex = 2;
			this.buttonPlaceBet.Text = "Поставить";
			this.buttonPlaceBet.UseVisualStyleBackColor = true;
			this.buttonPlaceBet.Click += new System.EventHandler(this.ButtonPlaceBetClick);
			// 
			// panelUp
			// 
			this.panelUp.Controls.Add(this.labelround);
			this.panelUp.Controls.Add(this.label);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(647, 61);
			this.panelUp.TabIndex = 0;
			// 
			// labelround
			// 
			this.labelround.BackColor = System.Drawing.Color.WhiteSmoke;
			this.labelround.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelround.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelround.Location = new System.Drawing.Point(0, 0);
			this.labelround.Name = "labelround";
			this.labelround.Size = new System.Drawing.Size(117, 61);
			this.labelround.TabIndex = 1;
			this.labelround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.Red;
			this.label.Dock = System.Windows.Forms.DockStyle.Right;
			this.label.Location = new System.Drawing.Point(111, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(536, 61);
			this.label.TabIndex = 0;
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "1.png");
			this.imageList1.Images.SetKeyName(1, "2.png");
			this.imageList1.Images.SetKeyName(2, "3.png");
			this.imageList1.Images.SetKeyName(3, "4.png");
			this.imageList1.Images.SetKeyName(4, "5.png");
			this.imageList1.Images.SetKeyName(5, "7.png");
			this.imageList1.Images.SetKeyName(6, "8.png");
			this.imageList1.Images.SetKeyName(7, "9.png");
			this.imageList1.Images.SetKeyName(8, "10.png");
			this.imageList1.Images.SetKeyName(9, "11.png");
			this.imageList1.Images.SetKeyName(10, "12.png");
			this.imageList1.Images.SetKeyName(11, "13.png");
			this.imageList1.Images.SetKeyName(12, "14.png");
			this.imageList1.Images.SetKeyName(13, "2.png");
			this.imageList1.Images.SetKeyName(14, "3.png");
			this.imageList1.Images.SetKeyName(15, "4.png");
			this.imageList1.Images.SetKeyName(16, "5.png");
			this.imageList1.Images.SetKeyName(17, "6.png");
			this.imageList1.Images.SetKeyName(18, "7.png");
			this.imageList1.Images.SetKeyName(19, "8.png");
			this.imageList1.Images.SetKeyName(20, "9.png");
			this.imageList1.Images.SetKeyName(21, "10.png");
			this.imageList1.Images.SetKeyName(22, "валет.png");
			this.imageList1.Images.SetKeyName(23, "дама.png");
			this.imageList1.Images.SetKeyName(24, "король.png");
			this.imageList1.Images.SetKeyName(25, "туз.png");
			this.imageList1.Images.SetKeyName(26, "2.png");
			this.imageList1.Images.SetKeyName(27, "3.png");
			this.imageList1.Images.SetKeyName(28, "4.png");
			this.imageList1.Images.SetKeyName(29, "5.png");
			this.imageList1.Images.SetKeyName(30, "6.png");
			this.imageList1.Images.SetKeyName(31, "7.png");
			this.imageList1.Images.SetKeyName(32, "8.png");
			this.imageList1.Images.SetKeyName(33, "9.png");
			this.imageList1.Images.SetKeyName(34, "10.png");
			this.imageList1.Images.SetKeyName(35, "валет.png");
			this.imageList1.Images.SetKeyName(36, "дама.png");
			this.imageList1.Images.SetKeyName(37, "король.png");
			this.imageList1.Images.SetKeyName(38, "туз.png");
			this.imageList1.Images.SetKeyName(39, "2.png");
			this.imageList1.Images.SetKeyName(40, "3.png");
			this.imageList1.Images.SetKeyName(41, "4.png");
			this.imageList1.Images.SetKeyName(42, "5.png");
			this.imageList1.Images.SetKeyName(43, "6.png");
			this.imageList1.Images.SetKeyName(44, "7.png");
			this.imageList1.Images.SetKeyName(45, "8.png");
			this.imageList1.Images.SetKeyName(46, "9.png");
			this.imageList1.Images.SetKeyName(47, "10.png");
			this.imageList1.Images.SetKeyName(48, "валет.png");
			this.imageList1.Images.SetKeyName(49, "дама.png");
			this.imageList1.Images.SetKeyName(50, "король.png");
			this.imageList1.Images.SetKeyName(51, "туз.png");
			this.imageList1.Images.SetKeyName(52, "рубашка.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 374);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(649, 353);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyGame";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
