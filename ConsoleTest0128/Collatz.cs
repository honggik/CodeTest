using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Collatz
	{
        //콜라스추측
        //짝수면 2로나누고 홀수면 3곱하고 1더하기
        //1이나올때까지 
        //횟수를 구하라 
		static void Solution()
		{
            int num = 623331;
			int count = 0;
            int answer = 0; //횟수 

            while (num >= 0)
            {
                //1이나오면 break걸어주기
                if (num == 1)
                {
                    break;
                }
                //아니면 answer 횟수 500번 까지 넘어가면 -1 반환
                else if (answer >= 500)
                {
                    answer = -1;
                    break;
                }
                //짝수면 2를 나누고
                else if (num % 2 == 0)
                {
                    num /= 2;
                    answer++;
                }
                //홀수면 3을곱하고 1더함
                else if (num % 2 == 1)
                {
                    num *= 3+1;
                   // num++;
                    answer++;
                }

            }
            Console.WriteLine(answer);
        }

        static void Exam()
        {
            int num = 623331;
            int count = 0;

            for (; ; )
            {
                if (num == 1)
                {
                    break;
                }
                else
                {
                    //짝수일때
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        count++;
                    }
                    if (num % 2 == 1)
                    {
                        num = num * 3 + 1;
                    }

                    if (count >= 500)
                    {
                        count = -1;
                        break;
                    }
                }
            }
			Console.WriteLine(count);
        }

		static void Main()
		{
			Solution();
            Exam();
		}
	}
}
