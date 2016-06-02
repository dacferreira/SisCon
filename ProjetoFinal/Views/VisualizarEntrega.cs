using BLL.Service;
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
    public partial class VisualizarEntrega : Form, IVisualizarEntrega
    {
        public VisualizarEntrega()
        {
            InitializeComponent();
        }


        public List<ItemConsultarEntregaModel> ListaProduto
        {
            get
            {
                return (List<ItemConsultarEntregaModel>)ConsultaProdutodataGridView.DataSource;
            }
            set
            {
                ConsultaProdutodataGridView.DataSource = value;
                ConsultaProdutodataGridView.AutoResizeColumns();
                ConsultaProdutodataGridView.AutoGenerateColumns = true;
            }
        }

        private void VisualizarEntrega_Load(object sender, EventArgs e)
        {
            CarregarTela();
        }

        private void CarregarTela()
        {
            PreencherInterface(ObterItemEntregaModelSessao());
        }

        private void PreencherInterface(ItemEntregaModel produtoModel)
        {
            //var teste = new EntregaService().GetALL();
            //var novo = teste.Where(p => p.idVenda == produtoModel.IdVenda).FirstOrDefault();
            var itensVenda = new EntregaService().GetItens(produtoModel.IdVenda.ToInt());
            ListaProduto = itensVenda.ToList();
        }

        private ItemEntregaModel ObterItemEntregaModelSessao()
        {
            ItemEntregaModel produtoModel = (ItemEntregaModel)ContextHelper.GetData("VisualizarEntregaModel");
            return produtoModel;
        }

        private void VisualizarEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void ConsultaProdutodataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
