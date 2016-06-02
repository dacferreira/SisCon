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
    public partial class Entrega : Form, IEntregaModel
    {
        #region [ Construtor ]

        public Entrega()
        {
            InitializeComponent();
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
                SituacaoComboBox.SelectedIndex = 2;
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

        public List<ItemEntregaModel> ListaEntrega
        {
            get
            {
                return (List<ItemEntregaModel>)ConsultaEntregadataGridView.DataSource;
            }
            set
            {
                ConsultaEntregadataGridView.DataSource = value;
                ConsultaEntregadataGridView.AutoResizeColumns();
            }
        }
        #endregion

        #region [ Propriedades auxiliares ]
        private void Entrega_Load(object sender, EventArgs e)
        {
            //Método Inicial
            CarregarTela();
        }
        #endregion

        #region [ Eventos ]

        public void CarregarTela()
        {
            ListaSituacao = typeof(SituacaoEntregaEnum).ToItemListaModel().ToList();
            ListaFiltro = typeof(FiltroEntregaEnum).ToItemListaModel();
            consultarEntrega();
        }

        #endregion

        private void ConsultaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                consultarEntrega();
            }
        }

        private void consultarEntrega()
        {
            string filtro = TypeExtension.ObterDescricao((FiltroEntregaEnum)Convert.ToInt16(Filtro));
            string situacaoEntrega = TypeExtension.ObterDescricao((SituacaoEntregaEnum)Convert.ToInt16(Situacao));
            var listaEntregas = new EntregaService().ObterEntregas(Nome, situacaoEntrega, filtro);

            List<ItemEntregaModel> lsita = new List<ItemEntregaModel>();

            if (listaEntregas.Any())
            {
                foreach (var item in listaEntregas)
                {
                    ItemEntregaModel entrega = new ItemEntregaModel();
                    var usuario = new UsuarioService().GetUsuarioById(item.idUsuario.ToInt());
                    var cliente = new ClienteService().GetClienteById(item.idCliente.ToInt());
                    entrega.Codigo = item.Codigo;
                    entrega.DataCompra = item.DataCompra;
                    entrega.DataEntrega = item.DataEntrega;
                    entrega.Desconto = item.Desconto;

                    string formaPagamento = string.Empty;
                    formaPagamento = item.Dinheiro > 0 ? "Dinheiro" : string.Empty;

                    if (string.IsNullOrWhiteSpace(formaPagamento))
                        formaPagamento = item.Credito > 0 ? "Crédito" : string.Empty;
                    else
                        formaPagamento = formaPagamento + (item.Credito > 0 ? " - Crédito" : string.Empty);

                    if (string.IsNullOrWhiteSpace(formaPagamento))
                        formaPagamento = item.Credito > 0 ? "Débito" : string.Empty;
                    else
                        formaPagamento = formaPagamento + (item.Debito > 0 ? " - Débito" : string.Empty);

                    entrega.FormaPagamento = formaPagamento;
                    entrega.NomeUsuario = usuario.Nome;
                    entrega.NomeCliente = !string.IsNullOrWhiteSpace(cliente.CPF) ? cliente.Nome : cliente.RazaoSocial;
                    entrega.CPF = !string.IsNullOrWhiteSpace(cliente.CPF) ? cliente.CPF : cliente.CNPJ;
                    entrega.EnderecoCliente = cliente.Endereco;
                    entrega.IdVenda = item.idVenda;
                    entrega.QuantidadeParcela = item.QuantidadeParcela;
                    entrega.Telefone = cliente.Telefone;
                    entrega.Status = item.Status;
                    entrega.ValorTotal = item.ValorTotal;
                    lsita.Add(entrega);
                }
                List<ItemEntregaModel> novaLista = new List<ItemEntregaModel>();
                if (situacaoEntrega == "Todos")
                {
                    if (filtro == "NOME/RAZÃO SOCIAL")
                    {
                        novaLista = lsita.Where(p => p.NomeCliente.ToUpper().Contains(Nome.ToUpper())).ToList();
                    }
                    if (filtro == "CPF/CNPJ")
                    {
                        novaLista = lsita.Where(p => p.CPF.ToUpper().Contains(Nome.ToUpper())).ToList();
                    }

                    if (filtro == "Endereço")
                    {
                        novaLista = lsita.Where(p => p.EnderecoCliente.ToUpper().Contains(Nome.ToUpper())).ToList();
                    }
                    lsita = new List<ItemEntregaModel>();

                    lsita = novaLista;
                }
                else
                {

                    if (filtro == "NOME/RAZÃO SOCIAL")
                    {
                        novaLista = lsita.Where(p => p.NomeCliente.ToUpper().Contains(Nome.ToUpper()) && p.Status == situacaoEntrega).ToList();
                    }
                    if (filtro == "CPF/CNPJ")
                    {
                        novaLista = lsita.Where(p => p.CPF.ToUpper().Contains(Nome.ToUpper()) && p.Status == situacaoEntrega).ToList();
                    }

                    if (filtro == "Endereço")
                    {
                        novaLista = lsita.Where(p => p.EnderecoCliente.ToUpper().Contains(Nome.ToUpper()) && p.Status == situacaoEntrega).ToList();
                    }
                    lsita = new List<ItemEntregaModel>();

                    lsita = novaLista;
                }
            }
            else
                MessageBox.Show("Nenhum registro encontrado!");

            ListaEntrega = lsita.ToList();

            if(!ListaEntrega.Any())
                MessageBox.Show("Nenhum registro encontrado!");

        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            consultarEntrega();
        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaEntregadataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaEntregadataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaEntregadataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaEntregadataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                confirmarEntrega(listaindice.FirstOrDefault());
            }
        }

        private void confirmarEntrega(int indiceLinhaSelicionada)
        {
            ItemEntregaModel entregaModel = ListaEntrega[indiceLinhaSelicionada];

            if (entregaModel.Status == "Entregue com Atraso" || entregaModel.Status == "Entregue")
            {
                MessageBox.Show("Entrega já foi Realizada!");
            }
            else
            {

                DialogResult resultado = MessageBox.Show("Deseja Confirmar entrega?", "Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    //AdicionarEntregaSessao(entregaModel);
                    //ConfirmarEntrega confirmarEntrega = new ConfirmarEntrega();
                    //confirmarEntrega.RefreshDgv += new ConfirmarEntrega.DoEvent(fm_RefreshDgv);
                    //confirmarEntrega.ShowDialog();
                    entregaModel.Status = "Entregue";

                    bool entregaRealizada = new EntregaService().ConfirmarEntrega(entregaModel);

                    if (entregaRealizada)
                    {
                        MessageBox.Show("Entrega Realizada com sucesso!");
                        consultarEntrega();
                    }

                    else
                        MessageBox.Show("Ocorreu um erro ao realizar a operação!");
                }
            }
            //ItemEntregaModel itemEntrega = new ItemEntregaModel();
            //itemEntrega = ObterEntregaSessao();

        }

        private void fm_RefreshDgv(List<ItemEntregaModel> lsita)
        {
            if(lsita.Any())
            ListaEntrega = lsita;
        }

        private void AdicionarEntregaSessao(ItemEntregaModel entregaModel)
        {
            ContextHelper.SetData("Entrega", entregaModel);
        }

        private void ConsultaEntregadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            const short linkVisualizarCliente = 4;
            const short linkVisualizarEndereco = 6;

            switch (e.ColumnIndex)
            {
                case linkVisualizarCliente:
                    LinkVisualizar(e.RowIndex);
                    break;
            }
        }

        private void LinkVisualizar(int indiceLinhaSelecionada)
        {
            ItemEntregaModel entregaModel = ListaEntrega[indiceLinhaSelecionada];
            AdicionarEntregaSessaoVizualizar(entregaModel);
            VisualizarEntrega visualizarEntrega = new VisualizarEntrega();
            visualizarEntrega.ShowDialog();
        }

        private void AdicionarEntregaSessaoVizualizar(ItemEntregaModel entregaModel)
        {
            ContextHelper.SetData("VisualizarEntregaModel", entregaModel);
        }
    }
}
