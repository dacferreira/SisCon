using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum FiltroPodutoEnum : short
    {
        [Description("Descrição")]
        Nome = 0,
        [Description("Localização")]
        Login = 1,
    }
}
