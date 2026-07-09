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
    }
}
