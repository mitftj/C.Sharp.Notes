using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //无限次数循环
            int a = 0;
            //while (true)//死循环
            //{
            //    a++;
            //    Console.WriteLine(a);
            //    Thread.Sleep(100);



            //}

            //while (a<=50)//死循环
            //{
            //    a++;
            //    Console.WriteLine(a);
            //    Thread.Sleep(100);



            //}
            while (true)//死循环
            {
                a++;
                Console.WriteLine("安全门已打开，请输入1关闭安全门");
              bool result=int.TryParse(Console.ReadLine(), out int NUM);
                if (NUM == 1)
                {
                    Console.WriteLine("安全门已关闭");
                    break;
                }
                else
                {

                    continue;
                }

                Console.WriteLine(a);
                Thread.Sleep(100);
            }


           
        }
    }
}
