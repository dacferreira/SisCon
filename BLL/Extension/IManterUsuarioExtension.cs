using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSource;
using DTO.Models;

namespace BLL.Extension
{
    public static class IManterUsuarioExtension
    {
        public static UsuarioModel ToItemUsuarioModel(this Usuario usuario)
        {
            UsuarioModel itemUsuarioModel = new UsuarioModel
            {
                Login = usuario.Login,
                Senha = usuario.Senha,
                Permissao = usuario.Permissao
            };

            return itemUsuarioModel;
        }
        public static List<UsuarioModel> ToListaUsuarioModel(this List<Usuario> listaUsuario)
        {
            return listaUsuario.Select(p => p.ToItemConsultarUsuarioModel()).ToList();
        }
        public static UsuarioModel ToItemConsultarUsuarioModel(this Usuario user)
        {
            UsuarioModel itemUsuarioModel = new UsuarioModel
            {
                Login = user.Login,
                Senha = user.Senha,
                Permissao = user.Permissao
            };
            return itemUsuarioModel;
        }
    }
}
