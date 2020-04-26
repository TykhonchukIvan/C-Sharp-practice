using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			int b = -5;
			int c = 6;
			if((a > 0) && (b > 0) && (c > 0))
			{
				Console.Write(a + b + c);
			}
			if ((a > 0) && (b > 0) && (c < 0))
			{
				Console.Write(a + b);
			}
			if ((a > 0) && (b < 0) && (c > 0))
			{
				Console.Write(a + c);
			}
			if ((a < 0) && (b < 0) && (c > 0))
			{
				Console.Write(b + c);
			}
		}
	}
}
