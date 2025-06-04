using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18字符串的处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mess = "ABB_机器人_#1600_900#asdfghjkl";
            //截取字符串
           int num= mess.IndexOf("#");//8


            int num1=mess.LastIndexOf("#");
            if (num != -1)
            {
                string news =  mess.Substring(num+1, num1- num -1);
               Console.WriteLine(news);
                if (news.Length > 0)
                {
                 string x= news.Substring(0, news.IndexOf("_"));//4
                    int newx=int.Parse(x)+50;
                    Console.WriteLine("x坐标是："+ newx);

                    string y = news.Substring( news.IndexOf("_")+1);//4
                    int newy = int.Parse(y) + 100;
                    Console.WriteLine("y坐标是：" + newy);
                }



            }







        }
    }
}
