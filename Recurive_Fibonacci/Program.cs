using System;

namespace Recurive_Fibonacci
{
    public static class Recursive
    {

        public static int Fibo(this int param)
        {
            if(param<2)
            {
                return param;

            }
            else
            {
                return Fibo(param - 1) + Fibo(param - 2);

            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
              Console.WriteLine(i.Fibo());
            }
            Console.Read();
        }
    }
}
