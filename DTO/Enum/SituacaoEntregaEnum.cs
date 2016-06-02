using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum SituacaoEntregaEnum : short
    {
        [Description("Todos")]
        Todos = 0,
        [Description("Entregue")]
        Entregue = 1,
        [Description("Pendente")]
        Pendente = 2
    }
}
