using System;
using System.Collections.Generic;
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
    public partial class AlterarQuantidade : Form, IAlterarQuantidadeModel
    {
        public delegate void DoEvent(List<ItemConsultarProdutoModelVenda> lista);
        public event DoEvent RefreshDgv;
        public delegate void DoEvent2(int quantidade);
        public event DoEvent2 RefreshQuantidadeDgv;
        public delegate void DoEvent3(List<ItemConsultarProdutoDevolucao> lista);
        public event DoEvent3 RefreshDgvDevolucao;

        public AlterarQuantidade()
        {
            InitializeComponent();
        }


        #region [ Implementação ]

        public int? QuantidadeAtual
        {
            get
            {
                return QuantidadeAtualTextBox.Text.ToNullableInt();
            }
            set
            {
                QuantidadeAtualTextBox.Text = value.ToString();
            }
        }

        public int? NovaQuantidade
        {
            get
            {
                return NovaQuantidadeTextBox.Text.ToNullableInt();
            }
            set
            {
                NovaQuantidadeTextBox.Text = value.ToString();
            }
        }

        #endregion

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RemoverObjetosSessao();
        }

        private void AlterarQuantidade_Load(object sender, EventArgs e)
        {
            NovaQuantidadeTextBox.Focus();
            CarregarTela();
        }

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("ConsultarProdutoModelVenda");
            ContextHelper.FreeNamedDataSlot("ListaConsultarProdutoModelVenda");
        }

        public void CarregarTela() //Método para carregar a tela
        {
            if (ModoEdicao())
            {
                PreencherInterface(ObterItemConsultaProdutooModelSessao());
            }
            if (ModoEdicaoQuantidade())
            {
                QuantidadeAtual = 1;
            }
            if (ModoEdicaoQuantidadeDevolucao())
            {
                PreencherInterfaceDevolucao(ObterItemConsultaProdutoDevolucaoModelSessao());
            }
        }

        private void PreencherInterfaceDevolucao(ItemConsultarProdutoDevolucao itemConsultarProduto)
        {
            QuantidadeAtual = itemConsultarProduto.Quantidade.ToNullableInt();
        }

        private ItemConsultarProdutoDevolucao ObterItemConsultaProdutoDevolucaoModelSessao()
        {
            ItemConsultarProdutoDevolucao produtoModel = (ItemConsultarProdutoDevolucao)ContextHelper.GetData("ConsultarProdutoModelVendaDevolucao");
            return produtoModel;
        }

        private bool ModoEdicaoQuantidadeDevolucao()
        {
            return ContextHelper.GetData("ConsultarProdutoModelVendaDevolucao") != null;
        }

        private void PreencherInterface(ItemConsultarProdutoModelVenda produtoModel) //Método para preencher a tela na alteração de Usuário
        {
            QuantidadeAtual = produtoModel.Quantidade.ToNullableInt();
        }

        public bool ModoEdicao()//Método para verificar se é uma edição
        {
            return ContextHelper.GetData("ConsultarProdutoModelVenda") != null;
        }

        public bool ModoEdicaoQuantidade()
        {
            return ContextHelper.GetData("InserirQuantidade") != null;
        }

        private ItemConsultarProdutoModelVenda ObterItemConsultaProdutooModelSessao()//Método para recuperar o Usuario que está sendo alterado
        {
            ItemConsultarProdutoModelVenda produtoModel = (ItemConsultarProdutoModelVenda)ContextHelper.GetData("ConsultarProdutoModelVenda");
            return produtoModel;
        }

        private List<ItemConsultarProdutoModelVenda> ObterItemListaConsultaProdutooModelSessao()//Método para recuperar o Usuario que está sendo alterado
        {
            List<ItemConsultarProdutoModelVenda> listaprodutoModel = (List<ItemConsultarProdutoModelVenda>)ContextHelper.GetData("ListaConsultarProdutoModelVenda");
            return listaprodutoModel;
        }

        #region [ Mascaras para Decimal e Inteiro ]

        protected bool NaoNumeroDigitado;

        protected void EntradaDecimal(object sender, KeyEventArgs e)
        {
            NaoNumeroDigitado = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                    {
                        NaoNumeroDigitado = true;
                        if ((int)e.KeyCode == 110 || (int)e.KeyCode == 188)
                            if (!((TextBox)sender).Text.Contains(","))
                                NaoNumeroDigitado = false;
                    }

            if (ModifierKeys == Keys.Shift)
                NaoNumeroDigitado = true;
        }

        protected void EntradaInteiro(object sender, KeyEventArgs e)
        {
            NaoNumeroDigitado = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                        NaoNumeroDigitado = true;

            if (ModifierKeys == Keys.Shift)
                NaoNumeroDigitado = true;
        }

        #endregion

        private void NovaQuantidadeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInteiro(sender, e);
            EnterMethod(e);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salvar();
            }
        }

        private void NovaQuantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            int erro = 0;

            if (NovaQuantidade == null)
            {
                erro = 1;
                MessageBox.Show("Preencha o campo obrigatório.");
            }

            if (NovaQuantidade == 0)
            {
                erro = 1;
                MessageBox.Show("Valor deve ser maior que zero.");
            }
            if (erro == 0)
            {

                bool InserirQuantidade = ContextHelper.GetData("InserirQuantidade") != null ? (bool)ContextHelper.GetData("InserirQuantidade") : false;
                  
                ItemConsultarProdutoModelVenda produtoModel = ContextHelper.GetData("ConsultarProdutoModelVenda") != null ? (ItemConsultarProdutoModelVenda)ContextHelper.GetData("ConsultarProdutoModelVenda") : new ItemConsultarProdutoModelVenda();
                List<ItemConsultarProdutoModelVenda> listaprodutoModel = ContextHelper.GetData("ListaConsultarProdutoModelVenda") != null ? (List<ItemConsultarProdutoModelVenda>)ContextHelper.GetData("ListaConsultarProdutoModelVenda")  : new List<ItemConsultarProdutoModelVenda>();

                if (listaprodutoModel != null && listaprodutoModel.Any())
                {
                    List<ItemConsultarProdutoModelVenda> newlistaprodutoModel = new List<ItemConsultarProdutoModelVenda>();

                    if (listaprodutoModel.Any())
                    {
                        int erroQuantidade = 0;

                        foreach (var item in listaprodutoModel)
                        {
                            if (produtoModel != null && produtoModel.Codigo == item.Codigo && produtoModel.Marca == item.Marca && produtoModel.PrecoCompra == item.PrecoCompra)
                            {
                                var listaProduto = new ProdutoService().ObterProdutos(string.Empty, 2, "Descrição");
                                var produto = listaProduto.Where(p => p.Codigo == produtoModel.Codigo).FirstOrDefault();
                                if (produto.Codigo != null && produto.Codigo > 0)
                                {
                                    if (produto.SaldoAtual < NovaQuantidade.Value)
                                    {
                                        MessageBox.Show("Quantidade ultrapassa Saldo existente. \n\n Saldo Atual: " + produto.SaldoAtual);
                                        NovaQuantidadeTextBox.Focus();
                                        erroQuantidade = 1;
                                    }
                                }
                                if (erroQuantidade == 0)
                                {
                                    item.Quantidade = NovaQuantidade.ToInt();
                                    item.PrecoCompra = String.Format("{0:0.00}", item.PrecoVenda * NovaQuantidade.Value).ToDouble();
                                }
                            }
                            newlistaprodutoModel.Add(item);
                        }
                        if (erroQuantidade == 0)
                        {
                            this.RefreshDgv(listaprodutoModel);

                            ContextHelper.FreeNamedDataSlot("ConsultarProdutoModelVenda");
                            ContextHelper.FreeNamedDataSlot("ListaConsultarProdutoModelVenda");
                            this.Close();
                        }
                    }
                }
                List<ItemConsultarProdutoDevolucao> listaprodutoDevolucaoModel = ContextHelper.GetData("ListaConsultarProdutoModelVendaDevolucao") != null ? (List<ItemConsultarProdutoDevolucao>)ContextHelper.GetData("ListaConsultarProdutoModelVendaDevolucao") : new List<ItemConsultarProdutoDevolucao>();
                if (listaprodutoDevolucaoModel != null  && listaprodutoDevolucaoModel.Any())
                {
                    if (NovaQuantidade == 0)
                    {

                        MessageBox.Show("Valor da Quantidade deve ser maior que zero.");
                    }
                    else
                    {
                        ItemConsultarProdutoDevolucao produtoModelDevolucao = (ItemConsultarProdutoDevolucao)ContextHelper.GetData("ConsultarProdutoModelVendaDevolucao");
                        List<ItemConsultarProdutoDevolucao> listaprodutoModelDevolucao = (List<ItemConsultarProdutoDevolucao>)ContextHelper.GetData("ListaConsultarProdutoModelVendaDevolucao");

                        List<ItemConsultarProdutoDevolucao> newlistaprodutoModel = new List<ItemConsultarProdutoDevolucao>();

                        if (listaprodutoModelDevolucao.Any())
                        {
                            if (NovaQuantidade <= QuantidadeAtual)
                            {
                                foreach (var item in listaprodutoModelDevolucao)
                                {
                                    if (produtoModelDevolucao != null && produtoModelDevolucao.Codigo == item.Codigo && produtoModelDevolucao.Marca == item.Marca && produtoModelDevolucao.Valor == item.Valor)
                                    {
                                        item.Quantidade = NovaQuantidade.ToInt();
                                        item.Valor = String.Format("{0:0.00}", item.PrecoUnitario * NovaQuantidade.Value).ToDouble();
                                    }
                                    newlistaprodutoModel.Add(item);
                                }
                                ContextHelper.FreeNamedDataSlot("ConsultarProdutoModelVendaDevolucao");
                                ContextHelper.FreeNamedDataSlot("ListaConsultarProdutoModelVendaDevolucao");
                                this.RefreshDgvDevolucao(listaprodutoModelDevolucao);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Quantidade de devolução, não pode ser maior que a quantidade vendida.");
                        }
                    }
                }
                if (InserirQuantidade)
                {
                    RefreshQuantidadeDgv(NovaQuantidade.ToInt());
                    ContextHelper.FreeNamedDataSlot("InserirQuantidade");
                    this.Close();

                }
            }
        }
    }
}
