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
    public partial class MaisVendidos : Form
    {
        public MaisVendidos()
        {
            InitializeComponent();
        }

        private void MaisVendidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maisVendidos3.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.maisVendidos3.Produto);
            // TODO: This line of code loads data into the 'maisVendidos3.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.maisVendidos3.Produto);
            // TODO: This line of code loads data into the 'maisVendidos2.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.maisVendidos2.Produto);
            // TODO: This line of code loads data into the 'maisVendidos1.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.maisVendidos1.Produto);
            

            this.reportViewer1.RefreshReport();
        }
    }
}
