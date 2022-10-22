using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\t\t\t\t\t O  numero é positivo ou negativo?");
            
            bool senumero;
            string Valordigitado;
            double n = 0;

            Console.WriteLine("Digite o numero");
            Valordigitado = Console.ReadLine();
            
            senumero = double.TryParse(Valordigitado, out _);

            if (senumero)
            {
                n = Math.Round(double.Parse(Valordigitado));
            }
            else
            { 
                Console.WriteLine("digite um numero!");
            }
                if (n > 0)
                {
                    Console.WriteLine("o Numero é Positivo");
                }
                    if (n == 0)
                    {
                         Console.Write("neutro");
                    }
                        if (n < 0)
                        {
                            Console.WriteLine("O numero é Negativo");
                        }    
            Console.ReadKey();
            

        }
    }
}
            
            
        

