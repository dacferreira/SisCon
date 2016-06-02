using BLL.Service;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Extension;
using System.Diagnostics;
using System.IO;

namespace ProjetoFinal.Views
{
    public partial class Venda : Form, IManterVendaModel
    {
        #region [ Construtor ]
        public delegate void DoEvent(bool lista);
        public event DoEvent RefreshPricipalDgv;

        public Venda()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Implementação ]

        public string DescricaoProdutoCadastrado
        {
            get
            {
                return DescricaoProdutoCadastradoTextBox.Text;
            }
            set
            {
                DescricaoProdutoCadastradoTextBox.Text = value;
            }
        }
        public int? DescricaoQuantidadeLabel
        {
            get
            {
                return QuantidadeLabelTextBox.Text.ToNullableInt();
            }
            set
            {
                QuantidadeLabelTextBox.Text = value.ToString();
            }
        }
        public string DescricaoProduto
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

        public double? PrecoUnitario
        {
            get
            {
                return PrecoUnitarioTextBox.Text.ToNullableDouble();
            }
            set
            {
                PrecoUnitarioTextBox.Text = value.ToString();
            }
        }

        public double? Quantidade
        {
            get
            {
                return QuantidadeTextBox.Text.ToNullableDouble();
            }
            set
            {
                QuantidadeTextBox.Text = value.ToString();
            }
        }

        public double? SubTotal
        {
            get
            {
                return SubTotalTextBox.Text.ToNullableDouble();
            }
            set
            {
                SubTotalTextBox.Text = value.ToString();
            }
        }

        public double? Total
        {
            get
            {
                return TotalTextBox.Text.ToNullableDouble();
            }
            set
            {
                TotalTextBox.Text = value.ToString();
            }
        }

        public List<ItemConsultarProdutoModelVenda> ListaProduto
        {
            get
            {
                return (List<ItemConsultarProdutoModelVenda>)ConsultaProdutoVendadataGridView.DataSource;
            }
            set
            {
                ConsultaProdutoVendadataGridView.DataSource = value;
                ConsultaProdutoVendadataGridView.AutoResizeColumns();
            }
        }

        #endregion

        public void fm_RefreshDgv(double valor)
        {
            var novalista = new List<ItemConsultarProdutoModelVenda>();
            novalista = ListaProduto;
            foreach (var item in novalista)
            {
                if (!item.Desconto)
                {
                    item.PrecoCompra = item.PrecoCompra - ((item.PrecoCompra * valor) / 100);
                    item.Desconto = true;
                }
            }
            ListaProduto = new List<ItemConsultarProdutoModelVenda>();
            ListaProduto = novalista;
            calcularTotal();
        }

