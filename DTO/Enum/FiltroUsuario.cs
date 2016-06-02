using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
    public enum FiltroUsuarioEnum : short
    {
        [Description("Nome")]
        Nome = 0,
        [Description("Login")]
        Login = 1,
    }
}
