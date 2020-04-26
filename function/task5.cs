using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{



		int e;
		e = int.Parse(Console.ReadLine());

		List<int> arr = new List<int>();
		List<string> str1 = new List<string>();
		List<string> str3 = new List<string>();
		string[][] nums = new string[5][];
		nums[0] = new string[10] { "", " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" };
		nums[1] = new string[10] { " десять", " одиннадцать", " двенадцать", " тринадцать", " четырнадцать", " пятнадцать", " шестнадцать", " семнадцать", " восемнадцать", " девятнадцать" };
		nums[2] = new string[10] { "", "", " двадцать", " тридцать", " сорок", " пятьдесят", " шестьдесят", " семьдесят", " восемьдесят", " девяносто" };
		nums[3] = new string[10] { "", " сто", " двести", " триста", " четыреста", " пятьсот", " шестьсот", " семьсот", " восемьсот", " девятьсот" };
		nums[4] = new string[3] { "", " одна", " две" };
		string[][] discharge = new string[3][];
		discharge[0] = new string[12] { "", " тысяч", " миллион", " миллиард", " триллион", " квадриллион", " квинтиллион", " секстиллион", " септиллион", " октиллион", " нониллион", " дециллион" };
		discharge[1] = new string[3] { "а", "и", "" };
		discharge[2] = new string[3] { "", "а", "ов" };
		int[] suf = { 2, 0, 1, 1, 1, 2, 2, 2, 2, 2, };
		List<int> disch(int k)
		{
			while (k > 0)
			{
				int a = k % 1000;
				arr.Add(a);
				k = k / 1000;
			}
			arr.Reverse();
			return arr;
		}
		string num(int n)
		{
			if (n == 0) return " ноль";
			string str = "";
			int c = n % 10;
			int b = ((n - c) / 10) % 10;
			int a = (n - (c + b)) / 100;
			str = nums[3][a] + ((b == 1) ? nums[1][c] : nums[2][b] + nums[0][c]);
			return str;
		}
		List<string> str2(List<int> arr1)
		{
			for (int i = arr1.Count - 1, j = 0; i >= 0; i--, j++)
			{
				if (i != arr1.Count - 2)
				{
					str1.Add(num(arr1[i]) + discharge[0][j]);
				}
				else
				{
					string a = (arr1[arr1.Count - 2]).ToString();
					if ((int)(a[1] - '0') != 1 && (int)(a[2] - '0') == 1)
					{
						string l = nums[3][(int)(a[0] - '0')] + ((int)(a[1] - '0') == 0 ? nums[4][1] : nums[2][(int)(a[1] - '0')] + nums[4][1]);
						str1.Add(l + discharge[0][j]);
					}
					else if ((int)(a[1] - '0') != 1 && (int)(a[2] - '0') == 2)
					{
						string l = nums[3][(int)(a[0] - '0')] + ((int)(a[1] - '0') == 0 ? nums[4][2] : nums[2][(int)(a[1] - '0')] + nums[4][2]);
						str1.Add(l + discharge[0][j]);
					}
					else
					{
						str1.Add(num(arr1[i]) + discharge[0][j]);
					}
				}
			}
			return str1;
		}
		string sufx(List<int> arrr)
		{
			arrr.Reverse();
			int a;
			string res = "";
			for (int i = arrr.Count - 1; i >= 0; i--)
			{
				if (i == 1)
				{
					a = arrr[i] % 10;
					str3.Add(discharge[1][suf[a]]);
				}
				else if (i == 0)
				{
					str3.Add(discharge[2][0]);
				}
				else
				{
					a = arrr[i] % 10;
					str3.Add(discharge[2][suf[a]]);
				}
			}
			for (int i = 0; i < str1.Count; i++)
			{
				res += str1[i] + str3[i];
			}
			return res;
		}
		disch(e);
		str1 = str2(arr);
		str1.Reverse();
		string result = sufx(arr).TrimStart();
		result = char.ToUpper(result[0]) + result.Substring(1);
		Console.WriteLine(result);
	}
}