        private void Venda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                if (ListaProduto != null && ListaProduto.Any())
                {

                    DialogResult resultado = MessageBox.Show("Deseja Abandonar a venda?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ListaProduto = new List<ItemConsultarProdutoModelVenda>();
                        DescricaoProdutoCadastrado = string.Empty;
                        PrecoUnitario = default(double);
                        Quantidade = default(double);
                        Total = default(double);
                        SubTotal = default(double);
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Deseja Abandonar a venda?", "Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.Close();
                        RemoverObjetosSessao();
                        //this.RefreshPricipalDgv(true);
                    }
                    else
                        return;
                }
            }
            if (e.KeyValue.Equals(113)) //F2 Alterar Quantidade
            {
                alterarQuantidade();
            }
            if (e.KeyValue.Equals(116)) //F5 Desconto
            {
                //if (ListaProduto != null && ListaProduto.Count() > 0)
                //{
                //    ContextHelper.SetData("ValorTotal", Total);
                //    SenhaDesconto senhaDesconto = new SenhaDesconto();
                //    senhaDesconto.RefreshDgv += new SenhaDesconto.DoEvent(fm_RefreshDgv);
                //    senhaDesconto.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("Necessário ter Produtos na lista de Venda, para usar esta Função.");
                //}
            }
            if (e.KeyValue.Equals(119)) //F8 
            {
                formaPagamento();
            }
            if (e.KeyValue.Equals(122)) //F11 
            {
                gerarOrcamento();

            }
        }

        private void gerarOrcamento()
        {
            UsuarioModel user = new UsuarioModel();
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
                user = new UsuarioService().GetUsuarioById(usuarioLogado.Codigo);

            var pasta = @"C:\arquivos\orcamento.txt";
            var stw = new StreamWriter(pasta, false, Encoding.Default);
            stw.WriteLine("                      ORÇAMENTO                              ");
            stw.WriteLine("                                                             ");
            stw.WriteLine("SMC LTDA");
            stw.WriteLine("RUA PEDRA DO SINO, 70 - PACIÊNCIA");
            stw.WriteLine("Telefone: (21) 2404-30255");
            stw.WriteLine("--------------------------------------------------------------");
            stw.WriteLine("DATA EMISSÃO");
            stw.WriteLine("" + DateTime.Now + "");
            stw.WriteLine("VENDEDOR: " + user.Nome + "");
            //stw.WriteLine("-------------------------------------------------------------");
            //stw.WriteLine("             ENTREGA");
            //stw.WriteLine("CLIENTE : " );
            //stw.WriteLine("ENDERECO: " );
            //stw.WriteLine("TELEFONE: " );
            stw.WriteLine("-------------------------------------------------------------");
            stw.WriteLine("COD PROD   DESCRICAO/MARCA    QTD   PRECO UNIT    TOTAL ITEM");

            foreach (var item in ListaProduto)
            {
                string descricao = item.Descricao + "/" + item.Marca;
                int espacoDescricao = 20;
                int espacoCodigo = 11;
                int espacoPrecoUnitario = 15;
                int espacoQuantidade = 6;

                int novoespacoDescricao = 0;
                int novoespacoCodigo = 0;
                int novoespacoPrecoUnitario = 0;
                int novoespacoQuantidade = 0;



                string itemCodigo = string.Empty;
                itemCodigo = item.Codigo.ToString();
                string descricaoCodigo = itemCodigo;

                if (!itemCodigo.Length.EhMaiorQue(espacoCodigo))
                {
                    novoespacoCodigo = espacoCodigo - itemCodigo.Length;
                    for (int i = 0; i < novoespacoCodigo; i++)
                    {
                        descricaoCodigo = descricaoCodigo + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoCodigo; i++)
                    {
                        descricaoCodigo = descricaoCodigo.Remove(20, 30);
                    }
                }


                if (!descricao.Length.EhMaiorQue(espacoDescricao))
                {
                    novoespacoDescricao = espacoDescricao - descricao.Length;
                    for (int i = 0; i < novoespacoDescricao; i++)
                    {
                        descricao = descricao + " ";
                    }
                }
                else
                {
                    descricao = descricao.Substring(0, 16) + "... ";
                }
                string itemQuantidade = string.Empty;
                itemQuantidade = item.Quantidade.ToString();
                string descricaoQuantidade = itemQuantidade;

                if (!itemQuantidade.Length.EhMaiorQue(espacoQuantidade))
                {
                    novoespacoQuantidade = espacoQuantidade - itemQuantidade.Length;
                    for (int i = 0; i < novoespacoQuantidade; i++)
                    {
                        descricaoQuantidade = descricaoQuantidade + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoDescricao; i++)
                    {
                        descricaoQuantidade = descricaoQuantidade.Remove(20, 30);
                    }
                }

                string itemPrecoUni = string.Empty;
                itemPrecoUni = item.PrecoVenda.ToString();
                string descricaoPrecoUnitario = itemPrecoUni;

                if (!itemPrecoUni.Length.EhMaiorQue(espacoPrecoUnitario))
                {
                    novoespacoPrecoUnitario = espacoPrecoUnitario - itemPrecoUni.Length;
                    for (int i = 0; i < novoespacoPrecoUnitario; i++)
                    {
                        descricaoPrecoUnitario = descricaoPrecoUnitario + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoPrecoUnitario; i++)
                    {
                        descricaoPrecoUnitario = descricaoPrecoUnitario.Remove(20, 30);
                    }
                }

                stw.WriteLine("" + descricaoCodigo + descricao + descricaoQuantidade + descricaoPrecoUnitario + item.PrecoCompra + "");
            }

            stw.WriteLine("-------------------------------------------------------------");
            stw.WriteLine("                                      TOTAL DO ORÇAMENTO: " + Total);

            stw.Flush();

            var ps = new Process();
            ps.StartInfo.FileName = pasta;
            ps.Start();
        }

        private void formaPagamento()
        {
            if (ListaProduto != null && ListaProduto.Count() > 0)
            {
                ContextHelper.SetData("ValorTotal", Total);
                ContextHelper.SetData("DadosVenda", ListaProduto);
                FormaPagamento formaPagamento = new FormaPagamento();
                formaPagamento.RefreshDgv += new FormaPagamento.DoEvent(fm_RefreshTela);
                formaPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Necessário ter Produtos na lista de Venda, para usar esta Função.");
            }
        }

        private void alterarQuantidade()
        {
            //QuantidadeTextBox.Enabled = true;
            //QuantidadeTextBox.Focus();
            AlterarQuantidade alterarQuantidade = new AlterarQuantidade();
            AdicionarQuantidadeLabelSessao(true);
            alterarQuantidade.RefreshQuantidadeDgv += new AlterarQuantidade.DoEvent2(fm_RefreshLabelQuantidadeProdutoDgv);
            alterarQuantidade.ShowDialog();
        }

        private void AdicionarQuantidadeLabelSessao(bool valor)
        {
            ContextHelper.SetData("InserirQuantidade", valor);
        }

        private void fm_RefreshLabelQuantidadeProdutoDgv(int quantidade)
        {
            DescricaoQuantidadeLabel = quantidade;
        }

        private void fm_RefreshTela(bool valor)
        {
            if (valor)
            {
                ListaProduto = new List<ItemConsultarProdutoModelVenda>();
                Quantidade = default(double?);
                Total = default(double?);
                DescricaoProdutoCadastrado = string.Empty;
                PrecoUnitario = default(double?);
                DescricaoProduto = string.Empty;
                SubTotal = default(double?);

                List<String> lista = PreencherListaProduto();
                DescricaoProdutoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(lista.ToArray());
                DescricaoProdutoTextBox.AutoCompleteCustomSource = data;
                DescricaoProdutoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DescricaoProdutoTextBox.Focus();
            }
        }

        private void DescricaoProdutoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Quantidade = DescricaoQuantidadeLabel.Value;

                if (Quantidade != null && Quantidade > 0)
                {
                    var listaProduto = new ProdutoService().ObterProdutos(string.Empty, 2, "Descrição");
                    var teste = DescricaoProduto.Split('-');
                    string descricao = DescricaoProduto.Split('-').FirstOrDefault().Trim();
                    string marca = string.Empty;
                    if (teste.Count() > 1)
                        marca = DescricaoProduto.Split('-').LastOrDefault().Trim();
                    var produto = new ProdutoModel();
                    if (!string.IsNullOrWhiteSpace(marca))
                        produto = listaProduto.Where(p => p.Descricao.ToUpper() == descricao.ToUpper() && p.Marca.ToUpper() == marca.ToUpper()).FirstOrDefault();
                    else
                        produto = listaProduto.Where(p => p.Descricao.ToUpper() == descricao.ToUpper()).FirstOrDefault();

                    var verificaProduto = new ItemConsultarProdutoModelVenda();

                    if (ListaProduto != null && ListaProduto.Count() > 0 && produto != null)
                        verificaProduto = ListaProduto.Where(p => p.Codigo == produto.Codigo).FirstOrDefault();
                    if (ListaProduto == null || (verificaProduto == null || verificaProduto.Codigo == 0))
                    {
                        if (produto != null)
                        {
                            if (DescricaoQuantidadeLabel.Value <= produto.SaldoAtual)
                            {
                                PrecoUnitario = produto.PrecoVenda;
                                SubTotal = produto.PrecoVenda * Quantidade;
                                DescricaoProdutoCadastrado = produto.Descricao + ((!string.IsNullOrWhiteSpace(produto.Marca)) ? (" - " + produto.Marca) : string.Empty);

                                List<ItemConsultarProdutoModelVenda> lista = new List<ItemConsultarProdutoModelVenda>();

                                ItemConsultarProdutoModelVenda item = new ItemConsultarProdutoModelVenda();
                                if (ListaProduto != null && ListaProduto.Count() > 0)
                                    lista.AddRange(ListaProduto);

                                item.Codigo = produto.Codigo;
                                item.Descricao = produto.Descricao;
                                item.EstoqueAtual = produto.SaldoAtual;
                                item.EstoqueMinimo = produto.EstoqueMinimo;
                                item.Localizacao = produto.Localizacao;
                                item.Marca = produto.Marca;
                                item.MargemLucro = produto.MargemLucro;
                                item.PrecoCompra = String.Format("{0:0.00}", produto.PrecoVenda * DescricaoQuantidadeLabel.Value).ToDouble();
                                item.PrecoVenda = String.Format("{0:0.00}", produto.PrecoVenda).ToDouble();
                                item.Quantidade = DescricaoQuantidadeLabel.Value;
                                DescricaoProduto = string.Empty;
                                lista.Add(item);

                                ListaProduto = lista;
                                DescricaoQuantidadeLabel = 1;

                                calcularTotal();
                            }

                            else
                            {
                                MessageBox.Show("Quantidade ultrapassa Saldo existente. \n\n Saldo Atual: " + produto.SaldoAtual);
                                AlterarQuantidade alterarQuantidade = new AlterarQuantidade();
                                AdicionarQuantidadeLabelSessao(true);
                                alterarQuantidade.RefreshQuantidadeDgv += new AlterarQuantidade.DoEvent2(fm_RefreshLabelQuantidadeProdutoDgv);
                                alterarQuantidade.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto já inserido na lista.");
                    }
                }
            }
        }
        
        private void calcularTotal()
        {
            double valorTotal1 = 0;

            //var valorTotalDesconto = ContextHelper.GetData("ValorTotalDesconto") != null ? Convert.ToDouble(ContextHelper.GetData("ValorTotalDesconto")) : 0;
            //if (valorTotalDesconto != null && valorTotalDesconto == 0)
            //{
                foreach (DataGridViewRow item in ConsultaProdutoVendadataGridView.Rows)
                {
                    valorTotal1 = valorTotal1 + Convert.ToDouble(item.Cells[3].Value);
                }
                if (ConsultaProdutoVendadataGridView.RowCount != null)
                {
                    Total = valorTotal1;
                }
                else
                {
                    Total = null;
                }
            //}
            //else
            //{
            //    Total = valorTotalDesconto + SubTotal;
            //}
        }
        
        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("ValorTotalDesconto");
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            DescricaoQuantidadeLabel = 1;
            //populando auto-complete
            List<String> lista = PreencherListaProduto();
            DescricaoProdutoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(lista.ToArray());
            DescricaoProdutoTextBox.AutoCompleteCustomSource = data;
            DescricaoProdutoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DescricaoProdutoTextBox.Focus();
        }

        private List<string> PreencherListaProduto()
        {
            var listaUsuario = new ProdutoService().ObterProdutos(string.Empty, 2, "Descrição");
            List<string> listDadosString = new List<string>();
            if (listaUsuario != null && listaUsuario.Any())
                foreach (var item in listaUsuario.Where(p => p.Situacao == true && p.SaldoAtual > 0))
                {
                    listDadosString.Add(item.Descricao + (!string.IsNullOrWhiteSpace(item.Marca) ? " - " + item.Marca : string.Empty));
                }
            return listDadosString;
        }

        private void QuantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrecoUnitario != null)
                SubTotal = PrecoUnitario * Quantidade;
        }

        private void QuantidadeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QuantidadeTextBox.Enabled = false;
                DescricaoProdutoTextBox.Focus();
            }
            EntradaInteiro(sender, e);
        }
        
        protected bool NaoNumeroDigitado;

        private void QuantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

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

        private void CancelarItemButton_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = ConsultaProdutoVendadataGridView.SelectedRows.Count;
            List<int> listaindice = new List<int>();
            for (int i = 0; i < selectedCellCount; i++)
            {
                int indice = ConsultaProdutoVendadataGridView.SelectedRows[i].Index;
                listaindice.Add(indice);
            }
            if (listaindice != null && listaindice.Count() > 0)
            {
                List<ItemConsultarProdutoModelVenda> lista = new List<ItemConsultarProdutoModelVenda>();
                lista = ListaProduto;
                foreach (var item in listaindice)
                {
                    ItemConsultarProdutoModelVenda produtoModel = ListaProduto[item];
                    lista.Remove(produtoModel);
                }
                ListaProduto = new List<ItemConsultarProdutoModelVenda>();
                ListaProduto = lista;
                DescricaoProdutoCadastrado = string.Empty;
                calcularTotal();
                PrecoUnitario = default(double);
                Quantidade = default(double);
                SubTotal = default(double);
            }
            else
            {
                MessageBox.Show("Necessário Selecionar um item para cancelar!");
            }
            DescricaoProdutoTextBox.Focus();
        }

        private void DescricaoProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                DescricaoProdutoTextBox.SelectedText = Char.ToUpper(e.KeyChar).ToString();

                e.Handled = true;
            }
        }
        
        private void AlterarQuantidadeButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ConsultaProdutoVendadataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ConsultaProdutoVendadataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }

            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutoVendadataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutoVendadataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                alterarQuantidade(listaindice.FirstOrDefault());
            }
            DescricaoProdutoTextBox.Focus();
        }

        private void alterarQuantidade(int indiceLinhaSelecionada)
        {
            //Método para alterar
            ItemConsultarProdutoModelVenda clienteModel = ListaProduto[indiceLinhaSelecionada];
            AdicionarProdutoCadastradoSessao(clienteModel);
            AdicionarListaProdutoCadastradoSessao(ListaProduto);
            AdicionarQuantidadeLabelSessao(false);
            AlterarQuantidade alterarQuantidade = new AlterarQuantidade();
            alterarQuantidade.RefreshDgv += new AlterarQuantidade.DoEvent(fm_RefreshQuantidadeProdutoDgv);
            alterarQuantidade.ShowDialog();
        }

        private void fm_RefreshQuantidadeProdutoDgv(List<ItemConsultarProdutoModelVenda> lista)
        {
            ListaProduto = lista;
        }
        private void AdicionarProdutoCadastradoSessao(ItemConsultarProdutoModelVenda produtoModelVenda)
        {
            ContextHelper.SetData("ConsultarProdutoModelVenda", produtoModelVenda);
        }
        private void AdicionarListaProdutoCadastradoSessao(List<ItemConsultarProdutoModelVenda> listaprodutoModelVenda)
        {
            ContextHelper.SetData("ListaConsultarProdutoModelVenda", listaprodutoModelVenda);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Devolucao devolucao = new Devolucao();
            devolucao.ShowDialog();
        }

        private void MovimentoDiarioButton_Click(object sender, EventArgs e)
        {
            List<IVendaModel> listanovaVenda = new VendaService().GetAll();
            List<IVendaModel> listaNEWVenda = listanovaVenda.Where(p => p.Data.Date == DateTime.Today.Date).ToList();


            UsuarioModel user = new UsuarioModel();
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
                user = new UsuarioService().GetUsuarioById(usuarioLogado.Codigo);

            var pasta = @"C:\arquivos\movimetodiario.txt";
            var stw = new StreamWriter(pasta, false, Encoding.Default);
            stw.WriteLine("                   MOVIMENTO DIÁRIO                          ");
            stw.WriteLine("                                                             ");
            stw.WriteLine("SMC LTDA");
            stw.WriteLine("RUA PEDRA DO SINO, 70 - PACIÊNCIA");
            stw.WriteLine("Telefone: (21) 2404-30255");
            stw.WriteLine("----------------------------------------------------------------------");
            stw.WriteLine("DATA EMISSAO");
            stw.WriteLine("" + DateTime.Now + "");
            stw.WriteLine("VENDEDOR: " + user.Nome + "");
            stw.WriteLine("----------------------------------------------------------------------");
            stw.WriteLine("COD VENDA   FORMA DE PAGAMENTO                             TOTAL VENDA");

            foreach (var item in listaNEWVenda)
            {
                int espacoCodigo = 12;
                int espacoFormaPagamento = 49;

                int novoespacoCodigo = 0;
                int novoespacoFormaPagamento = 0;

                string itemCodigo = string.Empty;
                itemCodigo = item.Id.ToString();
                string descricaoCodigo = itemCodigo;

                if (!itemCodigo.Length.EhMaiorQue(espacoCodigo))
                {
                    novoespacoCodigo = espacoCodigo - itemCodigo.Length;
                    for (int i = 0; i < novoespacoCodigo; i++)
                    {
                        descricaoCodigo = descricaoCodigo + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoCodigo; i++)
                    {
                        descricaoCodigo = descricaoCodigo.Remove(20, 30);
                    }
                }

                string formaPagamento = string.Empty;
                formaPagamento = item.Dinheiro > 0 ? "Dinheiro" : string.Empty;

                if (string.IsNullOrWhiteSpace(formaPagamento))
                    formaPagamento = item.Credito > 0 ? "Cartão de Crédito" : string.Empty;
                else
                    formaPagamento = formaPagamento + (item.Credito > 0 ? " - Cartão de Crédito" : string.Empty);

                if (string.IsNullOrWhiteSpace(formaPagamento))
                    formaPagamento = item.Credito > 0 ? "Cartão de Débito" : string.Empty;
                else
                    formaPagamento = formaPagamento + (item.Debito > 0 ? " - Cartão de Débito" : string.Empty);


                string itemFormaPagamento = string.Empty;
                itemFormaPagamento = formaPagamento;
                string descricaoFormaPagamento = itemFormaPagamento;

                if (!itemFormaPagamento.Length.EhMaiorQue(espacoFormaPagamento))
                {
                    novoespacoFormaPagamento = espacoFormaPagamento - itemFormaPagamento.Length;
                    for (int i = 0; i < novoespacoFormaPagamento; i++)
                    {
                        descricaoFormaPagamento = descricaoFormaPagamento + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoFormaPagamento; i++)
                    {
                        descricaoFormaPagamento = descricaoFormaPagamento.Remove(20, 30);
                    }
                }

                stw.WriteLine("" + descricaoCodigo + descricaoFormaPagamento + String.Format("{0:0.00}", item.ValorTotal) + "");
            }

            stw.WriteLine("----------------------------------------------------------------------");

            double valortotal = listaNEWVenda.Sum(p => p.ValorTotal);
            double valortotalDinheiro = listaNEWVenda.Sum(p => p.Dinheiro.HasValue ?p.Dinheiro.Value : 0);
            double valortotalCredito = listaNEWVenda.Sum(p => p.Credito.HasValue ? p.Credito.Value : 0);
            double valortotalDebito = listaNEWVenda.Sum(p => p.Debito.HasValue ? p.Debito.Value : 0);

            stw.WriteLine("                                 TOTAL DA VENDA EM DINHEIRO: " + String.Format("{0:0.00}", valortotalDinheiro));
            stw.WriteLine("                        TOTAL DE VENDA EM CARTÃO DE CRÉDITO: " + String.Format("{0:0.00}", valortotalCredito));
            stw.WriteLine("                         TOTAL DE VENDA EM CARTÃO DE DÉBITO: " + String.Format("{0:0.00}", valortotalDebito));
            stw.WriteLine("                                                             ");
            stw.WriteLine("                                       TOTAL DE VENDA GERAL: " + String.Format("{0:0.00}", valortotal));

            stw.Flush();

            var ps = new Process();
            ps.StartInfo.FileName = pasta;
            ps.Start();
        }
    }
}
