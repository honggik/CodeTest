using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Alphabets
	{
		//
		static string Solution1()
		{
			string answer = "";

			string s = Console.ReadLine();
			int n = 1;
			char[] c = s.ToCharArray();

			for (int i = 0; i < c.Length; i++)
			{
				if (c[i] == ' ') continue;

				//n만큼 문자를 밀어낸다.
				int temp = Convert.ToInt32(c[i] + n);

				if (c[i] >= 'A' && c[i] <= 'Z')
				{
					if (temp > 'Z')
					{
						temp -= 26;
					}
				}
				else
				{
					if (temp > 'z')
					{
						temp -= 26;
					}
				}
				c[i] = Convert.ToChar(temp);

			}
			answer = new string(c);

			return answer;
		}

		static void EXAM()
		{
			string s = "a B z";
			int n = 4;

			char[] c = s.ToCharArray();

			for (int i = 0; i < c.Length; i++)
			{
				if (c[i] == ' ') continue;

				//n만큼 밀어냄
				int temp = Convert.ToInt32(c[i]) + n;

				if (c[i] >= 'A' && c[i] <= 'Z')
				{
					if (temp > 'Z')
					{
						temp -= 26;
					}
				}
				else
				{
					if (temp > 'z')
					{
						temp -= 26;
					}
				}

				c[i] = Convert.ToChar(temp);


			}
			string result = new string(c);
			Console.WriteLine(result);
			

			
		}

		static void Main()
		{
			//string s = Solution1();
			//Console.WriteLine(s);

			EXAM();
		}
	}
}
