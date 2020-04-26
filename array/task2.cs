using System;
using System.Linq;

namespace MyArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 10, 45, -5, 12, 31, -12, 50 };
			int maxim = Max(array);
			Console.Write("Maximum: " + maxim);
			Console.ReadKey(true);
		}
		static int Max(int[] array)
		{
			int maxim = array[0];
			for (int i = 0; i < array.Count(); i++)
			{
				if (maxim < array[i])
				{
					maxim = array[i];
				}
			}
			return maxim;
		}
	}
}