using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Validar Operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>  Deberá validar que el operador recibido sea +, -, / o *. Caso contrario retornará + </returns>
        private static char ValidarOperador(char operador)
        {
            char ret = '+';

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                ret = operador;
            }
            return ret;
        }

        /// <summary>
        /// Operar
        /// </summary>
        /// <param name="num1"> numero 1</param>
        /// <param name="num2"> numero 2</param>
        /// <param name="operador"> +, -, *, / </param>
        /// <returns>validará y realizará la operación pedida entre ambos números.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double ret = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    ret = num1 + num2;
                    break;

                case '-':
                    ret = num1 - num2;
                    break;

                case '/':
                    ret = num1 / num2;
                    break;

                case '*':
                    ret = num1 * num2;
                    break;

            }
            return ret;
        }

    }

    public class Operando
    {
        private double numero;
        
        /// <summary>
        /// Validacion y seteo del numero
        /// </summary>
        public string Numero
        {

            get
            {
                return Convert.ToString(this.numero);
            }
            set
            {
                if (ValidarOperando(value) != 0)
                {
                    this.numero = Convert.ToDouble(value);
                }
                else
                {
                    this.numero = 0;
                }

            }
        }
        
        /// <summary>
        /// Constructor por defecto de tipo string
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }
        
        /// <summary>
        /// Conwtructor por defecto que asigna un valor
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
       
        /// <summary>
       /// Constructor por defecto que asigna valor 0.
       /// </summary>
        public Operando() : this(0)
        {
        }

        /// <summary>
        /// Vlidar Operando
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Valida que el numero sea un double y lo retorna, si no retorna 0.</returns>
        private double ValidarOperando(string strNumero)
        {
            double ret;

            if (double.TryParse(strNumero, out ret) == false)
            {
                ret = 0;
            }

            return ret;
        }

        /// <summary>
        /// Es Binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> retorna true/ false dependiendo si es booleano o no</returns>
        private static bool EsBinario(string binario)
        {
            bool ret = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }

        /// <summary>
        ///  Operador suma
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Crea el operador que uma los dos operandos. </returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        ///  Operador resta
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Crea el operador que resta los dos operandos. </returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        ///  Operador division
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>crea el operador que divide el operando 1 por el operando 2, siempre y cuando el operando 2 sea distinto de 0. </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double ret = double.MinValue;
            if (n2.numero != 0)
            {
                ret = n1.numero / n2.numero;
            }
            return ret;
        }

        /// <summary>
        ///  Operador multiplicacion
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>crea el operador que multiplica los dos operandos. </returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// validacion de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Valida que el numero sea binario y llama a la funcion que lo convierte a decimal. de no ser asi retorna una cadena que dice "numero invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            string ret = "Valor invalido.";
            if (binario != "Valor invalido.")
            {
                int entero = Convert.ToInt32(Convert.ToDouble(binario));
                char[] array = (binario.ToCharArray());
                double sumador = 0;

                if (EsBinario(binario))
                {
                    for (int i = binario.Length, j = 0; i > 0; i--, j++)
                    {

                        if (array[j] == '1')
                        {
                            sumador = sumador + Math.Pow(2, i - 1);
                        }

                    }

                    ret = Convert.ToString(sumador);
                }
            }

            return ret;
        }

        /// <summary>
        ///  validacion de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Valida que el numero sea decimal y llama a la funcion que lo convierte a binario. de no ser asi retorna una cadena que dice "numero invalido"</returns> 
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido.";
            if (numero != "Valor invalido.")
            {
                int entero = Convert.ToInt32(Convert.ToDouble(numero));

                if (entero < 0)
                {
                    entero = entero * (-1);
                }

                if (entero >= 0 && !(EsBinario(numero)))
                {
                    retorno = "";
                    do
                    {
                        retorno = entero % 2 + retorno;
                        entero /= 2;
                    } while (entero > 0);
                }
                

            }
            return retorno;
        }

    }


}
