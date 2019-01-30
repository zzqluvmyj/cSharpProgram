using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateApplication
{
    class Program
    {

        //委托的模板方法使用
        //回调方法使用
        //action<>没有返回值
        static void Main(string[] args)
        {
            ProductFactory p = new ProductFactory();
            WrapFactory w = new WrapFactory();

            Func<Procuct> func1 = new Func<Procuct>(p.MakePizza);
            Func<Procuct> func2 = new Func<Procuct>(p.MakeToyCar);

            Logger logger = new Logger();

            Action<Procuct> log = new Action<Procuct>(logger.Log);

            Box box1 = w.WrapProdect(func1,log);
            Box box2 = w.WrapProdect(func2,log);

            Console.WriteLine(box1.Procuct.Name);
            Console.WriteLine(box2.Procuct.Name);
        }   
    }
    class Logger
    {
        public void Log(Procuct product)
        {
            Console.WriteLine("Procduct {0} created at {1},price is {2}",product.Name,DateTime.UtcNow,product.Price);
        }
    }
    class Procuct
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Box
    {
        public Procuct Procuct { get; set; }
    }
    class WrapFactory
    {
        public Box WrapProdect(Func<Procuct> getProduct,Action<Procuct> logCallback)
        {
            Box box = new Box();
            Procuct procuct = getProduct();
            box.Procuct = procuct;
            logCallback(procuct);
            return box;
        }
    }

    class ProductFactory
    {
        public Procuct MakePizza()
        {
            Procuct procuct = new Procuct();
            procuct.Name = "Pizza";
            return procuct;
        }
        public Procuct MakeToyCar()
        {
            Procuct procuct = new Procuct();
            procuct.Name = "Toy car";
            return procuct;
        }
    }


}
