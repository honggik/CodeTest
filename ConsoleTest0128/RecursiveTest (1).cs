using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
    class RecursiveTest
    {
        static void Main()
        {
            int inputNum;
            bool bConvert = false;

            do
            {
                Console.Write("숫자 입력:");
                bConvert = int.TryParse(Console.ReadLine(), out inputNum);
            } while (!bConvert);

            if (inputNum % 2 == 0) inputNum -= 1;

            Recursive(inputNum);
        }

        static List<int> list = new List<int>();

        static void Recursive(int num)
        {
            if (num > 0)
            {
                //재귀함수로 num을 계속적으로 넣어줌 

                list.Add(num);
                Recursive(num - 2);
            }
            //0보다 작으면 계산 
            else
            {
                int tot = 1;
				// list.ForEach((p) => Console.Write((p == 1) ? $"{p}" : $"{p}*", tot *= p));

                //배열을 foreach문으로 돌려서 
				foreach (int temp in list)
				{
                    //tot랑 리스트배열이랑 곱함 
					tot *= temp;
                    //출력을할때는 temp*순서로 나와야하고 
                    //1이 됐을때는 temp만 나오게하여 
                    // ex)7*5*3*1 = tot형식으로 출력 
					Console.Write((temp == 1) ? $"{temp}" : $"{temp}*");
				}

				Console.WriteLine($" = {tot}");
            }
        }
    }   
}
