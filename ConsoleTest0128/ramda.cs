using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleTest0128
{
	class ramda
	{
		static void Main()
		{
			//그냥 스레드 
			Thread t1 = new Thread(ThreadStat);
			t1.Start();

			//익명메서드
			Thread t2 = new Thread(delegate ()
			{
				Console.WriteLine("신규 스레드 시작2");
			});
			t2.Start();

			//람다식: 익명메서드와 델리게이트를 간략하게 표현이 가능하고 linq식에서도 간략하게 사용한다. 
			Thread t3 = new Thread(() => Console.WriteLine("신규스레드 시작3"));
			t3.Start();

			Console.WriteLine();

			//재귀함수
			int inputNum=default;
			bool b = false;
			while(!b)
			{
				b = int.TryParse(Console.ReadLine(), out inputNum);
				if (b)
					break;
			}
			//for (; ; )
			//{
			//	Console.Write("숫자입력: ");
			//	b = int.TryParse(Console.ReadLine(), out inputNum);
			//	if (b)
			//		break;
			//}

			//do
			//{
			//	Console.Write("숫자 입력:");
			//	b = int.TryParse(Console.ReadLine(), out inputNum);
			//} while (!b);

			if (inputNum % 2 == 0) inputNum -= 1;

			RecursiveTest1(inputNum);
		}

		private static void RecursiveTest1(int num)
		{
			 List<int> numlist = new List<int>();
			if (num > 0)
			{
				numlist.Add(num);
				RecursiveTest1(num - 2);
			}
			else
			{
				int tot = 1;
				foreach (int temp in numlist)
				{
					tot *= temp;
					//int tempNum = temp == 1 ? Console.Write($"{temp}") : Console.Write($"{temp}*");
					if (temp == 1)
					{
						Console.Write($"{temp}");
					}
					else
					{
						Console.Write($"{temp}*");
					}
					Console.WriteLine($"{tot}");

				}
			}
		}

		private static void ThreadStat()
		{
			Console.WriteLine("신규 스레드 시작");
		}
	}
}
