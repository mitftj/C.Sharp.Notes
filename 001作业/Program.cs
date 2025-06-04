using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001作业
{
    #region 人类
    /// <summary>
    /// 人
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Money { get; set; }
        public string Number { get; set; }
    }
    #endregion
    #region 酒店
    /// <summary>
    /// 酒店
    /// </summary>
    public class Hotel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Hotel(Person person)
        {
            this.Name = person.Name;
            this.Id = person.Id;
            Console.WriteLine($"经查证{person.Name}先生您的身份证为{person.Id}欢迎您入住酒店");


        }

    }
    #endregion
    #region 火车
    /// <summary>
    /// 火车
    /// </summary>
    public class Train
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Number { get; set; }
        public Person MyPerson { get; set; }
        public List<Person> Personlist { get; set; } = new List<Person>();
        public Train(Person person)
        {
            MyPerson = person;
        }
        public Train(string name, string id, string number)//
        {
            Name = name;
            Id = id;
            Number = number;
        }
        public void List(Person person)
        {
            if ((this.Name == person.Name) && (this.Id == person.Id))
            {
                Console.WriteLine($"{person.Name}先生欢迎您乘坐火车，您的身份编号为{person.Id}");
            }
            else
            {
                return;
            }

        }

        public void  List1(Person person)
        {
            if ((MyPerson.Name == person.Name) && (MyPerson.Id == person.Id))
            {
                Console.WriteLine($"{person.Name}先生欢迎您乘坐火车，您的身份编号为{person.Id}");
            }
            else
            {
                return;
            }
        }
        public void AddPerson()
        {
            Personlist.Add(MyPerson);
        }
        public void AddPerson(Person person)//方法
        {

            this.Personlist.Add(person);
        }

        // 去 用这个列表去 核对  有没有这个人

        public bool Check(Person person)
        {
            bool result = this.Personlist.Where(c => c.Id == person.Id).Any();

            if (result)
            {
                MyPerson = this.Personlist.Where((c => c.Id == person.Id)).FirstOrDefault();

                return result;
            }
            else
            {
                MyPerson = null;
                return result;
            }


        }

        public void Transport3()
        {

            Console.WriteLine($"把{MyPerson.Name} 身份证号是：{MyPerson.Id} 运输到 目的地 ");
        }
    }
    #endregion
    #region 餐厅
    /// <summary>
    /// 餐厅
    /// </summary>
    public class Restaurant
    {
        public string Name { get; set; }

        public string Money { get; set; }
        public Restaurant(string money)
        {

            this.Money = money;
        }
        public void Transaction(Person person)
        {
            if (this.Money != person.Money)
            {
                return;
            }
            Console.WriteLine($"已支付{person.Money}元,{person.Name}先生祝您就餐愉快");
        }

    }
    #endregion
    #region 电话
    public class Telephone
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public Telephone(Person person, string model)
        {

            this.Model = model;
            this.Number = person.Number;
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args, Person person)
        {
            person.Name = "张三";
            person.Id = "341589200206204658";
            person.Money = "155";
            person.Number = "1555856662807";
            Train train = new Train(person);
            train.List(person);
            Hotel hotel = new Hotel(person);
            Console.WriteLine(hotel);
            Restaurant restaurant = new Restaurant(person.Money);
            restaurant.Transaction(person);
            Telephone telephone = new Telephone(person, "iPhone 13");
            Console.WriteLine($"您正在使用电话型号为: {telephone.Model}的手机给号码: {telephone.Number}打电话");
            Console.ReadLine();
        }
    }
}
