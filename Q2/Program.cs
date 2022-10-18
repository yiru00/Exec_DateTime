using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算圖書下個月歸還時間
			Console.Write("借閱時間 年/月/日: ");
			string input = Console.ReadLine();
			DateTime bookReturn = Convert.ToDateTime(input);

			DateTime threemonth = bookReturn.AddMonths(3);
			Console.WriteLine($"圖書應在三天後{threemonth:yyyy/MM/dd}歸還");
		}
	}
}
