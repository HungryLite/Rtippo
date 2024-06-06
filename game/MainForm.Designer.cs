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
		private System.Windows.Forms.Button buttonStartClick;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelAmountBot;
		private System.Windows.Forms.NumericUpDown fieldBot;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox fieldBalance;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox fieldName;
		private System.Windows.Forms.DataGridView tableBots;
		private System.Windows.Forms.Button buttonGameStart;
		private System.Windows.Forms.TextBox fieldBet;
		private System.Windows.Forms.Label labelBet;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Label panelInfo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label BalanceBankInfo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxAmountBet;
		private System.Windows.Forms.Button buttonRefuseBet;
		private System.Windows.Forms.Button buttonPlaceBet;
		private System.Windows.Forms.Label labelCardInfoTwo;
		private System.Windows.Forms.Label labelCardInfoOne;
		private System.Windows.Forms.ListBox gameInfo;
		private System.Windows.Forms.Label labelCardInfoThree;
		private System.Windows.Forms.Label boardInfo;
		private System.Windows.Forms.Label roundInfo;
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
			this.buttonStartClick = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableBots = new System.Windows.Forms.DataGridView();
			this.labelAmountBot = new System.Windows.Forms.Label();
			this.fieldBot = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonGameStart = new System.Windows.Forms.Button();
			this.fieldBet = new System.Windows.Forms.TextBox();
			this.labelBet = new System.Windows.Forms.Label();
			this.fieldBalance = new System.Windows.Forms.TextBox();
			this.labelBalance = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.fieldName = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.boardInfo = new System.Windows.Forms.Label();
			this.gameInfo = new System.Windows.Forms.ListBox();
			this.BalanceBankInfo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelCardInfoOne = new System.Windows.Forms.Label();
			this.labelCardInfoThree = new System.Windows.Forms.Label();
			this.labelCardInfoTwo = new System.Windows.Forms.Label();
			this.textBoxAmountBet = new System.Windows.Forms.TextBox();
			this.buttonRefuseBet = new System.Windows.Forms.Button();
			this.buttonPlaceBet = new System.Windows.Forms.Button();
			this.panelUp = new System.Windows.Forms.Panel();
			this.roundInfo = new System.Windows.Forms.Label();
			this.panelInfo = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableBots)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldBot)).BeginInit();
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
			this.tabPage1.Controls.Add(this.buttonStartClick);
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
			this.buttonStartClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.buttonStartClick.Location = new System.Drawing.Point(233, 135);
			this.buttonStartClick.Name = "button1";
			this.buttonStartClick.Size = new System.Drawing.Size(180, 50);
			this.buttonStartClick.TabIndex = 0;
			this.buttonStartClick.Text = "Начать игру";
			this.buttonStartClick.UseVisualStyleBackColor = true;
			this.buttonStartClick.Click += new System.EventHandler(this.StartClick);
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
			this.groupBox2.Controls.Add(this.tableBots);
			this.groupBox2.Controls.Add(this.labelAmountBot);
			this.groupBox2.Controls.Add(this.fieldBot);
			this.groupBox2.Location = new System.Drawing.Point(287, 18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 262);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Бот";
			// 
			// dataGridView1
			// 
			this.tableBots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableBots.Location = new System.Drawing.Point(30, 86);
			this.tableBots.Name = "dataGridView1";
			this.tableBots.Size = new System.Drawing.Size(240, 150);
			this.tableBots.TabIndex = 2;
			// 
			// label1
			// 
			this.labelAmountBot.Location = new System.Drawing.Point(7, 20);
			this.labelAmountBot.Name = "label1";
			this.labelAmountBot.Size = new System.Drawing.Size(100, 23);
			this.labelAmountBot.TabIndex = 1;
			this.labelAmountBot.Text = "Количество";
			// 
			// numericUpDown1
			// 
			this.fieldBot.Location = new System.Drawing.Point(116, 19);
			this.fieldBot.Maximum = new decimal(new int[] {
			7,
			0,
			0,
			0});
			this.fieldBot.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.fieldBot.Name = "numericUpDown1";
			this.fieldBot.Size = new System.Drawing.Size(120, 20);
			this.fieldBot.TabIndex = 0;
			this.fieldBot.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.fieldBot.ValueChanged += new System.EventHandler(this.FieldBotChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonGameStart);
			this.groupBox1.Controls.Add(this.fieldBet);
			this.groupBox1.Controls.Add(this.labelBet);
			this.groupBox1.Controls.Add(this.fieldBalance);
			this.groupBox1.Controls.Add(this.labelBalance);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Controls.Add(this.fieldName);
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
			this.fieldBet.Location = new System.Drawing.Point(146, 74);
			this.fieldBet.Name = "textBox3";
			this.fieldBet.Size = new System.Drawing.Size(100, 20);
			this.fieldBet.TabIndex = 5;
			// 
			// label4
			// 
			this.labelBet.Location = new System.Drawing.Point(7, 77);
			this.labelBet.Name = "label4";
			this.labelBet.Size = new System.Drawing.Size(145, 23);
			this.labelBet.TabIndex = 4;
			this.labelBet.Text = "Предварительная ставка";
			// 
			// textBox2
			// 
			this.fieldBalance.Location = new System.Drawing.Point(146, 48);
			this.fieldBalance.Name = "textBox2";
			this.fieldBalance.Size = new System.Drawing.Size(100, 20);
			this.fieldBalance.TabIndex = 3;
			// 
			// label3
			// 
			this.labelBalance.Location = new System.Drawing.Point(7, 48);
			this.labelBalance.Name = "label3";
			this.labelBalance.Size = new System.Drawing.Size(100, 23);
			this.labelBalance.TabIndex = 2;
			this.labelBalance.Text = "Баланс";
			// 
			// label2
			// 
			this.labelName.Location = new System.Drawing.Point(7, 20);
			this.labelName.Name = "label2";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Имя";
			// 
			// textBox1
			// 
			this.fieldName.Location = new System.Drawing.Point(146, 18);
			this.fieldName.Name = "textBox1";
			this.fieldName.Size = new System.Drawing.Size(100, 20);
			this.fieldName.TabIndex = 0;
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
			this.panel2.Controls.Add(this.boardInfo);
			this.panel2.Controls.Add(this.gameInfo);
			this.panel2.Controls.Add(this.BalanceBankInfo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(647, 111);
			this.panel2.TabIndex = 2;
			// 
			// labelinfo
			// 
			this.boardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.boardInfo.Location = new System.Drawing.Point(0, 43);
			this.boardInfo.Name = "labelinfo";
			this.boardInfo.Size = new System.Drawing.Size(647, 48);
			this.boardInfo.TabIndex = 2;
			this.boardInfo.Text = "labelinfo";
			this.boardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox1
			// 
			this.gameInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.gameInfo.FormattingEnabled = true;
			this.gameInfo.Location = new System.Drawing.Point(474, 0);
			this.gameInfo.Name = "listBox1";
			this.gameInfo.Size = new System.Drawing.Size(173, 111);
			this.gameInfo.TabIndex = 1;
			// 
			// label5
			// 
			this.BalanceBankInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.BalanceBankInfo.Location = new System.Drawing.Point(0, 0);
			this.BalanceBankInfo.Name = "label5";
			this.BalanceBankInfo.Size = new System.Drawing.Size(137, 111);
			this.BalanceBankInfo.TabIndex = 0;
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
			this.panelUp.Controls.Add(this.roundInfo);
			this.panelUp.Controls.Add(this.panelInfo);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(647, 61);
			this.panelUp.TabIndex = 0;
			// 
			// labelround
			// 
			this.roundInfo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.roundInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.roundInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.roundInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.roundInfo.Location = new System.Drawing.Point(0, 0);
			this.roundInfo.Name = "labelround";
			this.roundInfo.Size = new System.Drawing.Size(117, 61);
			this.roundInfo.TabIndex = 1;
			this.roundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label
			// 
			this.panelInfo.BackColor = System.Drawing.Color.Red;
			this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelInfo.Location = new System.Drawing.Point(111, 0);
			this.panelInfo.Name = "label";
			this.panelInfo.Size = new System.Drawing.Size(536, 61);
			this.panelInfo.TabIndex = 0;
			this.panelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			((System.ComponentModel.ISupportInitialize)(this.tableBots)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldBot)).EndInit();
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
