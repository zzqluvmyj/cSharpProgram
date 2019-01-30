using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateSamples
{
    //自定义委托
    public delegate int Calc(int x, int y); 


    class Program
    {
        static void Main(string[] args)
        {
            ////已有的委托
            //Calculator calculator = new Calculator();
            //Action action = new Action(calculator.Report);//委托
            //calculator.Report();
            //action.Invoke();
            //action();
            ////已有的委托
            //Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            //Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);
            //Console.WriteLine(func1(1,2));
            //Console.WriteLine(func2(2,3));
            
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            Calc calc = calculator.Add;

            Console.WriteLine(calc(3,7));

            Console.WriteLine(calc1(3,7));
            Console.WriteLine(calc2(3, 7));
            Console.WriteLine(calc3(3, 7));
            Console.WriteLine(calc4(3, 7));

        }
    }








    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("Hello");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
