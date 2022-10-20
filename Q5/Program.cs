using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//列出指定年份的每一個星期日


			Console.Write("請輸入年份");
			string input = Console.ReadLine();


			//找出輸入年份的1/1
			int yearInt = Convert.ToInt32(input);
			DateTime specifiedYear = new DateTime(yearInt, 01, 01);

			//找出1/1星期幾
			DayOfWeek specifiedDayOfWeek = specifiedYear.DayOfWeek;
			int weekInt = Convert.ToInt32(specifiedDayOfWeek);

			DateTime lastDay = new DateTime(yearInt, 12, 31);

			//找出第一個星期日
			DateTime result = specifiedYear;


			switch (weekInt)
			{
				case 0:

					break;
				case 1:
					result = specifiedYear.AddDays(6);
					break;
				case 2:
					result = specifiedYear.AddDays(5);
					break;
				case 3:
					result = specifiedYear.AddDays(4);
					break;
				case 4:
					result = specifiedYear.AddDays(3);
					break;
				case 5:
					result = specifiedYear.AddDays(2);
					break;
				case 6:
					result = specifiedYear.AddDays(1);
					break;
			}
			Console.WriteLine($"第一個星期日是{result}");


			//迴圈+7天
			while (result<lastDay)
			{
				//先判斷是否符合
				Console.WriteLine($"{result: yyyy-MM-dd}");
				result = result.AddDays(7);
			}
		}
	}
}
