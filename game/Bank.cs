using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
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
}
