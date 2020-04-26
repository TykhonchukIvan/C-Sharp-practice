using System;
using System.Collections.Generic;

namespace functions
{
	class Functions
	{
		static void Main(string[] args)
		{
			string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

			string day = "";
			string GetDay(int dayNumber)
			{
				for (int i = 0; i <= days.Length; i++)
				{
					if (i == dayNumber)
					{
						day = days[i - 1];
					}
					else
					{
						continue;
					}
				}
				return day;
			}
			Console.WriteLine(GetDay(1));
		}
	}
}

