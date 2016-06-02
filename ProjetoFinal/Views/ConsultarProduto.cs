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
    public partial class ConsultarProduto : Form, IConsultarProdutoModel
    {
        #region [ Construtor ]

        public ConsultarProduto()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Propriedades auxiliares ]
        private void ConsultarProduto_Load(object sender, EventArgs e)
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

        public List<ItemConsultarProdutoModel> ListaProduto
        {
            get
            {
                return (List<ItemConsultarProdutoModel>)ConsultaProdutodataGridView.DataSource;
            }
            set
            {
                ConsultaProdutodataGridView.DataSource = value;
                ConsultaProdutodataGridView.AutoResizeColumns();
                ConsultaProdutodataGridView.AutoGenerateColumns = true;
                //if (Convert.ToInt16(SituacaoComboBox.SelectedValue) == (short)SituacaoEnum.Inativo)
                //    ExibirColunasBotoesAcao(false);
                //else
                //    ExibirColunasBotoesAcao(true);
            }
        }
        #endregion

        #region [ Eventos ]

        private void NovoButton_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (!usuarioLogado.Permissao.Equals("Funcionário"))
                {
                    ContextHelper.FreeNamedDataSlot("Produto");
                    Produto fProduto = new Produto();
                    fProduto.RefreshDgv += new Produto.DoEvent(fm_RefreshDgv);
                    fProduto.ShowDialog();
                }
            }
            else
                MessageBox.Show("Usuáio não possui permissão a essa Funcionalidade.");
        }

        public void ExibirColunasBotoesAcao(bool exibir)
        {
        }

        private void PesquisaProdutoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            pesquisarProduto();
            //VerificarEstoque();
        }

        public void CarregarTela()
        {
            ListaSituacao = typeof(SituacaoEnum).ToItemListaModel().OrderByDescending(p => p.Codigo).ToList();
            ListaFiltro = typeof(FiltroPodutoEnum).ToItemListaModel();
            pesquisarProduto();
        }

        public void pesquisarProduto()
        {
            ListaProduto = new List<ItemConsultarProdutoModel>();
            string filtro = TypeExtension.ObterDescricao((FiltroPodutoEnum)Convert.ToInt16(Filtro));
            var listaUsuario = new ProdutoService().ObterProdutos(Nome, Situacao.ToInt(), filtro);
            var listaItemConsultarProdutoModel = new List<ItemConsultarProdutoModel>();
            if (listaUsuario != null && listaUsuario.Any())
                foreach (var item in listaUsuario)
                {
                    var itemConsultarProdutoModel = new ItemConsultarProdutoModel();
                    itemConsultarProdutoModel.Codigo = item.Codigo;
                    itemConsultarProdutoModel.Descricao = item.Descricao;
                    itemConsultarProdutoModel.Marca = item.Marca;
                    itemConsultarProdutoModel.PrecoCompra = item.PrecoCompra;
                    itemConsultarProdutoModel.PrecoVenda = item.PrecoVenda;
                    itemConsultarProdutoModel.MargemLucro = item.MargemLucro;
                    itemConsultarProdutoModel.Localizacao = item.Localizacao;
                    itemConsultarProdutoModel.EstoqueMinimo = item.EstoqueMinimo;
                    itemConsultarProdutoModel.EstoqueAtual = item.SaldoAtual;
                    itemConsultarProdutoModel.Situacao = item.Situacao ? "Ativo" : "Inativo";
                    listaItemConsultarProdutoModel.Add(itemConsultarProdutoModel);
                }
            ListaProduto = listaItemConsultarProdutoModel;

            if (!ListaProduto.Any() || ListaProduto.Count == 0)
            {

                UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                if (usuarioLogado != null)
                {
                    if (!usuarioLogado.Permissao.Equals("Funcionário"))
                    {
                        DialogResult resultado = MessageBox.Show("Nenhum registro foi encontrado, deseja cadastrar um novo?", "Nenhum registro encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            Nome = string.Empty;
                            Produto produto = new Produto();
                            produto.RefreshDgv += new Produto.DoEvent(fm_RefreshDgv);
                            produto.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("Nenhum registro encontrado!");
                }
            }
        }

        public void editarProduto(int indiceLinhaSelecionada)
        {
            //Método para alterar
            ItemConsultarProdutoModel produtoModel = ListaProduto[indiceLinhaSelecionada];
            string texto = produtoModel.Descricao.Split('\n').FirstOrDefault();
            texto = texto.Split('\r').FirstOrDefault();
            produtoModel.Descricao = texto;
            AdicionarProdutoSessao(produtoModel);
            Produto produto = new Produto();
            produto.RefreshDgv += new Produto.DoEvent(fm_RefreshDgv);
            produto.ShowDialog();
        }
        void fm_RefreshDgv(List<ItemConsultarProdutoModel> lista)
        {
            ListaProduto = lista;
            //VerificarEstoque();
        }
        public bool inativarProduto(int indiceLinhaSelecionada)
        {
            //Método para Excluir            
            ItemConsultarProdutoModel produtoModel = ListaProduto[indiceLinhaSelecionada];
            return new ProdutoService().Excluir(produtoModel.Codigo);
        }

        private bool ativarProduto(int indiceLinhaSelecionada)
        {
            //Método para Ativar
            ItemConsultarProdutoModel produtoModel = ListaProduto[indiceLinhaSelecionada];
            return new ProdutoService().Ativar(produtoModel.Codigo);
        }

        public void Visualizar(int indiceLinhaSelecionada)
        {
            //Método para Visualizar
        }

        private void AlterarPreco(int indiceLinhaSelecionada)
        {
            //Método para AlterarPreco
            ItemConsultarProdutoModel produtoModel = ListaProduto[indiceLinhaSelecionada];
            AdicionarProdutoSessao(produtoModel);
            AlterarPreco alterarPreco = new AlterarPreco();

            alterarPreco.RefreshDgv += new AlterarPreco.DoEvent(fm_RefreshDgv);
            alterarPreco.ShowDialog();
        }

        private void lancarSaldo(int indiceLinhaSelecionada)
        {
            //Método para LancarSaldo
            ItemConsultarProdutoModel produtoModel = ListaProduto[indiceLinhaSelecionada];
            AdicionarProdutoSessao(produtoModel);
            LancaSaldo lancarSaldo = new LancaSaldo();
            lancarSaldo.RefreshDgv += new LancaSaldo.DoEvent(fm_RefreshDgv);
            lancarSaldo.ShowDialog();
        }

        private void AdicionarProdutoSessao(ItemConsultarProdutoModel produtoModel)
        {
            ContextHelper.SetData("Produto", produtoModel);
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

        public void VerificarEstoque()
        {
            foreach (DataGridViewRow r in ConsultaProdutodataGridView.Rows)
            {
                if (Convert.ToDouble(r.Cells[8].Value) < Convert.ToDouble(r.Cells[7].Value))
                {
                    ConsultaProdutodataGridView.Rows[r.Index].DefaultCellStyle.BackColor = Color.Yellow;
                    ConsultaProdutodataGridView.Rows[r.Index].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            ConsultaProdutodataGridView.Refresh();
        }

        private void ConsultaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        #endregion

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaProdutodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                editarProduto(listaindice.FirstOrDefault());
            }
        }

        private void InativarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }
            if (ConsultaProdutodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }

                try
                {
                    ItemConsultarProdutoModel model = ListaProduto[listaindice.FirstOrDefault()];
                    var produto = new ProdutoService().GetProdutoById(model.Codigo);
                    if (produto.Situacao)
                    {
                        if (produto.SaldoAtual <= 0)
                        {
                            DialogResult resultado = MessageBox.Show("Deseja realmente inativar o(s) Produto(s)?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                inativarProduto(listaindice.FirstOrDefault());

                                MessageBox.Show("Operação realizada com sucesso!");
                                pesquisarProduto();
                            }
                        }
                        else
                            MessageBox.Show("Não é permitido inativar um Produto que possui saldo diferente de zero.");
                    }
                    else
                        MessageBox.Show("Não é permitido inativar um Produto que já está inativo.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
                }
                
            }
        }

        private void AtivarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }
            if (ConsultaProdutodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }

                try
                {

                    ItemConsultarProdutoModel model = ListaProduto[listaindice.FirstOrDefault()];
                    var produto = new ProdutoService().GetProdutoById(model.Codigo);
                    if (!produto.Situacao)
                    {
                        DialogResult resultado = MessageBox.Show("Deseja realmente ativar o(s) Produto(s)?", "Ativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            ativarProduto(listaindice.FirstOrDefault());

                            MessageBox.Show("Operação realizada com sucesso!");
                            pesquisarProduto();
                        }
                    }
                    else
                        MessageBox.Show("Não é permitido ativar um Produto que já está ativo.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
                }
            
            }
        }

        private void LancarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaProdutodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                
                ItemConsultarProdutoModel model = ListaProduto[listaindice.FirstOrDefault()];
                    var produto = new ProdutoService().GetProdutoById(model.Codigo);
                    if (produto.Situacao)
                    {
                        lancarSaldo(listaindice.FirstOrDefault());
                    }
                    else
                    {
                        MessageBox.Show("Não é permitido lançar saldo para produto inativo.");
                    }


            }
        }

        private void PrecoButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutodataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaProdutodataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutodataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutodataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                
                ItemConsultarProdutoModel model = ListaProduto[listaindice.FirstOrDefault()];
                var produto = new ProdutoService().GetProdutoById(model.Codigo);
                if (produto.Situacao)
                {
                    AlterarPreco(listaindice.FirstOrDefault());
                }
                else
                {
                    MessageBox.Show("Não é permitido lançar saldo para produto inativo.");
                }
            }
        }
    }
}
