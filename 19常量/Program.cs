using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //常量，不变的量，定义完后不能改变的值
            //定义 const +变量各类型+变量名称=赋值
            //声明即赋值
            const double pai = 3.14159226;
            //pai = 55;//无法再给常量赋值
            //计算圆的面积
            double arear = pai * 5 * 5;
            Console.WriteLine("arear面积"+arear);
            Console.ReadLine();

        }
    }
}
