using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//根據日期, 傳回今天是本月的上旬, 中旬或下旬
			Console.Write("請輸入今天日期 年/月/日 : ");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("未輸入");
				return;
			}

			DateTime today = Convert.ToDateTime(input);
			int day = today.Day;
			string meg=string.Empty;
			if (day <= 10)
			{
				meg = "上旬";

			}
			else if (day <= 20)
			{
				meg = "中旬";

			}
			else
			{
				meg = "下旬";
			}
			Console.WriteLine($"今天是{meg}");
		}
	}
}
