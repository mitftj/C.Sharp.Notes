using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13循环的嵌套
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"外循环第{i}");
                for (int j = 0; j < 5; j++) {
                    Console.WriteLine($"内循环第{j}");
                }
            }
            for (int i = 0; i < 10; i++)//负责行
            {

                
                for (int j = 0; j < 10; j++)//负责列
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\r\n");
            }
        }
    }
}
