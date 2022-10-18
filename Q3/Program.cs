using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//取得本月一日
			Console.WriteLine("請輸入今日日期 年/月/日/ :");
			string input = Console.ReadLine();
			DateTime today = Convert.ToDateTime(input);
			int year = today.Year;
			int month = today.Month;
			string firstday = $"{year.ToString()}/{month.ToString()}/01";
			Console.WriteLine($"本月的一日是{year}/{month}/01");
		}
	}
}
