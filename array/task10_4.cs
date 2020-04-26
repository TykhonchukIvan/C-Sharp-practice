using System;
namespace ConsoleApp7
{
	class Program
	{
		static Int32 add2pyramid(Int32[] arr, Int32 i, Int32 N)
		{
			Int32 imax;
			Int32 buf;
			if ((2 * i + 2) < N)
			{
				if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
				else imax = 2 * i + 1;
			}
			else imax = 2 * i + 1;
			if (imax >= N) return i;
			if (arr[i] < arr[imax])
			{
				buf = arr[i];
				arr[i] = arr[imax];
				arr[imax] = buf;
				if (imax < N / 2) i = imax;
			}
			return i;
		}
		static void Pyramid_Sort(Int32[] arr, Int32 len)
		{
			for (Int32 i = len / 2 - 1; i >= 0; --i)
			{
				long prev_i = i;
				i = add2pyramid(arr, i, len);
				if (prev_i != i) ++i;
			}
			Int32 buf;
			for (Int32 k = len - 1; k > 0; --k)
			{
				buf = arr[0];
				arr[0] = arr[k];
				arr[k] = buf;
				Int32 i = 0, prev_i = -1;
				while (i != prev_i)
				{
					prev_i = i;
					i = add2pyramid(arr, i, k);
				}
			}
		}
		static void Main(string[] args)
		{
			Int32[] arr = new Int32[100];
			//заполняем массив случайными числами
			Random rd = new Random();
			for (Int32 i = 0; i < arr.Length; ++i)
			{
				arr[i] = rd.Next(1, 101);
			}
			System.Console.WriteLine("Массив перед сортировкой:");
			foreach (Int32 x in arr)
			{
				System.Console.Write(x + " ");
			}
			//сортировка
			Pyramid_Sort(arr, arr.Length);
			System.Console.WriteLine("\n\nМассив после сортировки:");
			foreach (Int32 x in arr)
			{
				System.Console.Write(x + " ");
			}
		}
	}
}
