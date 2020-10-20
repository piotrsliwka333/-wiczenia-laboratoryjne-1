using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main()
        {
            var zad12 = new Zad12();
            zad12.SayHello();

            var zad13 = new Zad13();
            zad13.StopConsoleUntilPressKey();

            /*
            var zad14 = new Zad14();
            zad14.CheckIfWeCanDebugComments();
            */

            var zad15 = new Zad15();
            zad15.WorkingWithNumbers();
        }
    }
}
