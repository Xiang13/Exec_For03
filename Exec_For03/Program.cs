using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 右側對齊三角形
			int rows = 5;
			for (int i = 1; i <= rows; i++)
			{
				int countOfEmpty = rows - i;
				int countOfStar = i;
				string row = new string(' ', countOfEmpty) + new string('*', countOfStar);
				Console.WriteLine(row);
			}
		}
	}
}
