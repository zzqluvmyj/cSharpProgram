using System;

namespace CheckSamples
{
    class CheckSamples
    {
        public void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string str = Convert.ToString(x, 2);
            Console.WriteLine(str);

            //默认无法抛出溢出异常,必须通过checked
            //unchecked和checked相反
            checked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("overflowexception!");
                }
            }
        }

    }
}
