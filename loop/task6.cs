using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 123;
			Console.Write(n % 10);
			while ((n /= 10) != 0)
			Console.Write(n % 10);
		}
	}
}
