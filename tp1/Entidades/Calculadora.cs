using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;

            return "+";
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            //validará y realizará la operación pedida entre ambos números.
            double resultado = 0;
            operador = Calculadora.ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }
    }
}
