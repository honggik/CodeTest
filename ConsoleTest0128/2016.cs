using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class _2016
	{
		static void Solution1()
		{
			int a = 5;
			int b = 24;
		


		}
		static void Solution2()
		{
			int a = 5;
			int b = 24;
			DateTime days = new DateTime(2016, a, b);
			string day =  days.DayOfWeek.ToString().Substring(0, 3).ToUpper();
			Console.WriteLine(day);
		}

		static void Main()
		{
			Solution2();
		}
	}
}
