using System;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			a = int.Parse(Console.ReadLine());
			int b;
			b = int.Parse(Console.ReadLine());
			int c;
			c = int.Parse(Console.ReadLine());

			if ((a + b + c) > (a * b * c))
			{
				Console.Write((a + b + c) * 3);
			}
			else
			{
				Console.Write((a * b * c) * 3);
			}
			Console.ReadKey();
		}
	}
}
