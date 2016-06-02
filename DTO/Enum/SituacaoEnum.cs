using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Enum
{
   public enum SituacaoEnum : short
    {
       [Description("Inativo")]
       Inativo = 0,
       [Description("Ativo")]
       Ativo = 1,
       [Description("Todos")]
       Todos = 2
    }
}
