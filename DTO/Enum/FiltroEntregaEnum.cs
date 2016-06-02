using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum FiltroEntregaEnum : short
    {
        [Description("NOME/RAZÃO SOCIAL")]
        Nome = 0,
        [Description("Endereço")]
        Endereco = 2
    }
}
