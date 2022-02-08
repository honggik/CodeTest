using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class orderby_desc
	{
		//문자열 내림차순 
		static string s = "Zbcdefg";
		static void Solution()
		{
			

			//char에 배열을 넣는다
			char[] temp = s.ToCharArray();
			//오름차순으로 정렬
			Array.Sort(temp);
			//내림차순으로 정렬
			Array.Reverse(temp);

			
			string answer = new string(temp);
			Console.WriteLine(answer);

		}

		static void Exam()
		{
			//람다식으로 구현 배열에 담고 orderbyDesending을 한고 배열상태로 출력 
			string answer = new String(s.ToCharArray().OrderByDescending(x => x).ToArray());
			Console.WriteLine(answer);
		}
		static void Main()
		{
			Solution();
			Exam();
		}
	}
}
