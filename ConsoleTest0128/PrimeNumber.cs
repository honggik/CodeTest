using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class PrimeNumber
	{
		static void Main()
		{
			//소수 구하기 
			int tot = 2;
			Console.Write("2 ");
			for (int i = 3; i < 1000; i += 2)
			{
				bool bPrime = true;
				for (int k = 1; k <= i; k++)
				{
					if (i % k == 0 && k != 1)
					{
						bPrime = false;
						break;
					}
				}

				if (bPrime)
				{
					Console.WriteLine($"{i} ");
					tot += i;
				}
			}
			Console.WriteLine($" => {tot}");
			Console.ReadLine();
		}
	}


}
