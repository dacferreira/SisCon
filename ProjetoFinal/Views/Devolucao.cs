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
    public partial class Devolucao : Form, IDevolucaoModel
    {
        public Devolucao()
        {
            InitializeComponent();
        }

        private void Devolucao_Load(object sender, EventArgs e)
        {
            listaprodutoModelVenda = new List<ItemConsultarProdutoVenda>();
            listaprodutoModelDevolvido = new List<ItemConsultarProdutoDevolucao>();
            CodigoVendaTextBox.Focus();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            int erro = 0;
            if (codigoVenda == null)
            {
                erro = 1;
                MessageBox.Show("Necessário preencher o codigo da venda.");
            }
            if (erro == 0)
            {
                var devolucoes = new VendaService().ObterTodos(codigoVenda);

                listaprodutoModelDevolvido = new List<ItemConsultarProdutoDevolucao>();
                listaprodutoModelVenda = devolucoes.ToList();


                List<ItemConsultarProdutoVenda> novalistaVenda = new List<ItemConsultarProdutoVenda>();

                var vendaDevolucoes = new VendaService().GetAllDevolucoes();

                if (listaprodutoModelVenda.Any())
                foreach (var item in listaprodutoModelVenda)
                {
                    if (vendaDevolucoes.Any())
                        foreach (var itemDevolucao in vendaDevolucoes.Where(p=>p.CodigoVenda == codigoVenda))
                        {
                            if (item.Codigo == itemDevolucao.CodigoProduto && itemDevolucao.QuantidadeDevolucao <= item.Quantidade)
                            {
                                item.Quantidade = item.Quantidade - itemDevolucao.QuantidadeDevolucao;
                            }
                        }
                }

                if (listaprodutoModelVenda.Any())
                novalistaVenda = listaprodutoModelVenda.ToList();

                if (novalistaVenda.Any())
                {
                    List<ItemConsultarProdutoVenda> listaremove = new List<ItemConsultarProdutoVenda>();
                    listaremove = listaprodutoModelVenda;
                    foreach (var item in novalistaVenda.Where(p=>p.Quantidade == 0))
                    {
                        listaremove.Remove(item);
                    }
                    listaprodutoModelVenda = new List<ItemConsultarProdutoVenda>();
                    listaprodutoModelVenda = listaremove;
                }

                if (!listaprodutoModelVenda.Any())
                    MessageBox.Show("Nenhum registro encontrado!");
            }
        }

        public int? codigoVenda
        {
            get
            {
                return CodigoVendaTextBox.Text.ToNullableInt();
            }
            set
            {
                CodigoVendaTextBox.Text = value.ToString();
            }
        }

        public List<ItemConsultarProdutoVenda> listaprodutoModelVenda
        {
            get
            {
                return (List<ItemConsultarProdutoVenda>)ConsultaProdutoVendadataGridView.DataSource;
            }
            set
            {
                ConsultaProdutoVendadataGridView.DataSource = value;
                ConsultaProdutoVendadataGridView.AutoResizeColumns();
            }
        }

        public List<ItemConsultarProdutoDevolucao> listaprodutoModelDevolvido
        {
            get
            {
                return (List<ItemConsultarProdutoDevolucao>)ProdutoDevolucaoDataGridView.DataSource;
            }
            set
            {
                ProdutoDevolucaoDataGridView.DataSource = value;
                ProdutoDevolucaoDataGridView.AutoResizeColumns();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Alterar Quantidade de item por item
            int erro = 0;
            if (ProdutoDevolucaoDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ProdutoDevolucaoDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }

            if (erro == 0)
            {
                Int32 selectedCellCount = ProdutoDevolucaoDataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ProdutoDevolucaoDataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                alterarQuantidade(listaindice.FirstOrDefault());
            }
        }

        private void alterarQuantidade(int indiceLinhaSelecionada)
        {
            //Método para alterar
            ItemConsultarProdutoDevolucao produtoModelVenda = listaprodutoModelDevolvido[indiceLinhaSelecionada];
            AdicionarProdutoCadastradoSessao(produtoModelVenda);
            AdicionarListaProdutoCadastradoSessao(listaprodutoModelDevolvido);
            AdicionarListaProdutoVendaCadastradoSessao(listaprodutoModelVenda);
            AlterarQuantidade alterarQuantidade = new AlterarQuantidade();
            alterarQuantidade.RefreshDgvDevolucao += new AlterarQuantidade.DoEvent3(fm_RefreshQuantidadeProdutoDgv);
            alterarQuantidade.ShowDialog();
        }

        private void AdicionarListaProdutoVendaCadastradoSessao(List<ItemConsultarProdutoVenda> listaCadastroVenda)
        {
            ContextHelper.SetData("ListaCadastroVenda", listaprodutoModelVenda);
        }

        private void AdicionarProdutoCadastradoSessao(ItemConsultarProdutoDevolucao produtoModelVenda)
        {
            ContextHelper.SetData("ConsultarProdutoModelVendaDevolucao", produtoModelVenda);
        }

        private void AdicionarListaProdutoCadastradoSessao(List<ItemConsultarProdutoDevolucao> listaprodutoModelDevolvido)
        {
            ContextHelper.SetData("ListaConsultarProdutoModelVendaDevolucao", listaprodutoModelDevolvido);
        }

        private void fm_RefreshQuantidadeProdutoDgv(List<ItemConsultarProdutoDevolucao> lista)
        {
            List<ItemConsultarProdutoVenda> listaCadastroVenda = (List<ItemConsultarProdutoVenda>)ContextHelper.GetData("ListaCadastroVenda");

            if (listaCadastroVenda.Any())
            {
                listaprodutoModelVenda = new List<ItemConsultarProdutoVenda>();
                listaprodutoModelVenda = listaCadastroVenda;
            }
            listaprodutoModelDevolvido = lista;
        }
        
        private void DevolverButton_Click(object sender, EventArgs e)
        {
            //Adicionar na outra grid
            int erro = 0;
            //if (ConsultaProdutoVendadataGridView.SelectedRows.Count > 1)
            //{
            //    MessageBox.Show("Selecione apenas um registro!");
            //    erro = 1;
            //}

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
                foreach (var item in listaindice)
                {
                    Devolver(item);
                }
                //Devolver(listaindice.FirstOrDefault());
            }
        }

        private void Devolver(int item)
        {
            List<ItemConsultarProdutoDevolucao> lista = new List<ItemConsultarProdutoDevolucao>();
            //List<ItemConsultarProdutoVenda> listavenda = new List<ItemConsultarProdutoVenda>();
            List<ItemConsultarProdutoVenda> listavenda = new List<ItemConsultarProdutoVenda>();

            if (listaprodutoModelDevolvido != null && listaprodutoModelDevolvido.Any())
                lista.AddRange(listaprodutoModelDevolvido);

            //listavenda = listaprodutoModelVenda;
            listavenda = listaprodutoModelVenda;

            ItemConsultarProdutoVenda produto = listaprodutoModelVenda[item];
            ItemConsultarProdutoDevolucao devolucao = new ItemConsultarProdutoDevolucao();
            devolucao.Codigo = produto.Codigo;
            devolucao.Descricao = produto.Descricao;
            devolucao.Marca = produto.Marca;
            devolucao.PrecoUnitario = produto.PrecoUnitario;
            devolucao.Quantidade = produto.Quantidade;
            devolucao.Valor = produto.Valor;
            devolucao.CodigoItemPedido = produto.CodigoItemPedido;
            if (lista.Any())
            {
                var existeproduto = lista.Where(p => p.Codigo == produto.Codigo).FirstOrDefault();
                if (existeproduto == null)
                    lista.Add(devolucao);
            }else
                lista.Add(devolucao);

            //listavenda.Remove(produto);
            listaprodutoModelVenda = new List<ItemConsultarProdutoVenda>();
            listaprodutoModelVenda = listavenda;

            listaprodutoModelDevolvido = lista;
        }

        private void CodigoVendaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInteiro(sender, e);
            EnterMethod(e);
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

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void DevolverTodosButton_Click(object sender, EventArgs e)
        {
            //Adicionar na outra grid
            int erro = 0;
            //if (ConsultaProdutoVendadataGridView.SelectedRows.Count > 1)
            //{
            //    MessageBox.Show("Selecione apenas um registro!");
            //    erro = 1;
            //}

            if (ConsultaProdutoVendadataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ConsultaProdutoVendadataGridView.Rows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ConsultaProdutoVendadataGridView.Rows[i].Index;
                    listaindice.Add(indice);
                }
                foreach (var item in listaindice)
                {
                    Devolver(item);
                }
                //Devolver(listaindice.FirstOrDefault());
            }
        }

        private void RemoverItemButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (ProdutoDevolucaoDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ProdutoDevolucaoDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ProdutoDevolucaoDataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ProdutoDevolucaoDataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                RemoverItem(listaindice.FirstOrDefault());
            }
        }

        private void RemoverItem(int indiceSelecionado)
        {
            List<ItemConsultarProdutoDevolucao> lista = new List<ItemConsultarProdutoDevolucao>();

            if (listaprodutoModelDevolvido != null && listaprodutoModelDevolvido.Any())
                lista.AddRange(listaprodutoModelDevolvido);

            ItemConsultarProdutoDevolucao produto = listaprodutoModelDevolvido[indiceSelecionado];

            lista.Remove(produto);

            listaprodutoModelDevolvido = new List<ItemConsultarProdutoDevolucao>();

            listaprodutoModelDevolvido = lista;
        }

        private void Devolucao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                    this.Close();
                else
                    return;       
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
            else
                return;    
        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            //Finalizar a troca dos produtos
            int erro = 0;
            if (!listaprodutoModelDevolvido.Any())
            {
                erro = 1;
                MessageBox.Show("Favor inserir ao menos um item para efetuar a devolução.");
            }
            if (erro == 0)
            {
                bool venda = false;
                foreach (var item in listaprodutoModelDevolvido)
                {
                    venda = new VendaService().SalvarDevolucao(item.CodigoItemPedido, item.Quantidade, DateTime.Today, item.Codigo);
                }
                if (venda)
                {
                    MessageBox.Show("Operação realizada com sucesso.");

                    UsuarioModel user = new UsuarioModel();
                    UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
                    if (usuarioLogado != null)
                        user = new UsuarioService().GetUsuarioById(usuarioLogado.Codigo);

                    var pasta = @"C:\arquivos\devolucao.txt";
                    var stw = new StreamWriter(pasta, false, Encoding.Default);
                    stw.WriteLine("                      DEVOLUÇÃO                              ");
                    stw.WriteLine("                                                             ");
                    stw.WriteLine("SMC LTDA");
                    stw.WriteLine("RUA PEDRA DO SINO, 70 - PACIÊNCIA");
                    stw.WriteLine("Telefone: (21) 2404-30255");
                    stw.WriteLine("-------------------------------------------------------------");
                    stw.WriteLine("DATA EMISSAO");
                    stw.WriteLine("" + DateTime.Now + "");
                    stw.WriteLine("VENDEDOR: " + user.Nome + "");
                    stw.WriteLine("-------------------------------------------------------------");
                    stw.WriteLine("COD PROD   DESCRICAO/MARCA    QTD   PRECO UNIT    TOTAL ITEM");

                    foreach (var item in listaprodutoModelDevolvido)
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
                        itemPrecoUni = String.Format("{0:0.00}", item.PrecoUnitario);
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

                        stw.WriteLine("" + descricaoCodigo + descricao + descricaoQuantidade + descricaoPrecoUnitario + String.Format("{0:0.00}", item.Valor) + "");
                    }

                    stw.WriteLine("-------------------------------------------------------------");

                    double valortotal = listaprodutoModelDevolvido.Sum(p => p.Valor);
                    stw.WriteLine("                                   TOTAL DA DEVOLUÇÃO: " + String.Format("{0:0.00}", valortotal));

                    stw.Flush();

                    var ps = new Process();
                    ps.StartInfo.FileName = pasta;
                    ps.Start();

                    //this.Close();
                    Pesquisar();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
            }
        }

        private void CodigoVendaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
