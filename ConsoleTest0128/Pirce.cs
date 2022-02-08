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
			//count는 4다
			//4번 돌아야함
			//돌때마다 i만큼 증가후 더하기 

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
