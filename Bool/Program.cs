using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checar = true;
            Console.WriteLine(checar ? "checado" : "não verificado");  // output: checado

            Console.WriteLine(false ? "checado" : "não verificado");  // output: não verificado

            Console.ReadKey();
        }
    }
}
