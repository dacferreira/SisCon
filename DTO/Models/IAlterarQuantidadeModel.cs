using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IAlterarQuantidadeModel
    {
        int? QuantidadeAtual { get; set; }
        int? NovaQuantidade { get; set; }
    }
}
