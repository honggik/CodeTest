using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class rest__1
	{
		static void solution1()
		{
			int n = 12;
			int result = 0;
			for (int i = 1; i <= n; i++)
			{
				//나머지가 1인수를 구하고
				//그 중에서 최소수를 구해야함
				
				if (n % i == 1)
				{
					result = i;
					break;
				}
			}
			Console.WriteLine(result);
		}
		static void Main()
		{
			solution1();

		}

	}
}
