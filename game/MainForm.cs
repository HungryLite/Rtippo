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
		//класс игрока
		public class Player
		{
			public string Name { get; set; }
			public int Money { get; set; }
			public List<Card> Hand { get; set; }
			public bool IsSpectator { get; set; }
		
			public Player(string name, int money) // конструктор для создания класса Player, даем параметрам значения
			{
				Name = name;
				Money = money;
				Hand = new List<Card>();
				IsSpectator = false;
			}
		}

		//класс карт
		public class Card
		{
			public int Rank { get; set; } // Ранг карты (от 2 до 14, где 11 - валет, 12 - дама, 13 - король, 14 - туз)
			public string Suit { get; set; } // Масть карты (Черви, Бубны, Трефы, Пики)
	
			public Card(int rank, string suit)
			{
				Rank = rank;
				Suit = suit;
			}
		}

		//класс колоды
		public class Deck
		{
			private List<Card> Cards;
	
			public Deck()
			{
				Cards = new List<Card>();
				InitializeDeck(); // создает набор карт
				Shuffle();
			}
	
			public void InitializeDeck()
			{
				string[] suits = { "Черви", "Бубны", "Трефы", "Пики" };
				for (int suit = 0; suit < 4; suit++)
				{
					for (int rank = 2; rank <= 14; rank++)
					{
						Cards.Add(new Card(rank, suits[suit]));
					}
				}
			}
	
			public void Shuffle()
			{
				Random rand = new Random();
				Cards = Cards.OrderBy(x => rand.Next()).ToList();
			}
	
			public Card DealCard()
			{
				Card card = Cards[0]; // берем верхнюю карту из колоды
				Cards.RemoveAt(0);
				return card;
			}
		}

		//класс банка
		public class Bank
		{
			public int TotalMoney { get; private set; }
		
			public Bank(int initialMoney)
			{
				TotalMoney = initialMoney;
			}
		
			public void AddMoney(int amount)
			{
				TotalMoney += amount;
			}
		
			public void RemoveMoney(int amount)
			{
				TotalMoney -= amount;
			}
		}
		
		internal class Game
    		{
            		private static Game instance; 
            		public static Game Instance
	        	{
	            		get
	            		{
	                		if (instance == null)
	                		{
	                    			instance = new Game();
	                		}

	                		return instance;
	            		}
        		}

			public List<Player> Players;
			public Bank Bank;
			public int CurrentPlayerIndex; // кто ходит в данный момент
			private Deck Deck;
			public int Bets; // представка
			public int Round;
			public int DealerIndex;
			public int IsSpectatorCount;

	        	private Game()
	        	{
				Initialize();
			}

		        public void Initialize()
		        {
		            Players = new List<Player>();
		            Deck = new Deck();
		            Bank = new Bank(0);
		            Round = 1;
		            Bets = 0;
		            CurrentPlayerIndex = 0;
		            DealerIndex = 0;
		            IsSpectatorCount = 0;
		        }

	        	public void AddPlayers(DataGridView dataGridView, string mainname, int balance)
		    	{
			    	Instance.Players.Add(new Player(mainname, balance));
			        foreach (DataGridViewRow row in dataGridView.Rows)
				{
					if (!row.IsNewRow)
					{
						// Получаем данные из ячеек
					        string name = row.Cells["ID"].Value.ToString();
					        Instance.Players.Add(new Player(name, balance));
					}
				}
		    	}

	        	//получение решения для бота
		    	public bool GetRandomBool()
			{
			    return random.Next(2) == 0; // 0 или 1 (false или true)
			}

			//случайная ставка
			public int GetRandomBetAmount(int playerMoney, int bet, int bank)
			{
		        	int maxBetAmount = Math.Min(playerMoney, bank);
		        	// Генерируем случайную ставку от bet до maxBetAmount
		        	return random.Next(bet, maxBetAmount + 1);
			}

			//проверка выигрыша
			public int CalculateWinnings(List<Card> playerCards, int bet)
			{
			    int value1 = playerCards[0].Rank;
			    int value2 = playerCards[1].Rank;
			    int value3 = playerCards[2].Rank;

				//проверка условий
			    if (((value1 > value3) && (value2 < value3)) || ((value1 < value3) && (value2 > value3)))
			    {
			    	return bet;
			    }

			    else
			    {
			   	return -bet;
			    }
			}
			
			public void DealerNewIndex(ListBox listBox1)
			{
				if (Game.Instance.DealerIndex == Game.Instance.Players.Count - 1)
				{
					Game.Instance.DealerIndex = 0; // Если дилер последний в списке, начинаем с первого игрока
				}

				else
				{
					Game.Instance.DealerIndex = Game.Instance.DealerIndex + 1; // Иначе начинаем с игрока после дилера
				}

				Game.Instance.CurrentPlayerIndex = Game.Instance.DealerIndex;
				listBox1.Items.Add("Сдающий: " + Game.Instance.Players[Game.Instance.DealerIndex].Name);
			}
			
			public void PlayerNewIndex()
			{
				if (Game.Instance.CurrentPlayerIndex == Game.Instance.Players.Count - 1)
				{
					Game.Instance.CurrentPlayerIndex = 0; // Если игрок последний в списке, начинаем с первого игрока
				}

				else
				{
					Game.Instance.CurrentPlayerIndex = Game.Instance.CurrentPlayerIndex + 1; // Иначе начинаем со следующего игрока
				}
			}
			
			public void RandomDealerIndex()
			{
			    Game.Instance.DealerIndex = random.Next(Game.Instance.Players.Count);
			}

			async public Task PoolBank(Label labelinfo, ListBox listBox1) // метод выполянется параллельно с основной программой
			{
				int i = 0;
				if (Instance.Bank.TotalMoney >= Instance.Bets * (Instance.Players.Count) * 4)
			    	{
					labelinfo.Visible = true;
				    	labelinfo.BackColor = Color.FromArgb(0, 0, 255); // синий
				    	labelinfo.Text = " Раунд " + Convert.ToString(Instance.Round) + " Раздел банка ";
					await Task.Delay(2000);
				    
					foreach (Player player in Instance.Players)
					{
						if (!player.IsSpectator)
						{
							i++;
						}
					}

					int totalBankMoney = Instance.Bank.TotalMoney;
					int betPerPlayer = 0;
					foreach (Player player in Instance.Players)
					{
						if (!player.IsSpectator)
						{
			        			betPerPlayer = Convert.ToInt32(Math.Floor((double)totalBankMoney / i));
							player.Money += betPerPlayer;
						}
					}

					Instance.Bank.RemoveMoney(totalBankMoney);
					listBox1.Items.Add("Доля игроков: " + betPerPlayer);
			    	}
			}
			
			public void DistributionPlayerCard()
			{
				Deck.InitializeDeck();
				foreach (Player player in Game.Instance.Players)
			    	{
					player.Hand.Clear();
			        	if (!player.IsSpectator)
			        	{
			            		player.Hand.Add(Deck.DealCard());
			            		player.Hand.Add(Deck.DealCard());
			        	}
			    	}
			}
			
			async public Task CheckPlayers(Label labelinfo, ListBox listBox1)
			{
				foreach (Player player in Game.Instance.Players)
			    	{
			        	if ((!player.IsSpectator) && (player.Money < Game.Instance.Bets))
			        	{
			        		player.IsSpectator = true;
			        		labelinfo.Visible = true;
						labelinfo.BackColor = Color.FromArgb(0, 0, 255);
						labelinfo.Text = "Выбывает " + player.Name;
						listBox1.Items.Add("Выбывает " + player.Name);
						await Task.Delay(2000);
						labelinfo.Visible = false;
						Game.Instance.IsSpectatorCount++;
			        	}
			    	}
			}
			
			public void AddMoneyBank(ListBox ListBox1)
			{
				ListBox1.Items.Add("------------------");
				ListBox1.Items.Add("Игроки скидываются");
				foreach (Player player in Game.Instance.Players)
			    	{
				        if (!player.IsSpectator)
				        {
				            int betAmount = Game.Instance.Bets;
				            player.Money -= betAmount;
				            Game.Instance.Bank.AddMoney(betAmount);
				            ListBox1.Items.Add(player.Name + " баланс: " + player.Money);
				        }
			    	}

				ListBox1.Items.Add("Банк: " + Convert.ToString(Game.Instance.Bank.TotalMoney));
			}

			//ход игрока
			async public Task PlayerMove(Label labelCardInfoThree, ListBox listBox1, ImageList imageList1)
			{
				globalVariable = 0;
				while (globalVariable == 0)
		        	{
			        	await Task.Delay(1000);
			        	if (((globalVariable > Math.Min(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money, 
							Game.Instance.Bank.TotalMoney)) || (globalVariable < Bets)) && (globalVariable != 0))
			        	{
			        		if (globalVariable == -1)
			        		{
			        			break;
			        		}
	     
			        		globalVariable = 0;
			        		MessageBox.Show("Ошибка ввода ставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			        	}
		        	}

				int betAmount = globalVariable;
			    	if (betAmount != -1)
			    	{
		            		Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand.Add(Deck.DealCard());
		            		labelCardInfoThree.Image = imageList1.Images[CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Suit, 
						Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Rank)];

		            		int win = CalculateWinnings(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand, betAmount);
		            		if (win > 0)
		            		{
		            			MessageBox.Show("Вы выиграли", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
		            		}
		
		            		else
		            		{
		            			MessageBox.Show("Ставка не выиграла", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Error);
		           		}
			            			
			        	Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money += win;
			        	//добавление информации в listbox
					listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Поставил: " + 
						Convert.ToString(betAmount));

				    	listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Итого: " + Convert.ToString(win));
				    	listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Баланс: " + 
						Convert.ToString(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money));

				    	listBox1.Items.Add("Итого банк: " + Convert.ToString(-win));
				    	Game.Instance.Bank.AddMoney(-win);
				    	listBox1.Items.Add("Баланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney));
			    	}

				else
                		{
					listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " отказался от ставки");
				}
			}
			//ход бота
			async public Task BotMove(Label labelCardInfoThree, ListBox listBox1, ImageList imageList1, Label labelinfo)
			{
				bool willBet = GetRandomBool(); // Случайное решение о ставке (true или false)
			    	int betAmount = 0;
			    	if (willBet)
			    	{
				        if (Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money >= Bets)
				        {
				            betAmount = GetRandomBetAmount(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money, Bets, 
								Game.Instance.Bank.TotalMoney);
				        }
			    	}

			    	await Task.Delay(2000);
			    	if (betAmount > 0)
			    	{
			        	Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand.Add(Deck.DealCard());
			        	labelCardInfoThree.Image = imageList1.Images[CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Suit, 
						Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Rank)];

			        	int win = CalculateWinnings(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand, betAmount);
			        	Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money += win;

		            		//добавление информации в listbox
				    	listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Поставил: " + 
						Convert.ToString(betAmount));

			        	listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Итого: " + Convert.ToString(win));
			        	listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Баланс: " + Convert.ToString
						(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money));

			        	listBox1.Items.Add("Итого банк: " + Convert.ToString(-win));
			        
			        	Game.Instance.Bank.AddMoney(-win);
			        	listBox1.Items.Add("\nБаланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney));

			        	if (win < 0)
			        	{
			            		labelinfo.BackColor = Color.FromArgb(255, 0, 0);
			            		labelinfo.Visible = true;
			            		labelinfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Проиграл ставку " + 
							Convert.ToString(-win);
			        	}

			        	else
			        	{
			            		labelinfo.BackColor = Color.FromArgb(0, 255, 0);
			            		labelinfo.Visible = true;
			            		labelinfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Выиграл ставку " + 
							Convert.ToString(win);
			        	}
			    	}

			    	else
			    	{
					labelinfo.BackColor = Color.FromArgb(0, 0, 255);
					labelinfo.Visible = true;
					labelinfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Не поставил ставку";
					listBox1.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " отказался от ставки");
			    	}

			    	await Task.Delay(3000);
			    	labelinfo.Visible = false;
			}
		}
		
		public MainForm()
		{
			InitializeComponent();
		}

		static int globalVariable;
		
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
			dataGridView1.Rows.Clear();
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ColumnCount = 1;
	        	dataGridView1.Columns[0].Name = "ID";
	        	dataGridView1.Rows.Add("Бот1");
	        	numericUpDown1.Value = 1;
	        	//переключение tabControl на настройки игры
			tabControl1.SelectTab(1);
			//очистка старых значений
			label.Text = "";
			listBox1.Items.Clear();
		}
		//при изменении кол-ва ботов
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			int rowCount = (int)numericUpDown1.Value; // Получаем значение из NumericUpDown
			dataGridView1.ColumnCount = 1; // Установка количества столбцов
	        	dataGridView1.Columns[0].Name = "ID"; // Имя первого столбца

			// Добавление строк
			for (int i = 0; i < rowCount; i++)
			{
			    // Создаем массив строк для текущей строки
			    string[] row = new string[] { "Бот" + Convert.ToString(i + 1)}; // ID в формате "БотX"
			    // Добавляем строку в DataGridView
			    dataGridView1.Rows.Add(row);
			}
		}

		void ButtonGameStartClick(object sender, EventArgs e)
		{
			Game.Instance.Initialize();
			string mainname = textBox1.Text;
			int balance;
			int bet;
			
			try
			{
			    balance = int.Parse(textBox2.Text);
			    bet = int.Parse(textBox3.Text);

				if((bet > balance) || (bet <= 0) || (balance <= 0) || (bet * 2 > balance))
				{
					MessageBox.Show("Ошибка ввода данных для Игроков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
                		{
					Game.Instance.AddPlayers(dataGridView1, mainname, balance);
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
		
		private static Random random = new Random();
		
		private static int CardInfo(string suit, int rank)
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
		public async Task OutputInfo(Label labelinfo, string text)
		{
			labelinfo.Visible = true;
			labelinfo.BackColor = Color.FromArgb(0, 0, 255);
			labelinfo.Text = text;
			await Task.Delay(2000);
			labelinfo.Visible = false;
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
				await Game.Instance.PoolBank(labelinfo, listBox1);
				//проверка на выбывание игрока
				await Game.Instance.CheckPlayers(labelinfo, listBox1);
				//списываем деньги в банк
				Game.Instance.AddMoneyBank(listBox1);
				bool roundis = true;
				//задаем дилеру индекс
				Game.Instance.DealerNewIndex(listBox1); // назначили дилера
				//вывод информации о раунде
				await OutputInfo(labelinfo, " Раунд " + Convert.ToString(Game.Instance.Round) + " раздает " + 
					Game.Instance.Players[Game.Instance.DealerIndex].Name);

			    	await Task.Delay(2000);
			    	labelround.Text = "Раунд " + Convert.ToString(Game.Instance.Round);
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
					label.BackColor = Color.FromArgb(255, 0, 0);
					//выбираем следующего игрока
					Game.Instance.PlayerNewIndex();

					label.Text = "Ход игрока " + Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name;
					//если очередь дошла до дилера, то он ходит и на нем раунд заканчивается
					if (Game.Instance.CurrentPlayerIndex == Game.Instance.DealerIndex)
					{
						roundis = false;
					}

					if(!Game.Instance.Players[Game.Instance.CurrentPlayerIndex].IsSpectator)
		        		{
						label5.Text = "Баланс игрока: " + Convert.ToString(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money);
		        			label5.Text += "\nБаланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney);
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
							await Game.Instance.BotMove(labelCardInfoThree, listBox1, imageList1, labelinfo);
						}

						else
						{
							//ход игрока
							//менем цвет панели
							label.BackColor = Color.FromArgb(0, 255, 0);
							//ждем пока игрок не выберет ставку
							await Game.Instance.PlayerMove(labelCardInfoThree, listBox1, imageList1);
				        	}
					}

					if (Game.Instance.Bank.TotalMoney < Game.Instance.Bets)
					{
						await OutputInfo(labelinfo, "Конец раунда, деньги в «пул»-банке закончились");
					    	break;
					}
				}

				Game.Instance.Round++;
			}

			await OutputInfo(labelinfo, "Конец игры...");
			await OutputInfo(labelinfo, flagwin);
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
