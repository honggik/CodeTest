using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class string_false_true
	{
		static void Solution()
		{
			bool bconvert = false;

			int k;
			for (; ; )
			{
				Console.Write("입력: ");
				string s = Console.ReadLine();
				if (s.Length == 4 || s.Length == 6)
				{
					bconvert = int.TryParse(s, out k);
					if (bconvert)
					{
						Console.WriteLine(bconvert);
						//break;
					}
					else
					{
						Console.WriteLine(bconvert.ToString());
					}
				}
				else
				{
					Console.Write("message");
				}
			}
		}

		static void Main()
		{
			Solution();
		}

		
	}
}
