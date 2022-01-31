using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Lotto
	{
		//로또
		static void Main()
		{
			int[] lottos = { 44, 1, 0, 0, 31, 25  };
			int[] win_nums = { 31, 10, 45, 1, 6, 19 };

			int[] answer = new int[] { };
			int count = 0;
			int zeroCount = 0;

			foreach (int i in lottos)
			{
				if (i == 0)
				{
					zeroCount++;
					continue;
				}

				for (int j = 0; j < win_nums.Length; j++)
				{
					if (win_nums[j] == 0) continue;
					if (win_nums[j] == i)
					{
						count++;
						win_nums[j] = 0;
						break;
					}
				}
			}

			answer = new int[] { Rank(count + zeroCount),Rank(count) };
			foreach (int i in answer)
			{
				Console.WriteLine(i);
			}

			Solution();

		}

		static int Rank(int count)
		{
			int rank = 0;

			switch (count)
			{
				case 6:
					rank = 1;
					break;
				case 5:
					rank = 2;
					break;
				case 4:
					rank = 3;
					break;
				case 3:
					rank = 4;
					break;
				case 2:
					rank = 5;
					break;
				case 1:
					rank = 6;
					break;

			}
			return rank;
		}

		static void Solution()
		{
			int[] lottos = { 44, 1, 0, 0, 31, 25 };
			int[] win_nums = { 31, 10, 45, 1, 6, 19 };

			int right = default;
			int zeroCount = default;

			int[] answer = new int[2];

			//for (int i = 0; i < lottos.Length; i++)
			//{
			//	if (lottos[i] == 0)
			//	{
			//		zeroCount++;
			//		continue;
			//	}
			//	for (int j = 0; j < win_nums.Length; j++)
			//	{
			//		if (lottos[i] == win_nums[j])
			//		{
			//			right++;
			//			break;
			//		}
			//	}
			//}

			//이거와 다른점 구하기 
			for (int i = 0; i < lottos.Length; i++)
			{
				if (lottos[i] == 0)
				{
					zeroCount++;
					continue;
				}
				if (lottos[i] == win_nums[i])
				{
					right++;
				}
			}
		    
			
			int max = 7 - (right + zeroCount);
			int min = 7 - (right);
			if (max >= 7)
			{
				max = 6;
			}
			if (min >= 7)
			{
				min = 6;
			}
			Console.WriteLine(max);
			Console.WriteLine(min);

		}
	}
}
