using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum AcessoEnum : short
    {
        [Description("Funcionário")]
        Funcionario = 0,
        [Description("Gerente")]
        Gerente = 1,
        [Description("Administrador")]
        Administrador = 2
    }
}
