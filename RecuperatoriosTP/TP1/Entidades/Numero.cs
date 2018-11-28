using System;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        private double ValidarNumero(string strNumero)
        {
            double i = 0;
            bool n = double.TryParse(strNumero, out i);

            if (n)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }


        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero() : this(0) { }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #region Binario a decimal y viceversa
        public static string BinarioDecimal(string binario)
        {
            int i;
            int entero = 0;
            string returnAux = "";

            foreach (char c in binario)
                if (c != '0' && c != '1')
                    return "Valor no binario";

            if (binario == "" || ReferenceEquals(binario, null))
            {
                returnAux = "Valor inválido";
            }
            else
            {
                for (i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
                returnAux = entero.ToString();
            }

            return returnAux;
        }
        public static string DecimalBinario(string binario)
        {
            int numero;
            string returnValue = "";

            if (int.TryParse(binario, out numero))
            {
                while (numero > 0)
                {
                    returnValue = (numero % 2).ToString() + returnValue;
                    numero = numero / 2;
                }
            }
            else
                returnValue = "Valor inválido";

            return returnValue;
        }
        public static string DecimalBinario(double binario)
        {
            return DecimalBinario(binario.ToString());
        }
        #endregion

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
    }
}
