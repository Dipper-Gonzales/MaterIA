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
        public int OperacionNot(int valor)
        {
            return valor == 0 ? 1 : 0;
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
                    int resultadoNotA = OperacionNot(a);
                    int resultadoNotB = OperacionNot(b);
                    int resultadoAAndNotB = OperacionAnd(a, resultadoNotB);
                    int resultadoNotAAndB = OperacionAnd(resultadoNotA, b);
                    int resultadoAOrNotB = OperacionOr(a, resultadoNotB);
                    int resultadoNotAOrB = OperacionOr(resultadoNotA, b);

                    tabla.Add(new string[] {
                a.ToString(),
                b.ToString(),
                resultadoAnd.ToString(),
                resultadoOr.ToString(),
                resultadoNotA.ToString(),
                resultadoNotB.ToString(),
                resultadoAAndNotB.ToString(),
                resultadoNotAAndB.ToString(),
                resultadoAOrNotB.ToString(),
                resultadoNotAOrB.ToString()
            });
                }
            }

            return tabla;
        }
    }
}
