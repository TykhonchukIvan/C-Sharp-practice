using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = -5;
			int y = 10;
			if ((x > 0) && (y > 0))
			{
				Console.Write("Точка в первой координатной четверти");
			}
			if ((x < 0) && (y > 0))
			{
				Console.Write("Точка в второй координатной четверти");
			}
			if ((x < 0) && (y < 0))
			{
				Console.Write("Точка в третьей координатной четверти");
			}
			if ((x > 0) && (y < 0))
			{
				Console.Write("Точка в четвертой координатной четверти");
			}
			Console.ReadKey();
		}
	}
}
