using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
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
}
