using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出一个Josn字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string json1 = string.Format("{'Name':'{0}'}", 1);
            Console.WriteLine(json1);
            Console.ReadKey();
        }
    }
}
