using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IConfirmarProdutosEntregaModel
    {
        List<ItemConsultarProdutoModelVenda> listaprodutoModelVenda { get; set; }
        List<ItemConsultarProdutoModelVendaEntrega> listaprodutoModelEntrega { get; set; }
    }
}
