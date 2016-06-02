using DTO.Models;
using ProjetoFinal.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Views
{
    public partial class ConfirmarProdutosEntrega : Form, IConfirmarProdutosEntregaModel
    {
        public ConfirmarProdutosEntrega()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region [ Implementação ]

        public List<ItemConsultarProdutoModelVenda> listaprodutoModelVenda
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

        public List<ItemConsultarProdutoModelVendaEntrega> listaprodutoModelEntrega
        {
            get
            {
                return (List<ItemConsultarProdutoModelVendaEntrega>)ProdutoEntregaDataGridView.DataSource;
            }
            set
            {
                ProdutoEntregaDataGridView.DataSource = value;
                ProdutoEntregaDataGridView.AutoResizeColumns();
            }
        }

        #endregion

        private void ConfirmarProdutosEntrega_Load(object sender, EventArgs e)
        {
            listaprodutoModelVenda = new List<ItemConsultarProdutoModelVenda>();
            listaprodutoModelEntrega = new List<ItemConsultarProdutoModelVendaEntrega>();

            var listaVendaProduto = new List<ItemConsultarProdutoModelVenda>();
            List<ItemConsultarProdutoModelVenda> listaVenda = ContextHelper.GetData("DadosVenda") != null ? (List<ItemConsultarProdutoModelVenda>)ContextHelper.GetData("DadosVenda") : new List<ItemConsultarProdutoModelVenda>();
            if (listaVenda.Any())
            {
                foreach (var item in listaVenda)
                {
                    ItemConsultarProdutoModelVenda modelVenda = new ItemConsultarProdutoModelVenda();

                    modelVenda.Codigo = item.Codigo;
                    modelVenda.Desconto = item.Desconto;
                    modelVenda.Descricao = item.Descricao;
                    modelVenda.EstoqueAtual = item.EstoqueAtual;
                    modelVenda.EstoqueMinimo = item.EstoqueMinimo;
                    modelVenda.Localizacao = item.Localizacao;
                    modelVenda.Marca = item.Marca;
                    modelVenda.MargemLucro = item.MargemLucro;
                    modelVenda.PrecoCompra = item.PrecoCompra;
                    modelVenda.PrecoVenda = item.PrecoVenda;
                    modelVenda.Quantidade = item.Quantidade;
                    modelVenda.Entrega = item.Entrega;

                    listaVendaProduto.Add(modelVenda);
                }
            }
            listaprodutoModelVenda = listaVendaProduto;
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            //selecionar um a um
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
                foreach (var item in listaindice)
                {
                    Selecionar(item);
                }
                //Devolver(listaindice.FirstOrDefault());
            }
        }

        private void Selecionar(int item)
        {
            List<ItemConsultarProdutoModelVendaEntrega> lista = new List<ItemConsultarProdutoModelVendaEntrega>();
            //List<ItemConsultarProdutoVenda> listavenda = new List<ItemConsultarProdutoVenda>();
            List<ItemConsultarProdutoModelVenda> listavenda = new List<ItemConsultarProdutoModelVenda>();

            if (listaprodutoModelEntrega != null && listaprodutoModelEntrega.Any())
                lista.AddRange(listaprodutoModelEntrega);

            //listavenda = listaprodutoModelVenda;
            listavenda = listaprodutoModelVenda;

            ItemConsultarProdutoModelVenda produto = listaprodutoModelVenda[item];
            ItemConsultarProdutoModelVendaEntrega devolucao = new ItemConsultarProdutoModelVendaEntrega();
            devolucao.Codigo = produto.Codigo;
            devolucao.Descricao = produto.Descricao;
            devolucao.Marca = produto.Marca;
            devolucao.PrecoVenda = produto.PrecoVenda;
            devolucao.Marca = produto.Marca;
            devolucao.Desconto = produto.Desconto;
            devolucao.Quantidade = produto.Quantidade;
            devolucao.EstoqueAtual = produto.EstoqueAtual;
            devolucao.EstoqueMinimo = produto.EstoqueMinimo;
            devolucao.Localizacao = produto.Localizacao;
            devolucao.Marca = produto.Marca;
            devolucao.MargemLucro = produto.MargemLucro;
            devolucao.PrecoCompra = produto.PrecoCompra;

            if (lista.Any())
            {
                var existeproduto = lista.Where(p => p.Codigo == produto.Codigo).FirstOrDefault();
                if (existeproduto == null)
                    lista.Add(devolucao);
            }
            else
                lista.Add(devolucao);

            //listavenda.Remove(produto);
            listaprodutoModelVenda = new List<ItemConsultarProdutoModelVenda>();
            listaprodutoModelVenda = listavenda;

            listaprodutoModelEntrega = lista;
        }

        private void SelecionarTodosButton_Click(object sender, EventArgs e)
        {
            //selecionar todos
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
                    Selecionar(item);
                }
                //Devolver(listaindice.FirstOrDefault());
            }
        }

        private void RemoverItemButton_Click(object sender, EventArgs e)
        {
            // remover item
            int erro = 0;
            if (ProdutoEntregaDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!");
                erro = 1;
            }

            if (ProdutoEntregaDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um registro!");
                erro = 1;
            }
            if (erro == 0)
            {
                Int32 selectedCellCount = ProdutoEntregaDataGridView.SelectedRows.Count;
                List<int> listaindice = new List<int>();
                for (int i = 0; i < selectedCellCount; i++)
                {
                    int indice = ProdutoEntregaDataGridView.SelectedRows[i].Index;
                    listaindice.Add(indice);
                }
                RemoverItem(listaindice.FirstOrDefault());
            }
        }

        private void RemoverItem(int indiceSelecionado)
        {

            List<ItemConsultarProdutoModelVendaEntrega> lista = new List<ItemConsultarProdutoModelVendaEntrega>();

            if (listaprodutoModelEntrega != null && listaprodutoModelEntrega.Any())
                lista.AddRange(listaprodutoModelEntrega);

            ItemConsultarProdutoModelVendaEntrega produto = listaprodutoModelEntrega[indiceSelecionado];

            lista.Remove(produto);

            listaprodutoModelEntrega = new List<ItemConsultarProdutoModelVendaEntrega>();

            listaprodutoModelEntrega = lista;
        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            //finalizar
            int erro = 0;
            if (!listaprodutoModelEntrega.Any())
            {
                erro = 1;
                MessageBox.Show("Necessário ter itens para Entrega antes de realizar esta operação.");
            }
            if (erro == 0)
            {
                try
                {
                    List<ItemConsultarProdutoModelVenda> listaVenda = ContextHelper.GetData("DadosVenda") != null ? (List<ItemConsultarProdutoModelVenda>)ContextHelper.GetData("DadosVenda") : new List<ItemConsultarProdutoModelVenda>();
                    if (listaVenda.Any())
                    {
                        ContextHelper.FreeNamedDataSlot("DadosVenda");

                        foreach (var item in listaVenda)
                        {
                            foreach (var itementrega in listaprodutoModelEntrega)
                            {
                                if (item.Codigo == itementrega.Codigo)
                                {
                                    item.Entrega = true;
                                }
                            }
                        }
                        ContextHelper.SetData("DadosVenda", listaVenda);
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
                }
            }
        }
    }
}
