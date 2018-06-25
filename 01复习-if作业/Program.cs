using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习_if作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1
            //Console.WriteLine("请输入您的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("您已成年！");//正确

            //}
            //    Console.WriteLine("您已成年！");//这句话应该在{}里，我写的不对
            //Console.WriteLine("您未成年！");

            //作业2
            //Console.WriteLine("请输入您的语文成绩：");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的音乐成绩：");
            //int music = Convert.ToInt32(Console.ReadLine());
            //if ((chinese >= 90 && music >= 80) || (chinese == 100 && music >= 70))
            //{
            //    Console.WriteLine("奖励您100元");
            //}
            //Console.ReadKey();

            //作业3
            Console.WriteLine("请输入您的用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入您的密码：");
            string myPass = Console.ReadLine();
            if (userName == "admin" && myPass == "mypass")
            {
                Console.WriteLine("登陆成功");
                
            }
            Console.WriteLine("用户名或密码错误！");
            Console.ReadKey();
        }
    }
}
