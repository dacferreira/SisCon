using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IManterVendaModel
    {
        string DescricaoProduto { get; set; }
        string DescricaoProdutoCadastrado { get; set; }
        int? DescricaoQuantidadeLabel { get; set; }
        double? PrecoUnitario { get; set; }
        double? Quantidade { get; set; }
        double? SubTotal { get; set; }
        double? Total { get; set; }
        List<ItemConsultarProdutoModelVenda> ListaProduto { get; set; }
    }
}
