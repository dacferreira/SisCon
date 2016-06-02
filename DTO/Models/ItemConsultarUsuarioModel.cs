using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
   public class ItemConsultarUsuarioModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Permissao { get; set; }
        public string Situacao { get; set; }
    }
}
