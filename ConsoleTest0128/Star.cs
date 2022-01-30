using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Star
	{
		static void Main()
		{
			//Side();
			//star1();
			//star2();
			//star4();
			//star5();
			//star6();
			star7();

			Console.ReadLine();
		}

		//뒤집기
		static void Side()
		{
			int n = 12345;
			Console.WriteLine(n);

			while (n != 0)
			{
				Console.Write(n % 10);
				n = n / 10;
			}
		}

		static void star1()
		{
			//직각삼각형
			int k;
			bool bconvert = false;
			for (; ; )
			{
				Console.WriteLine("숫자 입력: ");
				bconvert = int.TryParse(Console.ReadLine(), out k);
				if (bconvert = true)
					break;
			}

			//for (int i = 0; i <=k; i++)
			//{
			//	for (int j = 0; j < i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//for (int i = 0; i <= k; i++)
			//{
			//	for (int j = 0; j <= k; j++)
			//	{
			//		//i수만큼 돌리게 하는법 없을까?
			//		]
			//			Console.Write("*");
			//			//break;
			//		}\
			//	}
			//	Console.WriteLine();
			//}
		}

		// 역순삼각형
		static void star2()
		{
			int k;
			bool bconvert = false;
			for (; ; )
			{
				Console.WriteLine("숫자 입력: ");
				bconvert = int.TryParse(Console.ReadLine(), out k);
				if (bconvert)
					break;
			}

			for (int i = 0; i < k; i++)
			{
				for (int j = 0; j <=k; j++)
				{
					if (j<k-i)
					{
						Console.Write(" ");
					}
					else
					{
						Console.Write("*");
					}
				}
				Console.WriteLine();

			}

		}

		

		//마름모
		static void start3()
		{
			//다차원 배열?
			int num;
			bool bconvert = false;
			for (; ; )
			{
				Console.WriteLine("숫자 입력: ");
				bconvert = int.TryParse(Console.ReadLine(), out num);
				if (bconvert)
					break;
			}
			int startidx = (num / 2) + 1;
			int end = startidx;
			

		}

		//역삼각형
		static void star4()
		{
			for (int i = 5; i >= 1; i--)
			{
				for (int j = i; j >= 1; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		static void star5()
		{
			for (int a = 1; a <= 5; a++)
			{
				for (int b = 1; b <= 5 - a; b++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= a; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		static void star6()
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= i - 1; j++)
				{
					Console.Write(" ");
				}
				for (int k = 0; k < 5 - i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

		}
		static void star7()
		{
			for (int i = 1; i <= 6; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if (i <= 3)
					{
						Console.Write("*");
					}
					else
						break;
				}

				for (int k =1; k < 6 - i; k++)
				{
					Console.Write("*");
				}
				if (i <= 3)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
	class Side
	{
		static void Main()
		{
			// ConsoleTest0128.Side
			
		}
	}
		 
}
