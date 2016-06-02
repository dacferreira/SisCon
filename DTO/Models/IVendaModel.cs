using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class IVendaModel
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public double? Desconto { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public double? Dinheiro { get; set; }
        public double? Debito { get; set; }
        public double? Credito { get; set; }
        public int? QtdParcela { get; set; }
    
    }
}
