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
			
		
			int[] answer = new int[2]; //answer[0],answer[1]로 해서 답구하기 위해서 
			int max = m;
			int min = n;
			int a = min;

			while (true)
			{
				a = max % min; //나머지를구하고 
				max = min;
				if (a  == 0)
				{
					break;
				}
				min = a;//나머지가 최대공약수
			}
			//최대 , 최소로 출력하기 
			answer = new int[] { min, n * m / min };
			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(answer);

		}

		static void exam()
		{
			int m = 5;
			int n = 2;
			int max = m;
			int min = n;

			int a = min;
			while (true)
			{
				a = max % min; // 나머지를 구한다.
				max = min; // max에 min을 저장 
				//a가  0이면 반복할 필요없이 나오기 
				if (a == 0)
				{
					break;
				}

				//나머즈를 min에 저장
				min = a;
			}
			//최대공약수 (나머지로 떨어져가는것,혹은 나머지인수, 최대.최소 곱해서 나머지 나누기)
			Console.WriteLine(min + ","+ n * m / min);

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
			exam();
		}
	}
}
