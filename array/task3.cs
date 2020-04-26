using System;
using System.Linq;

static class ArrayMinMaxSearch
{

	public static void Main()
	{
		int[] numbers = { 10, 13, 50, 77, 80, 95, 62, 1, 900, 78 };
		int minVal = numbers.Min();
		int indexMin = Array.IndexOf(numbers, minVal);
		Console.WriteLine(indexMin);
	}
}
