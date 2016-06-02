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
    public partial class VendaMensal : Form
    {
        public VendaMensal()
        {
            InitializeComponent();
        }

        private void VendaMensal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendaMensal1.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.vendaMensal1.Venda);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
