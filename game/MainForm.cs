using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace game
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public static int globalVariable;
		
		//загрузка формы (подготовка tabControl)
		void MainFormLoad(object sender, EventArgs e)
		{
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        //кнопка начать игру
        void StartClick(object sender, EventArgs e)
		{
			//подготовка таблицы для имени
			tableBots.Rows.Clear();
			tableBots.AllowUserToAddRows = false;
			tableBots.ColumnCount = 1;
	        tableBots.Columns[0].Name = "ID";
	        tableBots.Rows.Add("Бот1");
	        fieldBot.Value = 1;
	        //переключение tabControl на настройки игры
			tabControl1.SelectTab(1);
			//очистка старых значений
			panelInfo.Text = "";
			gameInfo.Items.Clear();
		}
		//при изменении кол-ва ботов
		void FieldBotChanged(object sender, EventArgs e)
		{
			tableBots.Rows.Clear();
			int rowCount = (int)fieldBot.Value; // Получаем значение из NumericUpDown
			tableBots.ColumnCount = 1; // Установка количества столбцов
	        tableBots.Columns[0].Name = "ID"; // Имя первого столбца

			// Добавление строк
			for (int i = 0; i < rowCount; i++)
			{
			    // Создаем массив строк для текущей строки
			    string[] row = new string[] { "Бот" + Convert.ToString(i + 1)}; // ID в формате "БотX"
			    // Добавляем строку в DataGridView
			    tableBots.Rows.Add(row);
			}
		}

		void ButtonGameStartClick(object sender, EventArgs e)
		{
			Game.Instance.Initialize();
			string mainname = fieldName.Text;
			int balance;
			int bet;
			
			try
			{
			    balance = int.Parse(fieldBalance.Text);
			    bet = int.Parse(fieldBet.Text);

				if((bet > balance) || (bet <= 0) || (balance <= 0) || (bet * 2 > balance))
				{
					MessageBox.Show("Ошибка ввода данных для Игроков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
                {
					Game.Instance.AddPlayers(tableBots, mainname, balance);
					Game.Instance.Bets = bet;
					tabControl1.SelectTab(2);
					StartGameLoop();
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Ошибка ввода данных для Игроков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        public static int CardInfo(string suit, int rank)
        {
            int value = 0;
            switch (suit)
            {
                case "Бубны":
                    value = rank;
                    break;
                case "Трефы":
                    value = rank + 13;
                    break;
                case "Пики":
                    value = rank + 26;
                    break;
                case "Черви":
                    value = rank + 39;
                    break;
            }

            return value - 2;
        }
        //вывод инфы
        public async Task OutputInfo(Label boardInfo, string text)
		{
			boardInfo.Visible = true;
			boardInfo.BackColor = Color.FromArgb(0, 0, 255);
			boardInfo.Text = text;
			await Task.Delay(2000);
			boardInfo.Visible = false;
		}
		
		private async void StartGameLoop()
		{
			//определение дилера
			Game.Instance.RandomDealerIndex();  // выбрали индекс игрока
				
			bool gameis = true;
			string flagwin = "Игрок победил";
			while (gameis) // пока игра активна
			{
				//раздаем карты игрокам
				Game.Instance.DistributionPlayerCard();
				//делим банк
				await Game.Instance.PoolBank(boardInfo, gameInfo);
				//проверка на выбывание игрока
				await Game.Instance.CheckPlayers(boardInfo, gameInfo);
				//списываем деньги в банк
				Game.Instance.AddMoneyBank(gameInfo);
				bool roundis = true;
				//задаем дилеру индекс
				Game.Instance.DealerNewIndex(gameInfo); // назначили дилера
				//вывод информации о раунде
				await OutputInfo(boardInfo, " Раунд " + Convert.ToString(Game.Instance.Round) + " раздает " + 
					Game.Instance.Players[Game.Instance.DealerIndex].Name);

			    await Task.Delay(2000);
			    roundInfo.Text = "Раунд " + Convert.ToString(Game.Instance.Round);
				//проверка на выигрыш в игре
				if ((Game.Instance.Players.Count == Game.Instance.IsSpectatorCount + 1) && (!Game.Instance.Players[0].IsSpectator))
				{
					break;
				}

				//проверка на проигрыш в игре
				if (Game.Instance.Players[0].IsSpectator)
				{
					flagwin = "Игрок проиграл";
					break;
				}

				while (roundis)
				{
					panelInfo.BackColor = Color.FromArgb(255, 0, 0);
					//выбираем следующего игрока
					Game.Instance.PlayerNewIndex();

					panelInfo.Text = "Ход игрока " + Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name;
					//если очередь дошла до дилера, то он ходит и на нем раунд заканчивается
					if (Game.Instance.CurrentPlayerIndex == Game.Instance.DealerIndex)
					{
						roundis = false;
					}

					if(!Game.Instance.Players[Game.Instance.CurrentPlayerIndex].IsSpectator)
		        	{
						BalanceBankInfo.Text = "Баланс игрока: " + Convert.ToString(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money);
		        		BalanceBankInfo.Text += "\nБаланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney);
		        		//задаем картинки для карт
		        		labelCardInfoOne.Image = imageList1.Images[CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[0].Suit, 
							Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[0].Rank)];

		        		labelCardInfoTwo.Image = imageList1.Images[CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[1].Suit, 
							Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[1].Rank)];

		        		labelCardInfoThree.Image = imageList1.Images[52];
		        		//проверка игроков
		        		
			        	if (Game.Instance.CurrentPlayerIndex != 0)
						{
							//ход бота
							await Game.Instance.BotMove(labelCardInfoThree, gameInfo, imageList1, boardInfo);
						}

						else
						{
							//ход игрока
							//менем цвет панели
							panelInfo.BackColor = Color.FromArgb(0, 255, 0);
							//ждем пока игрок не выберет ставку
							await Game.Instance.PlayerMove(labelCardInfoThree, gameInfo, imageList1);
				        }
					}

					if (Game.Instance.Bank.TotalMoney < Game.Instance.Bets)
					{
						await OutputInfo(boardInfo, "Конец раунда, деньги в «пул»-банке закончились");
					    break;
					}
				}

				Game.Instance.Round++;
			}

			await OutputInfo(boardInfo, "Конец игры...");
			await OutputInfo(boardInfo, flagwin);
			await Task.Delay(10000);
			tabControl1.SelectTab(0);
		}

		void ButtonPlaceBetClick(object sender, EventArgs e)
		{
			try {
				globalVariable = Convert.ToInt32(textBoxAmountBet.Text);
				if (globalVariable <= 0)
				{
					globalVariable = 0;
					MessageBox.Show("Ошибка ввода ставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception) {
				MessageBox.Show("Ошибка ввода ставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void ButtonRefuseBetClick(object sender, EventArgs e)
		{
			globalVariable =- 1;
		}
	}
}
