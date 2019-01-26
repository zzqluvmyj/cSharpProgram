using System;
using System.Windows.Forms;
namespace cSharpAdvanced.Operator
{
    class newSample
    {
        static void Main(string[] args)
        {
            //var x = 100;
            //var y = 100L;
            //var z = 100D;

            //Console.WriteLine(x.GetType().Name);
            //Console.WriteLine(y.GetType().Name);
            //Console.WriteLine(z.GetType().Name);


            Form myform = new Form() {
                Text="Hello",
                FormBorderStyle=FormBorderStyle.SizableToolWindow
            };//实例的初始化器
            //声明实例后,如果没有引用变量引用,将会被垃圾回收机制回收

            //string是类类型,但是不用new,把new操作符给隐藏了,感觉比java更加智能一点
            //类似的有数组类型

            //匿名类型
            //var person = new { Name = "Tom" };
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.GetType().Name);
           
            //myform.ShowDialog();

        }

    }
    class Student
    {
         public void Report()
        {
            Console.WriteLine("I am a student");
        }
    }
    class CsStudent:Student
    {
    }
}
