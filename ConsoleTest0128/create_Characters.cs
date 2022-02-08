using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class create_Characters
	{
		//이상한 문자 만들기

		static string s = "try hello world";
		static string Solution()
		{
			string answer = "";
			int check = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ')
				{
					//공백이면 t를넣고 
					answer += s[i];
					check = 0;
					continue;
				}
				//짝수면 대문자로 
				if (check % 2 == 0)
				{
					answer += s[i].ToString().ToUpper();
					check++;
				}
				//홀수면 소문자로 
				else
				{
					answer += s[i].ToString().ToLower();
					check++;
				}

			}
			return answer;
		}

		static void Exam()
		{
			string answer = "";
			int chk = 0;

			for (int i = 0; i < s.Length; i++)
			{
				//공백일때 answer에 넣어주고
				//chk =0으로 초기화 해준뒤 다시 반복문 형태로 가기
				if (s[i] == ' ')
				{
					answer += s[i];
					chk = 0;
					continue;
				}
				//짝수면 대문자
				if (chk % 2==0)
				{
					answer += s[i].ToString().ToUpper();
					chk++;
				}
				//홀수면 소문자로 
				else
				{
					answer += s[i].ToString().ToLower();
					chk++;

				}
			}
			Console.WriteLine(answer);
		}

		static void EXAM1()
		{
			int check = 0;
			string answer = string.Empty;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ')
				{
					answer = answer + s[i].ToString();
					check = 0;// check를 0으로 초기화 후 반복문으로 돌리기
					break;
				}
				//check가 짝수일때
				if (check % 2 == 0)
				{
					answer += s[i].ToString().ToUpper();
					check++;
				}
				//홀수일때
				else
				{
					answer += s[i].ToString().ToLower();
					check++;
				}
			}
			Console.WriteLine(answer);


		}
		static void Main()
		{
		   string s= Solution();
			Console.WriteLine(s);
			Console.WriteLine();
			Exam();
		}
	}
}
