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
            /*
            Console.WriteLine("请输入您对李四的评定等级（A-E）？");
            string input = Console.ReadLine();
            decimal salary = 5000m;
            bool flag = false;
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
            if (flag == true)
            {
                Console.WriteLine("您的输入有误，只能输入ABCDE");
                
            }
            Console.WriteLine("李四评级后的工资为" + salary);
            */
            //SWITCH 写法

            Console.WriteLine("请输入您对李四的评定等级（A-E）？");
            string input = Console.ReadLine();
            decimal salary = 5000m;
            bool flag = false;
            switch (input)
            {
                case "A":
                    salary += 500;
                    break;

                case "B":
                    salary += 200;
                    break;
                default://注意：匹配值和语句顺序无关，只和值有关！
                    Console.WriteLine("您的输入有误，只能输入ABCDE。");
                    flag = true;
                    break;
                case "C":
                    salary += 0;
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
            }
            if (flag == false)
            {
                //Console.WriteLine("您的输入有误，只能输入ABCDE。");
                Console.WriteLine("李四评级后的工资为" + salary);
            }
            
            Console.ReadKey();

        }
    }
}
