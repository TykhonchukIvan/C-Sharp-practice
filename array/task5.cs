using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] massiv = { 1, 2, 1, 1, 4, 5, 6 };
			Console.WriteLine();
			int summa = massiv.GetLength(0);
			summa = massiv[2] + massiv[4] + massiv[6];
			Console.WriteLine("Сумма={0},", summa);
		}
	}
}
