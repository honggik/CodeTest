using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class digit
	{
		static void Solution()
		{
			//자릿수 더하기 
			//char 배열로 받아
			// cahr을 string형태로 바꿔 더해줌 
			// char 형태로 인트변환 해서 더하면 특유의 아스키코드(?) 때문에 더하질못하!
			int n = 987;
			string s = n.ToString();
			char[] c = s.ToCharArray();
			int temp = 0;
			for (int i = 0; i < s.Length; i++)
			{
				temp = temp + Convert.ToInt32(c[i].ToString());
			}
			Console.WriteLine(temp);
		}
		static void SubstringExam()
		{
			int n = 987;
			string s = n.ToString();
			int answer  = 0;
			for (int i = 0; i < s.Length; i++)
			{
				answer += Convert.ToInt32(s.Substring(i, 1));
			}
			Console.WriteLine(answer);
		}
		//수학적으로
		static void Math()
		{
			int n = 987;
			int answer = 0;

			while (n != 0)
			{
				answer += (n % 10);
				n = n / 10;
				break; 
			}
			Console.WriteLine(answer);

		}
		static void Main()
		{
			Solution();
			SubstringExam();
			Main();
		}
	}
}
