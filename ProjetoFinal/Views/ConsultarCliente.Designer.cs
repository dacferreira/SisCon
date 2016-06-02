namespace ProjetoFinal.Views
{
    partial class ConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoLabel = new System.Windows.Forms.Label();
            this.ConsultaTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConsultaClientedataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscEstadualGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocialGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApelidoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UFColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaFisicaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaJuridiaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaClientedataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 231;
            this.label2.Text = "Consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 230;
            this.label1.Text = "Filtro:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(430, 22);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(160, 25);
            this.FiltroComboBox.TabIndex = 229;
            // 
            // SituacaoComboBox
            // 
            this.SituacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SituacaoComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituacaoComboBox.FormattingEnabled = true;
            this.SituacaoComboBox.Location = new System.Drawing.Point(690, 22);
            this.SituacaoComboBox.Name = "SituacaoComboBox";
            this.SituacaoComboBox.Size = new System.Drawing.Size(130, 25);
            this.SituacaoComboBox.TabIndex = 227;
            this.SituacaoComboBox.Visible = false;
            // 
            // SituacaoLabel
            // 
            this.SituacaoLabel.AutoSize = true;
            this.SituacaoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituacaoLabel.Location = new System.Drawing.Point(610, 25);
            this.SituacaoLabel.Name = "SituacaoLabel";
            this.SituacaoLabel.Size = new System.Drawing.Size(69, 17);
            this.SituacaoLabel.TabIndex = 228;
            this.SituacaoLabel.Text = "Situação:";
            this.SituacaoLabel.Visible = false;
            // 
            // ConsultaTextBox
            // 
            this.ConsultaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ConsultaTextBox.Location = new System.Drawing.Point(80, 22);
            this.ConsultaTextBox.MaxLength = 200;
            this.ConsultaTextBox.Name = "ConsultaTextBox";
            this.ConsultaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ConsultaTextBox.TabIndex = 222;
            this.ConsultaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaTextBox_KeyDown);
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.AutoSize = true;
            this.PesquisarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarButton.Location = new System.Drawing.Point(860, 20);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(90, 27);
            this.PesquisarButton.TabIndex = 3;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.SituacaoComboBox);
            this.groupBox1.Controls.Add(this.SituacaoLabel);
            this.groupBox1.Controls.Add(this.ConsultaTextBox);
            this.groupBox1.Controls.Add(this.PesquisarButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 60);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(960, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 234;
            this.button1.Text = "&Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // ConsultaClientedataGridView
            // 
            this.ConsultaClientedataGridView.AllowUserToAddRows = false;
            this.ConsultaClientedataGridView.AllowUserToDeleteRows = false;
            this.ConsultaClientedataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaClientedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaClientedataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ConsultaClientedataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaClientedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.BairroColumn,
            this.NomeGridColumn,
            this.CPFGridColumn,
            this.RGGridColumn,
            this.EnderecoGridColumn,
            this.CNPJGridColumn,
            this.InscEstadualGridColumn,
            this.RazaoSocialGridColumn,
            this.CEPColumn,
            this.ObsColumn,
            this.ApelidoGridColumn,
            this.UFColumn,
            this.CidadeColumn,
            this.TelefoneColumn,
            this.CelularColumn,
            this.PessoaFisicaColumn,
            this.PessoaJuridiaColumn});
            this.ConsultaClientedataGridView.Location = new System.Drawing.Point(12, 90);
            this.ConsultaClientedataGridView.Name = "ConsultaClientedataGridView";
            this.ConsultaClientedataGridView.ReadOnly = true;
            this.ConsultaClientedataGridView.Size = new System.Drawing.Size(1054, 340);
            this.ConsultaClientedataGridView.TabIndex = 177;
            this.ConsultaClientedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PesquisaClienteGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.AlterarButton);
            this.panel1.Location = new System.Drawing.Point(12, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 70);
            this.panel1.TabIndex = 182;
            // 
            // AlterarButton
            // 
            this.AlterarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarButton.Location = new System.Drawing.Point(0, 10);
            this.AlterarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(122, 60);
            this.AlterarButton.TabIndex = 179;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            this.AlterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // CodigoGridColumn
            // 
            this.CodigoGridColumn.DataPropertyName = "Codigo";
            this.CodigoGridColumn.FillWeight = 0.0005065262F;
            this.CodigoGridColumn.HeaderText = "Código";
            this.CodigoGridColumn.Name = "CodigoGridColumn";
            this.CodigoGridColumn.ReadOnly = true;
            // 
            // BairroColumn
            // 
            this.BairroColumn.DataPropertyName = "Bairro";
            this.BairroColumn.HeaderText = "Bairro";
            this.BairroColumn.Name = "BairroColumn";
            this.BairroColumn.ReadOnly = true;
            this.BairroColumn.Visible = false;
            // 
            // NomeGridColumn
            // 
            this.NomeGridColumn.DataPropertyName = "Nome";
            this.NomeGridColumn.FillWeight = 1064.002F;
            this.NomeGridColumn.HeaderText = "Nome / Razão Social";
            this.NomeGridColumn.Name = "NomeGridColumn";
            this.NomeGridColumn.ReadOnly = true;
            // 
            // CPFGridColumn
            // 
            this.CPFGridColumn.DataPropertyName = "CPF";
            this.CPFGridColumn.FillWeight = 49.10052F;
            this.CPFGridColumn.HeaderText = "CPF / CNPJ";
            this.CPFGridColumn.Name = "CPFGridColumn";
            this.CPFGridColumn.ReadOnly = true;
            // 
            // RGGridColumn
            // 
            this.RGGridColumn.DataPropertyName = "RG";
            this.RGGridColumn.FillWeight = 30.18557F;
            this.RGGridColumn.HeaderText = "RG / Inscrição Estadual";
            this.RGGridColumn.Name = "RGGridColumn";
            this.RGGridColumn.ReadOnly = true;
            // 
            // EnderecoGridColumn
            // 
            this.EnderecoGridColumn.DataPropertyName = "Endereco";
            this.EnderecoGridColumn.FillWeight = 40.93973F;
            this.EnderecoGridColumn.HeaderText = "Endereço";
            this.EnderecoGridColumn.Name = "EnderecoGridColumn";
            this.EnderecoGridColumn.ReadOnly = true;
            // 
            // CNPJGridColumn
            // 
            this.CNPJGridColumn.DataPropertyName = "CNPJ";
            this.CNPJGridColumn.FillWeight = 2.453647F;
            this.CNPJGridColumn.HeaderText = "CNPJ";
            this.CNPJGridColumn.Name = "CNPJGridColumn";
            this.CNPJGridColumn.ReadOnly = true;
            this.CNPJGridColumn.Visible = false;
            // 
            // InscEstadualGridColumn
            // 
            this.InscEstadualGridColumn.DataPropertyName = "InscEstadual";
            this.InscEstadualGridColumn.FillWeight = 2.453647F;
            this.InscEstadualGridColumn.HeaderText = "Inscrição Estadual";
            this.InscEstadualGridColumn.Name = "InscEstadualGridColumn";
            this.InscEstadualGridColumn.ReadOnly = true;
            this.InscEstadualGridColumn.Visible = false;
            // 
            // RazaoSocialGridColumn
            // 
            this.RazaoSocialGridColumn.DataPropertyName = "RazaoSocial";
            this.RazaoSocialGridColumn.FillWeight = 2.453647F;
            this.RazaoSocialGridColumn.HeaderText = "Razão Social";
            this.RazaoSocialGridColumn.Name = "RazaoSocialGridColumn";
            this.RazaoSocialGridColumn.ReadOnly = true;
            this.RazaoSocialGridColumn.Visible = false;
            // 
            // CEPColumn
            // 
            this.CEPColumn.DataPropertyName = "CEP";
            this.CEPColumn.HeaderText = "CEP";
            this.CEPColumn.Name = "CEPColumn";
            this.CEPColumn.ReadOnly = true;
            this.CEPColumn.Visible = false;
            // 
            // ObsColumn
            // 
            this.ObsColumn.DataPropertyName = "Obs";
            this.ObsColumn.HeaderText = "Obs";
            this.ObsColumn.Name = "ObsColumn";
            this.ObsColumn.ReadOnly = true;
            this.ObsColumn.Visible = false;
            // 
            // ApelidoGridColumn
            // 
            this.ApelidoGridColumn.DataPropertyName = "Apelido";
            this.ApelidoGridColumn.FillWeight = 2.453647F;
            this.ApelidoGridColumn.HeaderText = "Apelido";
            this.ApelidoGridColumn.Name = "ApelidoGridColumn";
            this.ApelidoGridColumn.ReadOnly = true;
            this.ApelidoGridColumn.Visible = false;
            // 
            // UFColumn
            // 
            this.UFColumn.DataPropertyName = "UF";
            this.UFColumn.HeaderText = "UFColumn";
            this.UFColumn.Name = "UFColumn";
            this.UFColumn.ReadOnly = true;
            this.UFColumn.Visible = false;
            // 
            // CidadeColumn
            // 
            this.CidadeColumn.DataPropertyName = "Cidade";
            this.CidadeColumn.HeaderText = "CidadeColumn";
            this.CidadeColumn.Name = "CidadeColumn";
            this.CidadeColumn.ReadOnly = true;
            this.CidadeColumn.Visible = false;
            // 
            // TelefoneColumn
            // 
            this.TelefoneColumn.DataPropertyName = "Telefone";
            this.TelefoneColumn.HeaderText = "Telefone";
            this.TelefoneColumn.Name = "TelefoneColumn";
            this.TelefoneColumn.ReadOnly = true;
            this.TelefoneColumn.Visible = false;
            // 
            // CelularColumn
            // 
            this.CelularColumn.DataPropertyName = "Celular";
            this.CelularColumn.HeaderText = "Celular";
            this.CelularColumn.Name = "CelularColumn";
            this.CelularColumn.ReadOnly = true;
            this.CelularColumn.Visible = false;
            // 
            // PessoaFisicaColumn
            // 
            this.PessoaFisicaColumn.DataPropertyName = "PessoaFisica";
            this.PessoaFisicaColumn.HeaderText = "PessoaFisica";
            this.PessoaFisicaColumn.Name = "PessoaFisicaColumn";
            this.PessoaFisicaColumn.ReadOnly = true;
            this.PessoaFisicaColumn.Visible = false;
            // 
            // PessoaJuridiaColumn
            // 
            this.PessoaJuridiaColumn.DataPropertyName = "PessoaJuridica";
            this.PessoaJuridiaColumn.HeaderText = "PessoaJuridica";
            this.PessoaJuridiaColumn.Name = "PessoaJuridiaColumn";
            this.PessoaJuridiaColumn.ReadOnly = true;
            this.PessoaJuridiaColumn.Visible = false;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsultaClientedataGridView);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaClientedataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.ComboBox SituacaoComboBox;
        private System.Windows.Forms.Label SituacaoLabel;
        private System.Windows.Forms.TextBox ConsultaTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ConsultaClientedataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscEstadualGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocialGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApelidoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UFColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaFisicaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaJuridiaColumn;

    }
}