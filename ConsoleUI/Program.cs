using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.NumberExtenion;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enther a number");
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The nearest biggest number for number " + n.ToString() + " is " + FindNearWrapper(n));
            Console.WriteLine();
        }
    }
}
