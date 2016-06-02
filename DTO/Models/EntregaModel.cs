
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class EntregaModel
    {
        public int? Codigo { get; set; }
        public int? idVenda { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; }
        public int? idCliente { get; set; }
        public int? idUsuario { get; set; }
        public double? Desconto { get; set; }
        public double? ValorTotal { get; set; }
        public DateTime DataCompra { get; set; }
        public double? Dinheiro { get; set; }
        public double? Debito { get; set; }
        public double? Credito { get; set; }
        public double? QuantidadeParcela { get; set; }
    }
}
