using System;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] cost = { 12, 15, 5, 19, 80, 20, 4, 13, 99, 120, 30, 125 };
			int max = -1;
			int index = -1;
			for (int i = 0; i < cost.Length; i++)

				if (max <= cost[i])
				{
					max = cost[i];
					index = i;
				}
			Console.WriteLine("Индекс максимального элемента:" + index);
			Console.ReadKey();
		}
	}
}
