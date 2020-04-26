using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b;
			a = 5;
			b = 9;
			if (a % 2 ==0)
			{
				Console.WriteLine(a * b);
			}
			else
			{
				Console.WriteLine(a + b);
			}
			Console.ForegroundColor = ConsoleColor.Green;
		}
	}
}




