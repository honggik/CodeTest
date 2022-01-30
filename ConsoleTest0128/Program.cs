using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest0128
{
	class Program
	{
		static void Main(string[] args)
		{
			Test1();
			Console.ReadLine();
		}
		static void Test1()
		{
			try
			{
				int k = ThrowProcess();
				Console.WriteLine("return");
			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
		}

		static void OKprocess()
		{
			try
			{
				Console.WriteLine("try");
				int[] arr = new int[3] { 1, 2, 3 };
				arr[0] = arr[1] + arr[2];
			}

			catch
			{
				Console.WriteLine("catch");
			}
			finally
			{
				Console.WriteLine("finally");
			}
		}

		static int ThrowProcess()
		{
			try
			{
				Console.WriteLine("try");
				int[] arr = new int[3] { 1, 2, 3, };
				return arr[3];
			}

			catch
			{
				Console.WriteLine("catch");
				throw new Exception("catch throw");
			}
			finally
			{
				Console.WriteLine("finally");
			}
		}
	}
}
