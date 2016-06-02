using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Extension
{
    public static class IntExtension
    {
        /// <summary>
        /// Indica se o número é par
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EhPar(this int numero)
        {
            return (numero % 2 == 0);
        }

        /// <summary>
        /// Indica se o número é maior do que o valor passado
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="valorComparado"></param>
        /// <returns></returns>
        public static bool EhMaiorQue(this int? valor, int valorComparado)
        {
            if (!valor.HasValue)
                return false;

            return valor.Value.EhMaiorQue(valorComparado);
        }

        /// <summary>
        /// Indica se o número é maior do que o valor passado
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="valorComparado"></param>
        /// <returns></returns>
        public static bool EhMaiorQue(this int valor, int valorComparado)
        {
            return (valor > valorComparado);
        }

        /// <summary>
        /// Retorna a referencia no formato string. Quando nulo retorna string em branco
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string ToStringOrEmpty(this int? valor)
        {
            if (valor.HasValue)
                return valor.Value.ToString();

            return string.Empty;
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo Int
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static int ToInt(this int? valor)
        {
            if (!valor.HasValue)
                return 0;

            return valor.Value;
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo Double
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        //public static double ToDouble(this int? valor)
        //{
        //    if (!valor.HasValue)
        //        return 0D;

        //    return Convert.ToDouble(valor.Value);
        //}

        /// <summary>
        /// Retorna a referencia adaptada para o tipo Double
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static double ToDouble(this string valor)
        {
            if (String.IsNullOrWhiteSpace(valor))
                return 0D;

            return Convert.ToDouble(valor);
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo Decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this int? valor)
        {
            if (!valor.HasValue)
                return (decimal)0;

            return Convert.
                ToDecimal(valor.Value);
        }

        /// <summary>
        /// Verifica se o valor da instância de um inteiro está contido em um array de inteiros.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static bool In(this int value, params int[] valores)
        {
            return Convert.ToBoolean(valores.Where(s => s == value).Count());
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo NullableInt
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static int? ToNullableInt(this object valor)
        {
            if (valor != null && valor.ToString().EhNumerico())
                return Convert.ToInt32(valor);

            return null;
        }

        /// <summary>
        /// Verifica se o conteúdo do texto representa valor numérico
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EhNumerico(this string valor)
        {
            int result;
            return Int32.TryParse(valor, out result);
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo NullableDecimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static decimal? ToNullableDecimal(this string valor)
        {
            if (valor.EhNuloVazioOuEspacos())
                return null;

            if (valor.EhDecimal())
            {
                decimal result;
                Decimal.TryParse(valor, out result);
                return result;
            }

            return null;
        }

        /// <summary>
        /// Retorna a referencia adaptada para o tipo NullableDecimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static double? ToNullableDouble(this string valor)
        {
            if (valor.EhNuloVazioOuEspacos())
                return null;

            if (valor.EhDouble())
            {
                double result;
                double.TryParse(valor, out result);
                return result;
            }

            return null;
        }
        /// <summary>
        /// Verifica se o texto é nulo, está vazio ou contém somente espaços
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EhNuloVazioOuEspacos(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return true;

            return string.IsNullOrEmpty(valor.Trim());
        }
        /// <summary>
        /// Verifica se a referencia pode ser convertida para Decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EhDecimal(this string valor)
        {
            decimal result;
            return Decimal.TryParse(valor, out result);
        }

        public static bool EhDouble(this string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }

    }
}
