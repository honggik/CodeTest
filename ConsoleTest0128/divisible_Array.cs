using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class divisible_Array
	{
		//나누어 떨어지는 배열 구하기 
		static void Solution1()
		{
			int[] arr = { 5, 9, 7, 10 };
			int divisor = 5;
			List<int> answer = new List<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				//나누어 떨어지는 수만 temp에 담기
				if (arr[i] % divisor == 0)
				{
					int temp = arr[i];
					answer.Add(temp);
				}
				
			}
			//만약에 answer에 담은게 없다 하면 
			// -1만 담기 
			//그러면 값은 -1하나만 나옴
			if (answer.Count == 0)
			{
				answer.Add(-1);
			}
			answer.Sort();
			foreach (int item in answer)
			{
				Console.WriteLine(item);

			}


		}
		static void Exam1()
		{
			//
			int[] n = { 5, 9, 8, 10 };
			int d = 5;
			List<int> answer = new List<int>();
			for (int i = 0; i < n.Length; i++)
			{
				if (n[i] % d == 0)
				{
					//temp는 나누어 떨어지는 n[i]를 담음
					int temp = n[i];

					//temp를 리스트에 담기
					answer.Add(temp);
				}
				//count 0이면 -1을 넣어주기 
				if (answer.Count == 0)
				{
					answer.Add(-1);
				}
			}
			answer.Sort();
			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}
		}

		
		static void Main()
		{
			Solution1();
		}
	}
}
