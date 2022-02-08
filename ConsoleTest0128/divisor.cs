using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class divisor
	{
		public static void Solution1()
		{
			//약수 덧셈 
			//13에서 17까지의 약수갯수들 더하기 

			int left = 13;
			int right = 17;
				int count = 0;
				int result = 0;
				for (int i = left; i <= right; i++)
				{
					//i까지의 약수를 구하고 
					
					for (int n = 1; n <= i; n++)
					{
						if (i % n == 0)
						{
						//약수의 갯수를 구함 
							count++;
						}
					}
					//약수갯수가 짝수면 
					if (count % 2 == 0)
					{
						//더해주고 마지막에 횟수를 초기화한다
						// 초기화해야지 다음 갯수도 정확해진ㄷ.
						result = result + i;
						count = 0;
					}
					else
					{
						result = result - i;
						count = 0;
					}
				
				}
			Console.WriteLine(result);

		}

		static void exam()
		{
			int left = 13;
			int right = 17;
			int count = 0;
			int answer = 0;
			//13에서 17까지 반복
			for (int i = left; i <= right; i++)
			{
				//i마다 약수의갯수를 구하기 위해서 반복
				// 1에서 i까지 
				for (int n = 1; n <= i; n++)
				{
					if (i % n == 0)
					{
						count++;
					}
				}
				//총횟수를 구하고 난뒤

				//횟수가 짝수이면 
				if (count % 2 == 0)
				{
					answer += i;
					count = 0; // 카운트를 초기화 시켜줘야지 각 약수의 갯수의 총 횟수가 정확해진다.
				}
				//횟수가 홀수이면
				else
				{
					answer -= i;
					count = 0;
				}
			}
			Console.WriteLine(answer);
			
		}

		public static void Main()
		{
			Solution1();
		}
	}
}
