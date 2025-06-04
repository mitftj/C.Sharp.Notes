using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_23集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList  //集合
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 18, 17, 19, 21, 20, 24 };
            ArrayList list = new ArrayList();
            list.Add(num);//把一维数组添加到集合-------作为集合的一个元素
            list.Add("A");//把字符串添加到集合
            list.AddRange(num);//把一维数组中的所有元素添加到集合





            #endregion
            Console.ReadKey();
         }
    }
}
