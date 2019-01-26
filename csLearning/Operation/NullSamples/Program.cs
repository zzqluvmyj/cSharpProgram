using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //x = null;
            /*值类型不能赋值为null*/

            //解决方法
            Nullable<int> x = null;
            Console.WriteLine(x);

            //等同于
            int? y = null;
            Console.WriteLine(y);
            y = 10;

            //null合并操作符,当y为空,赋值为后面的值,不为空,则为y值
            int z = y ?? 20;
            Console.WriteLine(z);
            

        }
    }
}
