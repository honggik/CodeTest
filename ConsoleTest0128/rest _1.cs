using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class rest__1
	{
		static void solution1()
		{
			int n = 12;
			int result = 0;
			for (int i = 1; i <= n; i++)
			{
				//나머지가 1인수를 구하고
				//그 중에서 최소수를 구해야함
				
				if (n % i == 1)
				{
					result = i;
					break;
				}
			}
			Console.WriteLine(result);
		}
		static void Exam()
		{
			//나머지가 1인 최소수를 구해라
			int n = int.Parse(Console.ReadLine());
			int answer = 0;

			for (int i = 0; i <= n; i++)
			{
				//나머지가 1일때 최소수 i를 구해라 
				// 만약에 최대수를 구할려면 반복문을 역순으로 돌리면 되지않을까?
				//근데 포문안에 if문을 넣으면 느려진다던데 어떻게 하면좋을까?
				
				if (n % i == 1)
				{
					answer = i;
					break;
				}
			}
			Console.WriteLine(answer);
		}
		static void Main()
		{
			solution1();
			Exam();

		}

	}
}
