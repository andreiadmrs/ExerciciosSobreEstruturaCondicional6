using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaCondicional6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.            */

            Console.WriteLine("Digite um número: ");

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1<0.0 || n1>100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (n1<=25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n1<=50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n1<=75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
    

