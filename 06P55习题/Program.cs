using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06P55习题
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //下面是我纠正后的写法，增加了闰年的考虑
            Console.WriteLine("请您输入年份：");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请您输入月份：");
            int moth = Convert.ToInt32(Console.ReadLine());
            int days=30;
            
            switch (moth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days += 1;
                    Console.WriteLine("您输入的{0}年{1}月份有{2}天", years, moth, days);
                    break;
                case 2:
                    if (years % 400 == 0 || years % 4 == 0 && years % 100 != 0)
                        Console.WriteLine("您输入的{0}年{1}月份有29天", years, moth);
                    else
                    {
                        Console.WriteLine("您输入的{0}年{1}月份有28天", years, moth);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("您输入的{0}年{1}月份有{2}天", years, moth, days);
                    break;
                default:
                    Console.WriteLine("您输入的月份有误，请输入1-12的数字。");
                    break;
  
               // Console.WriteLine("您输入的{0}年{1}月份有{2}天",years,moth,days);
            }
            
            //下面是老师的写法
            Console.WriteLine("请您输入年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请您输入月份：");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("您输入的{0}年{1}月份有31天", year, month);
                    break;

                case 2:
                    if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                    {
                        Console.WriteLine("您输入的{0}年{1}月份有29天", year, month);
                    }
                        
                    else
                    {
                        Console.WriteLine("您输入的{0}年{1}月份有28天", year, month);
                    }
                    break;
                default:
                    Console.WriteLine("您输入的{0}年{1}月份有30天", year, month);
                    break;
            }
            */

            //练习题，下面是老师的写法
            Console.WriteLine("请输入您的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            switch (score/10)//有一个问题，如果考试满分100，结果还是“E”哈哈，我是杠精    ╮（╯＿╰）╭
            {
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("E");
                    break;

            }

            Console.ReadKey();
        }
    }
}
