using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string x = "abc";
            string y = "cba";
            Console.WriteLine($"{x}\n{y}");
            string c = x;
            Console.WriteLine("");
            x = y;
            y = c;
            Console.WriteLine($"{x}\n{y}");
            Console.ReadKey();
        }
    }
}
