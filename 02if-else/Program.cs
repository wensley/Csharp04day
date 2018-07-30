using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入张三的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("奖励你100元！");
            }
            if (score < 90)
            {
                Console.WriteLine("不准出去玩，在家写总结！");
            }
            */
            //if/else
            /*
            Console.WriteLine("请输入张三的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("奖励你100元！");
            }
            else
            {
                Console.WriteLine("不准出去玩，在家写总结！");
            }
            */

            //练习1
            /*
            Console.WriteLine("请输入鸡蛋的数量：");
            int egg = Convert.ToInt32(Console.ReadLine());
            if (egg <= 5)
            {
                Console.WriteLine("自己吃掉！");
            }
            else
            {
                Console.WriteLine("退货去！");
            }
            */
            //练习2
            /*
            Console.WriteLine("请输入a的数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入b的数字：");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a%b==0||a+b>100)
            {
                Console.WriteLine("a={0}",a);
            }
            else
            {
                Console.WriteLine("b={0}",b);
            }
            */
            //练习3
            /*
            Console.WriteLine("请输入学员的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A");
            }


            if (90 > score&&score >= 80)
            {
                Console.WriteLine("B");
            }


            if (80>score && score >= 70)
            {
                Console.WriteLine("C");
            }
            
            if (70>score && score >= 60)
            {
                Console.WriteLine("D");
            }
            
            if (score<60)
            {
                Console.WriteLine("E");
            }

            Console.ReadKey();
            */
            /*
            //练习3的另一种写法
            Console.WriteLine("请输入学员的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else
            {
                if (90 > score && score >= 80)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    if (80 > score && score >= 70)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        if (score >= 60)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            
                            Console.WriteLine("E");
                            
                        }
                    }
                }
            }

            Console.ReadKey();
            */
                        
        }
    }
}
