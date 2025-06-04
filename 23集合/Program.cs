using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23集合
{
    internal class Program
    {
        public enum MachineStates
        {
            Intite,
            Start,
            Pause,
            Resuse,
            Exit
        }
        static void Main(string[] args)
        {
            //泛型集合LIst
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//固定大小
            int[] ints1 = new int[9];
            //升级到集合   泛型 List<T>
            //具体是什莫类型的集合 是你自己与用的时候再确定是什么
            //也就决定了你的集合元素是什么类型
            List<int> list = new List<int>();//集合是引用类型
            List<int> list1 = new List<int>() { 1, 2 };//{}集合初始化器
            list.Add(10);//添加新元素
            list.Add(11);//添加新元素
            list.Add(12);//添加新元素
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list[0] = 200;//索引改值
            list.Remove(300);//移除数据
            list.RemoveAt(1);//按照索引移除
            list.RemoveAll(a => a < 13);//goes to 指向 //按照一定的条件移除



            foreach (int i in list)
            {
                Console.WriteLine("获取大小是" + i);//显示集合大小
            }

            Console.WriteLine("获取大小是" + list.Count);//显示集合大小

            List<string> strings = new List<string>();
            strings.Add("PLC1200_Smart");
            strings.Add("PLC1200_工序1");
            strings.Add("PLC1500");
            //请输入您的设备名称添加至列表之中
            strings.Contains("a");
            string name = "PLC1200_工序1";
            if (strings.Contains(name))
            {
                Console.WriteLine("该设备已存在，请重新输入");
            }
            else
            {
                strings.Add(name);
                Console.WriteLine("设备添加成功");
            }
            int m = strings.IndexOf("PLC1200_工序1");//索引元素中的位置

            strings.Insert(1, "三菱FX3U"); //插入

            strings.Clear();//清空

            strings.AddRange(strings);//添加集合
            //数组转集合集合转数组
            string[] strings2 = strings.ToArray();//数组转集合
            List<string> nemName = strings.ToList();//集合转数组
            foreach (var item in strings)
            {
                Console.WriteLine("设备名称：" + item);
            }


            Console.WriteLine("stirings的大小1是：" + strings.Count);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            //查询集合
            List<int> lints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            List<int> lint3 = lints.Where(c => c >= 5 && c <= 8).ToList();
            foreach (var item in lint3)
            {
                Console.WriteLine(item);
            }

            List<int> int01 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> int02 = new List<int>() { 1, 2, 3, 4, 9 };
            List<int> int03 = new List<int>() { 1, 2, 3, 4, 410 };
            List<int> int04 = new List<int>() { 1, 2, 3, 4, 30 };
            List<int> int05 = new List<int>() { 1, 2, 3, 4, 20 };
            List<int> int06 = new List<int>() { 1, 2, 3, 4, 15 };
            List<int> int07 = new List<int>() { 1, 2, 3, 4, 15 };

            List<List<int>> ints2 = new List<List<int>>()
            {
                int01,int02,int03,int04,int05,int06,int07

            };
            int cc = ints2[1][3];
            Console.WriteLine("------------------------------------");
            //集合的排序
            List<int> intss = new List<int>() { 1, 5, 9, 4, 8, 7, 2, 6, 3 };
            intss.Sort();//集合排序
            intss.Reverse();//翻转
            foreach (var item in intss)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Type type= typeof(string);
            Type type1 = typeof(MachineStates);
           
            Console.WriteLine(type1.Name);
           string[]strings0= Enum.GetNames(type1); //数组转集合
            var result= strings0.ToList();





        }
    }
}
