using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Service;
using DTO.Enum;
using DTO.Models;
using ProjetoFinal.Extension;
using ProjetoFinal.Validacao;

namespace ProjetoFinal.Views
{
    public partial class Cliente : Form, IManterClienteModel
    {
        #region [ Construtor ]
        public delegate void DoEvent(List<ItemConsultarClienteModel> lista);
        public event DoEvent RefreshDgv;
        public Cliente()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]
        public string Endereco
        {
            get
            {
                return EnderecoTextBox.Text;
            }
            set
            {
                EnderecoTextBox.Text = value; ;
            }
        }

        public string Bairro
        {
            get
            {
                return BairroTextBox.Text;
            }
            set
            {
                BairroTextBox.Text = value; ;
            }
        }

        public string CEP
        {
            get
            {
                return CEPTextBox.Text;
            }
            set
            {
                CEPTextBox.Text = value;
            }
        }

        public string Cidade
        {
            get
            {
                return CidadeTextBox.Text;
            }
            set
            {
                CidadeTextBox.Text = value;
            }
        }

        public string UF
        {
            get
            {
                return UFTextBox.Text;
            }
            set
            {
                UFTextBox.Text = value;
            }
        }

        public string Telefone
        {
            get
            {
                return TelefoneTextBox.Text;
            }
            set
            {
                TelefoneTextBox.Text = value;
            }
        }

        public string Celular
        {
            get
            {
                return CelularTextBox.Text;
            }
            set
            {
                CelularTextBox.Text = value;
            }
        }

        public string Obs
        {
            get
            {
                return ObservaçãoTextBox.Text;
            }
            set
            {
                ObservaçãoTextBox.Text = value;
            }
        }

        public string CPF
        {
            get
            {
                return CPFTextBox.Text;
            }
            set
            {
                CPFTextBox.Text = value;
            }
        }

        public string RG
        {
            get
            {
                return RGTextBox.Text;
            }
            set
            {
                RGTextBox.Text = value;
            }
        }

        public string Nome
        {
            get
            {
                return NomeTextBox.Text;
            }
            set
            {
                NomeTextBox.Text = value;
            }
        }

        public string Apelido
        {
            get
            {
                return ApelidoTextBox.Text;
            }
            set
            {
                ApelidoTextBox.Text = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return CNPJTextBox.Text;
            }
            set
            {
                CNPJTextBox.Text = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return RazaoSocialTextBox.Text;
            }
            set
            {
                RazaoSocialTextBox.Text = value;
            }
        }

        public string InscEstadual
        {
            get
            {
                return InsEstadualTextBox.Text;
            }
            set
            {
                InsEstadualTextBox.Text = value;
            }
        }

        public bool PessoaFisica
        {
            get
            {
                return PessoaFisicaRadioButton.Checked;
            }
            set
            {
                PessoaFisicaRadioButton.Checked = value;
            }
        }

        public bool PessoaJuridica
        {
            get
            {
                return PessoaJuridicaRadioButton.Checked;
            }
            set
            {
                PessoaJuridicaRadioButton.Checked = value;
            }
        }

