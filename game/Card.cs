using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
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
}
