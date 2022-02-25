using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class BREAK_EVEN_POINT
	{
		//손익분기점 (백준)
		static void Main()
		{
			Exam1();
		}
		static void Exam1()
		{
			int A = 210000000; //1000만원
			int B = 9;
			int C = 10;
			int count = 1;

			if (B >= C)
			{
				count = -1;
			}
			while (true)
			{
				if ((A + (B * count)) < C * count)
				{
					break;
				}
			
				count++;
			}
			Console.WriteLine(count);
		}
	}
}
