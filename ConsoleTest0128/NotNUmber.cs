using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	//없는 숫자	더하기
	class NotNUmber
	{
		static void Solution1()
		{
			//int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 0 };
			Console.Write("숫자입력: ");
			int num = Convert.ToInt32(Console.ReadLine());

			int[] numbers = new int[num];

			int answer = 45;

			foreach (int number in numbers)
			{
				answer -= number;
			}

			Console.WriteLine(answer);
		}
		static void Main()
		{
			Solution1();
		}
	}
}
