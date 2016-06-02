using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ItemConsultarProdutoVenda
    {
        public int Codigo { get; set; }
        public int CodigoItemPedido { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double PrecoUnitario { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
