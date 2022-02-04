using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Common_divisor_Common_Mutiple
	{
		//최대 공약수 , 최소 공배수

		static void Solution(int m,int n)
		{
			
		
			int[] answer = new int[2];
			int max = m;
			int min = n;
			int a = min;

			while (true)
			{
				a = max * min;
				max = min;
				if (a  == 0)
				{
					break;
				}
				min = a;
			}
			answer = new int[] { min, n * m / min };
			Console.WriteLine(answer);

		}

	
		static int gcd(int n, int m)
		{
			if (m == 0)
			{
				return n;
			}
			else return gcd(m, n % m);
		}

		static void Main()
		{
			int m = 12;
			int n = 3;
			Solution(m,n);
		}
	}
}
