using System;
using System.Linq;

namespace MyArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 10, 45, -5, 12, 31, -12 };
			int maximum = Max(array);
			Console.Write("Minimum: " + maximum);
			Console.ReadKey(true);
		}
		static int Max(int[] array)
		{
			int min = array[0];
			for (int i = 0; i < array.Count(); i++)
			{
				if (min > array[i])
				{
					min = array[i];
				}
			}
			return min;
		}
	}
}
















