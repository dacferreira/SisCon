using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using DAL.DataSource;
using System.Data;

namespace DAL.Persistence
{
   public class UsuarioDAL
    {
        ProjetoFinalEntities entidade = new ProjetoFinalEntities();

        public UsuarioModel GetUsuarioByLogin(string login, string senha)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            var user = entidade.Usuarios.Where(p => p.Login.Contains(login) && p.Senha.Equals(senha) && p.Situacao == true).FirstOrDefault();
            if (user != null)
            {
                usuarioModel.Login = user.Login;
                usuarioModel.Nome = user.Nome;
                usuarioModel.Senha = user.Senha;
                usuarioModel.Permissao = user.Permissao;
            }

            return usuarioModel;
        }
        public List<UsuarioModel> ObterTodos()
        {
            var listaUsuario = new List<UsuarioModel>();
            
            var lista = entidade.Usuarios.ToList();
            if (lista != null && lista.Any())
            foreach (var item in lista)
            {
                var usuario = new UsuarioModel();

                usuario.Codigo = item.Id;
                usuario.Login = item.Login;
                usuario.Senha = item.Senha;
                usuario.Permissao = item.Permissao;
                usuario.Nome = item.Nome;
                usuario.Situacao = item.Situacao;
                listaUsuario.Add(usuario);
            }
            return listaUsuario;
        }

        public bool Salvar(string Nome, string Login, string Senha, string acesso, int codigo)
        {
            Usuario user = new Usuario();

            try
            {
                user.Nome = Nome;
                user.Login = Login;
                user.Senha = Senha;
                user.Permissao = acesso;
                user.Situacao = true;

                if (codigo == 0)
                    entidade.Usuarios.Add(user);
                else
                {
                    user.Id = codigo;
                    entidade.Usuarios.Attach(user);
                    entidade.Entry(user).State = EntityState.Modified;
                }
                entidade.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public UsuarioModel GetUsuarioById(int id)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            var user = entidade.Usuarios.Where(p => p.Id == id).FirstOrDefault();
            if (user != null)
            {
                usuarioModel.Login = user.Login;
                usuarioModel.Nome = user.Nome;
                usuarioModel.Senha = user.Senha;
                usuarioModel.Permissao = user.Permissao;
                usuarioModel.Situacao = user.Situacao;
            }

            return usuarioModel;
        }

        public bool Excluir(int codigo)
        {
            try
            {
                var user = entidade.Usuarios.Where(p => p.Id == codigo).FirstOrDefault();
                user.Id = codigo;
                user.Situacao = false;
                entidade.Usuarios.Attach(user);
                entidade.Entry(user).State = EntityState.Modified;
                entidade.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       
        public bool Ativar(int codigo)
        {
            try
            {
                var user = entidade.Usuarios.Where(p => p.Id == codigo).FirstOrDefault();
                user.Id = codigo;
                user.Situacao = true;
                entidade.Usuarios.Attach(user);
                entidade.Entry(user).State = EntityState.Modified;
                entidade.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
