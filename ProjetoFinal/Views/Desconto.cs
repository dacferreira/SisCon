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

namespace ProjetoFinal.Views
{
    public partial class Desconto : Form, IDescontoModel
    {
        #region [ Construtor ]

        public delegate void DoEvent(double valor);
        public event DoEvent RefreshDgv;

        public Desconto()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]


        public double? ValorDigitado
        {
            get
            {
                return ValorDescontoTextBox.Text.ToNullableDouble();
            }
            set
            {
                ValorDescontoTextBox.Text = value.ToString();
            }
        }
        public bool Valor
        {
            get
            {
                return ValorRadioButton.Checked;
            }
            set
            {
                ValorRadioButton.Checked = value;
            }
        }

        public bool Percentual
        {
            get
            {
                return PercentualRadioButton.Checked;
            }
            set
            {
                PercentualRadioButton.Checked = value;
            }
        }

        #endregion


        #region [ Eventos ]

        private void Desconto_Load(object sender, EventArgs e)
        {
            Valor = true;
            PercentualLabel.Visible = false;
        }

        private void ValorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Valor)
            {
                DescontoLabel.Text = "Valor Desconto";
                PercentualLabel.Visible = false;
            }
            if (Percentual)
            {
                DescontoLabel.Text = "Percentual Desconto";
                PercentualLabel.Visible = true;
            }
        }

        private void PercentualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Valor)
            {
                DescontoLabel.Text = "Valor Desconto";
                PercentualLabel.Visible = false;
            }
            if (Percentual)
            {
                DescontoLabel.Text = "Percentual Desconto";
                PercentualLabel.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValorDigitado.HasValue)
               this.RefreshDgv(ValorDigitado.Value);

            Venda venda = new Venda();
            venda.fm_RefreshDgv(ValorDigitado.Value);


            this.Close();
        }

        private void ValorDescontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaDecimal(sender, e);
        }

        protected bool NaoNumeroDigitado;
        private void ValorDescontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion
    }
}
