using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace ProjetoFinal.Extension
{
   public static class ItemListaModelExtension
    {
       public static List<ItemListaModel> ToItemListaModel(this Type typoEnumerador)
       {
           if (typoEnumerador.BaseType.Name != "Enum")
               return null;

           var lista = typoEnumerador.ToDicionarioEnum();

           return (from o in lista
                   select new ItemListaModel(Convert.ToInt64(o.Key), o.Value)).ToList();
       }
    }
}
