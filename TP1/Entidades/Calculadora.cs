using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        static public double Operar(Numero n1, Numero n2, string operador)
        {
            switch(ValidarOperador(operador))
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
                    return 0;
            }

        }
        static private string ValidarOperador(string operador)
        {
            string retorno;

            switch(operador)
            {
                case "+":
                    retorno = operador;
                    break;
                case "-":
                    retorno = operador;
                    break;
                case "*":
                    retorno = operador;
                    break;
                case "/":
                    retorno = operador;
                    break;
                default:
                    retorno = "+";
                    break;
            }
            return retorno;
        }
    }
}
