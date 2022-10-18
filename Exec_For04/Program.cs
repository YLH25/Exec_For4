using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//呈現1~20, 若是3的倍數顯示 foo, 若是5的倍數顯示bar, 
			//若是15的倍數顯示foobar, 其餘顯示數值
			for (int i = 1; i <= 20; i++)
			{
				if (i % 3 == 0)
				{
					if (i % 15 == 0)
					{
						Console.WriteLine($"{i}foobar");
					}
					else
					{
						Console.WriteLine($"{i}foo");
					}
				}
				else if (i % 5 == 0)
				{
					if (i % 15 == 0)
					{
						Console.WriteLine($"{i}foobar");
					}
					else
					{
						Console.WriteLine($"{i}bar");
					}
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
