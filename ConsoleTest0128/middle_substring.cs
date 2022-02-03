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
		static void Main()
		{
			solution1();
		}
	}
}