        public string CPFSessao
        {
            get
            {
                return ContextHelper.GetData("CPFCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("CPFCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("CPFCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string RGSessao
        {
            get
            {
                return ContextHelper.GetData("RGCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("RGCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("RGCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string ApelidoSessao
        {
            get
            {
                return ContextHelper.GetData("ApelidoCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("ApelidoCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("ApelidoCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string CNPJSessao
        {
            get
            {
                return ContextHelper.GetData("CNPJCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("CNPJCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("CNPJCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string NomeSessao
        {
            get
            {
                return ContextHelper.GetData("NomeCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("NomeCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("NomeCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string RazaoSocialSessao
        {
            get
            {
                return ContextHelper.GetData("RazaoSocialCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("RazaoSocialCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("RazaoSocialCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        public string InscEstadualSessao
        {
            get
            {
                return ContextHelper.GetData("InscEstadualCliente") == null ?
                                     string.Empty :
                                     ContextHelper.GetData("InscEstadualCliente").ToString();
            }
            set
            {
                ContextHelper.SetData("InscEstadualCliente", String.IsNullOrEmpty(value) ?
                                                                  null :
                                                                  value);
            }
        }
        #endregion

        #region [ Propriedades auxiliares ]

        private void Cliente_Load(object sender, EventArgs e) //Método para Inicial
        {
            //Método Inicial
            CarregarTela();
        }

        #endregion

        #region [ Eventos ]

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Cliente");
        }

        public void CarregarTela() //Método para carregar a tela
        {
            PessoaFisica = true;
            CPFTextBox.Focus();
            if (ModoEdicao())
            {
                CNPJTextBox.Enabled = false;
                InsEstadualTextBox.Enabled = false;
                RazaoSocialTextBox.Enabled = false;

                CPFTextBox.Enabled = false;
                RGTextBox.Enabled = false;
                NomeTextBox.Enabled = false;
                PreencherInterface(ObterItemConsultaClienteModelSessao());
            }
        }

        private void RadioButton_CheckedChanged(Object sender, EventArgs e)
        {
            if (PessoaFisica)
            {
                PessoaJuridicaGroupBox.Visible = false;
            }
            if (PessoaJuridica)
            {
                PessoaJuridicaGroupBox.Visible = true;
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (PessoaFisica)
            {
                if (string.IsNullOrWhiteSpace(CPF) || string.IsNullOrWhiteSpace(Nome))
                {
                    erro = 1;
                    MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
                }
                else
                {

                    bool nomeAlterado = NomeSessao != Nome;
                    bool cpfAlterado = CPFSessao != CPF;
                    bool rgAlterado = RGSessao != RG;
                    bool apelidoAlterado = ApelidoSessao != Apelido;
                    if (erro == 0)
                        if (nomeAlterado)
                        {
                            bool nomeJaExiste = new ClienteService().ExisteNome(Nome);
                            if (nomeJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe este mesmo Nome cadastado no sistema");
                            }
                        }
                    if (erro == 0)
                        if (cpfAlterado)
                        {
                            bool cpfJaExiste = new ClienteService().ExisteCPF(CPF);
                            if (cpfJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe este mesmo CPF cadastado no sistema");
                            }
                        }
                    if (erro == 0)
                        if (rgAlterado)
                        {
                            bool rgJaExiste = new ClienteService().ExisteRG(RG);
                            if (rgJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe este mesmo RG cadastado no sistema");
                            }
                        }
                    if (erro == 0)
                        if (!Validacao.ValidaCPF.IsCpf(CPF))
                        {
                            erro = 1;
                            MessageBox.Show("O número é um CPF Inválido!");
                        }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(CNPJ) || string.IsNullOrWhiteSpace(RazaoSocial))
                {
                    erro = 1;
                    MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
                }
                else
                {
                    bool cnpjAlterado = CNPJSessao != CNPJ;
                    bool razaoSocialAlterado = RazaoSocialSessao != RazaoSocial;
                    bool inscEstadualAlterado = InscEstadualSessao != InscEstadual;
                    if (erro == 0)
                        if (cnpjAlterado)
                        {
                            bool cnpjJaExiste = new ClienteService().ExisteCNPJ(CNPJ);
                            if (cnpjJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe este mesmo CNPJ cadastado no sistema");
                            }
                        }
                    if (erro == 0)
                        if (razaoSocialAlterado)
                        {
                            bool razaoSocialJaExiste = new ClienteService().ExisteCNPJ(RazaoSocial);
                            if (razaoSocialJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe esta mesma Razão Social cadastada no sistema");
                            }
                        }
                    if (erro == 0)
                        if (inscEstadualAlterado)
                        {
                            bool inscEstadualJaExiste = new ClienteService().ExisteCNPJ(InscEstadual);
                            if (inscEstadualJaExiste)
                            {
                                erro = 1;
                                MessageBox.Show("Já existe esta mesma Insc. Estadual cadastada no sistema");
                            }
                        }
                    if (erro == 0)
                        if (!Validacao.ValidaCNPJ.IsCnpj(CNPJ))
                        {
                            erro = 1;
                            MessageBox.Show("O número é um CNPJ Inválido!");
                        }
                }
            }
            if (erro == 0)
            {
                if (string.IsNullOrWhiteSpace(Endereco) || string.IsNullOrWhiteSpace(CEP) || string.IsNullOrWhiteSpace(Cidade)
                       || string.IsNullOrWhiteSpace(UF) || string.IsNullOrWhiteSpace(Telefone))
                {
                    erro = 1;
                    MessageBox.Show("Preencha o(s) campo(s) obrigatório(s).");
                }
            }
            if (erro == 0)
            {
                ItemConsultarClienteModel clienteModel = (ItemConsultarClienteModel)ContextHelper.GetData("Cliente");
                int codigo = 0;
                if (clienteModel != null)
                    codigo = clienteModel.Codigo;

                string tipoPessoa = string.Empty;
                if (PessoaFisica)
                    tipoPessoa = "F";
                if (PessoaJuridica)
                    tipoPessoa = "J";

                var clienteSalvo = new ClienteService().Salvar(CPF, RG, Nome, CNPJ, RazaoSocial, InscEstadual,
                    Endereco, CEP, Cidade, UF, Celular, Obs, Telefone, tipoPessoa, codigo, Bairro);
                if (clienteSalvo)
                {
                    MessageBox.Show("Operação realizada com sucesso!");
                    var listaUsuario = new ClienteService().ObterClientes(string.Empty, 2, "NOME/RAZÃO SOCIAL");
                    var listaItemConsultarClienteModel = new List<ItemConsultarClienteModel>();
                    if (listaUsuario != null && listaUsuario.Any())
                        foreach (var item in listaUsuario)
                        {
                            var itemConsultarClienteModel = new ItemConsultarClienteModel();
                            itemConsultarClienteModel.Codigo = item.Codigo;
                            itemConsultarClienteModel.CPF = !string.IsNullOrWhiteSpace(item.CPF) ? item.CPF : item.CNPJ;
                            itemConsultarClienteModel.RG = !string.IsNullOrWhiteSpace(item.RG) ? item.RG : item.InscEstadual;
                            itemConsultarClienteModel.Nome = !string.IsNullOrWhiteSpace(item.Nome) ? item.Nome : item.RazaoSocial;
                            itemConsultarClienteModel.CNPJ = item.CNPJ;
                            itemConsultarClienteModel.RazaoSocial = item.RazaoSocial;
                            itemConsultarClienteModel.InscEstadual = item.InscEstadual;
                            itemConsultarClienteModel.Endereco = item.Endereco;
                            itemConsultarClienteModel.Telefone = item.Telefone;
                            itemConsultarClienteModel.InscEstadual = item.InscEstadual;
                            itemConsultarClienteModel.Celular = item.Celular;
                            itemConsultarClienteModel.CEP = item.CEP;
                            itemConsultarClienteModel.Cidade = item.Cidade;
                            itemConsultarClienteModel.Bairro = item.Bairro;
                            itemConsultarClienteModel.Obs = item.Obs;
                            itemConsultarClienteModel.UF = item.UF;
                            listaItemConsultarClienteModel.Add(itemConsultarClienteModel);
                        }
                    this.RefreshDgv(listaItemConsultarClienteModel);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao realizar a operação.");
            }
        }
        #endregion

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            //DialogResult resultado = MessageBox.Show("Deseja Realmente Sair?", "Acesso ao Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (resultado == DialogResult.Yes)
            //{
            this.Close();
            RemoverObjetosSessao();
            //}
            //else
            //    return;
        }
        private void PreencherInterface(ClienteModel item) //Método para preencher a tela na alteração de Usuário
        {
            CPF = item.CPF;
            CPFSessao = item.CPF;
            if (!string.IsNullOrWhiteSpace(item.CPF))
            {
                PessoaFisica = true;
                PessoaJuridicaRadioButton.Enabled = false;
            }
            else
            {
                PessoaJuridica = true;
                PessoaFisicaRadioButton.Enabled = false;
            }
            RG = item.RG;
            RGSessao = item.RG;
            NomeSessao = item.Nome;
            Nome = item.Nome;
            CNPJSessao = item.CNPJ;
            CNPJ = item.CNPJ;
            RazaoSocial = item.RazaoSocial;
            RazaoSocialSessao = item.RazaoSocial;
            InscEstadualSessao = item.InscEstadual;
            Endereco = item.Endereco;
            Telefone = item.Telefone;
            InscEstadual = item.InscEstadual;
            Celular = item.Celular;
            CEP = item.CEP;
            Cidade = item.Cidade;
            Bairro = item.Bairro;
            Obs = item.Obs;
            UF = item.UF;
        }

        public bool ModoEdicao()//Método para verificar se é uma edição
        {
            return ContextHelper.GetData("Cliente") != null;
        }

        private ClienteModel ObterItemConsultaClienteModelSessao()//Método para recuperar o Usuario que está sendo alterado
        {
            ItemConsultarClienteModel clienteModel = (ItemConsultarClienteModel)ContextHelper.GetData("Cliente");
            return new ClienteService().GetClienteById(clienteModel.Codigo);
        }

        private void InsEstadualTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaInscricaoEstadual(sender, e);
        }

        private void InsEstadualTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
        }

        private void RGTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EntradaRG(sender, e);
        }

        private void RGTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NaoNumeroDigitado)
                e.Handled = true;
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

        protected void EntradaRG(object sender, KeyEventArgs e)
        {
            NaoNumeroDigitado = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                    {
                        NaoNumeroDigitado = true;
                        //if ((int)e.KeyCode == 110 || (int)e.KeyCode == 188)
                        //    if (!((TextBox)sender).Text.Contains(","))
                        //        NaoNumeroDigitado = false;
                        if (e.KeyCode == Keys.None)
                            NaoNumeroDigitado = false;

                        if ((int)e.KeyCode == 109)
                            NaoNumeroDigitado = false;
                    }

            if (ModifierKeys == Keys.Shift)
                NaoNumeroDigitado = true;
        }

        protected void EntradaInscricaoEstadual(object sender, KeyEventArgs e)
        {
            NaoNumeroDigitado = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                    {
                        NaoNumeroDigitado = true;
                        //if ((int)e.KeyCode == 110 || (int)e.KeyCode == 188)
                        //    if (!((TextBox)sender).Text.Contains(","))
                        //        NaoNumeroDigitado = false;
                        if (e.KeyCode == Keys.None)
                            NaoNumeroDigitado = false;

                        if ((int)e.KeyCode == 109)
                            NaoNumeroDigitado = false;

                        if ((int)e.KeyCode == 111)
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


        private void NomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsLower(e.KeyChar))
            //{
            //    NomeTextBox.SelectedText = Char.ToUpper(e.KeyChar).ToString();

            //    e.Handled = true;
            //}
        }
    }
}
