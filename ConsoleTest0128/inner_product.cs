using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class inner_product
	{
		//내적
		static int Inner()
		{
			int[] a = { 1, 2, 3, 4 };
			int[] b = { -3, -1, 0, 2 };
			int result = 0;
			for (int i = 0; i < a.Length; i++)
			{
				result = result + a[i] * b[i];
			}
			return result;
		}

		//음양 더하기 

		static int absolute()
		{
			int []abs = { 4, 7, 12 };
			bool[] signs = { true, false, true };
			int result = 0;

			if (abs.Length == signs.Length)
			{
				for (int i = 0; i<abs.Length; i++)
				{
					if (signs[i] == false)
					{
						abs[i] = abs[i] - (abs[i] * 2);
					}
					result = result + abs[i];
				}
			}

			return result;
			
		}

		//내적구하기
		static void Exam1()
		{

			int[] a = { 1, 2, 3, 4 };
			int[] b = { -3, -1, 0, 2 };

			int answer = 0;
			if (a.Length == b.Length)
			{
				for (int i = 0; i < a.Length; i++)
				{
					 answer = answer + (a[i]*b[i]);
				}
			}
			Console.WriteLine(answer);
		}
		//음양구하기
		//sign이 false 이면 
		// abs수에 -값으로 나오게 하기 
		// 7-(7*2) 하면됨
		//그렇게 바꾸고 배열의 합을 구하여라 

		static void Exam2()
		{
			int[] abs = { 4, 7, 12 };
			bool[] signs = { true, false, true };
			int answer = 0;
			if (abs.Length == signs.Length)
			{
				for (int i = 0; i < abs.Length; i++)
				{
					if (signs[i] == false)
					{
						abs[i] = abs[i] - abs[i] * 2;
					}
					answer = answer + abs[i];
				}
			}
			Console.WriteLine(answer);
		}
			

			static void Main()
		{
			int result = Inner();
			Console.WriteLine(result);

			int result1 = absolute();
			Console.WriteLine(result1);
		}
	}
}
