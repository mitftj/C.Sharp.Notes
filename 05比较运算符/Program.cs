using System;

namespace _05比较运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较运算符
            //声明一个值为10的int类型的变量
            int number01 = 10;
            //声明一个值为20的int类型的变量
            int number02 = 20;
            //比较是否相等==  //bool类型 真或假  true  or  false
            bool result = (number01 == number02);

            Console.WriteLine($"number01 == number02 的结果是" + result);

            Console.WriteLine($"number01 == number02 的结果是{result}");
            //不等于 !=   //反馈结果为bool类型 真或假  true  or  false
            bool result02 = (number01 != number02);

            Console.WriteLine($"number01 != number02 的结果是" + result02);

            Console.WriteLine($"number01 != number02 的结果是{result02}");

            //大于 >     //反馈结果为bool类型 真或假  true  or  false
            bool result03 = (number01 > number02);
            
            Console.WriteLine($"number01 > number02 的结果是" + result03);
            
            Console.WriteLine($"number01 > number02 的结果是{result03}");
            //小于 <   //反馈结果为bool类型 真或假  true  or  false
            bool result04 = (number01 < number02);
            
            Console.WriteLine($"number01 < number02 的结果是" + result04);
            
            Console.WriteLine($"number01 < number02 的结果是{result04}");
            //大于等于 >=  //反馈结果为bool类型 真或假  true  or  false
            bool result05 = (number01 >= number02);
            
            Console.WriteLine($"number01 >= number02 的结果是" + result05);
            
            Console.WriteLine($"number01 >= number02 的结果是{result05}");
            //小于等于 <=  //反馈结果为bool类型 真或假  true  or  false
            bool result06 = (number01 <= number02);
            
            Console.WriteLine($"number01 <= number02 的结果是" + result06);
            
            Console.WriteLine($"number01 <= number02 的结果是{result06}");

            Console.WriteLine("-----------------------------------------------------");
            //移位的 运算
            //向左移位
            int number03 = 5;
            int result07 = number03 << 3; //左移3位----00000101------》101000
            Console.WriteLine($"number03 << 3 的结果是" + result07);
            Console.WriteLine($"number03 << 3 的结果是{result07}");
            //向右移位
            int number04 = 8;
            int result08 = number04 >> 2; //右移2位 //00001000------》00000010
            Console.WriteLine($"number03 >> 2 的结果是" + result08);    
            Console.WriteLine($"number03 >> 2 的结果是{result08}");







            //快捷键
            //ctrl+k+d //格式化代码整理代码
            //ctrl+k+c //注释代码
            //ctrl+k+u //取消注释代码
            //ctrl+z //撤销
            //ctrl+y //重做
            //ctrl+f11 //调试
            //ctrl+f9 //断点
            //ctrl+f10 //运行到光标处
            //ctrl+f12 //查看定义
            //ctrl+f3 //查找
            //ctrl+f4 //关闭当前窗口
            //ctrl+f5 //运行
            //ctrl+f6 //切换窗口
            //ctrl+f7 //切换窗口






        }

    }
}
