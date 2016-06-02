namespace ProjetoFinal.Views
{
    partial class Entrega
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
            this.AlterarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsultaEntregadataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoLabel = new System.Windows.Forms.Label();
            this.ConsultaTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompraGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntregaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoGridColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NomeUsuarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamentoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEntregadataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlterarButton
            // 
            this.AlterarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarButton.Location = new System.Drawing.Point(0, 10);
            this.AlterarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(139, 60);
            this.AlterarButton.TabIndex = 179;
            this.AlterarButton.Text = "Confirmar Entrega";
            this.AlterarButton.UseVisualStyleBackColor = true;
            this.AlterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.AlterarButton);
            this.panel1.Location = new System.Drawing.Point(13, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 70);
            this.panel1.TabIndex = 185;
            // 
            // ConsultaEntregadataGridView
            // 
            this.ConsultaEntregadataGridView.AllowUserToAddRows = false;
            this.ConsultaEntregadataGridView.AllowUserToDeleteRows = false;
            this.ConsultaEntregadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaEntregadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaEntregadataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaEntregadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.ClienteGridColumn,
            this.TelefoneGridColumn,
            this.DataCompraGridColumn,
            this.DataEntregaGridColumn,
            this.EnderecoGridColumn,
            this.SituacaoGridColumn,
            this.NomeUsuarioColumn,
            this.QuantidadeGridColumn,
            this.FormaPagamentoGridColumn,
            this.CPFColumn,
            this.DescontoColumn,
            this.IdVendaColumn,
            this.ValorTotalColumn});
            this.ConsultaEntregadataGridView.Location = new System.Drawing.Point(13, 86);
            this.ConsultaEntregadataGridView.Name = "ConsultaEntregadataGridView";
            this.ConsultaEntregadataGridView.ReadOnly = true;
            this.ConsultaEntregadataGridView.Size = new System.Drawing.Size(1054, 340);
            this.ConsultaEntregadataGridView.TabIndex = 183;
            this.ConsultaEntregadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaEntregadataGridView_CellContentClick);
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
            this.SituacaoComboBox.Location = new System.Drawing.Point(685, 22);
            this.SituacaoComboBox.Name = "SituacaoComboBox";
            this.SituacaoComboBox.Size = new System.Drawing.Size(209, 25);
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
            this.PesquisarButton.Location = new System.Drawing.Point(960, 20);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(90, 27);
            this.PesquisarButton.TabIndex = 3;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.SituacaoComboBox);
            this.groupBox1.Controls.Add(this.SituacaoLabel);
            this.groupBox1.Controls.Add(this.ConsultaTextBox);
            this.groupBox1.Controls.Add(this.PesquisarButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 60);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            // 
            // CodigoGridColumn
            // 
            this.CodigoGridColumn.DataPropertyName = "Codigo";
            this.CodigoGridColumn.FillWeight = 0.006589003F;
            this.CodigoGridColumn.HeaderText = "Código";
            this.CodigoGridColumn.Name = "CodigoGridColumn";
            this.CodigoGridColumn.ReadOnly = true;
            this.CodigoGridColumn.Visible = false;
            // 
            // ClienteGridColumn
            // 
            this.ClienteGridColumn.DataPropertyName = "NomeCliente";
            this.ClienteGridColumn.FillWeight = 279.9335F;
            this.ClienteGridColumn.HeaderText = "Cliente";
            this.ClienteGridColumn.Name = "ClienteGridColumn";
            this.ClienteGridColumn.ReadOnly = true;
            this.ClienteGridColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TelefoneGridColumn
            // 
            this.TelefoneGridColumn.DataPropertyName = "Telefone";
            this.TelefoneGridColumn.FillWeight = 3.095814F;
            this.TelefoneGridColumn.HeaderText = "Telefone";
            this.TelefoneGridColumn.Name = "TelefoneGridColumn";
            this.TelefoneGridColumn.ReadOnly = true;
            // 
            // DataCompraGridColumn
            // 
            this.DataCompraGridColumn.DataPropertyName = "DataCompra";
            this.DataCompraGridColumn.FillWeight = 667.8146F;
            this.DataCompraGridColumn.HeaderText = "Data Compra";
            this.DataCompraGridColumn.Name = "DataCompraGridColumn";
            this.DataCompraGridColumn.ReadOnly = true;
            // 
            // DataEntregaGridColumn
            // 
            this.DataEntregaGridColumn.DataPropertyName = "DataEntrega";
            this.DataEntregaGridColumn.FillWeight = 328.8428F;
            this.DataEntregaGridColumn.HeaderText = "Data Entrega";
            this.DataEntregaGridColumn.Name = "DataEntregaGridColumn";
            this.DataEntregaGridColumn.ReadOnly = true;
            // 
            // EnderecoGridColumn
            // 
            this.EnderecoGridColumn.DataPropertyName = "EnderecoCliente";
            this.EnderecoGridColumn.FillWeight = 14.30165F;
            this.EnderecoGridColumn.HeaderText = "Endereço";
            this.EnderecoGridColumn.Name = "EnderecoGridColumn";
            this.EnderecoGridColumn.ReadOnly = true;
            this.EnderecoGridColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SituacaoGridColumn
            // 
            this.SituacaoGridColumn.DataPropertyName = "Status";
            this.SituacaoGridColumn.FillWeight = 21.60631F;
            this.SituacaoGridColumn.HeaderText = "Situação";
            this.SituacaoGridColumn.Name = "SituacaoGridColumn";
            this.SituacaoGridColumn.ReadOnly = true;
            this.SituacaoGridColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SituacaoGridColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NomeUsuarioColumn
            // 
            this.NomeUsuarioColumn.DataPropertyName = "NomeUsuario";
            this.NomeUsuarioColumn.FillWeight = 53.10072F;
            this.NomeUsuarioColumn.HeaderText = "Usuário";
            this.NomeUsuarioColumn.Name = "NomeUsuarioColumn";
            this.NomeUsuarioColumn.ReadOnly = true;
            this.NomeUsuarioColumn.Visible = false;
            // 
            // QuantidadeGridColumn
            // 
            this.QuantidadeGridColumn.DataPropertyName = "QuantidadeParcela";
            this.QuantidadeGridColumn.HeaderText = "Quantidade";
            this.QuantidadeGridColumn.Name = "QuantidadeGridColumn";
            this.QuantidadeGridColumn.ReadOnly = true;
            this.QuantidadeGridColumn.Visible = false;
            // 
            // FormaPagamentoGridColumn
            // 
            this.FormaPagamentoGridColumn.DataPropertyName = "FormaPagamento";
            this.FormaPagamentoGridColumn.FillWeight = 53.10072F;
            this.FormaPagamentoGridColumn.HeaderText = "Forma Pagamento";
            this.FormaPagamentoGridColumn.Name = "FormaPagamentoGridColumn";
            this.FormaPagamentoGridColumn.ReadOnly = true;
            this.FormaPagamentoGridColumn.Visible = false;
            // 
            // CPFColumn
            // 
            this.CPFColumn.DataPropertyName = "CPF";
            this.CPFColumn.HeaderText = "CPF/CNPJ";
            this.CPFColumn.Name = "CPFColumn";
            this.CPFColumn.ReadOnly = true;
            this.CPFColumn.Visible = false;
            // 
            // DescontoColumn
            // 
            this.DescontoColumn.DataPropertyName = "Desconto";
            this.DescontoColumn.HeaderText = "Desconto";
            this.DescontoColumn.Name = "DescontoColumn";
            this.DescontoColumn.ReadOnly = true;
            this.DescontoColumn.Visible = false;
            // 
            // IdVendaColumn
            // 
            this.IdVendaColumn.DataPropertyName = "IdVenda";
            this.IdVendaColumn.HeaderText = "IdVenda";
            this.IdVendaColumn.Name = "IdVendaColumn";
            this.IdVendaColumn.ReadOnly = true;
            this.IdVendaColumn.Visible = false;
            // 
            // ValorTotalColumn
            // 
            this.ValorTotalColumn.DataPropertyName = "ValorTotal";
            this.ValorTotalColumn.FillWeight = 53.10072F;
            this.ValorTotalColumn.HeaderText = "ValorTotal";
            this.ValorTotalColumn.Name = "ValorTotalColumn";
            this.ValorTotalColumn.ReadOnly = true;
            this.ValorTotalColumn.Visible = false;
            // 
            // Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsultaEntregadataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Entrega";
            this.Text = "Entrega";
            this.Load += new System.EventHandler(this.Entrega_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEntregadataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ConsultaEntregadataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.ComboBox SituacaoComboBox;
        private System.Windows.Forms.Label SituacaoLabel;
        private System.Windows.Forms.TextBox ConsultaTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompraGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntregaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoGridColumn;
        private System.Windows.Forms.DataGridViewLinkColumn SituacaoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamentoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotalColumn;
    }
}