using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do fatorial");

            Console.WriteLine("Introduza um número");
            string s = Console.ReadLine();
            int n = int.Parse(s);

            if (n < 0)
            {
                Console.WriteLine("O número deve ser positivo");
                return;
            }

            double factorial = 1;

            int i = 2;
            while (i <= n)

            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"{n}! = {factorial:0.#}");
        }
    }
}