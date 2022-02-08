using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class middle_substring
	{
		static void solution1()
		{
			string s = "qwer";
			string s2 = "qwer";

			//홀수면 한글자만
			if (s.Length % 2 == 1)
			{
				double middle = Math.Round((double)s.Length / 2);
				Console.WriteLine(s.Substring((int)middle, 1));

			}
			//짝수면 두글자
			else
			{
				double middle = Math.Round((double)s.Length / 2);
				Console.WriteLine(s.Substring((int)middle-1, 2));
			}
		

		}

		static void Exam()
		{
			string str1 = "qwer";
			string answer = "";
			if (str1.Length % 2 == 0)
			{
				int result = str1.Length / 2;
				answer = str1.Substring(result - 1, 2);
			}
			if (str1.Length % 3 == 0)
			{
				double result = Math.Round((double)str1.Length / 2);
				Console.WriteLine(str1.Substring((int)result / 1));
			}
		}
		static void Main()
		{
			solution1();
		}
	}
}
