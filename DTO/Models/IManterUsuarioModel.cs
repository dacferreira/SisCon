using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IManterUsuarioModel
    {
        string Nome { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        string ConfirmarSenha { get; set; }
        string NomeUsuarioSessao { get; set; }
        string LoginUsuarioSessao { get; set; }

        int? Acesso { get; set; }
        List<ItemListaModel> ListaAcesso { get; set; }
    }
}
