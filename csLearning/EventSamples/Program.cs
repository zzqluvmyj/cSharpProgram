using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace EventSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件拥有者
            timer.Interval = 1000;
            Boy boy = new Boy();//事件处理者
            Girl girl = new Girl();
            timer.Elapsed += boy.Action;//事件和订阅
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }

    }
    class Boy
    {
        //事件处理器
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump");
        }
    }
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing");
        }
    }
}
