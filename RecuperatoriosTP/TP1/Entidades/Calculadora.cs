using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Numero n1, Numero n2, string operador)
        {
            switch (ValidarOperador(operador))
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n1 / n2;
                default:
                    return n1 + n2;
            }

        }
        static private string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
                retorno = operador;

            return operador;
        }
    }
}
