using System;
namespace ConsoleApp1
{
	class Point 
	{
		double x, y; 
		public double X
		{
			get { return x; }
		}
		public double Y
		{
			get { return y; }
		}
		public Point(double x, double y) 
		{
			this.x = x;
			this.y = y;
		}
	}
	class Program
	{
		static double LengthSide(Point A, Point B)
		{
			return Math.Sqrt(((B.X - A.X) * (B.X - A.X)) + ((B.Y - A.Y) * (B.Y - A.Y)));
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter x,y coordinates of first point");
			double x0 = double.Parse(Console.ReadLine());
			double y0 = double.Parse(Console.ReadLine());		
			Point A = new Point(x0, y0);
			Console.WriteLine("Enter x,y coordinates of second point");
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			Point B = new Point(x1, y1);
			Console.WriteLine("Длина отрезка в декартовых координатах равна {0} ", LengthSide(A, B));
		}
	}
}
