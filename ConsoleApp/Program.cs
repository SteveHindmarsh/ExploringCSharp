using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            YieldServer ys = new YieldServer();

            foreach (int i in ys.All())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (int i in ys.Filter(3))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (int i in ys.FilterWithStatus(3, 4))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

    }
}
