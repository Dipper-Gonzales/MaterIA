using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    internal class RecurrenciaLogica
    {
        // Calcula la sucesión desde el término 1 hasta el término n
        public static List<long> CalcularSucesion(bool usaDosTerminos, long c1, long c2, long k, long a1, long a2, int n)
        {
            List<long> terminos = new List<long>();

            terminos.Add(a1); // término 1
            if (usaDosTerminos)
            {
                terminos.Add(a2); // término 2
            }

            for (int i = terminos.Count + 1; i <= n; i++)
            {
                long anterior1 = terminos[i - 2]; // a(i-1)
                long nuevoTermino;

                if (usaDosTerminos)
                {
                    long anterior2 = terminos[i - 3]; // a(i-2)
                    nuevoTermino = (c1 * anterior1) + (c2 * anterior2) + k;
                }
                else
                {
                    nuevoTermino = (c1 * anterior1) + k;
                }

                terminos.Add(nuevoTermino);
            }

            return terminos;
        }
    }
}
