using System;

namespace ConsoleApp16
{
    class Program
    {
		static void Main(string[] args)
		{
			Test();
			Console.WriteLine("Hello");
		}
		static void Test()
		{
			try
			{
				Exception();
			}
			catch (Exception ex)
			{

				throw new NullReferenceException("This is an unhandled exception", ex);
			}
		}

		static void Exception()
		{
			int a = 0;
			int b = 1 / a;
		}
	}
}
