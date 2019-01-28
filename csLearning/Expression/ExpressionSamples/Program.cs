using System.Windows.Forms;
using System;

namespace ExpressionSamples
{
    class Student
    {
        //propfull
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
    class Program
    {
        enum Level
        {
            HIGH,MID,LOW
        }
        static void Main(string[] args)
        {
            //Form myform = new Form();
            //myform.Text = "Hello";
            //myform.Load += myform_load;
            //myform.ShowDialog();

            //int a = 3;
            //hello:
            //    {
            //        if (a > 0) Console.WriteLine(a);
            //        a--;
            //        goto hello;
            //    }
            int a = 0;
            try
            {
                a=int.Parse("890989098098789789789789");
            }
            catch (ArgumentNullException e3)
            {
                Console.WriteLine(e3.Message);
            }
            catch (ArgumentException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (FormatException e2)
            {
                //Console.WriteLine(e2.Message);
                throw e2;
                //谁调用谁处理抛出的错误
            }
            finally
            {

            }
        }
        //object sender是事件的产生者,进入事件方法后需要转换
        //详细的事件处理在见后面学习
        public static void myform_load(object sender,EventArgs e)
        {
            Form form = sender as Form;
            if (form == null)
            {
                return;
            }
            form.Text = "New title";
        }
    }
}
