using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class essence_Desc
	{
		static int n = 118372;

		static void Solution()
		{

			//정수를 내림차순으로 

			//정수를 스트링 배열로 만들고 char배열로 쓴다.
			char[] c = n.ToString().ToCharArray();
			long answer = 0;
			
			//배열을 오름차순
			Array.Sort(c);
			//리버스는 sort하고해야지 내림차순 형태로 보여줄수있다.
			Array.Reverse(c);

			//char 배열을 스트링으로 바꾸고 인트형태로 출력 
			answer = Convert.ToInt64(new string(c));

			Console.WriteLine(answer);
		}

		static void Bubble()
		{
			List<int> list = new List<int>();
			string s = n.ToString();

			//listr에 담는다.
			//쪼개서 담아가짐
			foreach (var item in s)
			{
				list.Add(int.Parse(item.ToString()));
			}

			//버블정렬
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (list[i] > list[j])
					{
						int temp = list[i];
						list[i] = list[j];
						list[j] = temp;
					}
				}
			}

			string str = string.Empty;

			foreach (var item in list)
			{
				str = string.Format("{0}{1}", str, item);
			}
			Console.WriteLine(str);
		}

		static void Exam1()
		{
			char[] c = n.ToString().ToCharArray();

			//오름차순
			Array.Sort(c);

			//소트한상태에서는 reverse는 내림차순으로 출력
			Array.Reverse(c);

			long answer = 0;

			answer = Convert.ToInt64(new string(c));
			Console.WriteLine(answer);

			
		}


		static void Main()
		{

			//Solution();
			Bubble();
			
		}
	}
}
