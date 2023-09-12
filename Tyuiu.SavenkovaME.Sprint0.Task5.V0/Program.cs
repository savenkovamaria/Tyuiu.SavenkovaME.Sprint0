using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SavenkovaME.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 3));
            Console.WriteLine("A * B = " + DataService.Multiplication(6, 3));
            Console.WriteLine("A / B = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
