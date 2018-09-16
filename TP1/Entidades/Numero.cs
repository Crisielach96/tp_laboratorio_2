using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        private double ValidadNumero(string strNumero)
        {
            double num;
            bool n = double.TryParse(strNumero, out num);

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

        private void SetNumero(string numero)
        {
            this.numero = (this.ValidadNumero(numero));
        }

        public Numero(){}

        public Numero(double numero) : this(numero.ToString()) {}

        public Numero(string numero)
        {
            SetNumero(numero);
        }

        static string BinarioDeciemal(string binario)
        {
            double numero = 0;
            string mensaje = "";

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == 1)
                {
                    numero += (double)Math.Pow(2, binario.Length - i - 1);
                }
                else
                {
                    mensaje = "Valor Invalido";
                }
            }
            if (numero > 0)
            {
                mensaje = Convert.ToString(numero);
            }

            return mensaje;
        }

        static public string BinarioDecimal(double numero)
        {
            string binario = "";

            if(numero < 0)
            {
                return "Valor Invalido";
            }

            while (numero > 1)
            {
                if (numero % 2 != 0)
                {
                    binario = "1" + binario;
                    numero--;
                }
                else
                {
                    binario = "0" + binario;
                    numero = numero / 2;
                }
            }
            if (numero == 0)
            {
                return "0";
            }

            return "1" + binario;
        }

        static public string BinarioDecimal(string numero)
        {
            double num = Convert.ToDouble(numero);

            return BinarioDecimal(numero);
        }

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