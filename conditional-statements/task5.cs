using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			a = int.Parse(Console.ReadLine());

			if ((a >= 0) && (a <= 19))
			{
				Console.Write("Оценка F");
			}
			if ((a >= 20) && (a <= 39))
			{
				Console.Write("Оценка E");
			}
			if ((a >= 40) && (a <= 59))
			{
				Console.Write("Оценка D");
			}
			if ((a >= 60) && (a <= 74))
			{
				Console.Write("Оценка C");
			}
			if ((a >= 75) && (a <= 89))
			{
				Console.Write("Оценка B");
			}
			if ((a >= 90) && (a <= 100))
			{
				Console.Write("Оценка A");
			}
			Console.ReadKey();
		}
	}
}
