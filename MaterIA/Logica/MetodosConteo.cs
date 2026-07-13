using System;

namespace MaterIA.Logica
{
    public class MetodosConteo
    {
        public double Combinaciones(int n, int r)
        {
            if (r > n || r < 0 || n < 0)
                throw new ArgumentException("Los valores no son válidos: r no puede ser mayor que n, y ambos deben ser positivos.");

            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        
        public double Permutaciones(int n, int r)
        {
            if (r > n || r < 0 || n < 0)
                throw new ArgumentException("Los valores no son válidos: r no puede ser mayor que n, y ambos deben ser positivos.");

            return Factorial(n) / Factorial(n - r);
        }

        private double Factorial(int n)
        {
            double resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
        // Variaciones: V(n,r) = n! / (n-r)!
        public double Variaciones(int n, int r)
        {
            if (r > n || r < 0 || n < 0)
                throw new ArgumentException("Los valores no son válidos: r no puede ser mayor que n, y ambos deben ser positivos.");

            return Factorial(n) / Factorial(n - r);
        }
        // Permutaciones simples: P(n) = n!  (usa TODOS los elementos, el orden importa)
        public double PermutacionesSimple(int n)
        {
            if (n < 0)
                throw new ArgumentException("El valor de n debe ser positivo.");

            return Factorial(n);
        }

    }
}