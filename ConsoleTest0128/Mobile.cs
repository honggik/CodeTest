using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Mobile
	{
		//모바일 핸드폰의 뒤에 4자리 뺴고 전부다 *
		static void Main()
		{
			Solution2();
		}
		static void Solution()
		{
			string phone_number = "01050364531";

			string result = string.Empty;

			for (int i = 0; i < phone_number.Length; i++)
			{
				if (i < phone_number.Length - 4)
					result = result + "*";
				else
				{
					result += phone_number.Substring(i, 1);
				}
			}
			Console.WriteLine(result);
		}
		static void Solution2()
		{
			//문자열 반환은 스트링 빌더가 훨씬 빠르다 
			//유용 가변타입이라서 

			string phone_number = "01050364531";

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < phone_number.Length; i++)
			{
				if (i < phone_number.Length - 4)
					sb.Append("*");
				else
				{
					sb.Append(phone_number[i]);
				}
			}
			Console.WriteLine(sb.ToString());


		}
	}
}
