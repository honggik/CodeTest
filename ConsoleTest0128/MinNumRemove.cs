using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class MinNumRemove
	{
		static void Exam()
		{
			//최소 자릿수 제거하기 
			int[] arr = new int[] { 4, 3, 2, 1 };

			//리스트에 arr을 복사 
			List<int> b1 = arr.ToList();
			//오름차순
			b1.Sort();
			//제일 첫번째의 값을 제거 
			b1.Remove(b1[0]);

			//reverse: 내림차순으로 출력됨 
			b1.Reverse();

			//하지만 count가 없다 하면 
			if (b1.Count == 0)
			{

				foreach (int item in b1)
				{
					b1.RemoveAt(item);
				}
				//-1을 제거 
				b1.Add(-1);
			}

			foreach (var item in b1)
			{
				Console.WriteLine(item);
			}

		}
		static void RamdaExam()
		{
			int[] arr = { 4, 3, 2, 1 };
			int[] answer = new int[] { };
			if (arr.Length <= 1)
			{
				answer = new int[] { -1 };
			}
			int temp = arr.Min();

			//배열상태 람다식으로 표현 
			answer = arr.Select(x => x).Where(y => y != temp).ToArray();

			foreach (int item in answer)
			{
				Console.Write(item + ",");
			}


		}

		//람다식 풀이
		static void exam1()
		{
			int[] arr = { 4, 3, 2, 1 };
			int[] answer = new int[] { };

			//arr이 사이즈가 1이면 
			if (arr.Length <= 1)
			{
				answer = new int[] { -1 };
			}
			// arr 수 중에 가장작은수를 temp에 넣어라 
			int temp = arr.Min();

			//람다식 조회 => 배열타입으로 바꿔준다.
			answer = arr.Select(x => x).Where(y => y != temp).ToArray();
			foreach (int item in arr)
			{
				Console.Write(item + ",");
			}
		}

		static void Exam2()
		{
			int[] arr = { 4, 3, 2, 1 };
			List<int> answer = new List<int>(arr.ToList());// 배열 자체를 리스트에 복사

			//list타입으로 받으면 list.sort 
			// 배열타입이면 array.sotr(배열);
			answer.Sort();

			//list에 먼저 담자
			//answer[0]을 제거하고 출력
			answer.Remove(answer[0]);


			answer.Reverse();

			if (answer.Count <=1)
			{
				answer.Add(-1);
			}

			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}


			
		}

		static void Main()
		{
			//Exam();
			//RamdaExam();
			Exam2();
		}
	}
}
