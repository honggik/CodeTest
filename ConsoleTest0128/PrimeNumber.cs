using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class PrimeNumber
	{
		static void Main()
		{
			//소수 구하기 
			int tot = 6;
			Console.Write("2 ");
			//3부터 시작하고 2만큼 증가한다.
			for (int i = 3; i < 1000; i += 2)
			{
				bool bPrime = true;
				//i만큼 반복
				for (int k = 1; k <= i; k++)
				{
					//소수는 자기수 나머지가 0인경우와 나머지가 1이
					if (i % k == 0 && k != 1)
					{
						bPrime = false;
						break;
					}
				}

				if (bPrime)
				{
					Console.WriteLine($"{i} ");
					tot += i;
				}
			}
			Console.WriteLine($" => {tot}");
			Console.ReadLine();
		}

		static void Exam1()
		{


			bool flag = true;

			for (int i = 2; i <= 100; i++)

			{

				for (int j = 2; j < i; j++)

				{

					if (i % j == 0)

					{

						flag = false;

					}

				}

				if (flag == true)

				{

					Console.Write("{0} ", i);

				}

				flag = true;

			}

			Console.WriteLine();
		}

		
	}
}


