using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Extension
{
    public static class TypeExtension
    {
        public static string ObterDescricao(System.Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
        public static string ObterDescricaoEnum(this System.Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        public static IDictionary<object, string> ToDicionarioEnum(this System.Type enumType)
        {
            IDictionary<object, string> lista = new Dictionary<object, string>();

            foreach (System.Enum item in System.Enum.GetValues(enumType))
            {
                var valorEnum = item.GetType().GetField(item.ToString()).GetRawConstantValue();
                lista.Add(valorEnum, ObterDescricao(item));
            }

            return lista;
        }
    }
}
