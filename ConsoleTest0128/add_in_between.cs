using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class add_in_between
	{
		static void Solution1()
		{
			int a = 5;
			int b = 4;
			int answer = 0;

			//누가 더 큰지 비교해서
			//차례대로 반복되게 구현
			int max = a > b ? a : b;
			int min = a<b? a:b; 

			//두정수의 사이값을 구하기 위해서 
			// 사이값과 같이 더하기 위해서 
			for (int i = min; i <= max; i++)
			{
				answer = answer + i;
			}
			Console.WriteLine(answer);
		}
		static void Main()
		{
			Solution1();
		}
	}
}
