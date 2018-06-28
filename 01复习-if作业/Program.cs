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
            /*
            //作业1
            Console.WriteLine("请输入您的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("您已成年！");//正确

            }
            Console.WriteLine("您已成年！");//这句话应该在{}里，我写的不对
            Console.WriteLine("您未成年！");


            //这是我的作业，大写的错误
            //作业2不会做
            int chinese = 90, music = 70;//定义错误，应该是直接定义并接收用户输入的值
            if (chinese > 90 && music = 80 || chinese = 100 && music > 70) ;//关系运算符使用错误
            if ((chinese >= 90 && music == 80) || (chinese == 100 && music >= 70))//正确写法
            //上面没有正确定义，这里肯定显示各种错误，但想法是对
            {
                Console.WriteLine();
            }
            Console.ReadKey();
           
            //重新做的作业
            Console.WriteLine("请输入您的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入您的音乐成绩：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese >= 90 && music == 80) || (chinese == 100 && music >= 70))
            {
                Console.WriteLine("奖励你100元！");
            }
            Console.ReadKey();
             
            //作业3-完全懵逼

            Console.WriteLine("请输入用户名：");
            string user = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pass = Console.ReadLine();
            //if (user = user  pass = pass)
            //错误1：用户输入的是字符串，=右边是字符串类型需要加双引号！
            //错误2：关系运算符使用错误，应该使用==，例如user == "admin"
            //错误3：user和pass是逻辑与关系，两个表达式之间用&&
            if (user == "admin" && pass == "mypass")
            {
                Console.WriteLine("登陆成功");
            }
            //Console.WriteLine("登陆成功");//这句话应该在{}里，我写的不对
            Console.WriteLine("登陆失败");
            
            Console.ReadKey();
            */
            ///这是正确的做法
            //作业2
            Console.WriteLine("请输入您的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入您的音乐成绩：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese >= 90 && music >= 80) || (chinese == 100 && music >= 70))
            {
                Console.WriteLine("奖励您100元");
            }
            Console.ReadKey();

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
