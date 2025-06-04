using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10三元表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的成绩");
          bool reslt=int.TryParse(Console.ReadLine(), out int value);
            var num = 10;  //var代表系统给你推断类型
            if (reslt) 
            {
                if (value > 60) 
                {
                    Console.WriteLine("及格");

                }
                if (value < 60)
                {

                    Console.WriteLine("不及格");
                }
               
                    }



            if (reslt)
            {
                //三元表达式---?---:---;
                string mess = value >= 60 ? "及格" : "不及格";
                Console.WriteLine($"你的成绩是{value} {mess}");
            }
            Console.WriteLine("获取产线上相机拍摄该图片的ROI区域的个数");
            //<=5个 ok ng
            //系统的随机数
            Random random = new Random();//新建一个1随机数
          int num1=  random.Next(1,101);
            Console.WriteLine($"检测的结果是{num1}个区域");
            bool ress = num1 <= 5 ? true : false;

            if (ress)
            {
                Console.WriteLine("OK");
            }
            else {
                Console.WriteLine("NG");

                    }
        }
    }
}
