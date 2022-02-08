using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class x
	{
		static void Main()
		{
			Solution();
		}
		static void Solution()
		{
			int x = 2;
			int n = 5;
			List<int> answer = new List<int>();

			for (int i = 1; i <= n; i++)
			{
				answer.Add(x);
				x += 2;
			}

			foreach (int item in answer)
			{
				Console.Write(item+ " ");
			}
		}

	}
}
