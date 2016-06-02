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
using DTO.Models;
using DTO.Enum;
using ProjetoFinal.Extension;

namespace ProjetoFinal.Views
{
    public partial class ConsultarUsuario : Form, IConsultarUsuarioModel
    {
        #region [ Construtor ]
        public ConsultarUsuario()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Propriedades auxiliares ]
        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            //Método Inicial
            CarregarTela();
        }
        #endregion

        #region [ Implementação ]

        public string NomeView
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

        public int? Situacao
        {
            get
            {
                return SituacaoComboBox.SelectedValue.ToNullableInt();
            }
            set
            {
                SituacaoComboBox.SelectedValue = value;
            }
        }
        public List<ItemListaModel> ListaSituacao
        {
            get { return (List<ItemListaModel>)SituacaoComboBox.DataSource; }
            set
            {
                SituacaoComboBox.DataSource = value;
                SituacaoComboBox.DisplayMember = "Descricao";
                SituacaoComboBox.ValueMember = "Codigo";
                SituacaoComboBox.SelectedIndex = 0;
            }
        }

        public int? Filtro
        {
            get
            {
                return FiltroComboBox.SelectedValue.ToNullableInt();
            }
            set
            {
                FiltroComboBox.SelectedValue = value;
            }
        }
        public List<ItemListaModel> ListaFiltro
        {
            get { return (List<ItemListaModel>)FiltroComboBox.DataSource; }
            set
            {
                FiltroComboBox.DataSource = value;
                FiltroComboBox.DisplayMember = "Descricao";
                FiltroComboBox.ValueMember = "Codigo";
                FiltroComboBox.SelectedIndex = 0;
            }
        }

        public List<ItemConsultarUsuarioModel> ListaUsuario
        {
            get
            {
                return (List<ItemConsultarUsuarioModel>)ConsultaUsuariodataGridView.DataSource;
            }
            set
            {
                ConsultaUsuariodataGridView.DataSource = value;
                ConsultaUsuariodataGridView.AutoResizeColumns();
                if (Convert.ToInt16(SituacaoComboBox.SelectedValue) == (short)SituacaoEnum.Inativo)
                    ExibirColunasBotoesAcao(false);
                else
                    ExibirColunasBotoesAcao(true);
            }
        }
        #endregion

        #region [ Eventos ]

        private void NovoButton_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador"))
                {
                    ContextHelper.FreeNamedDataSlot("Usuario");
                    Usuario fFuncionario = new Usuario();
                    fFuncionario.RefreshDgv += new Usuario.DoEvent(fm_RefreshDgv);
                    fFuncionario.ShowDialog();
                }
                else
                    MessageBox.Show("Usuáio não possui permissão a essa funcionalidade.");
            }
        }

        public void ExibirColunasBotoesAcao(bool exibir)
        {
        }

        private void PesquisaUsuarioGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void verificaLista()
        {
            const short botaoAlterar = 5;
            const short botaoExcluir = 6;
            const short botaoAtivar = 7;

            foreach (DataGridViewRow r in ConsultaUsuariodataGridView.Rows)
            {
                if (!Convert.ToBoolean(r.Cells[4].Value))
                {
                    r.DataGridView.Columns[botaoExcluir].Visible = false;
                    r.DataGridView.Columns[botaoAlterar].Visible = false;
                    r.DataGridView.Columns[botaoAtivar].Visible = true;
                }
                else
                {
                    r.DataGridView.Columns[botaoExcluir].Visible = true;
                    r.DataGridView.Columns[botaoAlterar].Visible = true;
                    r.DataGridView.Columns[botaoAtivar].Visible = true;
                }
            }
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            pesquisarUsuario();
        }

        public void CarregarTela()
        {
            ListaSituacao = typeof(SituacaoEnum).ToItemListaModel().OrderByDescending(p => p.Codigo).ToList();
            ListaFiltro = typeof(FiltroUsuarioEnum).ToItemListaModel();
            pesquisarUsuario();
        }

        public void pesquisarUsuario()
        {
            string filtro = TypeExtension.ObterDescricao((FiltroUsuarioEnum)Convert.ToInt16(Filtro));
            var listaUsuario = new UsuarioService().ObterUsuarios(NomeView, Situacao.ToInt(), filtro);
            var listaItemConsultarUsuarioModel = new List<ItemConsultarUsuarioModel>();
            if (listaUsuario != null && listaUsuario.Any())
                foreach (var item in listaUsuario)
                {
                    var itemConsultarUsuarioModel = new ItemConsultarUsuarioModel();
                    itemConsultarUsuarioModel.Codigo = item.Codigo;
                    itemConsultarUsuarioModel.Nome = item.Nome;
                    itemConsultarUsuarioModel.Login = item.Login;
                    itemConsultarUsuarioModel.Situacao = item.Situacao ? "Ativo" : "Inativo"; ;
                    itemConsultarUsuarioModel.Permissao = item.Permissao;
                    listaItemConsultarUsuarioModel.Add(itemConsultarUsuarioModel);
                }
            ListaUsuario = listaItemConsultarUsuarioModel;
            //verificaLista();
            if (!ListaUsuario.Any() || ListaUsuario.Count == 0)
            {
                UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                if (usuarioLogado != null)
                {
                    if (usuarioLogado.Permissao.Equals("Administrador"))
                    {
                        DialogResult resultado = MessageBox.Show("Nenhum registro foi encontrado, deseja cadastrar um novo?", "Nenhum registro encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            NomeView = string.Empty;
                            ContextHelper.SetData("FecharUsuario", true);
                            Usuario user = new Usuario();
                            user.RefreshDgv += new Usuario.DoEvent(fm_RefreshDgv);
                            user.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("Nenhum registro foi encontrado!");
                }
            }

        }

        public void editarUsuario(int indiceLinhaSelecionada)
        {
            //Método para alterar
            ItemConsultarUsuarioModel usuarioModel = ListaUsuario[indiceLinhaSelecionada];
            AdicionarFuncionarioSessao(usuarioModel);
            Usuario usuario = new Usuario();
            usuario.RefreshDgv += new Usuario.DoEvent(fm_RefreshDgv);
            usuario.ShowDialog();
        }
        void fm_RefreshDgv(List<ItemConsultarUsuarioModel> lista)
        {
            ListaUsuario = lista;
        }
        public void inativarUsuario(int indiceLinhaSelecionada)
        {
            //Método para Excluir
            DialogResult resultado = MessageBox.Show("Deseja realmente inativar o Usuario?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ItemConsultarUsuarioModel usuarioModel = ListaUsuario[indiceLinhaSelecionada];

                UsuarioModel usuarioLogadoModel = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                if (usuarioLogadoModel != null && usuarioModel.Codigo == usuarioLogadoModel.Codigo)
                    MessageBox.Show("Não é permitido inativar o usuário que está logado no Sistema.");

                else
                {
                    var usuarioExcluido = new UsuarioService().Excluir(usuarioModel.Codigo);
                    if (usuarioExcluido)
                    {
                        MessageBox.Show("Operação realizada com sucesso!");
                        pesquisarUsuario();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao realizar a operação.");
                }
            }
        }
        public void ativarUsuario(int indiceLinhaSelecionada)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente ativar o usuario?", "Ativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //Método para Ativar
                ItemConsultarUsuarioModel usuarioModel = ListaUsuario[indiceLinhaSelecionada];

                var usuarioAtivado = new UsuarioService().Ativar(usuarioModel.Codigo);
                if (usuarioAtivado)
                {
                    MessageBox.Show("Operação realizada com sucesso!");
                    pesquisarUsuario();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
            }
        }
        public void Visualizar(int indiceLinhaSelecionada)
        {
            //Método para Visualizar
        }

        private void AdicionarFuncionarioSessao(ItemConsultarUsuarioModel usuarioModel)
        {
            ContextHelper.SetData("Usuario", usuarioModel);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarButton.PerformClick();
            }
        }
        private void ConsultaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }
        #endregion

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaUsuariodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaUsuariodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaUsuariodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaUsuariodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                editarUsuario(listaindice.FirstOrDefault());
            }
        }

        private void InativarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaUsuariodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaUsuariodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaUsuariodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaUsuariodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }

                ItemConsultarUsuarioModel CLienteModel = ListaUsuario[listaindice.FirstOrDefault()];
                var usuario = new UsuarioService().GetUsuarioById(CLienteModel.Codigo);
                if (usuario.Situacao)
                    inativarUsuario(listaindice.FirstOrDefault());
                else
                    MessageBox.Show("Não é permitido inativar um usuário que já está inativo.");
            }
        }

        private void AtivarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaUsuariodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaUsuariodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaUsuariodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaUsuariodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }

                ItemConsultarUsuarioModel CLienteModel = ListaUsuario[listaindice.FirstOrDefault()];
                var usuario = new UsuarioService().GetUsuarioById(CLienteModel.Codigo);
                if (!usuario.Situacao)
                    ativarUsuario(listaindice.FirstOrDefault());
                else
                    MessageBox.Show("Não é permitido ativar um usuário que já está ativo.");
            }
        }
    }
}
