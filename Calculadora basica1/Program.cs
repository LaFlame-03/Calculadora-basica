using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_basica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora_basica";
            Console.WriteLine("      \t\t\t\tCalculadora Básica        ");


            double valor1 = 0, valor2 = 0, resultado;
            string operador, valorDigitado;
            bool ÉNumero;

            Console.Write("Digite o 1º valor: ");
             valorDigitado = Console.ReadLine();
            //VERIFICA SE É UM NUMERO, O _ descarta se for o contrario de double
            ÉNumero = double.TryParse(valorDigitado, out _ );
            //FAZ A VALIDAÇÃO
            if (ÉNumero)
            {
                //Converte ao valor1, o  1 seria referencia de nº ao "out"
                valor1 = Math.Round(double.Parse(valorDigitado));
            }
            else
            {
                Console.WriteLine($"Isso '{valorDigitado}' é um numero por acaso?");
            }
            
                Console.Write("Digite a operação:" );
                operador = Console.ReadLine();

            Console.Write("Digite o 2º valor: ");
            valorDigitado = Console.ReadLine();
            ÉNumero = double.TryParse(valorDigitado, out _ );
            if (ÉNumero)
            {
                //Converte ao valor2
                valor2 = Math.Round(double.Parse(valorDigitado), 1);
            }
            else
            {
                Console.WriteLine($"Isso '{valorDigitado}' é um numero por acaso?");
            }
            
            switch (operador)
            {
                case ("+"):
                    resultado = Math.Round(valor1 + valor2, 1);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case ("-"):
                    resultado = Math.Round(valor1 - valor2, 1);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case ("*"):
                    resultado = Math.Round(valor1 * valor2, 1);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case ("/"):
                    resultado = Math.Round(valor1 / valor2, 1);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;
                case ("%"):
                    resultado = Math.Round(valor1 % valor2, 1);
                    Console.WriteLine($"{ valor1 } {'%'} { valor2 } = {resultado}");
                    break;
                default:
                    Console.WriteLine($"Isso '{operador}' é um operador por acaso ?");
                    break;
            }

            
            Console.ReadKey();

        }
    }
}
