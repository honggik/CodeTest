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
			int[] d = { 1, 6, 2, 5, 4 }; //1+2+4, 1+2+5; 1+2+8; 1+4+5; 1+5 // 9가 되는경우가 없음 
			int budget = 9;
			int budgetNow = 0;
			int answer = 0;
			//작은순서대로 계산하게 만듬
			//부서 갯수가 최대로 나옴
			Array.Sort(d); // {1,2,4,5,8};
			
			for (int i = 0; i < d.Length; i++)
			{
				int smallIndext = i;

			

				
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
