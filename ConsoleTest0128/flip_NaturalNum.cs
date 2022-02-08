using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class flip_NaturalNum
	{
		//자연수를 뒤집어 배열로 출력 
		static void Solution()
		{
			int n = 12345;
			char[] s = n.ToString().ToCharArray();
			int[] answer = new int[s.Length];

			for (int i = 0; i < s.Length; i++)
			{
				answer[i] = Convert.ToInt32(s[s.Length - i - 1].ToString());
			}
			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}
		}

		static void Exam1()
		{
			int n = 12345;
			char[] c = n.ToString().ToCharArray();
			Array.Sort(c);
			Array.Reverse(c);

			List<int> answer = new List<int>();

			for (int i = 0; i < c.Length; i++)
			{
				int temp = Convert.ToInt32(c[i].ToString());
				answer.Add(temp);
			}
			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}
		}
		static void Main()
		{
				Solution();
			Exam1();
		}
	}
}
