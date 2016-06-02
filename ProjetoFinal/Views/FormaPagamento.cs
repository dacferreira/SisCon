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
using BLL.Service;
using System.IO;
using System.Diagnostics;

namespace ProjetoFinal.Views
{
    public partial class FormaPagamento : Form, IFormaPagamentoModel
    {
        #region [ Construtor ]

        public delegate void DoEvent(bool valor);
        public event DoEvent RefreshDgv;
        public FormaPagamento()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]

        public string Descricao
        {
            get { return DescricaoProdutoTextBox.Text; }
            set { DescricaoProdutoTextBox.Text = value; }
        }

        public string RazaoSocial
        {
            get { return RazaoSocialTextBox.Text; }
            set { RazaoSocialTextBox.Text = value; }
        }

        public int? DescontoValor
        {
            get
            {
                return DescontoTextBox.Text.ToNullableInt();
            }
            set
            {
                DescontoTextBox.Text = value.ToString();
            }
        }
        public string Endereco
        {
            get { return EnderecoTextBox.Text; }
            set { EnderecoTextBox.Text = value; }
        }

        public string Telefone
        {
            get { return TelefoneTextBox.Text; }
            set { TelefoneTextBox.Text = value; }
        }

        public double? Dinheiro
        {
            get
            {
                return DinheiroTextBox.Text.ToNullableDouble();
            }
            set
            {
                DinheiroTextBox.Text = String.Format("{0:0.00}", value);
            }
        }

        public double? Debito
        {
            get
            {
                return DebitoTextBox.Text.ToNullableDouble();
            }
            set
            {
                DebitoTextBox.Text = String.Format("{0:0.00}", value);
            }
        }

        public double? Credito
        {
            get
            {
                return CreditoTextBox.Text.ToNullableDouble();
            }
            set
            {
                CreditoTextBox.Text = String.Format("{0:0.00}", value);
            }
        }


        public double? TotalVenda
        {
            get
            {
                return TotalVendaTextBox.Text.ToNullableDouble();
            }
            set
            {
                TotalVendaTextBox.Text = String.Format("{0:0.00}", value);
            }
        }

        public double? Troco
        {
            get
            {
                return TrocoTextBox.Text.ToNullableDouble();
            }
            set
            {
                TrocoTextBox.Text = String.Format("{0:0.00}", value);
            }
        }

        public double? ValorPago
        {
            get
            {
                return ValorPagoTextBox.Text.ToNullableDouble();
            }
            set
            {
                ValorPagoTextBox.Text = String.Format("{0:0.00}", value);
            }
        }

        public bool Entrega
        {
            get
            {
                return EntregaCheckBox.Checked;
            }
            set
            {
                EntregaCheckBox.Checked = value;
            }
        }

        public bool Desconto
        {
            get
            {
                return DescontoCheckBox.Checked;
            }
            set
            {
                DescontoCheckBox.Checked = value;
            }
        }
        public bool EhDinheiro
        {
            get
            {
                return DinheiroCheckBox.Checked;
            }
            set
            {
                DinheiroCheckBox.Checked = value;
            }
        }
        public bool EhDebito
        {
            get
            {
                return DebitoCheckBox.Checked;
            }
            set
            {
                DebitoCheckBox.Checked = value;
            }
        }
        public bool EhCredito
        {
            get
            {
                return CreditoCheckBox.Checked;
            }
            set
            {
                CreditoCheckBox.Checked = value;
            }
        }
        public bool NotaFiscal
        {
            get
            {
                return NotaFiscalCheckBox.Checked;
            }
            set
            {
                NotaFiscalCheckBox.Checked = value;
            }
        }

        public int? Vezes
        {
            get
            {
                return CreditoComboBox.SelectedValue.ToNullableInt();
            }
            set
            {
                CreditoComboBox.SelectedValue = value;
            }
        }

        public List<int> ListaVezes
        {
            get
            {
                return (List<int>)CreditoComboBox.DataSource; 
            }
            set
            {
                CreditoComboBox.DataSource = value;
                CreditoComboBox.DisplayMember = "Descricao";
                CreditoComboBox.SelectedIndex = 0;
            }
        }
        #endregion

