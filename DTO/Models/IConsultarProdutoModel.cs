using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IConsultarProdutoModel
    {
        string Nome { get; set; }

        int? Situacao { get; set; }
        List<ItemListaModel> ListaSituacao { get; set; }

        int? Filtro { get; set; }
        List<ItemListaModel> ListaFiltro { get; set; }

        List<ItemConsultarProdutoModel> ListaProduto { get; set; }
    }
}
