using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _000作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //人  属性"" 姓名 身份证 钱
            //方法 坐火车 住酒店  吃饭 20元  打电话 号 人
            //类 火车    酒店  饭店  手机
            Person person = new Person();

            person.Name = "张三";

            person.Money = 20;

            person.Icord = "15955833131313";

            Train train = new Train(person.Name, person.Icord);

        }

    }
    //1.预定火车，火车需要把预定的人放到列表之中

    //人类
    public class Person
    {
        public string Name { get; set; }
        public string Icord { get; set; }
        public int Money { get; set; }
    }
    public class Train
    {
        public string Name { get; set; }
        public string Icord { get; set; }
        public Train(string name, string icord)
        {
            this.Name = name;
            this.Icord = icord;
        }

        public void Transportation(Person person)

        {
            if (!(this.Name == person.Name) && !(this.Icord == person.Icord))
            {
                return;
            }

            Console.WriteLine($"把{person.Name}运输到目的地,身份证号是{person.Icord}，运输到目的地");
        }

    }
    public class Hotel
    {
        public string Name { get; set; }
        public string Icord { get; set; }
        public Hotel(string name,string icord)
        {
            this.Name = name;
            this.Icord = icord;
        }
        public void Stay(Person person)
        {

            if (!(this.Name == person.Name) && !(this.Icord == person.Icord))
            {
                return;
            }
            Console.WriteLine($"把{person.Name}运输到目的地,身份证号是{person.Icord}，运输到目的地");
        }
    }
}
