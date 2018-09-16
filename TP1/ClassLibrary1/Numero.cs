using System;

namespace ClassLibrary1
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                this.numero = this.ValidadNumero(value);
            }
        }

        private double ValidadNumero(string strNumero)
        {
            bool n = double.TryParse(strNumero, out double num);

            if (n)
            {
                num = double.Parse(strNumero);
            }
            else
            {
                num = 0;
            }

            return num;
        }


        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero() : this(0) { }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        #region Binario a decimal y viceversa
        public string BinarioDecimal(string binario)
        {
            int entero = 0;

            int numero;

            if (int.TryParse(binario, out numero))
            {
                for (int i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
            }

            return entero.ToString();
        }

        public string DecimalBinario(string binario)
        {
            string returnValue = "";

            if (int.TryParse(binario, out int numero))
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

        public string DecimalBinario(double binario)
        {
            return this.DecimalBinario(binario.ToString());
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
