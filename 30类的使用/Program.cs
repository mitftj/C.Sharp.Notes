using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30类的使用
{
    //人和手机  人要拨打电话
   
    internal class Program
    {
        static void Main(string[] args)
        {
            person person=new person("张三");
            Phone phone = new Phone("华为");
            person.Call("15955833541", phone);

        }
    }
    public class person
    {
        public string Name {  get; set; }
        public person(string name)
        {
            Name = name;
        }

        public void Call(string num,Phone phone)
        {
            Console.WriteLine("我是："+Name);
            phone.Transfer(num);
        }
    }
    public class Phone
    {
        private string name;
        public string Namb { get; set; }
        public  List<string> List { get; set; } = new List<string>();
        public Phone(string a)
        {
            name = a;
        }

        public void Transfer(string num)
        {
            Namb=num;
            List.Add(Namb);
            Console.WriteLine($"您正在使用{name}品牌手机，正在拨打{num}号码");
        }
    }
}