        private void EntregaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Entrega)
            {
                DescricaoProdutoTextBox.Enabled = true;
                DescricaoProdutoTextBox.Focus();
                NovoClienteButton.Enabled = true;
                ConfirmarProdutosEntrega confirmarEntrega = new ConfirmarProdutosEntrega();
                confirmarEntrega.ShowDialog();
            }
            else
            {
                DescricaoProdutoTextBox.Enabled = false;
                NovoClienteButton.Enabled = false;
                AlterarButton.Enabled = false;
                RazaoSocial = string.Empty;
                Endereco = string.Empty;
                Telefone = string.Empty;
                DescricaoProdutoTextBox.Text = "Digite o nome do Cliente";
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            RemoverObjetosSessao();
            this.Close();
        }

        private void FormaPagamento_Load(object sender, EventArgs e)
        {
            EhDinheiro = true;
            Double? valorTotal = ContextHelper.GetData("ValorTotal") != null ? Convert.ToDouble(ContextHelper.GetData("ValorTotal")) : default(double);
            TotalVenda = valorTotal;
            Dinheiro = valorTotal;
            ValorPago = valorTotal;
            //populando auto-complete
            List<String> lista = PreencherListaCliente();
            DescricaoProdutoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(lista.ToArray());
            DescricaoProdutoTextBox.AutoCompleteCustomSource = data;
            DescricaoProdutoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DescricaoProdutoTextBox.Focus();

            List<int> listavezes = new List<int>();
            listavezes.Add(1);
            listavezes.Add(2);
            listavezes.Add(3);
            listavezes.Add(4);
            listavezes.Add(6);
            listavezes.Add(7);
            listavezes.Add(8);
            listavezes.Add(9);
            listavezes.Add(10);
            listavezes.Add(11);
            listavezes.Add(12);

            ListaVezes = listavezes;            
        }

        private List<string> PreencherListaCliente()
        {
            var listaCliente = new ClienteService().ObterClientes(string.Empty, 2, "NOME/RAZÃO SOCIAL");
            List<string> listDadosString = new List<string>();
            if (listaCliente != null && listaCliente.Any())
                foreach (var item in listaCliente)
                {
                    listDadosString.Add((item.PessoaFisica ? item.Nome + " - " + item.CPF : item.RazaoSocial + " - " + item.CNPJ));
                }
            return listDadosString;
        }

        #region [ Métodos Auxiliares]

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

        string str = "";
        private void DinheiroTextBox_KeyDown(object sender, KeyEventArgs e)
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
                DinheiroTextBox.Text = "";
            }
            if (str.Length == 1)
            {
                DinheiroTextBox.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                DinheiroTextBox.Text = "0," + str;
            }
            else if (str.Length > 2)
            {
                DinheiroTextBox.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void DinheiroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (NaoNumeroDigitado)
            //    e.Handled = true;
            e.Handled = true;
        }

        string str2 = "";
        private void DebitoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //EntradaDecimal(sender, e);
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
                DebitoTextBox.Text = "";
            }
            if (str2.Length == 1)
            {
                DebitoTextBox.Text = "0,0" + str2;
            }
            else if (str2.Length == 2)
            {
                DebitoTextBox.Text = "0," + str2;
            }
            else if (str2.Length > 2)
            {
                DebitoTextBox.Text = str2.Substring(0, str2.Length - 2) + "," +
                                str2.Substring(str2.Length - 2);
            }
        }

        private void DebitoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (NaoNumeroDigitado)
                e.Handled = true;
        }

        string str3 = "";
        private void CreditoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //EntradaDecimal(sender, e);
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
            if (((KeyCode == 8) || (KeyCode == 46)) && (str3.Length > 0))
            {
                str3 = str3.Substring(0, str3.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str3 = str3 + Convert.ToChar(KeyCode);
            }
            if (str3.Length == 0)
            {
                CreditoTextBox.Text = "";
            }
            if (str3.Length == 1)
            {
                CreditoTextBox.Text = "0,0" + str3;
            }
            else if (str3.Length == 2)
            {
                CreditoTextBox.Text = "0," + str3;
            }
            else if (str3.Length > 2)
            {
                CreditoTextBox.Text = str3.Substring(0, str3.Length - 2) + "," +
                                str3.Substring(str3.Length - 2);
            }
        }

        private void CreditoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void DescricaoProdutoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(Descricao))
                {
                    string descricao = Descricao.Split('-').FirstOrDefault().Trim();
                    bool nomeexiste = new ClienteService().ExisteNome(descricao);
                    bool razaoSocialexiste = new ClienteService().ExisteRazaoSocial(descricao);
                    if (nomeexiste || razaoSocialexiste)
                    {
                        var listaCliente = new ClienteService().ObterClientes(descricao, 2, "NOME/RAZÃO SOCIAL");
                        if (listaCliente.Count() > 0)
                        {
                            RazaoSocial = listaCliente.FirstOrDefault().PessoaFisica == true ? listaCliente.FirstOrDefault().Nome : listaCliente.FirstOrDefault().RazaoSocial;
                            Endereco = listaCliente.FirstOrDefault().Endereco;
                            Telefone = listaCliente.FirstOrDefault().Telefone;
                            AlterarButton.Enabled = true;
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("Nenhum registro foi encontrado, deseja cadastrar um novo?", "Nenhum registro encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                ContextHelper.SetData("FecharCliente", true);
                                Cliente produto = new Cliente();
                                produto.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
                                produto.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Nenhum registro foi encontrado, deseja cadastrar um novo?", "Nenhum registro encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            ContextHelper.SetData("FecharCliente", true);
                            Cliente produto = new Cliente();
                            produto.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
                            produto.ShowDialog();
                        }
                    }
                }
            }
        }

        #endregion

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RazaoSocial))
            {
                var listaCliente = new ClienteService().ObterClientes(RazaoSocial, 2, "NOME/RAZÃO SOCIAL");
                if (listaCliente.Count() > 0)
                {
                    ItemConsultarClienteModel clienteModel = new ItemConsultarClienteModel();
                    clienteModel.Celular = listaCliente.FirstOrDefault().Celular;
                    clienteModel.Telefone = listaCliente.FirstOrDefault().Telefone;
                    clienteModel.CEP = listaCliente.FirstOrDefault().CEP;
                    clienteModel.Cidade = listaCliente.FirstOrDefault().Cidade;
                    clienteModel.CNPJ = listaCliente.FirstOrDefault().CNPJ;
                    clienteModel.Codigo = listaCliente.FirstOrDefault().Codigo;
                    clienteModel.CPF = listaCliente.FirstOrDefault().CPF;
                    clienteModel.Endereco = listaCliente.FirstOrDefault().Endereco;
                    clienteModel.InscEstadual = listaCliente.FirstOrDefault().InscEstadual;
                    clienteModel.Nome = listaCliente.FirstOrDefault().Nome;
                    clienteModel.Obs = listaCliente.FirstOrDefault().Obs;
                    clienteModel.RazaoSocial = listaCliente.FirstOrDefault().RazaoSocial;
                    clienteModel.RG = listaCliente.FirstOrDefault().RG;
                    clienteModel.UF = listaCliente.FirstOrDefault().UF;
                    clienteModel.PessoaFisica = listaCliente.FirstOrDefault().PessoaFisica;
                    clienteModel.PessoaJuridica = listaCliente.FirstOrDefault().PessoaJuridica;
                    AdicionarClienteSessao(clienteModel);
                    Cliente cliente = new Cliente();
                    cliente.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
                    cliente.ShowDialog();
                }
            }
        }
        void fm_RefreshDgv(List<ItemConsultarClienteModel> lista)
        {
            ItemConsultarClienteModel clienteModel = (ItemConsultarClienteModel)ContextHelper.GetData("FormaPagamentoCliente");
            ItemConsultarClienteModel newclienteModel = new ItemConsultarClienteModel();
            List<ClienteModel> listClienteModel = new List<ClienteModel>();

            if (clienteModel != null)
                newclienteModel = lista.Where(p => p.Codigo == clienteModel.Codigo).FirstOrDefault();

            else
            {
                var listaClienteNovo = new ClienteService().ObterClientes(RazaoSocial, 2, "NOME/RAZÃO SOCIAL");
                listClienteModel = listaClienteNovo.OrderBy(p => p.Codigo).ToList();
                int idClienteLast = listClienteModel.LastOrDefault().Codigo;

                newclienteModel = lista.Where(p => p.Codigo == idClienteLast).FirstOrDefault();

                //populando auto-complete
                List<String> listaautocomplete = PreencherListaCliente();
                DescricaoProdutoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(listaautocomplete.ToArray());
                DescricaoProdutoTextBox.AutoCompleteCustomSource = data;
                DescricaoProdutoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DescricaoProdutoTextBox.Focus();

            }

            if (newclienteModel != null)
            {
                RazaoSocial = newclienteModel.CPF != null ? newclienteModel.Nome : newclienteModel.RazaoSocial;
                Endereco = newclienteModel.Endereco;
                Telefone = newclienteModel.Telefone;
            }
            AlterarButton.Enabled = true;
            RemoverObjetosSessao();
        }

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Cliente");
            ContextHelper.FreeNamedDataSlot("FormaPagamentoCliente");
        }
        private void AdicionarClienteSessao(ItemConsultarClienteModel clienteModel)
        {
            ContextHelper.SetData("Cliente", clienteModel);
            ContextHelper.SetData("FormaPagamentoCliente", clienteModel);
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            realizarVenda();
        }

        private void realizarVenda()
        {
            int erro = 0;
            if (Entrega)
            {
                if (string.IsNullOrWhiteSpace(RazaoSocial))
                {
                    erro = 1;
                    MessageBox.Show("Para realizar a entrega, é necessário selecionar um Cliente.");
                }
            }
            if (erro == 0)
                if (Desconto && !DescontoValor.HasValue)
                {
                    erro = 1;
                    MessageBox.Show("Uma vez que a opção de desconto está selecionada é necessário inserir um valor de desconto.");
                }
            if (erro == 0)
                if (EhDebito && !Debito.HasValue)
                {
                    erro = 1;
                    MessageBox.Show("Uma vez que a opção de Cartão de Débito está selecionada é necessário inserir um valor de Débito.");
                }
            if (erro == 0)
                if (EhCredito && !Credito.HasValue)
                {
                    erro = 1;
                    MessageBox.Show("Uma vez que a opção de Cartão de Crédito está selecionada é necessário inserir um valor de Crédito.");
                }
            if (erro == 0)
                if (EhDinheiro && !Dinheiro.HasValue)
                {
                    erro = 1;
                    MessageBox.Show("Uma vez que a opção de Dinheiro está selecionada é necessário inserir um valor de Dinheiro.");
                }
            if (erro == 0)
            {
                if ((Debito.HasValue && Debito > TotalVenda) || (Credito.HasValue && Credito > TotalVenda))
                {
                    erro = 1;
                    MessageBox.Show("Valores de debito ou credito não podem ser maior que o total da venda.");
                }
            }
            if (erro == 0)
                if (ValorPago < TotalVenda)
                {
                    erro = 1;
                    MessageBox.Show("Valor Pago não pode ser menor que o Valor Total.");
                }
            if (erro == 0)
            {
                ItemConsultarClienteModel clienteModel = new ItemConsultarClienteModel();

                if (Entrega)
                {
                    var listaCliente = new ClienteService().ObterClientes(RazaoSocial, 2, "NOME/RAZÃO SOCIAL");
                    if (listaCliente.Count() > 0)
                    {
                        clienteModel.Celular = listaCliente.FirstOrDefault().Celular;
                        clienteModel.Telefone = listaCliente.FirstOrDefault().Telefone;
                        clienteModel.CEP = listaCliente.FirstOrDefault().CEP;
                        clienteModel.Cidade = listaCliente.FirstOrDefault().Cidade;
                        clienteModel.CNPJ = listaCliente.FirstOrDefault().CNPJ;
                        clienteModel.Codigo = listaCliente.FirstOrDefault().Codigo;
                        clienteModel.CPF = listaCliente.FirstOrDefault().CPF;
                        clienteModel.Endereco = listaCliente.FirstOrDefault().Endereco;
                        clienteModel.InscEstadual = listaCliente.FirstOrDefault().InscEstadual;
                        clienteModel.Nome = listaCliente.FirstOrDefault().Nome;
                        clienteModel.Obs = listaCliente.FirstOrDefault().Obs;
                        clienteModel.RazaoSocial = listaCliente.FirstOrDefault().RazaoSocial;
                        clienteModel.RG = listaCliente.FirstOrDefault().RG;
                        clienteModel.UF = listaCliente.FirstOrDefault().UF;
                        clienteModel.PessoaFisica = listaCliente.FirstOrDefault().PessoaFisica;
                        clienteModel.PessoaJuridica = listaCliente.FirstOrDefault().PessoaJuridica;
                    }
                }

                UsuarioModel user = new UsuarioModel();
                List<ItemConsultarProdutoModelVenda> listaVenda = ContextHelper.GetData("DadosVenda") != null ? (List<ItemConsultarProdutoModelVenda>)ContextHelper.GetData("DadosVenda") : new List<ItemConsultarProdutoModelVenda>();
                UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                if (usuarioLogado != null)
                    user = new UsuarioService().GetUsuarioById(usuarioLogado.Codigo);
                TotalVenda = TotalVenda - ((TotalVenda.Value * (DescontoValor.HasValue ? DescontoValor : 0)) / 100);

                double? valorDescontoNovo = ((TotalVenda.Value * (DescontoValor.HasValue ? DescontoValor : 0)) / 100);
                var venda = new VendaService().Salvar(listaVenda, clienteModel, ValorPago, TotalVenda, Dinheiro, Debito, Credito, user, Vezes.Value, valorDescontoNovo);

                List<IVendaModel> listanovaVenda = new VendaService().GetAll();
                DateTime datavenda = listanovaVenda.LastOrDefault() != null ? listanovaVenda.LastOrDefault().Data : default(DateTime);
                int idvenda = listanovaVenda.LastOrDefault() != null ? listanovaVenda.LastOrDefault().Id : default(int);
                if (venda)
                {
                    MessageBox.Show("Operação realizada com sucesso!");

                    this.Close();

                    imprimirCupom(user, listaVenda, datavenda, idvenda);

                    this.RefreshDgv(true);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao realizar esta operação!");
                }
            }
        }

        private void imprimirCupom(UsuarioModel user, List<ItemConsultarProdutoModelVenda> listaVenda, DateTime datavenda, int idvenda)
        {
            int espacoidvenda = 15;
            int novoespacoidvenda = 0;


            string itemidvenda = string.Empty;
            itemidvenda = idvenda.ToString();
            string descricaoidvenda = itemidvenda;

            if (!itemidvenda.Length.EhMaiorQue(espacoidvenda))
            {
                novoespacoidvenda = espacoidvenda - itemidvenda.Length;
                for (int i = 0; i < novoespacoidvenda; i++)
                {
                    descricaoidvenda = descricaoidvenda + " ";
                }
            }
            else
            {
                for (int i = 0; i < novoespacoidvenda; i++)
                {
                    descricaoidvenda = descricaoidvenda.Remove(15, 30);
                }
            }

            var pasta = @"C:\arquivos\venda.txt";
            var stw = new StreamWriter(pasta, false, Encoding.Default);
            stw.WriteLine("                         VENDA                              ");
            stw.WriteLine("                                                             ");
            stw.WriteLine("SMC LTDA");
            stw.WriteLine("RUA PEDRA DO SINO, 70 - PACIÊNCIA");
            stw.WriteLine("Telefone: (21) 2404-30255");
            stw.WriteLine("------------------------------------------------------------------------");
            stw.WriteLine("COD. VENDA     DATA EMISSAO");
            stw.WriteLine("" + descricaoidvenda + datavenda + "");
            stw.WriteLine("VENDEDOR: " + user.Nome + "");
            stw.WriteLine("------------------------------------------------------------------------");
            stw.WriteLine("             DADOS DO CLIENTE");
            stw.WriteLine("CLIENTE : " + RazaoSocialTextBox.Text);
            stw.WriteLine("ENDERECO: " + EnderecoTextBox.Text);
            stw.WriteLine("TELEFONE: " + TelefoneTextBox.Text);
            stw.WriteLine("------------------------------------------------------------------------");
            stw.WriteLine("COD PROD   DESCRICAO/MARCA    QTD   PRECO UNIT    TOTAL ITEM     ENTREGA");

            foreach (var item in listaVenda)
            {
                string descricao = item.Descricao + "/" + item.Marca;
                int espacoDescricao = 20;
                int espacoCodigo = 11;
                int espacoPrecoUnitario = 15;
                int espacoQuantidade = 6;
                int espacoTOTALVENDA = 15;

                int novoespacoDescricao = 0;
                int novoespacoCodigo = 0;
                int novoespacoPrecoUnitario = 0;
                int novoespacoQuantidade = 0;
                int novoespacoTOTALVENDA = 0;



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
                itemPrecoUni = String.Format("{0:0.00}", item.PrecoVenda);
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


                string itemValorTotal = string.Empty;
                itemValorTotal = String.Format("{0:0.00}", item.PrecoCompra);
                string descricaoValorTotal = itemValorTotal;

                if (!itemValorTotal.Length.EhMaiorQue(espacoTOTALVENDA))
                {
                    novoespacoTOTALVENDA = espacoTOTALVENDA - itemValorTotal.Length;
                    for (int i = 0; i < novoespacoTOTALVENDA; i++)
                    {
                        descricaoValorTotal = descricaoValorTotal + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < novoespacoTOTALVENDA; i++)
                    {
                        descricaoValorTotal = descricaoValorTotal.Remove(20, 30);
                    }
                }

                stw.WriteLine("" + descricaoCodigo + descricao + descricaoQuantidade + descricaoPrecoUnitario + descricaoValorTotal + (item.Entrega ? "S" : "N") + "");
            }

            stw.WriteLine("------------------------------------------------------------------------");
            stw.WriteLine("                                                                          ");
            stw.WriteLine("                                              TOTAL DA VENDA: " + String.Format("{0:0.00}", TotalVenda));
            stw.WriteLine("                                                 VALOR PAGO : " + String.Format("{0:0.00}", ValorPago));
            stw.WriteLine("                                                      TROCO : " + String.Format("{0:0.00}", Troco));

            stw.Flush();

            var ps = new Process();
            ps.StartInfo.FileName = pasta;
            ps.Start();
        }

        private void ValorPagoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TotalVenda != null)
                Troco = ValorPago - TotalVenda;
        }

        string str4 = "";
        private void ValorPagoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
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
            if (((KeyCode == 8) || (KeyCode == 46)) && (str4.Length > 0))
            {
                str4 = str4.Substring(0, str4.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str4 = str4 + Convert.ToChar(KeyCode);
            }
            if (str4.Length == 0)
            {
                ValorPagoTextBox.Text = "";
            }
            if (str4.Length == 1)
            {
                ValorPagoTextBox.Text = "0,0" + str4;
            }
            else if (str4.Length == 2)
            {
                ValorPagoTextBox.Text = "0," + str4;
            }
            else if (str4.Length > 2)
            {
                ValorPagoTextBox.Text = str4.Substring(0, str4.Length - 2) + "," +
                                str4.Substring(str4.Length - 2);
            }
        }

        private void ValorPagoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DescontoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Desconto)
            {
                UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                if (usuarioLogado != null)
                {
                    if (usuarioLogado.Permissao.Equals("Funcionario") || usuarioLogado.Permissao.Equals("Funcionário"))
                    {
                        //DescontoTextBox.Visible = true;
                        SenhaDesconto senhaDesconto = new SenhaDesconto();
                        senhaDesconto.fm_RefreshDgvDesconto += new SenhaDesconto.DoEvent(fm_RefreshDgvDesconto);
                        senhaDesconto.Show();
                    }
                    else
                        fm_RefreshDgvDesconto(true);
                }
            }
            else
                fm_RefreshDgvDesconto(false);
        }
        void fm_RefreshDgvDesconto(bool validaSenha)
        {
            if (validaSenha)
            {
                DescontoTextBox.Visible = true;
                DescontoTextBox.Focus();
            }
            else
            {
                DescontoTextBox.Visible = false;
                DescontoValor = default(int?);
            }
        }

        private void DescricaoProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                DescricaoProdutoTextBox.SelectedText = Char.ToUpper(e.KeyChar).ToString();

                e.Handled = true;
            }
        }
        int teste = 0;
        private void DescontoTextBox_TextChanged(object sender, EventArgs e)
        {
                if (DescontoValor.HasValue)
                {

                    if (DescontoValor <= 0 || DescontoValor > 100)
                    {
                        MessageBox.Show("Valor de desconto deve estar entre 1 e 100");
                        DescontoValor = default(int?);
                    }
                    else
                    {
                        double desconto = new double();
                        desconto = (DescontoValor.HasValue ? DescontoValor.Value : default(double));
                        TotalVenda = TotalVenda - ((TotalVenda * desconto) / 100);
                    }
                }
                else
                {
                    Double? valorTotal = ContextHelper.GetData("ValorTotal") != null ? Convert.ToDouble(ContextHelper.GetData("ValorTotal")) : default(double);
                    TotalVenda = valorTotal;
                }
        }

        private void DinheiroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EhDinheiro)
            {
                DinheiroTextBox.Enabled = true;
                DinheiroTextBox.Focus();
            }
            else
            {
                DinheiroTextBox.Enabled = false;
                Dinheiro = default(double?);
            }
        }

        private void DebitoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EhDebito)
            {
                DebitoTextBox.Enabled = true;
                DebitoTextBox.Focus();
            }
            else
            {
                DebitoTextBox.Enabled = false;
                Debito = default(double?);
            }
        }

        private void CreditoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EhCredito)
            {
                CreditoTextBox.Enabled = true;
                CreditoComboBox.Enabled = true;
                CreditoTextBox.Focus();
            }
            else
            {
                CreditoTextBox.Enabled = false;
                CreditoComboBox.Enabled = false;
                Credito = default(double?);
            }
        }

        private void DinheiroTextBox_TextChanged(object sender, EventArgs e)
        {
            double dinheiro = new double();
            dinheiro = (Dinheiro.HasValue ? Dinheiro.Value : default(double));
            
            double debito = new double();
            debito = (Debito.HasValue ? Debito.Value : default(double));

            double credito = new double();
            credito = (Credito.HasValue ? Credito.Value : default(double));

            ValorPago = (dinheiro + debito + credito);
        }

        private void DebitoTextBox_TextChanged(object sender, EventArgs e)
        {

            double dinheiro = new double();
            dinheiro = (Dinheiro.HasValue ? Dinheiro.Value : default(double));

            double debito = new double();
            debito = (Debito.HasValue ? Debito.Value : default(double));

            double credito = new double();
            credito = (Credito.HasValue ? Credito.Value : default(double));

            ValorPago = (dinheiro + debito + credito);
        }

        private void CreditoTextBox_TextChanged(object sender, EventArgs e)
        {

            double dinheiro = new double();
            dinheiro = (Dinheiro.HasValue ? Dinheiro.Value : default(double));

            double debito = new double();
            debito = (Debito.HasValue ? Debito.Value : default(double));

            double credito = new double();
            credito = (Credito.HasValue ? Credito.Value : default(double));

            ValorPago = (dinheiro + debito + credito);
        }

        private void DescontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
            
        }

        private void DescontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInteiro(sender, e);            
        }

        private void NovoClienteButton_Click(object sender, EventArgs e)
        {
            RazaoSocial = string.Empty;
            Telefone = string.Empty;
            Endereco = string.Empty;
            Cliente cliente = new Cliente();
            cliente.RefreshDgv += new Cliente.DoEvent(fm_RefreshDgv);
            cliente.ShowDialog();
        }
    }
}
