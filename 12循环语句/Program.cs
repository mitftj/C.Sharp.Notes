using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //有限次数循环
            int length = 10;
            int A = 0;
            for (int i = 0; i < length; i++)
            {
                A++;
                Console.WriteLine($"当前执行几{i}次");
            }
            Console.ReadLine();


            //有十个产品每个产品有五道工序
            int numCount = 10;
            int b = 0;
            for (int i = 0; i < numCount; i++)//次数为numCount-1//用<=时一致
            {
                b++;

                Console.WriteLine($"当前为第{b}个产品");

               
                Console.WriteLine("执行第壹道工序");
              Thread.Sleep(50);
                Console.WriteLine("执行第贰道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第叁道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第肆道工序");
                Thread.Sleep(50);
                if (b == 3)
                {
                    Console.WriteLine($"当前第{b}个产品出错，第四道工序有问题");
                        continue;//不再执行下方语句/不终止循环继续执行下一次循环
                }
                Console.WriteLine("执行第伍道工序");
                Thread.Sleep(50);
               



            }
            Console.ReadLine();

            for (int i = 1; i <= numCount; i++)//次数为numCount-1//用<=时一致
            {
                

                Console.WriteLine($"当前为第{i}个产品");


                Console.WriteLine("执行第壹道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第贰道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第叁道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第肆道工序");
                Thread.Sleep(50);
                if (i == 3)
                {
                    Console.WriteLine($"当前第{i}个产品出错，第四道工序有问题");
                    continue;//不再执行下方语句/不终止循环继续执行下一次循环
                }
                Console.WriteLine("执行第伍道工序");
                Thread.Sleep(50);




            }
            //
            for (int i = 1; i <= numCount; i++)//次数为numCount-1//用<=时一致
            {


                Console.WriteLine($"当前为第{i}个产品");


                Console.WriteLine("执行第壹道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第贰道工序");
                if (i == 3)
                {
                    Console.WriteLine($"当前第{i}个产品出错，第贰道工序有问题，程序停止运行！");
                    break;//跳出顶部的循环
                }
                Thread.Sleep(50);
                Console.WriteLine("执行第叁道工序");
                Thread.Sleep(50);
                Console.WriteLine("执行第肆道工序");
                Thread.Sleep(50);

                Console.WriteLine("执行第伍道工序");
                Thread.Sleep(50); 
            }
            //无限次数循环

        }
    }
}
