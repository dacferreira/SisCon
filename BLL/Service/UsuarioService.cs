using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSource;
using DAL.Persistence;
using DTO.Models;

namespace BLL.Service
{
    public class UsuarioService
    {
        private IConsultarUsuarioModel _view;
        public IConsultarUsuarioModel View
        {
            get { return _view; }
            set { _view = value; }
        }

        public DTO.Models.UsuarioModel GetUsuarioByLogin(string login, string senha)//Método para Obter o Usuario pelo Login e Senha
        {
            List<UsuarioModel> lista = new UsuarioDAL().ObterTodos();
            List<UsuarioModel> novalista = new List<UsuarioModel>();
            UsuarioModel usuarioModel = new UsuarioModel();

            var user = lista.Where(p => p.Login.Equals(login) && p.Senha.Equals(senha) && p.Situacao == true).FirstOrDefault();
            //return new UsuarioDAL().GetUsuarioByLogin(login, senha);
            if (user != null)
            {
                usuarioModel.Codigo = user.Codigo;
                usuarioModel.Login = user.Login;
                usuarioModel.Nome = user.Nome;
                usuarioModel.Senha = user.Senha;
                usuarioModel.Permissao = user.Permissao;
            }
            return usuarioModel;
        } 

        public UsuarioModel GetUsuarioById(int id)//Método para Obter o Usuario pelo id
        {
            return new UsuarioDAL().GetUsuarioById(id);
        }

        public List<UsuarioModel> ObterUsuarios(string nome, int situacao, string filtro)//Método usuado na Pesquisa de usuário, retorna os usuarios pesquisados
        {
            List<UsuarioModel> lista = new UsuarioDAL().ObterTodos();
            List<UsuarioModel> novalista = new List<UsuarioModel>();
            if (situacao != 2)
            {
                if (filtro == "Login")
                    novalista = lista.Where(p => p.Login.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                else
                    novalista = lista.Where(p => p.Nome.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
            }
            else
            {
                if (situacao == 2)
                {
                    if (filtro == "Login")
                        novalista = lista.Where(p => p.Login.ToLower().Contains(nome.ToLower())).ToList();

                    else
                        novalista = lista.Where(p => p.Nome.ToLower().Contains(nome.ToLower())).ToList();
                }
                else
                {
                    if (filtro == "Login")
                        novalista = lista.Where(p => p.Login.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                    else
                        novalista = lista.Where(p => p.Nome.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                }
            }
                return novalista;
        }

        public bool Salvar(string Nome, string Login, string Senha, string acesso, int codigo)
        {
            return new UsuarioDAL().Salvar(Nome, Login, Senha, acesso, codigo);
        }

        public bool Excluir(int codigo)
        {
            return new UsuarioDAL().Excluir(codigo);
        }

        public bool Ativar(int codigo)
        {
            return new UsuarioDAL().Ativar(codigo);
        }

        public bool ExisteNome(string nomeAlterado)
        {
            var usuarios = new UsuarioDAL().ObterTodos();
            UsuarioModel user = new UsuarioModel();
            user = usuarios.Where(p => p.Nome.Equals(nomeAlterado)).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }

        public bool ExisteLogin(string loginAlterado)
        {
            var usuarios = new UsuarioDAL().ObterTodos();
            UsuarioModel user = new UsuarioModel();
            user = usuarios.Where(p => p.Login.Equals(loginAlterado)).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }

        public bool ExisteSenhaGerenteAdministrador(string Senha)
        {
            var usuarios = new UsuarioDAL().ObterTodos();
            UsuarioModel user = new UsuarioModel();
            user = usuarios.Where(p => p.Senha.Equals(Senha) && (p.Permissao.Equals("Administrador") || p.Permissao.Equals("Gerente"))).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }
    }
}
