using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11条件分支语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //假设 有三个设备   PLC    KUKA机器人 海康相机
            //1.PLC走串口通讯
            //2.KUKA机器人走网口
            //3.海康相机走网口
            Console.WriteLine("切换当前设备 目前设备如下：PLC    KUKA机器人 海康相机");
            Console.WriteLine("请输入切换设备名称");
            string machineName=Console.ReadLine();
            Console.WriteLine($"你切换成的设备名称是：{machineName}");
            //
            switch (machineName)
            {
                case "PLC":
                    Console.WriteLine("PLC走串口通信");
                    break;//跳出语句
                case "KUKA机器人":
                    Console.WriteLine("KUKA机器人走网口通信");
                    break;//跳出语句
                case "海康相机":
                    Console.WriteLine("海康相机走网口通信");
                    break;//跳出语句
                default:
                    Console.WriteLine("未查找到当前设备");
                    break;
            }









        }
    }
}
