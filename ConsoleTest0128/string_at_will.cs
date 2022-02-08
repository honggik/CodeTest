using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	//문자열 마음대로 
	//사전순으로 

	class string_at_will
	{
		static void Solution1()
		{
			string[] str = { "abce", "abcd", "cdx" };
			int n = 2;

			string[] answer = new string[] { };
			Dictionary<string, string> dic = new Dictionary<string, string>();

			for (int i = 0; i < str.Length; i++)
			{
				//ex) abce,c 이런 값으로 나옴
				dic.Add(str[i], str[i][n].ToString());
			}
			//사전순으로 정렬 
			answer = dic.OrderBy(x => x.Value).ThenBy(y => y.Key).Select(x => x.Key).ToArray();
			foreach (var item in answer)
			{
				Console.WriteLine(item);
			}
		}

		static void Solution2()
		{
			string[] str = { "sun", "bed", "car" };
			int n = 1;

			//orderby(x=>x) => 전체 사전순으로 간다 즉 bed car sun
			//order by(X=>x)에서 order (x=>x[n])을넣어주면 그 인덱스를 이용하여 order by가 된다.
			string[] answer = str.ToList().OrderBy(x => x).OrderBy(x => x[n]).ToArray();

			foreach (string item in answer)
			{
				Console.WriteLine(item);
			}

		}

		static void Exam()
		{
			string[] str = { "sun", "bed", "car" };
			int n = 1;

			string[] answer = new string[] { };

			Dictionary<string, string> dic = new Dictionary<string, string>();

			for (int i = 0; i < str.Length; i++)
			{
				dic.Add(str[i], str[i][n].ToString());
			}
			//dic.OrderBy(x => x.Value).ThenBy(y => y.Key).Select(x => x.Key).ToArray();
			//answer = dic.OrderBy(x => x.Value).ThenBy(y => y.Key).Select(x => x.Key).ToArray();
			answer = dic.OrderBy(x => x.Value).Select(x => x.Key).ToArray();
			foreach (string itme in answer)
			{
				Console.WriteLine(itme);
			}

		}

		static void Main()
		{
			//Solution2();
			Solution1();
			Console.WriteLine("exam");
			Exam();

		}
	}
}
