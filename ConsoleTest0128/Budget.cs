using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Budget
	{
		static void Solution()
		{
			int[] d = { 1, 3, 2, 5, 4 };
			int budget = 9;
			int budgetNow = 0;
			int answer = 0;
			//작은순서대로 계산하게 만듬
			//부서 갯수가 최대로 나옴
			Array.Sort(d); // {1,2,3,4,5};
			
			for (int i = 0; i < d.Length; i++)
			{
				int smallIndext = i;

				//선택정렬을 하여 가장작은값을 찾음

				
				//가장 작은값이 예산에 허용된다면 추가
				if (budgetNow + d[i] <= budget)
				{
					answer++;
					budgetNow += d[i];
				}
				else
				{
					break;
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
