using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int xBinary = 11;
			int left = 1;
			int right = xBinary;
			int resultBinary = 0;
			while (left <= right)
			{

				int middle = (left + right) / 2;

				if (middle * middle == xBinary)
				{
					resultBinary = middle;
					break;
				}
				if (middle * middle < xBinary)
				{
					left = middle + 1;
					resultBinary = middle;
				}
				else
				{
					right = middle - 1;
				}

			}
			Console.WriteLine(resultBinary);
		}
	}
}
