using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	//3진법
	class ternary_scale
	{
		//3진법을 통해서 => 10진수로 
		static void Solution1()
		{
			int n = 45;

			int answer = 0;
			int cnt = 0;

			string str = string.Empty;

			while (true)
			{
				double temp = Math.Pow(3, cnt);
				if (temp > n)
				{
					cnt--;
					break;
				}
				cnt++;
			}

			for (int i = cnt; i >= 0; i--)
			{
				int pow = (int)Math.Pow(3, i);
				for (int j = 2; j >= 0; j--)
				{
					if (n >= pow * j)
					{
						str += j;
						n -= pow * j;
						break;
					}

					if (j == 0)
					{
						str += "0";
					}
				}
			}
		}

		static void Exam(int number, int N)
		{
			StringBuilder sb = new StringBuilder();
			int current = number;
			int answer = 0;

			// 진법 변환할 숫자가 0보다 큰 경우 지속 진행
			while (current > 0)
			{
				// 만약 N으로 나누었는데 10보다 작다면 해당 숫자를 바로 append
				if (current % N < 10)
				{
					sb.Append(current % N);

					// 만약 N이 10보다 큰 경우, N으로 나누었는데 10 이상이면 A, B등으로 표현하므로 기존 숫자는 10진법이므로 10만큼 빼고 'A'를 더한다. 
					// 왜냐면 1~9까지는 숫자로 표기하지만, 10 부터는 'A', 'B' 순서로 나타내기 때문이다.
					// 나머지가 10이라면 'A' + 10이 아니라 'A'로 나타내야 하기 때문
				}
				else
				{
					sb.Append((char)(current % N - 10 + 'A'));
				}
				current /= N;
			}
			Console.WriteLine("숫자 : " + number + "를 " + N + "진법으로 변환한 수 : " + sb.ToString());

			var idx = sb.Length;
			var sum = 0;
			for (var i = 0; i < sb.Length; i++)
			{
				var pow = (int)Math.Pow(3, --idx);
				answer += int.Parse(sb[i].ToString()) * pow;
			}
			Console.Write(answer);

		}

		static void Exam2()
		{
			int n = 45;
			int answer = 0;
			string str = "";

			while (true)
			{
				var a = n / 3; //15
				var b = n % 3;// 0

				n = a; //15 
				str += b.ToString(); //0

				if (n < 3) //15 
				{
					str += a.ToString(); 
					break;
				}
			}

			var idx = str.Length;//1
			var sum = 0;
			for (var i = 0; i < str.Length; i++)
			{
				var pow = (int)Math.Pow(3, --idx); // 
				answer += int.Parse(str[i].ToString()) * pow;
			}
			Console.Write(answer);
		}
		static void Main()
		{
			Exam(45,3);
			Exam2();
		}
	}
}
