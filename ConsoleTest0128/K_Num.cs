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

		static void EXAM1()
		{
			int[] array = { 1, 5, 2, 6, 3, 7, 4 };

			int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

			int[] answer = new int[commands.GetLongLength(0)];//answer은 commands에 사이즈에 맞게


			for (int n = 0; n < answer.Length; n++)
			{
				//시작,끝점,인덱스에 값을 구함 
				int i = commands[n, 0];
				int		j = commands[n, 1];
				int k = commands[n, 2];

				//위에 두면 result가 계속 차인다.
				//그래서 새롭게 생성을 꾸준히 해줘야함 
				List<int> result = new List<int>();

				//배열을 i에서 j번째만큼의 사이즈를 구해서 넣어야함
				//예를들어섯 2.5이면 
				//배열상에서는 1에서4까지만 구하면된다.
				for (int jj = i - 1; jj < j; jj++)
				{
					//result에 원본 array[1]에서 array[4]까지 담는다. ex)
					result.Add(array[jj]);
				}
				//오름차순
				result.Sort();
				//anser[n]마다 result[k번째수를] 저장 
				//answer[0] = result의 k번째수를 저장 
				answer[n] = result[k-1];
				
			}
			foreach (int item in answer)
			{
				Console.WriteLine(item);
			}


		}
		static void Main()
		{
			//Solution1();
			//Exam();
			Console.WriteLine(" ");
			EXAM1();
		}
	}
}
