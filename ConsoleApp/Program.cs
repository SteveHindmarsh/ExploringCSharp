using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Enumerator enumerator = new Enumerator();
            foreach (int i in enumerator.Calculate())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            YieldClient yc = new YieldClient();

            foreach (int i in yc.All)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (int i in yc.Filter)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (int i in yc.FilterWithRetainedLocalStatus)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach (int i in yc.Power)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

    }
}
