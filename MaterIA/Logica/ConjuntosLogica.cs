using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    public class ConjuntosLogica
    {
        // Verifica si un elemento ya está en una lista (manual, sin usar Contains de LINQ)
        private static bool Contiene(List<string> lista, string elemento)
        {
            foreach (string item in lista)
            {
                if (item == elemento) return true;
            }
            return false;
        }

        // Unión: todos los elementos de A y B, sin repetir
        public static List<string> Union(List<string> conjuntoA, List<string> conjuntoB)
        {
            List<string> resultado = new List<string>();

            foreach (string elemento in conjuntoA)
            {
                if (!Contiene(resultado, elemento))
                    resultado.Add(elemento);
            }

            foreach (string elemento in conjuntoB)
            {
                if (!Contiene(resultado, elemento))
                    resultado.Add(elemento);
            }

            return resultado;
        }

        // Intersección: elementos que están en A y también en B
        public static List<string> Interseccion(List<string> conjuntoA, List<string> conjuntoB)
        {
            List<string> resultado = new List<string>();

            foreach (string elemento in conjuntoA)
            {
                if (Contiene(conjuntoB, elemento) && !Contiene(resultado, elemento))
                    resultado.Add(elemento);
            }

            return resultado;
        }

        // Diferencia: elementos que están en A pero NO en B (A - B)
        public static List<string> Diferencia(List<string> conjuntoA, List<string> conjuntoB)
        {
            List<string> resultado = new List<string>();

            foreach (string elemento in conjuntoA)
            {
                if (!Contiene(conjuntoB, elemento))
                    resultado.Add(elemento);
            }

            return resultado;
        }

        // Producto cartesiano: todos los pares posibles (a, b)
        public static List<string> ProductoCartesiano(List<string> conjuntoA, List<string> conjuntoB)
        {
            List<string> resultado = new List<string>();

            foreach (string a in conjuntoA)
            {
                foreach (string b in conjuntoB)
                {
                    resultado.Add("(" + a + ", " + b + ")");
                }
            }

            return resultado;
        }
    }
}
