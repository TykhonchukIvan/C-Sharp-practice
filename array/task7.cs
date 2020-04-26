using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mas = new int[] { 10, 25, 34, 47, 56, 62, 77, 88, 94, 105 };
			int count = 0;

			foreach (int x in mas)
				if (x % 2 == 1)
					count++;

			Console.WriteLine("Количество нечетных элементов: " + count);
			Console.ReadKey();
		}
	}
}
