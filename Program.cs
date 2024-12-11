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
            //Task 2
            string a = "abc";
            string b = "cba";
            string c = "bac";
            Console.WriteLine($"{a}\n{b}\n{c}");
            string d = a;
            Console.WriteLine("");
            a = b;
            b = c;
            c = d;
            Console.WriteLine($"{a}\n{b}\n{c}");
            Console.ReadKey();
        }
    }
}
