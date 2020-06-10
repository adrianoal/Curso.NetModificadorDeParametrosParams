using System;

namespace ModificadorDeParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando calculadora de soma:

            int s0 = CalculadoraSoma.Sum(5);
            int s1 = CalculadoraSoma.Sum(2, 3);
            int s2 = CalculadoraSoma.Sum(2, 4, 3);

            Console.WriteLine(s0);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
