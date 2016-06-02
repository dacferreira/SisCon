using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Service;
using DTO.Enum;
using DTO.Models;
using ProjetoFinal.Extension;

namespace ProjetoFinal.Views
{
    public partial class Usuario : Form, IManterUsuarioModel
    {
        #region [ Construtor ]
        public delegate void DoEvent(List<ItemConsultarUsuarioModel> lista);
        public event DoEvent RefreshDgv;
        public Usuario()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Métodos Principais ]

        private void CancelarButton_Click(object sender, EventArgs e) //Método para cancelar a ação de Criar usuário
        {
            //DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Acesso ao Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (resultado == DialogResult.Yes)
            //{
                this.Close();
                RemoverObjetosSessao();
            //}
            //else
            //    return;
        }

        private void SalvarButton_Click(object sender, EventArgs e) //Método para Salvar o Usuário
        {
            incluirUsuario();
        }

        private void incluirUsuario()
        {
            int erro = 0;
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Senha) || string.IsNullOrWhiteSpace(ConfirmarSenha)
                                               || Acesso == null)
            {
                erro = 1;
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
            }

            if (Senha != ConfirmarSenha)
            {
                erro = 1;
                MessageBox.Show("Senha e Confirmar Senha devem ser Iguais.");
            }
            bool nomeAlterado = NomeUsuarioSessao != Nome;
            bool loginAlterado = LoginUsuarioSessao != Login;
            if (erro == 0)
                if (loginAlterado)
                {
                    bool nomeJaExiste = new UsuarioService().ExisteNome(Nome);
                    bool loginJaExiste = new UsuarioService().ExisteLogin(Login);

                    if (loginAlterado)
                        if (loginJaExiste)
                        {
                            erro = 1;
                            MessageBox.Show("Já existe esta mesmo Login cadastado no sistema");
                        }
                }
            if (erro == 0)
            {
                ItemConsultarUsuarioModel usuarioModel = (ItemConsultarUsuarioModel)ContextHelper.GetData("Usuario");
                string acesso = TypeExtension.ObterDescricao((AcessoEnum)Convert.ToInt16(Acesso));
                int codigo = 0;
                if (usuarioModel != null)
                    codigo = usuarioModel.Codigo;
                var usuarioSalvo = new UsuarioService().Salvar(Nome, Login, Senha, acesso, codigo);
                if (usuarioSalvo)
                {
                    MessageBox.Show("Operação realizada com sucesso!");

                    var listaUsuario = new UsuarioService().ObterUsuarios(string.Empty, 2, "Descrição");
                    var listaItemConsultarUsuarioModel = new List<ItemConsultarUsuarioModel>();
                    if (listaUsuario != null && listaUsuario.Any())
                        foreach (var item in listaUsuario)
                        {
                            var itemConsultarUsuarioModel = new ItemConsultarUsuarioModel();
                            itemConsultarUsuarioModel.Codigo = item.Codigo;
                            itemConsultarUsuarioModel.Nome = item.Nome;
                            itemConsultarUsuarioModel.Login = item.Login;
                            itemConsultarUsuarioModel.Situacao = item.Situacao ? "Ativo" : "Inativo";
                            itemConsultarUsuarioModel.Permissao = item.Permissao;
                            listaItemConsultarUsuarioModel.Add(itemConsultarUsuarioModel);
                        }
                    this.RefreshDgv(listaItemConsultarUsuarioModel);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
            }
        }

        #endregion

        #region [ Propriedades auxiliares ]

        private void Usuario_Load(object sender, EventArgs e) //Método para Inicial
        {
            //Método Inicial
            CarregarTela();
        }

        #endregion

        #region [ Implementação ]

        public string Nome
        {
            get
            {
                return NomeTextBox.Text;
            }
            set
            {
                NomeTextBox.Text = value;
            }
        }

        public string Login
        {
            get
            {
                return LoginTextBox.Text;
            }
            set
            {
                LoginTextBox.Text = value;
            }
        }

        public string Senha
        {
            get
            {
                return SenhaTextBox.Text;
            }
            set
            {
                SenhaTextBox.Text = value;
            }
        }

        public string ConfirmarSenha
        {
            get
            {
                return ConfirmarSenhaTextBox.Text;
            }
            set
            {
                ConfirmarSenhaTextBox.Text = value;
            }
        }

        public int? Acesso
        {
            get
            {
                return AcessoComboBox.SelectedValue.ToNullableInt();
            }
            set
            {
                AcessoComboBox.SelectedValue = value;
            }
        }

        public List<ItemListaModel> ListaAcesso
        {
            get
            {
                return (List<ItemListaModel>)AcessoComboBox.DataSource;
            }
            set
            {
                AcessoComboBox.DataSource = value;
                AcessoComboBox.DisplayMember = "Descricao";
                AcessoComboBox.ValueMember = "Codigo";
                AcessoComboBox.SelectedIndex = 0;
            }
        }

        public string NomeUsuarioSessao
        {
            get
            {
                return ContextHelper.GetData("NomeUsuario") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("NomeUsuario").ToString();
            }
            set
            {
                ContextHelper.SetData("NomeUsuario", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }

        public string LoginUsuarioSessao
        {
            get
            {
                return ContextHelper.GetData("LoginUsuario") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("LoginUsuario").ToString();
            }
            set
            {
                ContextHelper.SetData("LoginUsuario", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        #endregion

        #region [ Eventos ]

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Usuario");
        }

        public void CarregarTela() //Método para carregar a tela
        {
            ListaAcesso = typeof(AcessoEnum).ToItemListaModel();
            if (ModoEdicao())
            {
                NomeTextBox.Enabled = false;
                LoginTextBox.Enabled = false;
                PreencherInterface(ObterItemConsultaUsuarioarioModelSessao());
            }
        }

        private void PreencherInterface(UsuarioModel usuarioModel) //Método para preencher a tela na alteração de Usuário
        {
            Nome = usuarioModel.Nome;
            Login = usuarioModel.Login;
            NomeUsuarioSessao = usuarioModel.Nome;
            LoginUsuarioSessao = usuarioModel.Login;
            int? tipoAcesso = null;
            if (usuarioModel.Permissao != null)
            {
                if (usuarioModel.Permissao == "Funcionário")
                    tipoAcesso = 0;

                if (usuarioModel.Permissao == "Gerente")
                    tipoAcesso = 1;

                if (usuarioModel.Permissao == "Administrador")
                    tipoAcesso = 2;
            }

            Acesso = tipoAcesso;
        }

        public bool ModoEdicao()//Método para verificar se é uma edição
        {
            return ContextHelper.GetData("Usuario") != null;
        }

        private UsuarioModel ObterItemConsultaUsuarioarioModelSessao()//Método para recuperar o Usuario que está sendo alterado
        {
            ItemConsultarUsuarioModel usuarioModel = (ItemConsultarUsuarioModel)ContextHelper.GetData("Usuario");
            return new UsuarioService().GetUsuarioById(usuarioModel.Codigo);
        }

        #endregion
    }
}
