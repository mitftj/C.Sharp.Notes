using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29类的方法02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();//类的给构造方法
            person.Add(1, 2);
            //10 中国
            Person person2 = new Person(10,"中国");
            Person perso3 = new Person(8, "美国");
            //8 美国

            Console.WriteLine();
            person.City = "美国";

        }
    }
    public class Person
    {

        private int weight;
        private int NumID = 123456;
        public string Adress { get; set; }

        public string City { get; set; }
        //方法的重载 ----重名的方法（相同的方法名字）载入不同的参数类型
        //与返回值无关  目的是便于方法的管理规范
        #region 方法的重载
        public void Add()
        {
            Console.WriteLine("没有参数的加法");


        }

        public void Add(int a)
        {
            Console.WriteLine(a + 10);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        #endregion
        //类的构造方法
        //访问修饰符 +类名（） 有无参数   系统会给你一个无参数的构造
        //没有   返回值  或者有返回值 这一说
        public Person()
        {
            weight = 10;
            Eat();
            City = "中国";
        }
        public void Eat()
        {
            Console.WriteLine("干饭");

        }
        /// <summary>
        /// 构造重载---带参数的--体重--国籍
        /// </summary>
        /// <param name="w">体重</param>
        /// <param name="city">国籍</param>
        public Person(int w,string city)
        {
            weight = w;
            this.City = city;
            Eat();
        }
        private void GetCtiy()
        {
            Console.WriteLine();
        }
    }
}
