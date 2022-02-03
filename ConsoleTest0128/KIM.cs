using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class KIM
	{
		//서울에서 김서방 찾기
		static void Solution()
		{
			string answer = "";
			string [] seoul = new string []{ "Lee","Kim" };
				
			for (int i = 0; i < seoul.Length; i++)
			{
				if (seoul[i] == "Kim")
				{
					answer = $"김서방은{i}에 있다.";
				}
			}
			Console.WriteLine(answer);
		}

		static void Main()
		{
			Solution();
		}
	}
}
