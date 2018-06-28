using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您对李四的评定等级（A-E）？");
            string input = Console.ReadLine();
            decimal salary = 5000m;
            bool flag = true;
            if (input == "A")
            {
                salary += 500;
            }
            if (input == "B")
            {
                salary += 200;
            }
            if (input == "C")
            {
                
            }
            if (input == "D")
            {
                salary -= 200;
            }
            if (input == "E")
            {
                salary -= 500;
            }
            else
            {
                Console.WriteLine("您的输入有误，只能输入ABCDE");
            }
            Console.WriteLine("李四评级后的工资为" + salary);
        }
    }
}
