using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //n次循环，如果i从0开始，则循环条件为i<n
            //n次循环，如果i从1开始，则循环条件为i<=n
            /*
            int i = 0;  //因为i是控件循环次数的，所以i又叫做：循环变量
            while (i < 5) 
            {
                Console.WriteLine("下次考试一定要细心"+i);//+i计数
                i ++;  //千万不要忘记这一句
            }
            */

            /* 下面是作业
            //练习1
            int h = 0;
            while (h < 100)
            {
                Console.WriteLine("欢迎来传智播客学习！"+h);
                h++;
            }
            */
            //练习2
            /*
            Console.WriteLine("请输入班级总人数：");
            int ren = Convert.ToInt32(Console.ReadLine());
            int score=0;
            int i = 0;//我没有定义这个变量
            int sum = 0; //存用户的总成绩,我没有定义这个变量
            while (i < ren)
            {
                Console.WriteLine("请输入第{0}名学员的成绩：",i+1);
                score=Convert.ToInt32(Console.ReadLine());
                sum += score;  //等于sum=sum+score；这个表达式等于重复赋值sum，并累加score成绩值
                i++;//应该是i++，我写的ren++这个变量是不对的

               // Console.WriteLine("班级学员的平均成绩为{0}，总成绩为{1}",score/ren,ren+ren);
            }
            Console.WriteLine("班级总学员{0}名，总成绩为{1}分，平均成绩为{2}分", ren, sum, sum / ren);
            */
            //
            /*
            //昨天听完，今天又重新做了一遍

            Console.WriteLine("请输入班级人数：");
            int conut = Convert.ToInt32(Console.ReadLine());
            int score;
            int sum=0;
            int i = 0;
            while (i<conut)
            {
                Console.WriteLine("请输入第{0}位学员成绩：",i+1);
                score =Convert.ToInt32( Console.ReadLine());
                sum = sum + score;
                i++;
            }
            Console.WriteLine("班级总人数为{0}人，学员的平均成绩为{1}，总成绩为{2}。",conut,sum/conut,sum);
            */
            /*
            //练习3
            Console.WriteLine("Do you write?(y/n)");
            string ans = Console.ReadLine();
            
            int i = 0;
            while (ans=="n"&&i<=5)//分清&&和||
            {
                Console.WriteLine("Speak agin",+i);
                
                Console.WriteLine("Do you write?(y/n)");
                ans = Console.ReadLine();
                
                i++;//计数讲了几遍

            }
            Console.WriteLine("Go home!");
            */
            //练习4
            //Console.WriteLine("2006年80000人，每年增长25%，哪年达到20万人？");

            int y = 2006;
            double r = 80000;
            while (r<200000) //循环条件
            {
                r = r * 1.25; //计算一年的增长率
                y++; //输出年份
            }
            
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
