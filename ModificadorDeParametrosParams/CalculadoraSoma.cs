using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace ModificadorDeParametrosParams
{
    class CalculadoraSoma
    {
        // Metodo:
        public static int Sum(params int[] numero)
        {
            int sum = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                sum += numero[i];
            }
            return sum;
        }
    }
}
