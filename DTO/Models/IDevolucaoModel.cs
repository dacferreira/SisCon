using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IDevolucaoModel
    {
        int? codigoVenda { get; set; }
        List<ItemConsultarProdutoVenda> listaprodutoModelVenda { get; set; }
        List<ItemConsultarProdutoDevolucao> listaprodutoModelDevolvido { get; set; }
    }
}
