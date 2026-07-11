using System;
using System.Collections.Generic;
using System.Text;

namespace MaterIA.Logica
{
    public class CalculadoraLogica
    {
        // Convierte un texto en la base indicada a decimal
        public static int ATexto_a_Decimal(string texto, string base_)
        {
            switch (base_)
            {
                case "Binario": return ConversorBase.BinarioADecimal(texto);
                case "Octal": return ConversorBase.OctalADecimal(texto);
                case "Decimal": return int.Parse(texto);
                case "Hexadecimal": return ConversorBase.HexadecimalADecimal(texto);
                default: return 0;
            }
        }

        // Convierte un decimal a texto en la base indicada
        public static string Decimal_a_Texto(int numero, string base_)
        {
            switch (base_)
            {
                case "Binario": return ConversorBase.DecimalABinario(numero);
                case "Octal": return ConversorBase.DecimalAOctal(numero);
                case "Decimal": return numero.ToString();
                case "Hexadecimal": return ConversorBase.DecimalAHexadecimal(numero);
                default: return "0";
            }
        }

        // Realiza la operación aritmética básica
        public static int Calcular(int operandoA, int operandoB, string operador)
        {
            switch (operador)
            {
                case "+": return operandoA + operandoB;
                case "-": return operandoA - operandoB;
                case "*": return operandoA * operandoB;
                case "/":
                    if (operandoB == 0) throw new System.DivideByZeroException();
                    return operandoA / operandoB;
                default: return 0;
            }
        }
    }
}
