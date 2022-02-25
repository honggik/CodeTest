using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class honeyHoues
	{
		static void Main()
		{
			//벌집 
		}
		static void Solution()
		{
			int input = int.Parse(Console.ReadLine());
			Console.WriteLine(int.MaxValue);
			if (input == 1)
			{
				Console.WriteLine(1);
				return;
			}

			int math = input * 12 - 3;
			int sqrt = Convert.ToInt32(Math.Sqrt(math));

			int n = ((3 + sqrt) / 6) + 1;
			Console.WriteLine(n);
		}
	}
}
