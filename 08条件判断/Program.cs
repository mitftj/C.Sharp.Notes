using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08条件判断
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //条件判断
            int a = 10;
            int b = 20;
         
            if (a == b)
            {
                Console.WriteLine("结果正确");

            }
            else
            {
                Console.WriteLine("结果错误");

            }
            //试题

            Console.WriteLine("请输入姓名，并按下回车");
            string 姓名name = Console.ReadLine();
            if (姓名name == "张三")
            {
                Console.WriteLine("输入正确请选择出行地点");
                string location = Console.ReadLine();

                if (location == "北京")
                {
                    Console.WriteLine("选定成功，五秒后准备传送至北京");
                }


                if (location == "上海")
                {
                    Console.WriteLine("选定成功，五秒后准备传送至上海");
                }


                if (location == "深圳")
                {
                    Console.WriteLine("选定成功，五秒后准备传送至深圳");
                }
                if (location == "广东")
                {
                    Console.WriteLine("选定成功，五秒后准备传送至广东");
                }
            }
            else
            {
                Console.WriteLine("输入错误请重新输入姓名,并按下回车");
                Console.WriteLine("请输入姓名，并按下回车");
                string 姓名name1 = Console.ReadLine();
                if (姓名name == "张三")
                {
                    Console.WriteLine("输入正确请选择出行地点");
                    string location = Console.ReadLine();

                    if (location == "北京")
                    {
                        Console.WriteLine("选定成功，五秒后准备传送至北京");
                    }


                    if (location == "上海")
                    {
                        Console.WriteLine("选定成功，五秒后准备传送至上海");
                    }


                    if (location == "深圳")
                    {
                        Console.WriteLine("选定成功，五秒后准备传送至深圳");
                    }
                    if (location == "广东")
                    {
                        Console.WriteLine("选定成功，五秒后准备传送至广东");
                    }
                }

                Console.WriteLine("--------------------------------------------------------------");
                //与或非
                Console.WriteLine("请输入你的年龄");
                string mess01 = Console.ReadLine();
                Console.WriteLine("请输入管理员代码");
                string mess02 = Console.ReadLine();
                int age = 0;
                bool resut01 = int.TryParse(mess01, out age);
                //if (resut01)
                //{
                //    if (age > 18 && age < 45)//&&同时满足
                //    {
                //        Console.WriteLine("请进入传送空间");
                //    }

                //    else
                //    {
                //        Console.WriteLine("条件不满足，请离开");
                //    }



                //}

                if (age > 18 || mess02 == "9527")//||满足其中一个条件
                {

                    Console.WriteLine("请进入传送空间");

                }
                else
                {
                    Console.WriteLine("条件不满足，请离开");
                }
                //非！
                Console.WriteLine("请输入PLC 点位Q0.0的赋值--{监控安全门的点位}");
                string num1 = Console.ReadLine();

              bool result01 = int.TryParse(num1, out int number);
                if (!result01)
                {
                    bool sts = Convert.ToBoolean(number);

                    if (!sts)//true取反为false      为false 取反为true 
                    {
                        Console.WriteLine("安全门被打开");
                    }
                    else
                    {
                        Console.WriteLine("安全门被关闭");

                    }

                }











            }
        }
    }
}
