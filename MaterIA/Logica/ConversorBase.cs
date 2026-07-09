using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    public class ConversorBase
    {
        public static int BinarioADecimal(string binario)
        {
            int resultado_decimal = 0;
            int ultimoNumero = binario.Length - 1;
            for (int i = 0; i <= ultimoNumero; i++)
            {
                if (binario[ultimoNumero - i] == '1')
                {
                    resultado_decimal += (int)Math.Pow(2, i);
                }
            }
            return resultado_decimal;
        }
        public static string DecimalABinario(int numero)
        {
            string resultado = "";
            while (numero > 0)
            {
                if (numero % 2 == 1)
                    resultado = "1" + resultado;
                else
                    resultado = "0" + resultado;

                numero = numero / 2;
            }

            if (resultado == "") resultado = "0"; 

            return resultado;
        }
    }
}
