using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    public class RelacionRecurrencia
    {
        public string ResolverEcuacionCaracteristica(double c1, double c2, out double raiz1, out double raiz2, out bool tieneRaicesReales)
        {
            // x^2 - c1x - c2 = 0  =>  a=1, b=-c1, c=-c2
            double a = 1;
            double b = -c1;
            double c = -c2;

            double discriminante = (b * b) - (4 * a * c);

            if (discriminante > 0)
            {
                tieneRaicesReales = true;
                raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                return $"Raíces reales distintas: r1 = {raiz1}, r2 = {raiz2}";
            }
            else if (discriminante == 0)
            {
                tieneRaicesReales = true;
                raiz1 = -b / (2 * a);
                raiz2 = raiz1;
                return $"Raíz real repetida: r = {raiz1}";
            }
            else
            {
                tieneRaicesReales = false;
                raiz1 = 0;
                raiz2 = 0;
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                return $"Raíces complejas: {parteReal} ± {parteImaginaria}i";
            }
        }

        // ===== RELACIÓN HOMOGÉNEA =====
        // Devuelve a(n) usando la solución general con las condiciones iniciales a0 y a1
        public double ResolverHomogenea(double c1, double c2, double a0, double a1, int n)
        {
            double raiz1, raiz2;
            bool tieneRaicesReales;
            ResolverEcuacionCaracteristica(c1, c2, out raiz1, out raiz2, out tieneRaicesReales);

            if (!tieneRaicesReales)
                throw new ArgumentException("Las raíces son complejas; este método solo resuelve el caso de raíces reales.");

            if (raiz1 != raiz2)
            {
                // Caso raíces distintas: a(n) = A*r1^n + B*r2^n
                // Con n=0: A + B = a0
                // Con n=1: A*r1 + B*r2 = a1
                double B = (a1 - raiz1 * a0) / (raiz2 - raiz1);
                double A = a0 - B;

                return A * Math.Pow(raiz1, n) + B * Math.Pow(raiz2, n);
            }
            else
            {
                // Caso raíz repetida: a(n) = (A + B*n)*r^n
                // Con n=0: A = a0
                // Con n=1: (A + B)*r = a1
                double A = a0;
                double B = (a1 / raiz1) - A;

                return (A + B * n) * Math.Pow(raiz1, n);
            }
        }

        // ===== RELACIÓN NO HOMOGÉNEA (con término constante d) =====
        // a(n) = c1*a(n-1) + c2*a(n-2) + d
        // Se calcula término a término (más simple y directo que la solución analítica)
        public double ResolverNoHomogenea(double c1, double c2, double d, double a0, double a1, int n)
        {
            if (n == 0) return a0;
            if (n == 1) return a1;

            double anterior2 = a0;
            double anterior1 = a1;
            double actual = 0;

            for (int i = 2; i <= n; i++)
            {
                actual = c1 * anterior1 + c2 * anterior2 + d;
                anterior2 = anterior1;
                anterior1 = actual;
            }

            return actual;
        }
    }
}
