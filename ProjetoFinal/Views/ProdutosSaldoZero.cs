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
    public partial class ProdutosSaldoZero : Form
    {
        public ProdutosSaldoZero()
        {
            InitializeComponent();
        }

        private void ProdutosSaldoZero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produtosSaldoZero1.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.produtosSaldoZero1.Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
