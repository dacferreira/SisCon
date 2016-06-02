using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Models;
using ProjetoFinal.Extension;

namespace ProjetoFinal.Views
{
    public partial class FM_Principal : Form
    {
        #region [ Construtor ]
        public FM_Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Métodos Principais ]

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void FM_Principal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                UsuarioLogadoTextBox.Text = usuarioLogado.Login;
                PermissaoUsuarioTextBox.Text = usuarioLogado.Permissao;
                UsusarioStatusLabel.Text = usuarioLogado.Login;
                PermissaoStatusLabel.Text = usuarioLogado.Permissao;
            }
            //if (usuarioLogado.Permissao == "Funcionário")
            //{
            //    this.Hide();
            //    Venda venda = new Venda();
            //    venda.ShowDialog();
            //}
        }

        private void SairToolStripButton_Click(object sender, EventArgs e)
        {

            Sair();

        }

        #endregion

        #region [ Navegação de Menu ]

        private void MenuCadastroFuncionario_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador"))
                {
                    Usuario child = new Usuario();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        public void MenuConsultaFuncionario_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador"))
                {
                    ConsultarUsuario child = new ConsultarUsuario();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void MenuCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente child = new Cliente();
            OpenFormInMaster(child);
        }

        private void MenuCadastroProduto_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (!usuarioLogado.Permissao.Equals("Funcionário"))
                {
                    Produto child = new Produto();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void MenuConsultaCliente_Click(object sender, EventArgs e)
        {
            //UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            //if (usuarioLogado != null)
            //{
            //    if (!usuarioLogado.Permissao.Equals("Funcionário"))
            //    {
            ConsultarCliente child = new ConsultarCliente();
            OpenFormInMaster(child);
            //}
            //else
            //    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            //}
        }

        public void MenuConsultaProduto_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (!usuarioLogado.Permissao.Equals("Funcionário"))
                {
                    ConsultarProduto child = new ConsultarProduto();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void ConsultaProdutoToolStripButton_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (!usuarioLogado.Permissao.Equals("Funcionário"))
                {
                    ConsultarProduto child = new ConsultarProduto();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void ConsultaClienteToolStripButton_Click(object sender, EventArgs e)
        {
            //UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            //if (usuarioLogado != null)
            //{
            //    if (!usuarioLogado.Permissao.Equals("Funcionário"))
            //    {
            ConsultarCliente child = new ConsultarCliente();
            OpenFormInMaster(child);
            //}
            //else
            //    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            //}
        }

        private void MenuRegistroVenda_Click(object sender, EventArgs e)
        {
            Venda child = new Venda();

            child.RefreshPricipalDgv += new Venda.DoEvent(fm_RefreshFormPrincipal);
            child.ShowDialog();
            //OpenFormInMaster(child);
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            Sobre child = new Sobre();
            OpenFormInMaster(child);
        }

        #endregion

        #region [ Metodos Auxiliares ]

        private void Sair()
        {
            DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Acesso ao Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void Logout()
        {
            DialogResult resultado = MessageBox.Show("Deseja Realmente fazer Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                ContextHelper.SetData("LogoutUsuario", true);
                Form1 login = new Form1();
                login.ShowDialog();
            }
            else
                return;
        }

        public void OpenFormInMaster(Form child)
        {
            child.MaximizeBox = true;
            child.ControlBox = false;
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
        }

        #endregion

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void produtosComSaldoZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    ProdutosSaldoZero child = new ProdutosSaldoZero();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }

        }

        private void inventáriosomenteProdutosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    TodosProdutosAtivos child = new TodosProdutosAtivos();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void todosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    TodosProdutos child = new TodosProdutos();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void produtosMaisVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    MaisVendidos child = new MaisVendidos();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }

        private void fm_RefreshFormPrincipal(bool valor)
        {
            this.Refresh();
        }


        private void FM_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                Sair();
            }
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.U:
                        MenuConsultaFuncionario_Click(sender, e);
                        break;

                    case Keys.C:
                        MenuConsultaCliente_Click(sender, e);
                        break;

                    case Keys.P:
                        MenuConsultaProduto_Click(sender, e);
                        break;

                    case Keys.E:
                        MenuConsultaEntrega_Click(sender, e);
                        break;

                    // case Keys.R:
                    //   MenuConsultaRelatorio_Click(sender, e);
                    // break;

                    case Keys.V:
                        MenuRegistroVenda_Click(sender, e);
                        break;

                    case Keys.Escape:
                        SairToolStripButton_Click(sender, e);
                        break;
                }
            }
        }

        private void MenuConsultaEntrega_Click(object sender, EventArgs e)
        {
            Entrega entrega = new Entrega();
            OpenFormInMaster(entrega);
        }

        private void DevolucaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    Devolucao devolucao = new Devolucao();
                    OpenFormInMaster(devolucao);
                }
                else
                {
                    ContextHelper.SetData("VoltarFormPrincipal", true);
                    SenhaDesconto senhaDesconto = new SenhaDesconto();
                    senhaDesconto.fm_RefreshDgvDevolucao += new SenhaDesconto.DoEvent2(fm_RefreshDgvdevolucao);
                    senhaDesconto.Show();
                }
            }
        }

        private void fm_RefreshDgvdevolucao(bool exiteSenha)
        {
            if (exiteSenha)
            {
                Devolucao devolucao = new Devolucao();
                OpenFormInMaster(devolucao);
            }
        }

        private void relatórioMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioLogado = (UsuarioModel)ContextHelper.GetData("UsuarioLogadoModel");
            if (usuarioLogado != null)
            {
                if (usuarioLogado.Permissao.Equals("Administrador") || usuarioLogado.Permissao.Equals("Gerente"))
                {
                    VendaMensal child = new VendaMensal();
                    OpenFormInMaster(child);
                }
                else
                    MessageBox.Show("Usuário não possui permissão a essa Funcionalidade.");
            }
        }
    }
}
