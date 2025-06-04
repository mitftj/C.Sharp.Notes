using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //转义字符
            //\n换行
            //\t制表符
            //\\反斜杠
            //\'单引号
            //\"双引号
            //\0空字符
            //\a响铃
            //\b退格
            //\r回车
            //\f换页
            //\v垂直制表符
            //\xhh十六进制数
            //\uhhhhUnicode字符
            //\UhhhhhhhhUnicode字符
            //\0空字符
           Console.WriteLine("西门子PLC的产地是：\r\n德国");
            Console.WriteLine(@"D:\alx");
            Console.WriteLine("D:\\alx");
            Console.WriteLine("\"你好明天\"");

            Console.WriteLine("\"你好明天\"\t你好");

            Console.WriteLine("你好！明天！\t");
            Console.WriteLine("你好！明天！\\");
            Console.WriteLine("你好！明天！\'");
            Console.WriteLine("你好！明天！\"");
            Console.WriteLine("你好！明天！\0");
            Console.WriteLine("你好！明天！\a");
            Console.WriteLine("你好！明天！\b");
            Console.WriteLine("你好！明天！\r");
        }
    }
}
