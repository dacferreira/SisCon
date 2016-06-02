using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class IVendaDevolucaoModel
    {
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public int QuantidadeVenda { get; set; }
        public int QuantidadeDevolucao { get; set; }
    }
}
