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
            string msg = string.Format(@"{'IsDing':false,'IsInput':false,'Id':null,'Type':2,'From':{'Id':{0},'Name':'Kenny.Lee','Type':0},'To':'','DingCount':0,'HeadImg':'https://stream-cdn.weikebang.com/headimgs/40405','sdaf':'qe qwe','Top':false,'Data':'老郑不要玻璃心 哈哈','Reply':null,'IsReply':false}",1);
         
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
