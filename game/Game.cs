using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
	internal class Game
	{
		private static readonly Random random = new Random();

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

		public void AddPlayers(DataGridView tableBots, string mainname, int balance)
		{
			Instance.Players.Add(new Player(mainname, balance));
			foreach (DataGridViewRow row in tableBots.Rows)
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

		public void DealerNewIndex(ListBox gameInfo)
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
			gameInfo.Items.Add("Сдающий: " + Game.Instance.Players[Game.Instance.DealerIndex].Name);
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

		async public Task PoolBank(Label boardInfo, ListBox gameInfo) // метод выполянется параллельно с основной программой
		{
			int i = 0;
			if (Instance.Bank.TotalMoney >= Instance.Bets * (Instance.Players.Count) * 4)
			{
				boardInfo.Visible = true;
				boardInfo.BackColor = Color.FromArgb(0, 0, 255); // синий
				boardInfo.Text = " Раунд " + Convert.ToString(Instance.Round) + " Раздел банка ";
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
				gameInfo.Items.Add("Доля игроков: " + betPerPlayer);
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

		async public Task CheckPlayers(Label boardInfo, ListBox gameInfo)
		{
			foreach (Player player in Game.Instance.Players)
			{
				if ((!player.IsSpectator) && (player.Money < Game.Instance.Bets))
				{
					player.IsSpectator = true;
					boardInfo.Visible = true;
					boardInfo.BackColor = Color.FromArgb(0, 0, 255);
					boardInfo.Text = "Выбывает " + player.Name;
					gameInfo.Items.Add("Выбывает " + player.Name);
					await Task.Delay(2000);
					boardInfo.Visible = false;
					Game.Instance.IsSpectatorCount++;
				}
			}
		}

		public void AddMoneyBank(ListBox gameInfo)
		{
			gameInfo.Items.Add("------------------");
			gameInfo.Items.Add("Раунд " + Convert.ToString(Game.Instance.Round));
			gameInfo.Items.Add("Игроки скидываются");
			foreach (Player player in Game.Instance.Players)
			{
				if (!player.IsSpectator)
				{
					int betAmount = Game.Instance.Bets;
					player.Money -= betAmount;
					Game.Instance.Bank.AddMoney(betAmount);
					gameInfo.Items.Add(player.Name + " баланс: " + player.Money);
				}
			}

			gameInfo.Items.Add("Банк: " + Convert.ToString(Game.Instance.Bank.TotalMoney));
		}

		//ход игрока
		async public Task PlayerMove(Label labelCardInfoThree, ListBox gameInfo, ImageList imageList1)
		{
			MainForm.globalVariable = 0;
			while (MainForm.globalVariable == 0)
			{
				await Task.Delay(1000);
				if (((MainForm.globalVariable > Math.Min(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money,
					Game.Instance.Bank.TotalMoney)) || (MainForm.globalVariable < Bets)) && (MainForm.globalVariable != 0))
				{
					if (MainForm.globalVariable == -1)
					{
						break;
					}

					MainForm.globalVariable = 0;
					MessageBox.Show("Ошибка ввода ставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			int betAmount = MainForm.globalVariable;
			if (betAmount != -1)
			{
				Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand.Add(Deck.DealCard());
				labelCardInfoThree.Image = imageList1.Images[MainForm.CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Suit,
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
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Поставил: " +
					Convert.ToString(betAmount));

				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Итого: " + Convert.ToString(win));
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Баланс: " +
					Convert.ToString(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money));

				gameInfo.Items.Add("Итого банк: " + Convert.ToString(-win));
				Game.Instance.Bank.AddMoney(-win);
				gameInfo.Items.Add("Баланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney));
			}

			else
			{
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " отказался от ставки");
			}
		}
		//ход бота
		async public Task BotMove(Label labelCardInfoThree, ListBox gameInfo, ImageList imageList1, Label boardInfo)
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
				labelCardInfoThree.Image = imageList1.Images[MainForm.CardInfo(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Suit,
					Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand[2].Rank)];

				int win = CalculateWinnings(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Hand, betAmount);
				Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money += win;

				//добавление информации в listbox
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Поставил: " +
					Convert.ToString(betAmount));

				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Итого: " + Convert.ToString(win));
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Баланс: " + Convert.ToString
					(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Money));

				gameInfo.Items.Add("Итого банк: " + Convert.ToString(-win));

				Game.Instance.Bank.AddMoney(-win);
				gameInfo.Items.Add("\nБаланс банка: " + Convert.ToString(Game.Instance.Bank.TotalMoney));

				if (win < 0)
				{
					boardInfo.BackColor = Color.FromArgb(255, 0, 0);
					boardInfo.Visible = true;
					boardInfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Проиграл ставку " +
						Convert.ToString(-win);
				}

				else
				{
					boardInfo.BackColor = Color.FromArgb(0, 255, 0);
					boardInfo.Visible = true;
					boardInfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Выиграл ставку " +
						Convert.ToString(win);
				}
			}

			else
			{
				boardInfo.BackColor = Color.FromArgb(0, 0, 255);
				boardInfo.Visible = true;
				boardInfo.Text = Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " Не поставил ставку";
				gameInfo.Items.Add(Game.Instance.Players[Game.Instance.CurrentPlayerIndex].Name + " отказался от ставки");
			}

			await Task.Delay(3000);
			boardInfo.Visible = false;
		}
	}
}
