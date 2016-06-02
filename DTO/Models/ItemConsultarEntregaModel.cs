using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ItemConsultarEntregaModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double Quantidade { get; set; }
    }
}
