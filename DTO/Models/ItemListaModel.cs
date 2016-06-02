using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ItemListaModel
    {
        public ItemListaModel()
        {
        }

        public ItemListaModel(Nullable<Int64> codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public Nullable<Int64> Codigo { get; set; }
                
        public string Descricao { get; set; }
    }
}
