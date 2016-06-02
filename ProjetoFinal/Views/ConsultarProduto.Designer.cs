namespace ProjetoFinal.Views
{
    partial class ConsultarProduto
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
            this.ConsultaProdutodataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCompraGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVendaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MargemLucroGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalizacaoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMinimoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoLabel = new System.Windows.Forms.Label();
            this.ConsultaTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrecoButton = new System.Windows.Forms.Button();
            this.LancarButton = new System.Windows.Forms.Button();
            this.AtivarButton = new System.Windows.Forms.Button();
            this.InativarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutodataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultaProdutodataGridView
            // 
            this.ConsultaProdutodataGridView.AllowUserToAddRows = false;
            this.ConsultaProdutodataGridView.AllowUserToDeleteRows = false;
            this.ConsultaProdutodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaProdutodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaProdutodataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaProdutodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.Descricao,
            this.MarcaGridColumn,
            this.PrecoCompraGridColumn,
            this.PrecoVendaGridColumn,
            this.MargemLucroGridColumn,
            this.LocalizacaoGridColumn,
            this.EstoqueMinimoGridColumn,
            this.EstoqueAtual,
            this.SituacaoGridColumn});
            this.ConsultaProdutodataGridView.Location = new System.Drawing.Point(12, 90);
            this.ConsultaProdutodataGridView.Name = "ConsultaProdutodataGridView";
            this.ConsultaProdutodataGridView.ReadOnly = true;
            this.ConsultaProdutodataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsultaProdutodataGridView.Size = new System.Drawing.Size(1054, 340);
            this.ConsultaProdutodataGridView.TabIndex = 175;
            this.ConsultaProdutodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PesquisaProdutoGridView_CellContentClick);
            // 
            // CodigoGridColumn
            // 
            this.CodigoGridColumn.DataPropertyName = "Codigo";
            this.CodigoGridColumn.FillWeight = 0.03729939F;
            this.CodigoGridColumn.HeaderText = "Código";
            this.CodigoGridColumn.Name = "CodigoGridColumn";
            this.CodigoGridColumn.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.FillWeight = 0.2864331F;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // MarcaGridColumn
            // 
            this.MarcaGridColumn.DataPropertyName = "Marca";
            this.MarcaGridColumn.FillWeight = 0.4442831F;
            this.MarcaGridColumn.HeaderText = "Marca";
            this.MarcaGridColumn.Name = "MarcaGridColumn";
            this.MarcaGridColumn.ReadOnly = true;
            // 
            // PrecoCompraGridColumn
            // 
            this.PrecoCompraGridColumn.DataPropertyName = "PrecoCompra";
            this.PrecoCompraGridColumn.FillWeight = 0.6891223F;
            this.PrecoCompraGridColumn.HeaderText = "Preço de Compra";
            this.PrecoCompraGridColumn.Name = "PrecoCompraGridColumn";
            this.PrecoCompraGridColumn.ReadOnly = true;
            // 
            // PrecoVendaGridColumn
            // 
            this.PrecoVendaGridColumn.DataPropertyName = "PrecoVenda";
            this.PrecoVendaGridColumn.FillWeight = 1.999249F;
            this.PrecoVendaGridColumn.HeaderText = "Preço de Venda";
            this.PrecoVendaGridColumn.Name = "PrecoVendaGridColumn";
            this.PrecoVendaGridColumn.ReadOnly = true;
            // 
            // MargemLucroGridColumn
            // 
            this.MargemLucroGridColumn.DataPropertyName = "MargemLucro";
            this.MargemLucroGridColumn.FillWeight = 0.219666F;
            this.MargemLucroGridColumn.HeaderText = "Magem de Lucro";
            this.MargemLucroGridColumn.Name = "MargemLucroGridColumn";
            this.MargemLucroGridColumn.ReadOnly = true;
            // 
            // LocalizacaoGridColumn
            // 
            this.LocalizacaoGridColumn.DataPropertyName = "Localizacao";
            this.LocalizacaoGridColumn.FillWeight = 0.219666F;
            this.LocalizacaoGridColumn.HeaderText = "Localização";
            this.LocalizacaoGridColumn.Name = "LocalizacaoGridColumn";
            this.LocalizacaoGridColumn.ReadOnly = true;
            // 
            // EstoqueMinimoGridColumn
            // 
            this.EstoqueMinimoGridColumn.DataPropertyName = "EstoqueMinimo";
            this.EstoqueMinimoGridColumn.FillWeight = 2.412498F;
            this.EstoqueMinimoGridColumn.HeaderText = "Estoque Mínimo";
            this.EstoqueMinimoGridColumn.Name = "EstoqueMinimoGridColumn";
            this.EstoqueMinimoGridColumn.ReadOnly = true;
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.DataPropertyName = "EstoqueAtual";
            this.EstoqueAtual.FillWeight = 3.741852F;
            this.EstoqueAtual.HeaderText = "Estoque Atual";
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.ReadOnly = true;
            // 
            // SituacaoGridColumn
            // 
            this.SituacaoGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SituacaoGridColumn.DataPropertyName = "Situacao";
            this.SituacaoGridColumn.HeaderText = "Situação";
            this.SituacaoGridColumn.Name = "SituacaoGridColumn";
            this.SituacaoGridColumn.ReadOnly = true;
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
            this.button1.TabIndex = 232;
            this.button1.Text = "&Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NovoButton_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.PrecoButton);
            this.panel1.Controls.Add(this.LancarButton);
            this.panel1.Controls.Add(this.AtivarButton);
            this.panel1.Controls.Add(this.InativarButton);
            this.panel1.Controls.Add(this.AlterarButton);
            this.panel1.Location = new System.Drawing.Point(12, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 70);
            this.panel1.TabIndex = 180;
            // 
            // PrecoButton
            // 
            this.PrecoButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoButton.Location = new System.Drawing.Point(520, 10);
            this.PrecoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrecoButton.Name = "PrecoButton";
            this.PrecoButton.Size = new System.Drawing.Size(122, 60);
            this.PrecoButton.TabIndex = 183;
            this.PrecoButton.Text = "Preço";
            this.PrecoButton.UseVisualStyleBackColor = true;
            this.PrecoButton.Visible = false;
            this.PrecoButton.Click += new System.EventHandler(this.PrecoButton_Click);
            // 
            // LancarButton
            // 
            this.LancarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancarButton.Location = new System.Drawing.Point(390, 10);
            this.LancarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LancarButton.Name = "LancarButton";
            this.LancarButton.Size = new System.Drawing.Size(122, 60);
            this.LancarButton.TabIndex = 182;
            this.LancarButton.Text = "Lançar";
            this.LancarButton.UseVisualStyleBackColor = true;
            this.LancarButton.Click += new System.EventHandler(this.LancarButton_Click);
            // 
            // AtivarButton
            // 
            this.AtivarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtivarButton.Location = new System.Drawing.Point(260, 10);
            this.AtivarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AtivarButton.Name = "AtivarButton";
            this.AtivarButton.Size = new System.Drawing.Size(122, 60);
            this.AtivarButton.TabIndex = 181;
            this.AtivarButton.Text = "Ativar";
            this.AtivarButton.UseVisualStyleBackColor = true;
            this.AtivarButton.Click += new System.EventHandler(this.AtivarButton_Click);
            // 
            // InativarButton
            // 
            this.InativarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InativarButton.Location = new System.Drawing.Point(130, 10);
            this.InativarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InativarButton.Name = "InativarButton";
            this.InativarButton.Size = new System.Drawing.Size(122, 60);
            this.InativarButton.TabIndex = 180;
            this.InativarButton.Text = "Inativar";
            this.InativarButton.UseVisualStyleBackColor = true;
            this.InativarButton.Click += new System.EventHandler(this.InativarButton_Click);
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsultaProdutodataGridView);
            this.Name = "ConsultarProduto";
            this.Text = "ConsultarProduto";
            this.Load += new System.EventHandler(this.ConsultarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutodataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaProdutodataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.ComboBox SituacaoComboBox;
        private System.Windows.Forms.Label SituacaoLabel;
        private System.Windows.Forms.TextBox ConsultaTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InativarButton;
        private System.Windows.Forms.Button AtivarButton;
        private System.Windows.Forms.Button PrecoButton;
        private System.Windows.Forms.Button LancarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCompraGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVendaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MargemLucroGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalizacaoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMinimoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoGridColumn;
    }
}