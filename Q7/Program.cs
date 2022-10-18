using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//根據不同時間, 傳回不同問安方式
			Console.Write("請輸入時間 年/月/日 時/分/秒");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("未輸入");
			}
			DateTime today = Convert.ToDateTime(input);
			int hour = today.Hour;

			if (hour <= 11)
			{
				Console.WriteLine("早安");
			}
			else if (hour <= 18)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
