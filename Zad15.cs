using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class Zad15
    {
        public void WorkingWithNumbers()
        {
            Console.WriteLine("");
            Console.WriteLine("Zad 15");

            int a = 10;
            short b = 32100;
            ushort c = 65000;

            // addition
            int result1 = a + b;
            Console.WriteLine($"Result {a} + {b} = {result1}");

            // subtraction
            int result2 = c - b;
            Console.WriteLine($"Result {c} - {b} = {result2}");

            // multiplication
            int result3 = c * a;
            Console.WriteLine($"Result {c} * {a} = {result3}");

            // division
            int result4 = c / a;
            Console.WriteLine($"Result {c} / {a} = {result4}");

        }

    }
}
