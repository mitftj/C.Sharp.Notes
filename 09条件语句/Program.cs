using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09条件语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的成绩");
          bool result=  double.TryParse(Console.ReadLine(), out double sorce);
            //满足任何一个条件即跳出//多个条件选择一个
            //if
            //else if
            //else if
            //else if
            //else if
            //else if
            //else if
            //......
            //else if
            //else




            if (result)
            {
                if (sorce >= 60 && sorce < 70)
                {
                    Console.WriteLine("OK");
                }
                else if (sorce <= 70 && sorce <= 80)
                {
                    Console.WriteLine("优秀");
                }
                else if (sorce > 80 && sorce <= 100)
                {
                    Console.WriteLine("非常优秀");

                }
                else 
                {
                    Console.WriteLine("不及格");

                }
            }
                    






        }
    }
}
