using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Pirce
	{
		static void Solution1()
		{
			int price = 3;
			int money = 20;
			int count = 4;

			int total = 0;
			for (int i = 1; i <= count; i++)
			{
				total = total + price * i;
			}
			if (money < total)
			{
				Console.WriteLine(total - money);
			}

		}
		static void Main()
		{
			Solution1();
		}
	}
}
