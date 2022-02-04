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
			char[] c = n.ToString().ToCharArray();
			long answer = 0;

			Array.Sort(c);
			Array.Reverse(c);

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

		static void Main()
		{

			//Solution();
			Bubble();
			
		}
	}
}
