using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28类的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "唐三";

            //person.Study();
            //person.Eat();
            //person.Drink();
            person.Add(10, 20);

           int e= person.Add1(1, 2, 3);
            Console.ReadLine();
            int.TryParse(Console.ReadLine(), out e);
            Console.WriteLine("请输入你要旅行的城市 ;隔开");
           string addr= Console.ReadLine();

          List<string> result=  person.TravelAddress(addr);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }








        }
    }
    public class Person
    {
        //静态特征
        public int Age { get; set; } //成员变量
        public string Name { get; set; }
        public int MyId { get; set; }

        //动态特征 他能够干什么--方法就是功能---用方法来描述
        //1.能吃 功能 方法 函数

        //访问修饰符+有无返回值（没有返回值用void）+方法名称+()----大驼峰命名法
        //1.没有返回值 也不带参数

        /// <summary>
        ///     表示能吃的方法
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("能吃饭");
            Digestion();

        }
        public void Drink()
        {
            Console.WriteLine("能喝水");
            Digestion();
        }
        private void Digestion()
        {
            Console.WriteLine("开始消化");
            Console.WriteLine("等待两个小时");
            Console.WriteLine("消化完毕");
        }
        /// <summary>
        /// 表示学习的方法
        /// </summary>
        public void Study()
        {
            Console.WriteLine("我是"+this.Name);//this指当前的对象
            Console.WriteLine( "能学习");
        }

        //有加法的功能
        public void Add(int a,int b)//带参数 没有返回值 a，b，叫形式参数--形参
        {
            int c = a + b;//c 局部变量

            Console.WriteLine(c);
        }

        public int Add1(int a, int b,int c)//带参数 有返回值 
        {
            int d = c + a + b;//c 局部变量
            return d;
            
        }
        public List<string > TravelAddress(string address)
        {
            //上海;广东;北京
            
          var reult=  address.Split(';').ToList();
            return reult;
        }
        public string GetMyInfor()
        {
            this.Age = 30;
            this.MyId = 1357924;

          string ate= "姓名"+this.Name +"年龄"+this.Age.ToString()+"身份证号" + this.MyId.ToString();
            return ate;
        }
    }
}

