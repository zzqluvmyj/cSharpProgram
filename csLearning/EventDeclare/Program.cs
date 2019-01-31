using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//事件的自定义声明
//事件是用委托实现的
namespace EventDeclare
{
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();//事件拥有者
            Waiter waiter = new Waiter();//事件处理者

            customer.Order += waiter.Action;//订阅事件
            customer.Think();//触发事件
            customer.PayTheBill();//验证事件处理者对事件进行了处理
        }


    }
    public class Customer
    {
        //事件订阅的声明,看谁订阅了该事件,通过+=符号订阅

        public EventHandler Order;
        //简化写法,不用自己写明委托声明
        //private OrderEventHandler orderEventHandler;
        //public event OrderEventHandler Order
        //{
        //    add
        //    {
        //        this.orderEventHandler += value;
        //    }
        //    remove
        //    {
        //        this.orderEventHandler -= value;
        //    }
        //}



        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}",this.Bill);
        }

        //事件发生
        //public void Think()
        //{
        //    Console.WriteLine("Let me think..");
        //    if (this.Order != null)
        //    {
        //        OrderEventArgs e = new OrderEventArgs();
        //        e.DishName = "dsg";
        //        e.Size = "large";
        //        this.Order.Invoke(this,e);
        //    }
        //}
        //简化写法
        public void Think()
        {
            Console.WriteLine("Let me think..");
            this.OnOrder("5te","large");
        }
        protected void OnOrder(string dishname,string size)
        {
            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishname;
                e.Size = size;
                this.Order.Invoke(this, e);
            }
        }
    }

    //事件的传递的参数,需要继承
    public class OrderEventArgs:EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }
    public class Waiter
    {

        //简写
        public void Action(object o,EventArgs ev)
        {
            Customer customer = o as Customer;
            OrderEventArgs e = ev as OrderEventArgs;
            Console.WriteLine("I will server you,{0}", e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;

            }
            customer.Bill += price;
        }

        //internal void Action(Customer customer, OrderEventArgs e)
        //{
        //    Console.WriteLine("I will server you,{0}",e.DishName);
        //    double price = 10;
        //    switch (e.Size)
        //    {
        //        case "small":
        //            price = price * 0.5;
        //            break;
        //        case "large":
        //            price = price * 1.5;
        //            break;
        //        default:
        //            break;

        //    }
        //    customer.Bill += price;
        //}
    }
}
