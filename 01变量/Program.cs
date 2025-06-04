using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变量类型决定空间的大小和存储的值的类型
            //变量   声明变量的目的是 在内存上开辟空间
            //变量的名称就是空间的名称

            //变量的类型+变量的名称=变量的值（赋值）;

            ///在内存上开了一个int（32位整形）类型的空间，名称为a
            //整型
            int a = 30; //整型
            int b = 20; //整型
            int c = a + b; //整型
            //小数形
            double d = 3.14; //双精度
            //声明一个变量---无值
            int e;
            e= 10; //赋值
            //
            int f = 2147483647;

            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
           Console.WriteLine(e);
            Console.ReadLine();
            

            //变量的类型
            //变量的名称 number//小驼峰命名法，首个单词首字母小写，后面每个单词首字母大写

            int sensorNumber = 10; //以字母或者下划线开头不能以数字开头
                                   //关键字不能作为变量名
            Console.WriteLine(sensorNumber);
                        //浮点型
                        float Temperature = 36.76f; //七位精度整数加小数一起是七位
            
            float Number = 3.1415926f; //
            Console.WriteLine(Temperature);
            Console.WriteLine(Number);



            Console.WriteLine(sensorNumber);

            Console.ReadLine();

            //15位精度整数加小数一起是15位
            double g = 3.141592653589793238;
               
            short h = 32767; //短整型
            long i = 9223372036854775807; //长整型
            byte j = 255; //字节型
            ushort k = 65535; //无符号短整型
            ulong l = 18446744073709551615; //无符号长整型
            sbyte m = -128; //有符号字节型
            bool n = true; //布尔型      
            char o = 'A'; //字符型
            string p = "hello"; //字符串型
            decimal q = 3.14159265358979323846264338327950288419716939937510582097494459230781640628m; //十进制型
            object r = 3.14159265358979323846264338327950288419716939937510582097494459230781640628; //对象型
            var s = 3.14159265358979323846264338327950288419716939937510582097494459230781640628; //隐式类型变量
        Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);   

            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(s);
            


            char Eender= '男'; //字符型只占用一个字节
            char Eender1 = '女';
            //字符串
            string Name = "张三"; 
            string SchoolName = "天一素始道化空庭院";
            string WorkId = "20231001";
            bool LedStates = true;//真
            bool LedStates1 = false;//假
            decimal socre = 99.9m; //decimal类型28位精度      
            //C#变量区分大小写
            //变量加下划线
            int _SensorNumber = 10; //下划线命名法，变量名称以字母或者下划线开头，不能以数字开头

            Console.WriteLine(Eender);
            Console.WriteLine(Eender1);
            Console.WriteLine(Name);
            Console.WriteLine(SchoolName);
            Console.WriteLine(WorkId);
            Console.WriteLine(LedStates);
            Console.WriteLine(LedStates1);
                Console.WriteLine(socre);
            Console.WriteLine(_SensorNumber);





        }
    }
}
