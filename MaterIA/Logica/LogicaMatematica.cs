using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    internal class LogicaMatematica
    {
        public int OperacionAnd(int valorA, int valorB)
        {
            return valorA & valorB;
        }

        public bool OperacionAndBool(bool a, bool b)
        {
            return a && b;
        }
        public int OperacionOr(int valorA, int valorB)
        {
            return valorA | valorB;
        }

        public bool OperacionOrBool(bool a, bool b)
        {
            return a || b;
        }
        public List<string[]> TablaVerdadCompleta()
        {
            List<string[]> tabla = new List<string[]>();
            int[] valores = { 0, 1 };

            foreach (int a in valores)
            {
                foreach (int b in valores)
                {
                    int resultadoAnd = OperacionAnd(a, b);
                    int resultadoOr = OperacionOr(a, b);
                    tabla.Add(new string[] { a.ToString(), b.ToString(), resultadoAnd.ToString(), resultadoOr.ToString() });
                }
            }

            return tabla;
        }
    }
}
