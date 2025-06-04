using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0502值类型之间的转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num01= 10;//32位整形
            
            double num03= 3.1415926;//64位浮点型
            //小的数据位放到大的数据位里，自动类型转换 ，为隐式类型转换
            double result01 = num01 ; //int类型转换为double类型
            Console.WriteLine($"int类型转换为double类型的结果是{result01}");
            Console.WriteLine($"int类型转换为double类型的结果是" + result01);
            //大数据位放到小的数据位里，显示类型转换 ，为强制类型转换
            int result02 =(int)num03;//double类型转换为int类型(强制转换)
            Console.WriteLine($"double类型转换为int类型的结果是{result02}");
            Console.WriteLine($"double类型转换为int类型的结果是" + result02);

            int a1 = 10;
            double a2 = 20.5;
            int result03 = (int)(a1 + a2);
            int result04 = a1 + (int)a2;
            Console.WriteLine($"(int)(a1 + a2)的结果是{result03}");
            Console.WriteLine($"a1 + (int)a2的结果是{result04}");
            double result05 = (a1 +(double)(int) a2)/5;//int类型转换为double类型
            Console.WriteLine("-----------------------------------------------------");
            //字符串和值类型之间的转换
            string str01 = "123";//有效数字形式的字符串
            string str02 = "456";
           int result06= int.Parse(str01);//字符串转换为数字
            int result07 = int.Parse(str02);
            Console.WriteLine($"字符串转换为int类型的结果是{result06}");
            Console.WriteLine($"字符串转换为int类型的结果是" + result06);
            result07 += 100;
            Console.WriteLine($"字符串转换为int类型的结果是{result07}");

            //值类型类型转换为字符串
            string str03 = result06.ToString();
            Console.WriteLine($"int类型转换为字符串的结果是{str03}");
            Console.WriteLine($"int类型转换为字符串的结果是" + str03);
            //字符串拼接
            string str04 = str01 + str02;
            Console.WriteLine($"字符串拼接的结果是{str04}");
            Console.WriteLine($"字符串拼接的结果是" + str04);

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("请输入你的年龄,并按回车键结束");
            string age=Console.ReadLine();
            Console.WriteLine("你的年龄为" + age + "岁");
            Console.ReadLine();
                





        }
    }
}
