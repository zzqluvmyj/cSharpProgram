using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            Human human = new Human();
            Teacher teacher = new Teacher();


            //is as使用
            var r = human is Animal;
            Console.WriteLine(r);

            var r1 = animal as Teacher;
            if (r1 == null)
            {
                Console.WriteLine("Can't conversion");
            }


            //显式类型转换
            //1.cast形式
            uint x = 60000;
            ushort y = (ushort)x;
            Console.WriteLine(y);

            //2.Convert类
            y=Convert.ToUInt16(x);
            string z = Convert.ToString(y);

            //3.parse 只能解析正确的数据格式  tryparse
            //适用于将字符串转换为数据
            double n = double.Parse("435345");

            //4.非继承类之间的转换,这是显式转换的后台秘密
            Stone s = new Stone();
            s.Age = 5000;
            Monkey m = (Monkey)s;
            Console.WriteLine(m.Age);
            //explicit关键字的作用是强制转换用户自定义的类型转换运算符。
            //通常前面用static后免用operator,一般是把当前类型转换成另一个类型（将原类型的转换成目标类型）


        }

    }
    class Stone
    {
        public int Age;
        public static explicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }       
    }
    class Monkey
    {
        public int Age;
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who am I");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I can teach");
        }
    }
}
