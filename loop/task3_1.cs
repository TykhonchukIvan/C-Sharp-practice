using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int result;
			int x = 9;
			if (x == 0 || x == 1)
			{
				Console.WriteLine(x);
			}
			if (x == 2)
			{
				Console.WriteLine(x);
			}
			for (int i = 1; x > i; i++)
			{
				result = i * i;
				if (result > x)
				{
					i--;
					Console.WriteLine(i);
					break;

				}
				else if (result == x)
				{
					Console.WriteLine(i);
					break;
				}
			}
		}
	}
}
