using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Matrix
	{
		//행렬의 덧셈
		static void Main()
		{
			Solution();
		}
		static void Solution()
		{
			int[,] arr1 = { { 1, 2 }, { 2, 3 } };
			int[,] arr2 = { { 3, 4 }, { 5, 6 } };
			int[,] answer = new int[arr1.Length, arr2.Length];
			//getLength에 알아오기 
			for (int i = 0; i < arr1.Length; i++)
			{
				for (int j = 0; j < arr2.Length; j++)
				{
					answer[i, j] = arr1[i, j] + arr2[i, j];
				}
			}

			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}
		}

	}
}
