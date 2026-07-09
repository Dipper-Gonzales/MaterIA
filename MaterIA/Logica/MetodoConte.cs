using System;
using System.Collections.Generic;
using System.Text;

namespace TuProyecto.Logica
{
    public static class MetodoConteo
    {
       
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n debe ser mayor o igual a 0");

            long resultado = 1;

            for (int i = 2; i <= n; i++)
                resultado *= i;

            return resultado;
        }

        
        public static long Permutacion(int n)
        {
            return Factorial(n);
        }

       
        public static long Variacion(int n, int r)
        {
            if (r > n)
                throw new ArgumentException("r no puede ser mayor que n");

            return Factorial(n) / Factorial(n - r);
        }

       
        public static long VariacionConRepeticion(int n, int r)
        {
            return (long)Math.Pow(n, r);
        }

        public static long Combinacion(int n, int r)
        {
            if (r > n)
                throw new ArgumentException("r no puede ser mayor que n");

            return Factorial(n) /
                  (Factorial(r) * Factorial(n - r));
        }
    }
}