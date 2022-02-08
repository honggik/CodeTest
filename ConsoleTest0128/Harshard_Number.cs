using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	public class Harshard_Number
	{
		//하샤드 수구하기
		//x = 18이면 자리숫 덧셈 1+8 = 9 => 18%9 == 0 이면 true
		static void Main()
		{
			Solution();
		}
		static void Solution()
		{
			int x = 18;
			int result = 0;
			bool bCheck = true;
			string s = x.ToString();
			for (int i = 0; i < s.Length; i++)
			{
				result += Convert.ToInt32(s.Substring(i, 1));
			
			}
			if (x % result == 0)
			{
				bCheck = true;
				Console.WriteLine(bCheck);
			}
			else
			{
				bCheck = false;
				Console.WriteLine(bCheck);
			}

		}
	}
}
