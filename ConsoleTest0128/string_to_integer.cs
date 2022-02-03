using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class string_to_integer
	{
		//문자열을 정수로 
		static void Solution1()
		{

			bool b = false;

			int inputNum;

			for (; ; )
			{
				Console.Write("입력");
				string s = Console.ReadLine();

				b = int.TryParse(s, out inputNum);
				if (b)
				{
					Console.WriteLine(inputNum);
				}
				else
				{
					Console.WriteLine(s);
				}
			}
		}
		static void Main()
		{
			Solution1();
		}
	}
}
