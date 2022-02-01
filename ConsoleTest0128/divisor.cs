using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class divisor
	{
		public static void Solution1()
		{
			int left = 13;
			int right = 17;
				int count = 0;
				int result = 0;
				for (int i = left; i <= right; i++)
				{
					for (int n = 1; n <= i; n++)
					{
						if (i % n == 0)
						{
							count++;
						}
					}
					if (count % 2 == 0)
					{
						result = result + i;
						count = 0;
					}
					else
					{
						result = result - i;
						count = 0;
					}
				
				}
			Console.WriteLine(result);

		}

		public static void Main()
		{
			Solution1();
		}
	}
}
