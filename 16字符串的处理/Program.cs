using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _16字符串的处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mess = "ABB_机器人_1600";
          int num=  mess.IndexOf("人");//索引
          string mess1=  mess.Insert(num+1, "型号：");//插入
            string mess2=mess.Remove(num+1);//删除

            string mess3=mess.Remove(mess.IndexOf("机"),4);//选取删除
            string mess4 = mess.Replace("ABB", "FUNC");//所有选取内容替换
            string mess5 = mess.ToLower();//大写转小写

           bool result= string.IsNullOrEmpty(mess5);//判断值是否为空空为true 不空为false
            string mm = "123456789";

            Console.WriteLine(mess1);
            Console.WriteLine(mess2);
            Console.WriteLine(mess3);
            Console.WriteLine(mess4);
            Console.ReadLine();











        }
    }
}
