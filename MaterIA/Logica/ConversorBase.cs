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
        public static string DecimalAHexadecimal(int numero)
        {
            if (numero == 0) return "0";

            string digitos = "0123456789ABCDEF";
            string resultado = "";

            while (numero > 0)
            {
                int residuo = numero % 16;
                resultado = digitos[residuo] + resultado;
                numero = numero / 16;
            }

            return resultado;
        }

        // Hexadecimal -> Decimal
        public static int HexadecimalADecimal(string hexadecimal)
        {
            string digitos = "0123456789ABCDEF";
            hexadecimal = hexadecimal.ToUpper();

            int resultado_decimal = 0;
            int ultimoNumero = hexadecimal.Length - 1;

            for (int i = 0; i <= ultimoNumero; i++)
            {
                char caracter = hexadecimal[ultimoNumero - i];
                int valor = digitos.IndexOf(caracter);
                resultado_decimal += valor * (int)Math.Pow(16, i);
            }

            return resultado_decimal;
        }

        // Binario -> Hexadecimal (reutiliza los dos anteriores)
        public static string BinarioAHexadecimal(string binario)
        {
            int decimal_ = BinarioADecimal(binario);
            return DecimalAHexadecimal(decimal_);
        }

        // Hexadecimal -> Binario (reutiliza los dos anteriores)
        public static string HexadecimalABinario(string hexadecimal)
        {
            int decimal_ = HexadecimalADecimal(hexadecimal);
            return DecimalABinario(decimal_);
        }
    }
}
