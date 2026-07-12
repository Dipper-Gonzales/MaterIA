using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    internal class SerieTaylor
    {
        public double CalcularExponencial(double x, int terminos)
        {
            double suma = 0;
            for (int n = 0; n < terminos; n++)
            {
                suma += Math.Pow(x, n) / Factorial(n);
            }
            return suma;
        }

        public double CalcularSeno(double x, int terminos)
        {
            double suma = 0;
            for (int n = 0; n < terminos; n++)
            {
                int exponente = 2 * n + 1;
                double signo = Math.Pow(-1, n);
                suma += signo * Math.Pow(x, exponente) / Factorial(exponente);
            }
            return suma;
        }

        public double CalcularCoseno(double x, int terminos)
        {
            double suma = 0;
            for (int n = 0; n < terminos; n++)
            {
                int exponente = 2 * n;
                double signo = Math.Pow(-1, n);
                suma += signo * Math.Pow(x, exponente) / Factorial(exponente);
            }
            return suma;
        }

        public double CalcularLn(double x, int terminos)
        {
            double suma = 0;
            for (int n = 1; n <= terminos; n++)
            {
                double signo = Math.Pow(-1, n + 1);
                suma += signo * Math.Pow(x, n) / n;
            }
            return suma;
        }

        public double CalcularPi(int terminos)
        {
            double suma = 0;
            for (int n = 0; n < terminos; n++)
            {
                double signo = Math.Pow(-1, n);
                suma += signo / (2 * n + 1);
            }
            return 4 * suma;
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
    }
}
