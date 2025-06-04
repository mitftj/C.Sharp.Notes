using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24字典
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //字典 检索 -----》对应的内容
            //键 key --------value
            //键值对的关系
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                ["产品1"] = "生产的内容是芯片型号：X25686 采取工艺号为：TY12167",
                ["产品2"]="生产的内容是 芯片型号：X87223 采取工艺号为：GB12333",
                  ["产品3"] = "生产的内容是 芯片型号：X87226 采取工艺号为：GT12359"

            };
            dic.Add("产品4", "生产的内容是 芯片型号：X87886 采取工艺号为：CT3459");//添加内容
           List<string> workManShip= dic.Keys.ToList();//获取字典key的集合

            foreach (var item in workManShip)
            {
                Console.WriteLine(item);
            }
            var result=dic.Keys.ToList();

            foreach (var item in result)//获取字典
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dic["产品4"]);

            List<string> guangDong_City= new List<string>{ "广东","深圳","肇庆"};
            List<string> jiangSu_City = new List<string> { "苏州", "昆山", "南京" };
            Dictionary<string, List<string>> dic_City= new Dictionary<string, List<string>>()
            {
                ["广东省"] = guangDong_City,
                ["江苏省"] = jiangSu_City
            };
            List<string> strings = dic_City["广东省"];
            Console.WriteLine(  "--------------------");
            String name = "广东省";
            if (dic_City.ContainsKey (name))
            {
                string possword = dic_City[name][2];
            }
            //怎么增加
            name = "云南";
            List<string> list_string = new List<string>();
            list_string.Add("大理");
            list_string.Add("昆明");
            list_string.Add("怒江");
            dic_City.Add (name, list_string);
            name = "云南省";
            if (dic_City.ContainsKey(name))
            {
                string possword = dic_City[name][2];
            }
            foreach (var item in strings)
            {
                
            }


            dic_City.Add(name, strings);

            Console.WriteLine("请输入您的产品号");
            string ints = Console.ReadLine();

            Console.WriteLine(dic["产品4"]);





        }
    }
}
