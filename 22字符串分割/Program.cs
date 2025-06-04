using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22字符串分割
{
    internal class Program
    {
        public enum MyEnum
        {
            PLC1200,
            PLC200_Smart,
            FNX_3U,
            FNX_5U,
            欧姆龙


        }
        static void Main(string[] args)
        {
            //PLC发过来数据
            string mess = "A02 XL6 PLC1200   10.26 25.69";
           string []nums= mess.Split(' ');
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            //PLC发过来数据
            string mess1 = "A02;XL6,PLC1200  10.26 '25.69";
            char[] chars = { ';', ',', ' ' };
            string[] strings = mess1.Split(chars);
            foreach (var item in strings)
            {
                Console.WriteLine("strings"+item);
            }
            if (strings[2]=="PLC1200") 
            {
                Console.WriteLine(mess1);
            }
            Console.WriteLine($"坐标X：{strings[strings.Length-2]}坐标Y：{strings[strings.Length-2]}");

            string nama=strings[2];
            MyEnum myEnum = MyEnum.PLC1200;
            if (Enum.TryParse(nama,out myEnum))
            {
                switch (myEnum)
                {
                    case MyEnum.PLC1200:
                        break;
                    case MyEnum.PLC200_Smart:
                        break;
                    case MyEnum.FNX_3U:
                        break;
                    case MyEnum.FNX_5U:
                        break;
                    case MyEnum.欧姆龙:
                        break;
                    default:
                        break;
                }
            }

                 //PLC发过来数据
            string mess03 = "A02;XL6,PLC1200  10.26 '25.69";
            char[] chars1 = { ';', ',', ' ' };
            string[] string2 = mess03.Split(chars);
            string2[0] = "B02";
             // 把字符串数组 转成   成一个字符串  //  发送  等
            string reult =string.Join("--------",string2);

            Console.WriteLine(reult);
            Console.ReadLine();
        }
    }
}
