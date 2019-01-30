using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //传值参数
            //Student stu = new Student("Tim");
            //Print(stu);
            //Console.WriteLine("{0:D},{1:D}", stu.GetHashCode(), stu.Name);

            //引用参数
            //int x = 10;
            //ADDone(ref x);
            //Console.WriteLine(x);


            //输出参数
            //Console.WriteLine("input a number");
            //string arg = Console.ReadLine();
            //double x = 0;
            //bool b = double.TryParse(arg, out x);
            //if (b == false)
            //{
            //    Console.WriteLine("input error");
            //}
            //double r;
            //if(DoubleParse("34qs5",out r))
            //Console.WriteLine(r);
            //else Console.WriteLine("parse fail!");

            //数组参数
            Console.WriteLine(Sum(1,2,3));
            Console.WriteLine("{0},{1},{2}",23,43,45);
            string str = "a,b:c;d!d";
            string[] result=str.Split(',', ':', ';', '!');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //扩展方法,为double类型添加扩展方法
            double x = 3.1234535;
            x.Round(4);//Round的第一个参数就是x


        }


        //数组参数
        static int Sum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }


        //自己实现的tryParse
        static bool DoubleParse(string input,out double r)
        {
            try
            {
                r = double.Parse(input);
                return true;
            }
            catch
            {
                r = 0;
                return false;
            }
        }

        //引用参数  直接传引用的地址
        static void ADDone(ref int x)
        {
            x++;
            Console.WriteLine(x);
        }


        //传值参数-传引用类型时复制到形参的是引用的地址
        //传值的时候是复制到形参的时候会在栈中开辟新的值类型的空间
        //值类型在栈分配空间,引用类型在堆分配空间.
        public static void Print(Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("{0:D},{1:D}",stu.GetHashCode(),stu.Name);
        }
    }

    //扩展方法
    static class DoubleExtension
    {
        public static double Round(this double input,int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }


    //输出参数
    class StuentFactory
    {
        public static bool Create(string name,int age,out Student stu)
        {
            stu = null;
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (age < 20 || age > 80)
            {
                return false;
            }
            stu = new Student(name,age);
            return true;
        }
    }
    class Student
    {
        private string name;
        private int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Student(string name,int age)
        {
            this.name = name;
            this.Age = age;
        }
    }
}
