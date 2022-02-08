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
			//2016년
			int a = 5;
			int b = 24;

		}
		static void Solution2()
		{
			int a = 5;
			int b = 24;
			DateTime days = new DateTime(2016, a, b);
			string day = days.DayOfWeek.ToString().Substring(0, 3).ToUpper();
			Console.WriteLine(day);
		}

		static void exam()
		{
			//년 월 일 => 오버로드임 년월일 시간 도 할수있음
			DateTime date = new DateTime(2016, 5, 24);
			//the만 나오게 하기위해서 요일구하기
			string day = date.DayOfWeek.ToString().Substring(0, 3).ToString();

		}

		static void Main()
		{
			Solution2();
		}
	}
}
