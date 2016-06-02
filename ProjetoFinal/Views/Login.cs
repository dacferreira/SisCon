using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Service;
//using DAL.Persistence;
using DTO.Models;
using ProjetoFinal.Extension;
//using ProjetoFinal.DataSource;
using ProjetoFinal.Views;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        //Os valores da propriedade serão passados para o Program.cs
        public bool Logado { get; set; }
        public string Usuario { get; set; }

        #region [ Construtor ]
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Metodos Principais ]

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel model = new UsuarioModel();

                this.Cursor = Cursors.WaitCursor;
                //Nesta parte recupere os valores do seu banco de dados               
                string usuarioDigitado = tbUsuario.Text;
                string senhaDigitada = tbSenha.Text;
                if (!string.IsNullOrWhiteSpace(usuarioDigitado) && !string.IsNullOrWhiteSpace(senhaDigitada))
                {
                    var usuarioLogado = new UsuarioService().GetUsuarioByLogin(usuarioDigitado, senhaDigitada);
                    //var funcionarioLogado = new FuncionarioService().GetFuncionarioByLogin(usuarioDigitado, senhaDigitada);
                    if (usuarioLogado.Login == null)
                    {
                        Logado = false;
                        //lblDadosVazios.Visible = false;
                        //lblDadosInvalidos.Visible = true;
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                    else
                    {
                        model.Codigo = usuarioLogado.Codigo;
                        model.Login = usuarioLogado.Login;
                        model.Nome = usuarioLogado.Nome;
                        model.Permissao = usuarioLogado.Permissao;
                        model.Situacao = usuarioLogado.Situacao;
                        Logado = true;
                        //Salvar o nome de usuário nas configurações do aplicativo
                        //Properties.Settings.Default.Usuario = tbUsuario.Text;
                        Properties.Settings.Default.Save();
                        ContextHelper.SetData("UsuarioLogadoModel", model);
                        this.Close();
                        this.Dispose();
                        if (ContextHelper.GetData("LogoutUsuario") != null)
                        {
                            FM_Principal form = new FM_Principal();
                            form.ShowDialog();
                        }
                    }                   
                }
                else
                {
                    Logado = false;
                    //lblDadosVazios.Visible = true;
                    MessageBox.Show("Favor preencher todos os campos.");
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Acesso ao Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                this.Close();
            else
                return;
        }
        #endregion                

        #region [ Métodos Auxiliares ]

        public void SplashScreen()
        {
            Application.Run(new TelaSplash());
        }

        private void EnterMethod(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        #endregion

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            EnterMethod(e);
        }
    }
}
