using System;

namespace Console1
{
	class Program
	{
		static void PrintArr(int[] a, string title = "")
		{
			if (title != "")
				Console.WriteLine(title);
			for (int i = 0; i < a.Length; Console.Write("{0} ", a[i++])) ;
			Console.WriteLine();
		}
		static void SwapHalf(int[] a)
		{
			int step, lim = a.Length >> 1;
			step = (a.Length & 1) == 0 ? lim : lim + 1;
			for (int i = 0, tmp; i < lim; i++)
			{
				tmp = a[i];
				a[i] = a[i + step];
				a[i + step] = tmp;
			}
		}
		static void Main()
		{
			int i = 5;
			int[] arr = new int[i];
			Random rnd = new Random();
			for (i = 0; i < arr.Length; arr[i++] = rnd.Next(arr.Length + 1)) ;
			PrintArr(arr, "Исходный:");
			SwapHalf(arr);
			PrintArr(arr, "После обмена:");
		}
	}
}
