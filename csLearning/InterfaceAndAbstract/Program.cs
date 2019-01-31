using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Run();
            Trunk t = new Trunk();
            t.Run();
        }
    }
    interface IVehicle
    {
        void Run();
        void Stop();
        void Fill();
    }
    abstract class Vehicle:IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("stop!");
        }
        public abstract void Run();
        public void Fill()
        {
            Console.WriteLine("pay and fill");
        }
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is runing...");
        }
    }
    class Trunk : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("trunk is runing...");
        }
    }
}
