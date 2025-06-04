using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number01 = 10;
            int number02 = 20;
            int number03 = 30;
            //加法
            int result = number01 + number03;
            //整理代码ctrl+k+d
            Console.WriteLine($" number01 + number03的结果是"+result);
            Console.WriteLine($"number01 + number03的结果是{result}");
            //减法
            result = number01 - number03;
            Console.WriteLine($" number01 - number03 的结果是" + result);
            Console.WriteLine($"number01 - number03 的结果是{result}");
            //乘法        
            result = number01 * number03;
            Console.WriteLine($" number01 * number03 的结果是" + result);
            Console.WriteLine($"number01 * number03 的结果是{result}");
            //除法
            result = number01 / number03;
            Console.WriteLine($"number01 / number03 的结果是" + result);//整数型赋值结果为小数的话会自动去除小数部分
            Console.WriteLine($" number01 / number03 的结果是{result}");
           
                double number002 = 20;
            double number003 = 30;
            double result01= number002 /number003;
            Console.WriteLine($"number002 /number003 的结果是" + result01);
            Console.WriteLine($"number002 /number003 的结果是{result01}");
            //求余数
            result =15% number01;
            Console.WriteLine($"15% number01 的结果是" + result);
            Console.WriteLine($"15% number01 的结果是{result}");

            //优先级
            result = number01 + number02 * 5;
            Console.WriteLine($"number01 + number02 * 5 的结果是" + result);
            Console.WriteLine($"number01 + number02 * 5 的结果是{result}");
            Console.WriteLine("-------------------------------------------------------");
            int i = 0;
            //i = i + 1;
           // i = i + 1;
            //i = i + 1;
            i++;//先赋值再++//
            Console.WriteLine(i++);
            ++i; Console.WriteLine(i++);
            int m = 10;
            m-=5; //m = m - 5;
            Console.WriteLine(m);








            Console.ReadLine();
        }
    }
}
