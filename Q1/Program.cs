using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算三天後 DVD 應歸還時間
			Console.Write("租借時間年/月/日: ");
			string input = Console.ReadLine();
			DateTime dvdReturn = Convert.ToDateTime(input);

			DateTime dayAfterDays = dvdReturn.AddDays(3);
			Console.WriteLine($"DVD應在三天後{dayAfterDays:yyyy/MM/dd}歸還");
		}
	}
}
