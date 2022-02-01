using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	//k번째 수
	class K_Num
	{
		static void Solution1()
		{
			//시작점,끝점,인덱스가 필요함
			//전체원본
			int[] array = { 1, 5, 2, 6, 3, 7, 4 };

			int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

			int[] answer = new int[commands.GetLongLength(0)];

			for (int i = 0; i < commands.GetLongLength(0); i++)
			{
				//시작위치,끝,인덱스의 배열들의 값을 다 읽기 위해서

				int start = commands[i, 0];
				int end = commands[i, 1];
				int index = commands[i, 2];

				//배열의 사이즈를 구하기 시작에서 끝점까지
				int[] temp = new int[end - start + 1];

				for (int a = 0; a < temp.Length; a++)
				{
					// temp[a]는 start에서 시작해야함
					//start부터 시작해야하지만 배열은 start -1 형식으로 가야함
					//start에서 증가를해야하는데 +a 씩 올려줘야함

					temp[a] = array[a + start - 1];
				}
				// 오름차순으로 정렬을 하며
				Array.Sort(temp);

				//index는 index수를 가지고와라
				//index = 3이면 
				//원래 배열상태에서 -1 
				// start랑 비슷함
				answer[i] = temp[index - 1];
				Console.Write(answer[i] + ",");
			}
		}
		//혼자짜보기
		//원본 배열을 입력하여 => 시작,끝,인덱스를 이용해서 그 값을 찾아내라 
		static void Exam()
		{
			int[] array = {1,4,5,6,7,8,9 };
			int[,] commands = { { 1, 4, 2 }, { 2, 5, 3 } };

			int [] answer = new int[commands.GetLongLength(0)];
			//commands에 배열을 찾아라
			for (int n = 0; n < commands.GetLongLength(0); n++)
			{
				int i = commands[n, 0];
				int j = commands[n, 1];
				int k = commands[n, 2];

				//배열의 값을 구해야함 (사이즈)
				int[] temp = new int[j-i +1];


				for (int ak = 0; ak < temp.Length; ak++)
				{
					temp[ak] = array[ak + i - 1];
				}

				Array.Sort(temp);
				answer[n] = temp[k - 1];

				Console.Write(answer[n]+ "," );
			}
		}
		static void Main()
		{
			//Solution1();
			Exam();
		}
	}
}
