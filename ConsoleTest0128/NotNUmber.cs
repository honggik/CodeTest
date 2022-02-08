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

		static void Exam1()
		{
			int [] numbers = { 1, 2, 3, 4, 6, 7, 8, 0 };
			int answer = 0;
			
			//9까지 돌려서 합구하기
			for (int i = 0; i <= 9; i++)
			{
				answer = answer + i;
			}
			//nuber 배열의 합을구하고 
			// answer과 num합을 뺌
			answer = answer - numbers.Sum();

			Console.WriteLine(answer);

			Console.WriteLine();
			answer = 0;

			for (int i = 0; i <= 9; i++)
			{
				answer = answer + i;
			}
			int result = 0;
			for (int i = 0;i< numbers.Length; i++)
			{
				result = result + numbers[i];
			}
			Console.WriteLine(answer - result);
		}

		static void Exam2()
		{

		}
		static void Main()
		{
			Solution1();
		}
	}
}
