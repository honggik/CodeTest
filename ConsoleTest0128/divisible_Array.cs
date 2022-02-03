using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class divisible_Array
	{
		static void Solution1()
		{
			int[] arr = { 5, 9, 7, 10 };
			int divisor = 5;
			List<int> answer = new List<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % divisor == 0)
				{
					int temp = arr[i];
					answer.Add(temp);
				}
				
			}
			if (answer.Count == 0)
			{
				answer.Add(-1);
			}
			answer.Sort();
			foreach (int item in answer)
			{
				Console.WriteLine(item);

			}


		}
		static void Main()
		{
			Solution1();
		}
	}
}
