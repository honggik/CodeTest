using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Sqrt
	{
		static long Solution()
		{
			long answer = 0;

			int n = 121;

			for (int i = 0; i <= n; i++)
			{
				if (i * i == n)
				{
					answer = (i + 1) * (i + 1);
					break;
				}
				else if (i*i >= n)
				{
					answer = -1;
					break;
				}
			}
			return answer;
		}
		static void Main()
		{
			long answer = Solution();
			Console.WriteLine(answer);
		}
	}
}
