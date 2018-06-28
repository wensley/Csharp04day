using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入您的分数：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            Console.ReadKey();
            ////跳出if_else if语句
            */

            //练习一  以下写法错误
            /*
            Console.WriteLine("请您输入密码：");
            int password = Convert.ToInt32(Console.ReadLine());
            if (password == 888888)
            {
                Console.WriteLine("密码正确");
            }
            else if (password != 888888)
            {
                Console.WriteLine("请您再次输入密码：");
                Console.ReadLine();
            }
            else if (password == 888888)
            {
                Console.WriteLine("密码正确");
            }
            else
            {
                Console.WriteLine("密码错误，程序结束！");
            }
            */

            //练习一  正确写法
            /*
            Console.WriteLine("请您输入密码：");
            int password = Convert.ToInt32(Console.ReadLine());
            if (password == 888888)
            {
                Console.WriteLine("密码正确");
            }
            else
            {
                Console.WriteLine("请您再次输入密码：");
                password = Convert.ToInt32(Console.ReadLine());

                if (password == 888888)
                {
                    Console.WriteLine("密码正确");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }


                Console.ReadKey();
                */
            /*
            //练习二  我作对了，开心 o(*￣▽￣*)ブ
            Console.WriteLine("请您输入用户名：");
            string user =Console.ReadLine();

            Console.WriteLine("请您输入密码：");
            string password = Console.ReadLine();
            if (user == "admin" && password == "888888")
            {
                Console.WriteLine("登陆成功");
            }
            else if (user != "admin")
            {
                Console.WriteLine("用户名不正确");
            }
            else  
                    {
                Console.WriteLine("请输入密码：");
            }
            Console.ReadKey();
            */

            //练习三
            
            Console.WriteLine("请输入您的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if (age >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age <=10)
            {
                Console.WriteLine("禁止查看");
            }
            else if (age >= 10&&age<=18)
            {
                Console.WriteLine("是否继续查看，请输入yes或者no");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("请查看");
                }
                else
                {
                    Console.WriteLine("你已放弃查看！");
                }
            }
            
            Console.ReadKey();
            

        }
    }
}
