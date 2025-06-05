using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34接口
{
    /// <summary>
    /// 三角叉头接口
    /// </summary>
    public interface ITriangularPlug
    {
        //private int num = 3;//是契约不能实列
        int Length {  get; set; }//不能写public 也不能赋值
       void GenPow();//不能写public 也不能实现
        string Name {  get; set; }

    }
    /// <summary>
    /// wifi接口
    /// </summary>
    public interface IWiFi
    {
        string IpAdress {  get; set; }
        void Communication(string ip);
    }
    #region 电脑
    /// <summary>
    /// 电脑
    /// </summary>
    public class Computer : ITriangularPlug, IWiFi
    {

        public int Length { get; set; } = 3;

        public string Name { get; set; } = "华为电脑";
        public string IpAdress { get; set ; }

        public void Communication(string ip)
        {
            Console.WriteLine($"电脑正在使用{ip}的ip接口");
        }

        public void GenPow()
        {
            Console.WriteLine("给华为电脑提供");
        }
    }
    #endregion
    #region 空调
    /// <summary>
    /// 空调
    /// </summary>
    public class GreeAirConditioner : ITriangularPlug, IWiFi
    {
        public int Length { get; set; }
        public string Name { get; set; }
        public string IpAdress { get; set; }

        public void Communication(string ip)
        {
            Console.WriteLine($"空调正在使用{ip}的ip接口");
        }

        public void GenPow()
        {
            Console.WriteLine("能给格力空调提供");
        }
    }

    #endregion
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ITriangularPlug triangularPlug = new GreeAirConditioner();//多态接口 对象=实现类的实列
            ITriangularPlug triangularPlug1 = new Computer();
            List<ITriangularPlug> list = new List<ITriangularPlug>();
            list.Add(triangularPlug1);  
            list.Add(triangularPlug);
             
           
            List<IWiFi>iwif= new List<IWiFi>();
            IWiFi iwiFi1 = new Computer();
            IWiFi iwiFi2 = new GreeAirConditioner();
            ITriangularPlug triangular = new Computer();
            IWiFi wiFi =(IWiFi)triangularPlug;//强制转换调用
            wiFi.Communication("192.168.1.10");
            foreach (var item in list)
            {
                item.GenPow();
                IWiFi dd=(IWiFi)item;
                dd.Communication("119921668.1.10");
            }


        }
    }
}
