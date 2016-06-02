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

namespace ProjetoFinal.Views
{
    public partial class SenhaDesconto : Form, ISenhaDescontoModel
    {
        #region [ Construtor ]

        public delegate void DoEvent(bool exiteSenha);
        public event DoEvent fm_RefreshDgvDesconto;

        public delegate void DoEvent2(bool exiteSenha);
        public event DoEvent2 fm_RefreshDgvDevolucao;

        public SenhaDesconto()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]
        
        public string Senha
        {
            get
            {
                return tbSenha.Text;
            }
            set
            {
                tbSenha.Text = value;
            }
        }

        #endregion

        #region [ Eventos ]

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidaSenha();
        }

        private void ValidaSenha()
        {
            int erro = 0;
            if (String.IsNullOrWhiteSpace(Senha))
            {
                erro = 1;
                MessageBox.Show("Necessário digitar uma senha de Gerente ou Administrador");
            }
            if (erro == 0)
            {
                if (BuscarSenha())
                {
                    bool voltarformprincipal = ContextHelper.GetData("VoltarFormPrincipal") != null ? (bool)ContextHelper.GetData("VoltarFormPrincipal") : false;

                    if (voltarformprincipal)
                        this.fm_RefreshDgvDevolucao(true);

                    else
                        this.fm_RefreshDgvDesconto(true);
                    this.Close();
                }
                else
                    MessageBox.Show("Senha incorreta!");
            }
        }
        void fm_RefreshDgv(bool exiteSenha)
        {
            this.fm_RefreshDgvDesconto(exiteSenha);
        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            bool voltarformprincipal = ContextHelper.GetData("VoltarFormPrincipal") != null ? (bool)ContextHelper.GetData("VoltarFormPrincipal") : false;

            if (voltarformprincipal)
                this.fm_RefreshDgvDevolucao(false);
            else
            this.fm_RefreshDgvDesconto(false);
        }

        private bool BuscarSenha()
        {
            try
            {
                var usuarioLogado = new UsuarioService().ExisteSenhaGerenteAdministrador(Senha);
                return usuarioLogado;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        #endregion

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidaSenha();
            }
        }

        private void SenhaDesconto_Load(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao != "Administrador")
                {
                }
            }
        }
    }
}
