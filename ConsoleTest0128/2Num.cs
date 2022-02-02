using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class _2Num
	{
		static void Solution()
		{
			int[] number = { 2, 1, 3, 4, 1 };
			int[] numbers = { 2, 1, 3, 4, 1 };

			//두개의 수를 뽑아 더하기
			// 중복수 없애기
			// 오름차순 정렬
			List<int> answer = new List<int>();
			for (int i = 0; i < number.Length-1; i++)
			{
				for (int j= i + 1; j < number.Length; j++)
				{
					int temp = number[i] + number[j];
					if (answer.Contains(temp) == false)
					{
						answer.Add(temp);
					}
				}
			}
			answer.Sort();
			Console.WriteLine(answer.ToArray());

			List<int> answer1 = new List<int>();

			// 이중 for문을 돌린다. 첫번째는 numbers.Length-1까지다.
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				// 두번째 for문은 i+1 번 부터 시작한다.
				for (int j = i + 1; j < numbers.Length; j++)
				{
					// i번째와 j번째를 더해서 temp에 담는다.
					int temp = numbers[i] + numbers[j];
					// 리스트에 temp와 동일한 값이 있는지 검사
					answer1.Add(temp);
				}
			}
			answer1.Sort();
			int[] list = answer1.Distinct().ToArray();
			foreach (int item in list)
			{
				Console.Write(item +" ," );
			}
			
		}

		static void Exam()
		{
			int[] num = { 2, 3, 3, 5, 6, 4, 5, 7 };

			List<int> answerList = new List<int>();

			for (int i = 0; i < num.Length; i++)
			{
				for (int j = i + 1; j < num.Length; j++)
				{
					int temp = num[i] + num[j];
					if (answerList.Contains(temp) == false)
					{
						answerList.Add(temp);
					}
					
				}
			}
			answerList.Sort();
			foreach(int item in answerList)
			{
				Console.Write(item + ",");
			}
		}

		static void Main()
		{
			//Solution();
			Exam();
		}
	}
}
