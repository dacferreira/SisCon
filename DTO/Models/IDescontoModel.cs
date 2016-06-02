using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IDescontoModel
    {
        Double? ValorDigitado { get; set; }
        bool Valor { get; set; }
        bool Percentual { get; set; }
    }
}
