using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _06值类型转换
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //字符串与值类型之间的转换
            double num03 = 15.123456;

            string str03 = num03.ToString("F2");//double类型转换为字符串类型//保留几位有效数字

            Console.WriteLine(str03);
            DateTime time = DateTime.Now;
            Console.WriteLine("时间是" + time.ToString("yyyy-MM-dd HH:mm:ss"));//时间格式化

           







            try
            {
                Console.WriteLine("请输入一个小数");
                //字符串转值类型
                string str01 = Console.ReadLine();//1.接收控制台数据

                double num1 = double.Parse(str01);//2.字符串转换为double类型

                double num2 = 100 / num1;//3.除法
                Console.WriteLine("mum的值是" + num2);//打印结果
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("有异常"+ex.Message); 
                Console.ReadLine(); 
            }

            
          
        }
    }
}
