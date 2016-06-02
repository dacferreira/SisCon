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
    public partial class ConsultarCliente : Form, IConsultarClienteModel
    {
        #region [ Construtor ]
        public ConsultarCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Propriedades auxiliares ]
        private void ConsultarCliente_Load(object sender, EventArgs e)
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
                return ConsultaTextBox.Text;
            }
            set
            {
                ConsultaTextBox.Text = value;
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

        public List<ItemConsultarClienteModel> ListaCliente
        {
            get
            {
                return (List<ItemConsultarClienteModel>)ConsultaClientedataGridView.DataSource;
            }
            set
            {
                ConsultaClientedataGridView.DataSource = value;
                ConsultaClientedataGridView.AutoResizeColumns();
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
            ContextHelper.FreeNamedDataSlot("Cliente");
            Cliente fProduto = new Cliente();
            fProduto.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
            fProduto.ShowDialog();
        }

        public void ExibirColunasBotoesAcao(bool exibir)
        {
        }

        private void PesquisaClienteGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }
        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            pesquisarCliente();
        }

        public void CarregarTela()
        {
            ListaSituacao = typeof(SituacaoEnum).ToItemListaModel().OrderByDescending(p => p.Codigo).ToList();
            ListaFiltro = typeof(FiltroClienteEnum).ToItemListaModel();
            pesquisarCliente();
        }

        public void pesquisarCliente()
        {
            string filtro = TypeExtension.ObterDescricao((FiltroClienteEnum)Convert.ToInt16(Filtro));
            var listaUsuario = new ClienteService().ObterClientes(Nome, 2, filtro);
            var listaItemConsultarClienteModel = new List<ItemConsultarClienteModel>();
            if (listaUsuario != null && listaUsuario.Any())
                foreach (var item in listaUsuario)
                {
                    var itemConsultarClienteModel = new ItemConsultarClienteModel();
                    itemConsultarClienteModel.Codigo = item.Codigo;
                    itemConsultarClienteModel.CPF = !string.IsNullOrWhiteSpace(item.CPF) ? item.CPF : item.CNPJ;
                    itemConsultarClienteModel.RG = !string.IsNullOrWhiteSpace(item.RG) ? item.RG : item.InscEstadual;
                    itemConsultarClienteModel.Nome = !string.IsNullOrWhiteSpace(item.Nome) ? item.Nome : item.RazaoSocial;
                    itemConsultarClienteModel.CNPJ = item.CNPJ;
                    itemConsultarClienteModel.RazaoSocial = item.RazaoSocial;
                    itemConsultarClienteModel.InscEstadual = item.InscEstadual;
                    itemConsultarClienteModel.Endereco = item.Endereco;
                    itemConsultarClienteModel.Telefone = item.Telefone;
                    itemConsultarClienteModel.InscEstadual = item.InscEstadual;
                    itemConsultarClienteModel.Celular = item.Celular;
                    itemConsultarClienteModel.CEP = item.CEP;
                    itemConsultarClienteModel.Cidade = item.Cidade;
                    itemConsultarClienteModel.Obs = item.Obs;
                    itemConsultarClienteModel.UF = item.UF;
                    listaItemConsultarClienteModel.Add(itemConsultarClienteModel);
                }
            ListaCliente = listaItemConsultarClienteModel;
            ConsultaClientedataGridView.Refresh();
            if (!ListaCliente.Any() || ListaCliente.Count == 0)
            {
                DialogResult resultado = MessageBox.Show("Nenhum registro foi encontrado, deseja cadastrar um novo?", "Nenhum registro encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Nome = string.Empty;
                    ContextHelper.SetData("FecharCliente", true);
                    Cliente produto = new Cliente();
                    produto.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
                    produto.ShowDialog();
                }
            }
        }

        public void editarCliente(int indiceLinhaSelecionada)
        {
            //Método para alterar
            ItemConsultarClienteModel clienteModel = ListaCliente[indiceLinhaSelecionada];
            AdicionarClienteSessao(clienteModel);
            Cliente cliente = new Cliente();
            cliente.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
            cliente.ShowDialog();
        }
        void fm_RefreshDgv(List<ItemConsultarClienteModel> lista)
        {
            ListaCliente = lista;
        }
        public void inativarCliente(int indiceLinhaSelecionada)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente inativar o Cliente?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (resultado == DialogResult.Yes)
             {
                 //Método para Excluir
                 ItemConsultarClienteModel CLienteModel = ListaCliente[indiceLinhaSelecionada];
                 var produtoExcluido = new ClienteService().Excluir(CLienteModel.Codigo);
                 if (produtoExcluido)
                 {
                     MessageBox.Show("Operação realizada com sucesso!");
                     pesquisarCliente();
                 }
                 else
                     MessageBox.Show("Ocorreu um erro ao realizar a operação.");
             }
        }

        private void ativarCliente(int indiceLinhaSelecionada)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente ativar o Cliente?", "Ativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (resultado == DialogResult.Yes)
              {
                  //Método para Ativar
                  ItemConsultarClienteModel clienteModel = ListaCliente[indiceLinhaSelecionada];
                  var produtoAtivado = new ClienteService().Ativar(clienteModel.Codigo);
                  if (produtoAtivado)
                  {
                      MessageBox.Show("Operação realizada com sucesso!");
                      pesquisarCliente();
                  }
                  else
                      MessageBox.Show("Ocorreu um erro ao realizar a operação.");
              }
        }
        public void Visualizar(int indiceLinhaSelecionada)
        {
            //Método para Visualizar
        }

        private void AdicionarClienteSessao(ItemConsultarClienteModel clienteModel)
        {
            ContextHelper.SetData("Cliente", clienteModel);
        }

        public void EnterMethod()
        {
            PesquisarButton.PerformClick();
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
            if (ConsultaClientedataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaClientedataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaClientedataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaClientedataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                editarCliente(listaindice.FirstOrDefault());
            }
        }

        private void InativarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaClientedataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaClientedataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaClientedataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaClientedataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                ItemConsultarClienteModel CLienteModel = ListaCliente[listaindice.FirstOrDefault()];
                var cliente = new ClienteService().GetClienteById(CLienteModel.Codigo);
                if (cliente.Situacao)
                    inativarCliente(listaindice.FirstOrDefault());
                else
                    MessageBox.Show("Não é permitido inativar um cliente que já está inativo.");
            }
        }

        private void AtivarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaClientedataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaClientedataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaClientedataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaClientedataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }

                ItemConsultarClienteModel CLienteModel = ListaCliente[listaindice.FirstOrDefault()];
                var cliente = new ClienteService().GetClienteById(CLienteModel.Codigo);
                if (!cliente.Situacao)
                    ativarCliente(listaindice.FirstOrDefault());
                else
                    MessageBox.Show("Não é permitido ativar um cliente que já está ativo.");
                
            }
        }
    }
}
