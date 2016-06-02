using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ItemEntregaModel
    {
        public int? Codigo { get; set; }
        public int? IdVenda { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataEntrega { get; set; }
        public string EnderecoCliente { get; set; }
        public string Status { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string NomeUsuario { get; set; }
        public double? Desconto { get; set; }
        public double? ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Telefone { get; set; }
        public double? QuantidadeParcela { get; set; }
    }
}
