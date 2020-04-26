using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int counter = 0;
			for (int i = 1; i < 99; i += 2)
			{
				sum += i;
				counter++;
			}
			Console.WriteLine($"Сумма чётных чисел от 1 до 99 равна: {sum}");
			Console.WriteLine($"Количество чётных чисел от 1 до 99 равно: {counter}");
			Console.ReadKey();
		}
	}
}
