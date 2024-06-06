using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
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
}
