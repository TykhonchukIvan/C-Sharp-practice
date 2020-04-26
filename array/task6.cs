using System;

namespace ConsoleApp1
{
	class Program
	{
		public static int Main()
		{
			int[] ara = new int[] { 10, 25, 34, 47, 56, 62, 77, 88, 94, 105 };
			foreach (var i in ara)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
			Array.Reverse(ara);
			foreach (var i in ara)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
			Console.ReadKey();
			return 0;
		}
	}
}
