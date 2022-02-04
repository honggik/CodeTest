using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class MinNumRemove
	{
		static void Exam()
		{
			//최소 자릿수 제거하기 
			int[] arr = new int[] { 4, 3, 2, 1 };

			List<int> b1 = arr.ToList();
			b1.Sort();

			b1.Remove(b1[0]);

			b1.Reverse();

			if (b1.Count == 0)
			{
				foreach (int item in b1)
				{
					b1.RemoveAt(item);
				}
				b1.Add(-1);
			}

			foreach (var item in b1)
			{
				Console.WriteLine(item);
			}

		}
		static void RamdaExam()
		{
			int[] arr = { 4, 3, 2, 1 };
			int[] answer = new int[] { };
			if (arr.Length <= 1)
			{
				answer = new int[] { -1 };
			}
			int temp = arr.Min();

			//배열상태
			answer = arr.Select(x => x).Where(y => y != temp).ToArray();

			foreach (int item in answer)
			{
				Console.Write(item + ",");
			}


		}

		static void Main()
		{
			Exam();
			RamdaExam();
		}
	}
}
