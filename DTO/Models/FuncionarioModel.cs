using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class FuncionarioModel
    {
        public int IdFuncionario { get; set; }

        public string Matricula { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string NomeFuncionario { get; set; }

        public Nullable<DateTime> DataAdmissao { get; set; }
        
        public string CPF { get; set; }

        public string Complemento { get; set; }

        public string Cargo { get; set; }

        public bool FlgSituacaoFuncionario { get; set; }
    }
}
