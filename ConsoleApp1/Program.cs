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
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

            Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
            
            Console.ReadKey();
        }
    }
}
