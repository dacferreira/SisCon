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
    public partial class Produto : Form, IManterPodutoModel
    {
        #region [ Construtor ]
        public delegate void DoEvent(List<ItemConsultarProdutoModel> lista);
        public event DoEvent RefreshDgv;

        public Produto()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]

        public string Descricao
        {
            get
            {
                return DescricaoProdutoTextBox.Text;
            }
            set
            {
                DescricaoProdutoTextBox.Text = value;
            }
        }

        public string Marca
        {
            get
            {
                return MarcaTextBox.Text;
            }
            set
            {
                MarcaTextBox.Text = value;
            }
        }

        public double? PrecoCompra
        {
            get
            {
                return PrecoCompraProdutoTextBox.Text.ToNullableDouble();
            }
            set
            {
                PrecoCompraProdutoTextBox.Text = value.ToString();
            }
        }

        public double? PrecoVenda
        {
            get
            {
                return PrecoVendaTextBox.Text.ToNullableDouble();
            }
            set
            {
                PrecoVendaTextBox.Text = value.ToString();
            }
        }

        public double? MargemLucro
        {
            get
            {
                return MargemLucroTextBox.Text.ToNullableDouble();
            }
            set
            {
                MargemLucroTextBox.Text = value.ToString();
            }
        }

        public string Localizacao
        {
            get
            {
                return LocalizacaoTextBox.Text;
            }
            set
            {
                LocalizacaoTextBox.Text = value;
            }
        }

        public double? EstoqueMinimo
        {
            get
            {
                return EstoqueMinimoTextBox.Text.ToNullableDouble();
            }
            set
            {
                EstoqueMinimoTextBox.Text = value.ToString();
            }
        }

        public double? EstoqueAtual
        {
            get
            {
                return EstoqueAtualTextBox.Text.ToNullableDouble();
            }
            set
            {
                EstoqueAtualTextBox.Text = value.ToString();
            }
        }

        public string NomeProdutoSessao
        {
            get
            {
                return ContextHelper.GetData("NomeProduto") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("NomeProduto").ToString();
            }
            set
            {
                ContextHelper.SetData("NomeProduto", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }

        public string MarcaProdutoSessao
        {
            get
            {
                return ContextHelper.GetData("MarcaProduto") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("MarcaProduto").ToString();
            }
            set
            {
                ContextHelper.SetData("MarcaProduto", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        #endregion

        #region [ Propriedades auxiliares ]

        private void Produto_Load(object sender, EventArgs e) //Método para Inicial
        {
            //Método Inicial
            CarregarTela();
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

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (string.IsNullOrWhiteSpace(Descricao) ||  PrecoCompra == null || PrecoVenda == null || MargemLucro == null || string.IsNullOrWhiteSpace(Localizacao)
                                               || EstoqueAtual == null)
            {
                erro = 1;
                MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
            }
            bool nomeAlterado = NomeProdutoSessao != Descricao;
            bool marcaAlterado = MarcaProdutoSessao != Marca;
            if (nomeAlterado || marcaAlterado)
            {
                bool nomeJaExiste = new ProdutoService().ExisteNome(Descricao);
                bool marcaJaExiste = new ProdutoService().ExisteMarca(Marca);

                if (nomeJaExiste && marcaJaExiste)
                {
                    erro = 1;
                    MessageBox.Show("Já existe esta Descrição desta marca cadastada no sistema");
                }
            }

            if (erro == 0)
            {
                ItemConsultarProdutoModel produtoModel = (ItemConsultarProdutoModel)ContextHelper.GetData("Produto");
                int codigo = 0;
                if (produtoModel != null)
                    codigo = produtoModel.Codigo;
                var produtoSalvo = new ProdutoService().Salvar(Descricao, Marca, PrecoCompra.Value, PrecoVenda.Value, MargemLucro.Value, Localizacao, EstoqueAtual.Value, codigo);
                if (produtoSalvo)
                {
                    MessageBox.Show("Operação realizada com sucesso!");
                    RemoverObjetosSessao();
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
                            itemConsultarProdutoModel.Situacao = item.Situacao ? "Ativo" : "Inativo"; ;
                            listaItemConsultarProdutoModel.Add(itemConsultarProdutoModel);
                        }
                    this.Close();
                    this.RefreshDgv(listaItemConsultarProdutoModel);

                    //Método para LancarSaldo


                    //ItemConsultarProdutoModel produtoModelnovo = new ItemConsultarProdutoModel();
                    //produtoModelnovo.Codigo = listaUsuario.LastOrDefault().Codigo;
                    //produtoModelnovo.Descricao = listaUsuario.LastOrDefault().Descricao;
                    //produtoModelnovo.EstoqueAtual = listaUsuario.LastOrDefault().SaldoAtual;
                    //produtoModelnovo.EstoqueMinimo = listaUsuario.LastOrDefault().EstoqueMinimo;
                    //produtoModelnovo.Localizacao = listaUsuario.LastOrDefault().Localizacao;
                    //produtoModelnovo.Marca = listaUsuario.LastOrDefault().Marca;
                    //produtoModelnovo.MargemLucro = listaUsuario.LastOrDefault().MargemLucro;
                    //produtoModelnovo.PrecoCompra = listaUsuario.LastOrDefault().PrecoCompra;
                    //produtoModelnovo.PrecoVenda = listaUsuario.LastOrDefault().PrecoVenda;
                    //produtoModelnovo.Situacao = listaUsuario.LastOrDefault().Situacao == true ? "Ativo" : "Inativo";

                    //AdicionarProdutoLacamentoSessao(produtoModelnovo);
                    //LancaSaldo lancarSaldo = new LancaSaldo();
                    //lancarSaldo.ShowDialog();
                }
            }
        }

        private void AdicionarProdutoLacamentoSessao(ItemConsultarProdutoModel produtoModelnovo)
        {
            ContextHelper.SetData("Produto", produtoModelnovo);
        }

        #endregion

        #region [ Eventos ]

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Produto");
        }

        public void CarregarTela() //Método para carregar a tela
        {
            if (ModoEdicao())
            {
                DescricaoProdutoTextBox.Enabled = false;
                MarcaTextBox.Enabled = false;
                EstoqueAtualTextBox.Enabled = false;
                PreencherInterface(ObterItemConsultaProdutooModelSessao());
            }
            else{
                EstoqueMinimo = 0;
                EstoqueAtual = 0;
            }
        }

        private void PreencherInterface(ProdutoModel produtoModel) //Método para preencher a tela na alteração de Usuário
        {
            //Descricao = produtoModel.Descricao;
            string texto = produtoModel.Descricao.Split('\n').FirstOrDefault();
            texto = texto.Split('\r').FirstOrDefault();
            Descricao = texto;
            Marca = produtoModel.Marca;
            PrecoCompra = produtoModel.PrecoCompra;
            PrecoVenda = produtoModel.PrecoVenda;
            MargemLucro = produtoModel.MargemLucro;
            Localizacao = produtoModel.Localizacao;
            EstoqueMinimo = produtoModel.EstoqueMinimo;
            EstoqueAtual = produtoModel.SaldoAtual;
            NomeProdutoSessao = produtoModel.Descricao;
            MarcaProdutoSessao = produtoModel.Marca;
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
        
        private void MargemLucroTextBox_TextChanged(object sender, EventArgs e)
        {
            if(PrecoCompra != null && MargemLucro != null)
            PrecoVenda = ((PrecoCompra * MargemLucro) / 100) + PrecoCompra;

            if(MargemLucro == null)
                PrecoVenda = default(double);
        }

        private void PrecoCompraProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrecoCompra != null && MargemLucro != null)
                PrecoVenda = ((PrecoCompra * MargemLucro) / 100) + PrecoCompra;

            if(PrecoCompra == null)
                PrecoVenda = default(double);
        }

        string str = "";
        private void PrecoCompraProdutoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //EntradaDecimal(sender, e);
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                PrecoCompraProdutoTextBox.Text = "";
            }
            if (str.Length == 1)
            {
                PrecoCompraProdutoTextBox.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                PrecoCompraProdutoTextBox.Text = "0," + str;
            }
            else if (str.Length > 2)
            {
                PrecoCompraProdutoTextBox.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void PrecoCompraProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (NaoNumeroDigitado)
                e.Handled = true;
        }

        string str2 = "";
        private void MargemLucroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInteiro(sender, e);
        }

        private void MargemLucroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void EstoqueMinimoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaDecimal(sender, e);
        }

        private void EstoqueMinimoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void EstoqueAtualTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInteiro(sender, e);
        }

        private void EstoqueAtualTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
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

        private void PrecoVendaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //EntradaDecimal(sender, e);
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str2.Length > 0))
            {
                str2 = str2.Substring(0, str2.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str2 = str2 + Convert.ToChar(KeyCode);
            }
            if (str2.Length == 0)
            {
                PrecoVendaTextBox.Text = "";
            }
            if (str2.Length == 1)
            {
                PrecoVendaTextBox.Text = "0,0" + str2;
            }
            else if (str2.Length == 2)
            {
                PrecoVendaTextBox.Text = "0," + str2;
            }
            else if (str2.Length > 2)
            {
                PrecoVendaTextBox.Text = str2.Substring(0, str2.Length - 2) + "," +
                                str2.Substring(str2.Length - 2);
            }
        }

        private void PrecoVendaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;

        }

        private void PrecoVendaTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (PrecoCompra != null && PrecoVenda != null)
            //    MargemLucro = (100 * (PrecoVenda - PrecoCompra)) / PrecoCompra;

            //if (PrecoCompra == null || PrecoVenda == null)
            //    PrecoVenda = default(double);
        }
        
        #endregion
    }
}
