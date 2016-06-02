using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum FiltroClienteEnum : short
    {
        [Description("NOME/RAZÃO SOCIAL")]
        Nome = 0,
        [Description("CPF/CNPJ")]
        CPF = 1,
        [Description("RG/INCR. ESTADUAL")]
        Login = 2,
        [Description("Endereço")]
        Endereco = 3
    }
}
