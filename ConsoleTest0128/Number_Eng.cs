using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace ConsoleTest0128
{
	class Number_Eng
	{
        static void Soultion1()
        {
            //문자를 영어로 
            string s = string.Empty;
            Console.Write("문자입력: ");
            s =  Console.ReadLine();
            Dictionary<string, string> numberDictionary = new Dictionary<string, string>()
            {   
            { "zero", "0" },
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

            //딕셔너리에 key와 value를저장하여 
            //key값을 value값으로 출력
            foreach (var keyValuePair in numberDictionary)
            {
                //이게 뭘까?
                s = s.Replace(keyValuePair.Key, keyValuePair.Value);
            }

			Console.WriteLine(s);
        }

        static void Solution2()
        {
            string s = Console.ReadLine();

           //바로 replace를 한다.
            s = s.Replace("zero", "0");
            s = s.Replace("one", "1");
            s = s.Replace("two", "2");
            s = s.Replace("three", "3");
            s = s.Replace("four", "4");
            s = s.Replace("five", "5");
            s = s.Replace("six", "6");
            s = s.Replace("seven", "7");
            s = s.Replace("eight", "8");
            s = s.Replace("nine", "9");

            int k;
            int answer = 0;

            //숫자가 맞는지 확인한다.
            bool bconvert = int.TryParse(s, out k);
            //맞으면 출력 
            if (bconvert)
            {
                answer = k;
            }
             Console.WriteLine(answer);


        }

        static void Main()
        {
            // Soultion1();
            Solution2();
        }



}
}
