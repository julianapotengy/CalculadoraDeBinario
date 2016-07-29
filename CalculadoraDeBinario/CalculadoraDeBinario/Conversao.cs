using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeBinario
{
    class Conversao
    {
        public static string InverterString(string str)
        {
            int tamanho = str.Length;
            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }
            return new string(caracteres);
        }

        public static int BinarioParaDecimal(string valorBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;

            string numeroInvertido = InverterString(valorBinario);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }

        public static string BinarioParaHex(string valorBinario)
        {
            string valorHex= "";
           valorHex = Convert.ToInt32(valorBinario, 2).ToString("X");

            return valorHex;
        }

        public static string DecimalParaBinario(string valorDecimal)
        {
            string valorBinario = "";
            int dividendo = Convert.ToInt32(valorDecimal);

            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }
            else
            {
                while (dividendo > 0)
                {
                    valorBinario += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                }
                return InverterString(valorBinario);
            }
        }

        public static string DecimalParaHex(int valorDecimal)
        {
            string valorHex = "";
            valorHex = valorDecimal.ToString("X");

            return valorHex;
        }

        public static string HexParaBinario(string valorHex)
        {
            string valorBinario = "";
            valorBinario = Convert.ToString(Convert.ToInt32(valorHex, 16), 2);

            return valorBinario;
        }

        public static string HexParaDecimal(string valorHex)
        {
            string valorDecimal = "";
            valorDecimal = Convert.ToString(Convert.ToInt32(valorHex, 16));

            return valorDecimal;
        }
    }
}
