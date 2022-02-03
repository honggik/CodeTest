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
			string[] seoul = new string[] { "Lee", "Kim" };

			for (int i = 0; i < seoul.Length; i++)
			{
				if (seoul[i] == "Kim")
				{
					answer = $"김서방은{i}에 있다.";
				}
			}
			Console.WriteLine(answer);
		}

		static void Exam()
		{
			//람다식 표현 
			string[] seoul = new string[] { "Lee", "Kim" };

			int index = Array.FindIndex(seoul, x => x == "Kim");

			Console.WriteLine($"김서방은{index}에 있다.");
		}
		static void WaterMelon()
		{
			//수박수박수
			int n = 4;
			string answer = string.Empty;

			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					answer += "박";
				}
				else
				{
					answer += "수";
				}
			}
			Console.WriteLine();
			Console.Write(answer);

		}

		static void Main()
		{
			Solution();
			Exam();
			WaterMelon();
		}
	}
}
