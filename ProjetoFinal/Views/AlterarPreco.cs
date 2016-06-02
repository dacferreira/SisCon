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
    public partial class AlterarPreco : Form, IAlterarPreco
    {

        #region [ Construtor ]

        public delegate void DoEvent(List<ItemConsultarProdutoModel> lista);
        public event DoEvent RefreshDgv;

        public AlterarPreco()
        {
            InitializeComponent();
        }
        
        #endregion

        #region [ Implementação ]

        public double? Preco
        {
            get
            {
                return PrecoTextBox.Text.ToNullableDouble();
            }
            set
            {
                PrecoTextBox.Text = value.ToString();
            }
        }

        public double? PrecoAtual
        {
            get
            {
                return PrecoAtualTextBox.Text.ToNullableDouble();
            }
            set
            {
                PrecoAtualTextBox.Text = value.ToString();
            }
        }

        #endregion

        #region [ Eventos]

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (PrecoAtual == null)
            {
                erro = 1;
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
            }
            if (erro == 0)
            {
                ItemConsultarProdutoModel produtoModel = (ItemConsultarProdutoModel)ContextHelper.GetData("Produto");
                if (produtoModel != null)
                {
                    var produtoSalvo = new ProdutoService().Salvar(produtoModel.Descricao, produtoModel.Marca, produtoModel.PrecoCompra, PrecoAtual.Value, produtoModel.MargemLucro, produtoModel.Localizacao,  produtoModel.EstoqueAtual, produtoModel.Codigo);
                    if (produtoSalvo)
                    {
                        MessageBox.Show("Operação realizada com sucesso!");
                        RemoverObjetosSessao();
                        Preco = default(double);
                        PrecoAtual = default(double);
                        var listaUsuario = new ProdutoService().ObterProdutos(string.Empty, 2, "Descrição");
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
                        this.RefreshDgv(listaItemConsultarProdutoModel);  
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao realizar a operação.");
                    }
                }
            }
        }

        private void AlterarPreco_Load(object sender, EventArgs e)
        {
            //Método Inicial
            CarregarTela();
        }

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Produto");
        }

        public void CarregarTela() //Método para carregar a tela
        {
            if (ModoEdicao())
            {
                PreencherInterface(ObterItemConsultaProdutooModelSessao());
            }
        }

        private void PreencherInterface(ProdutoModel produtoModel) //Método para preencher a tela na alteração de Usuário
        {
            Preco = produtoModel.PrecoVenda;
        }

        public bool ModoEdicao()//Método para verificar se é uma edição
        {
            return ContextHelper.GetData("Produto") != null;
        }

        private ProdutoModel ObterItemConsultaProdutooModelSessao()//Método para recuperar o Usuario que está sendo alterado
        {
            ItemConsultarProdutoModel produtoModel = (ItemConsultarProdutoModel)ContextHelper.GetData("Produto");
            return new ProdutoService().GetProdutoById(produtoModel.Codigo);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
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

        private void LancamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaDecimal(sender, e);
        }

        private void LancamentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        #endregion
    }
}
