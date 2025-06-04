using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _02变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //字符串拼接
            string siemens_PLC_IP = "192.168.1.1";
            string siemens_PLC_Model = "S7-1200";
            Console.WriteLine("西门子PLC的IP地址是： " + siemens_PLC_IP+"型号是： "+ siemens_PLC_Model);


            //占位符{0}{1}{2}{3}
            Console.WriteLine("西门子PLC的IP地址是: {0}型号是： {1}", siemens_PLC_IP, siemens_PLC_Model);
            Console.WriteLine("型号是： {1}", siemens_PLC_IP, siemens_PLC_Model);
              
            //用$
            Console.WriteLine($"西门子PLC的IP地址是： {siemens_PLC_IP}型号是： {siemens_PLC_Model}");
            Console.ReadLine();






        }
    }
}
