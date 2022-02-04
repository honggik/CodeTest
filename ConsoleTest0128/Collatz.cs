using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Collatz
	{

		static void Solution()
		{
			int num = 623331
			int count = 0;
            int answer = 0;

            while (num >= 0)
            {
                if (num == 1)
                {
                    break;
                }
                else if (answer >= 500)
                {
                    answer = -1;
                    break;
                }
                else if (num % 2 == 0)
                {
                    num /= 2;
                    answer++;
                }
                else if (num % 2 == 1)
                {
                    num *= 3;
                    num++;
                    answer++;
                }

            }
            Console.WriteLine(answer);
        }

		static void Main()
		{
			Solution();
		}
	}
}
