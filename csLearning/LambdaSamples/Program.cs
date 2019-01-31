using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = (int a, int b) => a + b;
            //只有一个返回语句可以省略return,只有一个参数可以省略()
            Console.WriteLine(func(3,7));
            Print<int>((int a, int b) => a + b,10,90);
        }
        static void Print<T>(Func<T,T,T> func,T x,T y)
        {
            T res = func(x, y);
            Console.WriteLine(res);
        }
    }
}
