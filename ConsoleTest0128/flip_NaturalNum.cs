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
			char[] s = n.ToString().ToCharArray();//char배열로 바꾼다.
			int[] answer = new int[s.Length];//char배열만큼 사이즈를 정해준다.

			for (int i = 0; i < s.Length; i++)
			{
				// 자연수를 뒤집어서 4에서 0까지의 역순으로 출력 
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
			//애초에 sort를 한뒤
			Array.Sort(c);
			//reveser로 하면 내림차순이 됨 
			Array.Reverse(c);

			List<int> answer = new List<int>();//리스트에 담기위해서 

			for (int i = 0; i < c.Length; i++)
			{
				//1,2,3,4,5를 리스트에 담고 
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
