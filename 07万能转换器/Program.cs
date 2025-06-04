using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07万能转换器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert.支持多种数据类型（如 string、null、object 等）转换为目标类型‌。
            //若输入为 null，返回目标类型的默认值（如 Convert.ToInt32(null) → 0）‌
            //输入格式无效时（如非数字字符串），抛出 FormatException‌34。

            bool led_States = false;
            //将bool转int
int a = Convert.ToInt32(led_States);
            Console.WriteLine($"convert.toInt32(led_States)" + a);
int b = Convert.ToInt32($"1223355");
            Console.WriteLine($"convert.toInt32" + b);
            bool c = Convert.ToBoolean(1);
            Console.WriteLine($"ToBoolean"+c);
            string d = "2025-05-14  10:53:14";
            Console.WriteLine("Conveert.TOdatetime(d)" + d);

DateTime timel = DateTime.Now;//当前时间

            string mess = "12.51353";
double result= Convert.ToDouble(mess);
            int result1 = Convert.ToInt32((int)result);
            Console.WriteLine(result1);//个位数 奇变偶不变



        }
    }
}
