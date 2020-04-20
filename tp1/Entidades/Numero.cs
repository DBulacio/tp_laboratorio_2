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

        #region Constructores
        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        // Unico lugar en el que se llama a ValidarNumero
        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        private double ValidarNumero(string strNumero)
        {
            Double num = 0;

            // veo si está vacía
            if (string.IsNullOrEmpty(strNumero))
            {
                return num;
            }
            
            // devuelve un bool. Si es false, llena num con 0 .. sino, lo llena con el double que corresponde.
            Double.TryParse(strNumero, out num);

            return num;
        }

        #region Converters
        // A partir de aca SOLO SE TRABAJA CON ENTEROS POSITIVOS!!!
        //.
        //.
        public static string BinarioDecimal(string binario)
        {
            if(!Int32.TryParse(binario, out int num))
                return "invalido";

            num = Convert.ToInt32(binario, 2);

            if (num < 0)
                num = Math.Abs(num);

            return num.ToString();
        }

        public static string DecimalBinario(double numero)
        {
            if (Double.IsNaN(numero))
                return "invalido";

            int num = (int)numero;

            if(num < 0)
                num = Math.Abs(num);

            string strBin = "";
            for(int i = 0; num > 0; i++)
            {
                // Leo de atrás para adelante -.-
                strBin = (num % 2) + strBin;
                num = num / 2;
            }

            return strBin;
        }

        public static string DecimalBinario(string numero)
        {
            if (string.IsNullOrEmpty(numero) || !Double.TryParse(numero, out double n))
                return "invalido";

            return Numero.DecimalBinario(n);
        }

        #endregion

        #region operadores

        public static double operator + (Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator - (Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator * (Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator / (Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;

            return num1.numero / num2.numero;
        }
        #endregion
    }
}
