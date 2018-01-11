using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public void SetStr(string str)
        {
            str = "bbb";
        }


        static void Main(string[] args)
        {
            //string str = "aaa";
            //Program p = new Program();
            //p.SetStr(str);
            //Console.WriteLine(str);


            StringBuilder sb = new StringBuilder();
            DateTime dt2 = DateTime.Now;
            for (int i = 0; i < 200000; i++)
            {
                sb.Append("aaaaa");
            }
            string str2 = sb.ToString();
            Console.WriteLine((DateTime.Now - dt2).TotalMilliseconds);


            DateTime dt = DateTime.Now;
            string str = "";
            for (int i = 0; i < 200000; i++)
            {
                str += "aaaaa";
            }
            Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


            Console.ReadLine();
            //字符串是引用类型 ，  字符串是一个特殊的引用类型    需要大量拼接字符串需要怎么优化


        }
    }
}
