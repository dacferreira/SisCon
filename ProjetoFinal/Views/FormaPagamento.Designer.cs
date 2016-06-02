namespace ProjetoFinal.Views
{
    partial class FormaPagamento
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
            this.FormaPagamentoGroupBox = new System.Windows.Forms.GroupBox();
            this.CreditoCheckBox = new System.Windows.Forms.CheckBox();
            this.DinheiroCheckBox = new System.Windows.Forms.CheckBox();
            this.DebitoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditoComboBox = new System.Windows.Forms.ComboBox();
            this.CreditoTextBox = new System.Windows.Forms.TextBox();
            this.DinheiroTextBox = new System.Windows.Forms.TextBox();
            this.DebitoTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.NotaFiscalCheckBox = new System.Windows.Forms.CheckBox();
            this.EntregaCheckBox = new System.Windows.Forms.CheckBox();
            this.DescricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.EndereçoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RazaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalVendaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TrocoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ValorPagoTextBox = new System.Windows.Forms.TextBox();
            this.DescontoCheckBox = new System.Windows.Forms.CheckBox();
            this.DescontoTextBox = new System.Windows.Forms.TextBox();
            this.NovoClienteButton = new System.Windows.Forms.Button();
            this.FormaPagamentoGroupBox.SuspendLayout();
            this.ClienteGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormaPagamentoGroupBox
            // 
            this.FormaPagamentoGroupBox.Controls.Add(this.CreditoCheckBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.DinheiroCheckBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.DebitoCheckBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.label1);
            this.FormaPagamentoGroupBox.Controls.Add(this.CreditoComboBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.CreditoTextBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.DinheiroTextBox);
            this.FormaPagamentoGroupBox.Controls.Add(this.DebitoTextBox);
            this.FormaPagamentoGroupBox.Location = new System.Drawing.Point(12, 221);
            this.FormaPagamentoGroupBox.Name = "FormaPagamentoGroupBox";
            this.FormaPagamentoGroupBox.Size = new System.Drawing.Size(401, 172);
            this.FormaPagamentoGroupBox.TabIndex = 0;
            this.FormaPagamentoGroupBox.TabStop = false;
            this.FormaPagamentoGroupBox.Text = "Forma Pagamento:";
            // 
            // CreditoCheckBox
            // 
            this.CreditoCheckBox.AutoSize = true;
            this.CreditoCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreditoCheckBox.Location = new System.Drawing.Point(6, 128);
            this.CreditoCheckBox.Name = "CreditoCheckBox";
            this.CreditoCheckBox.Size = new System.Drawing.Size(198, 27);
            this.CreditoCheckBox.TabIndex = 448;
            this.CreditoCheckBox.Text = "Cartão de Crédito";
            this.CreditoCheckBox.UseVisualStyleBackColor = true;
            this.CreditoCheckBox.CheckedChanged += new System.EventHandler(this.CreditoCheckBox_CheckedChanged);
            // 
            // DinheiroCheckBox
            // 
            this.DinheiroCheckBox.AutoSize = true;
            this.DinheiroCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DinheiroCheckBox.Location = new System.Drawing.Point(6, 42);
            this.DinheiroCheckBox.Name = "DinheiroCheckBox";
            this.DinheiroCheckBox.Size = new System.Drawing.Size(104, 27);
            this.DinheiroCheckBox.TabIndex = 446;
            this.DinheiroCheckBox.Text = "Dinheiro";
            this.DinheiroCheckBox.UseVisualStyleBackColor = true;
            this.DinheiroCheckBox.CheckedChanged += new System.EventHandler(this.DinheiroCheckBox_CheckedChanged);
            // 
            // DebitoCheckBox
            // 
            this.DebitoCheckBox.AutoSize = true;
            this.DebitoCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DebitoCheckBox.Location = new System.Drawing.Point(6, 86);
            this.DebitoCheckBox.Name = "DebitoCheckBox";
            this.DebitoCheckBox.Size = new System.Drawing.Size(190, 27);
            this.DebitoCheckBox.TabIndex = 447;
            this.DebitoCheckBox.Text = "Cartão de Débito";
            this.DebitoCheckBox.UseVisualStyleBackColor = true;
            this.DebitoCheckBox.CheckedChanged += new System.EventHandler(this.DebitoCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(326, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 23);
            this.label1.TabIndex = 439;
            this.label1.Text = "x";
            // 
            // CreditoComboBox
            // 
            this.CreditoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreditoComboBox.Enabled = false;
            this.CreditoComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditoComboBox.FormattingEnabled = true;
            this.CreditoComboBox.Location = new System.Drawing.Point(352, 131);
            this.CreditoComboBox.Name = "CreditoComboBox";
            this.CreditoComboBox.Size = new System.Drawing.Size(42, 25);
            this.CreditoComboBox.TabIndex = 438;
            // 
            // CreditoTextBox
            // 
            this.CreditoTextBox.Enabled = false;
            this.CreditoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreditoTextBox.Location = new System.Drawing.Point(205, 120);
            this.CreditoTextBox.MaxLength = 200;
            this.CreditoTextBox.Name = "CreditoTextBox";
            this.CreditoTextBox.Size = new System.Drawing.Size(115, 38);
            this.CreditoTextBox.TabIndex = 3;
            this.CreditoTextBox.TextChanged += new System.EventHandler(this.CreditoTextBox_TextChanged);
            this.CreditoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreditoTextBox_KeyDown);
            this.CreditoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditoTextBox_KeyPress);
            // 
            // DinheiroTextBox
            // 
            this.DinheiroTextBox.Enabled = false;
            this.DinheiroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DinheiroTextBox.Location = new System.Drawing.Point(205, 31);
            this.DinheiroTextBox.MaxLength = 4;
            this.DinheiroTextBox.Name = "DinheiroTextBox";
            this.DinheiroTextBox.Size = new System.Drawing.Size(115, 38);
            this.DinheiroTextBox.TabIndex = 1;
            this.DinheiroTextBox.TextChanged += new System.EventHandler(this.DinheiroTextBox_TextChanged);
            this.DinheiroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DinheiroTextBox_KeyDown);
            this.DinheiroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DinheiroTextBox_KeyPress);
            // 
            // DebitoTextBox
            // 
            this.DebitoTextBox.Enabled = false;
            this.DebitoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DebitoTextBox.Location = new System.Drawing.Point(205, 75);
            this.DebitoTextBox.MaxLength = 200;
            this.DebitoTextBox.Name = "DebitoTextBox";
            this.DebitoTextBox.Size = new System.Drawing.Size(115, 38);
            this.DebitoTextBox.TabIndex = 2;
            this.DebitoTextBox.TextChanged += new System.EventHandler(this.DebitoTextBox_TextChanged);
            this.DebitoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebitoTextBox_KeyDown);
            this.DebitoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DebitoTextBox_KeyPress);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(86, 572);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 61);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "&Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(214, 572);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 61);
            this.SalvarButton.TabIndex = 5;
            this.SalvarButton.Text = "&Finalizar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // NotaFiscalCheckBox
            // 
            this.NotaFiscalCheckBox.AutoSize = true;
            this.NotaFiscalCheckBox.Location = new System.Drawing.Point(206, 12);
            this.NotaFiscalCheckBox.Name = "NotaFiscalCheckBox";
            this.NotaFiscalCheckBox.Size = new System.Drawing.Size(79, 17);
            this.NotaFiscalCheckBox.TabIndex = 8;
            this.NotaFiscalCheckBox.Text = "Nota Fiscal";
            this.NotaFiscalCheckBox.UseVisualStyleBackColor = true;
            this.NotaFiscalCheckBox.Visible = false;
            // 
            // EntregaCheckBox
            // 
            this.EntregaCheckBox.AutoSize = true;
            this.EntregaCheckBox.Location = new System.Drawing.Point(11, 49);
            this.EntregaCheckBox.Name = "EntregaCheckBox";
            this.EntregaCheckBox.Size = new System.Drawing.Size(63, 17);
            this.EntregaCheckBox.TabIndex = 7;
            this.EntregaCheckBox.Text = "Entrega";
            this.EntregaCheckBox.UseVisualStyleBackColor = true;
            this.EntregaCheckBox.CheckedChanged += new System.EventHandler(this.EntregaCheckBox_CheckedChanged);
            // 
            // DescricaoProdutoTextBox
            // 
            this.DescricaoProdutoTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Marcos",
            "Amanda",
            "Raul",
            "Pedro",
            "Maria"});
            this.DescricaoProdutoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.DescricaoProdutoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DescricaoProdutoTextBox.Enabled = false;
            this.DescricaoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricaoProdutoTextBox.Location = new System.Drawing.Point(95, 42);
            this.DescricaoProdutoTextBox.MaxLength = 100;
            this.DescricaoProdutoTextBox.Name = "DescricaoProdutoTextBox";
            this.DescricaoProdutoTextBox.Size = new System.Drawing.Size(318, 26);
            this.DescricaoProdutoTextBox.TabIndex = 9;
            this.DescricaoProdutoTextBox.Text = "Digite o nome do Cliente";
            this.DescricaoProdutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescricaoProdutoTextBox_KeyDown);
            this.DescricaoProdutoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescricaoProdutoTextBox_KeyPress);
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.Enabled = false;
            this.EnderecoTextBox.Location = new System.Drawing.Point(123, 49);
            this.EnderecoTextBox.MaxLength = 100;
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(262, 20);
            this.EnderecoTextBox.TabIndex = 409;
            // 
            // EndereçoLabel
            // 
            this.EndereçoLabel.AutoSize = true;
            this.EndereçoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndereçoLabel.Location = new System.Drawing.Point(5, 50);
            this.EndereçoLabel.Name = "EndereçoLabel";
            this.EndereçoLabel.Size = new System.Drawing.Size(73, 17);
            this.EndereçoLabel.TabIndex = 412;
            this.EndereçoLabel.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 411;
            this.label5.Text = "Razão Social / Nome:";
            // 
            // RazaoSocialTextBox
            // 
            this.RazaoSocialTextBox.Enabled = false;
            this.RazaoSocialTextBox.Location = new System.Drawing.Point(123, 23);
            this.RazaoSocialTextBox.MaxLength = 100;
            this.RazaoSocialTextBox.Name = "RazaoSocialTextBox";
            this.RazaoSocialTextBox.Size = new System.Drawing.Size(262, 20);
            this.RazaoSocialTextBox.TabIndex = 408;
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Enabled = false;
            this.TelefoneTextBox.Location = new System.Drawing.Point(123, 75);
            this.TelefoneTextBox.Mask = "(99) 0000-0000";
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(84, 20);
            this.TelefoneTextBox.TabIndex = 410;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 413;
            this.label6.Text = "Telefone:";
            // 
            // AlterarButton
            // 
            this.AlterarButton.Enabled = false;
            this.AlterarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarButton.Location = new System.Drawing.Point(263, 85);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(122, 30);
            this.AlterarButton.TabIndex = 443;
            this.AlterarButton.Text = "&Editar Cadastro";
            this.AlterarButton.UseVisualStyleBackColor = true;
            this.AlterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // ClienteGroupBox
            // 
            this.ClienteGroupBox.Controls.Add(this.AlterarButton);
            this.ClienteGroupBox.Controls.Add(this.EnderecoTextBox);
            this.ClienteGroupBox.Controls.Add(this.label6);
            this.ClienteGroupBox.Controls.Add(this.EndereçoLabel);
            this.ClienteGroupBox.Controls.Add(this.TelefoneTextBox);
            this.ClienteGroupBox.Controls.Add(this.label5);
            this.ClienteGroupBox.Controls.Add(this.RazaoSocialTextBox);
            this.ClienteGroupBox.Location = new System.Drawing.Point(13, 85);
            this.ClienteGroupBox.Name = "ClienteGroupBox";
            this.ClienteGroupBox.Size = new System.Drawing.Size(400, 130);
            this.ClienteGroupBox.TabIndex = 444;
            this.ClienteGroupBox.TabStop = false;
            this.ClienteGroupBox.Text = "Dados Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalVendaTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TrocoTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ValorPagoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 166);
            this.groupBox1.TabIndex = 443;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Venda";
            // 
            // TotalVendaTextBox
            // 
            this.TotalVendaTextBox.Enabled = false;
            this.TotalVendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TotalVendaTextBox.Location = new System.Drawing.Point(180, 29);
            this.TotalVendaTextBox.MaxLength = 200;
            this.TotalVendaTextBox.Name = "TotalVendaTextBox";
            this.TotalVendaTextBox.Size = new System.Drawing.Size(124, 38);
            this.TotalVendaTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 441;
            this.label8.Text = "Total Venda";
            // 
            // TrocoTextBox
            // 
            this.TrocoTextBox.Enabled = false;
            this.TrocoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TrocoTextBox.Location = new System.Drawing.Point(180, 116);
            this.TrocoTextBox.MaxLength = 5;
            this.TrocoTextBox.Name = "TrocoTextBox";
            this.TrocoTextBox.Size = new System.Drawing.Size(124, 38);
            this.TrocoTextBox.TabIndex = 431;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 434;
            this.label11.Text = "Troco";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(16, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 433;
            this.label12.Text = "Valor Pago";
            // 
            // ValorPagoTextBox
            // 
            this.ValorPagoTextBox.Enabled = false;
            this.ValorPagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ValorPagoTextBox.Location = new System.Drawing.Point(180, 73);
            this.ValorPagoTextBox.MaxLength = 5;
            this.ValorPagoTextBox.Name = "ValorPagoTextBox";
            this.ValorPagoTextBox.Size = new System.Drawing.Size(124, 38);
            this.ValorPagoTextBox.TabIndex = 5;
            this.ValorPagoTextBox.TextChanged += new System.EventHandler(this.ValorPagoTextBox_TextChanged);
            this.ValorPagoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValorPagoTextBox_KeyDown);
            this.ValorPagoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorPagoTextBox_KeyPress);
            // 
            // DescontoCheckBox
            // 
            this.DescontoCheckBox.AutoSize = true;
            this.DescontoCheckBox.Location = new System.Drawing.Point(13, 14);
            this.DescontoCheckBox.Name = "DescontoCheckBox";
            this.DescontoCheckBox.Size = new System.Drawing.Size(72, 17);
            this.DescontoCheckBox.TabIndex = 445;
            this.DescontoCheckBox.Text = "Desconto";
            this.DescontoCheckBox.UseVisualStyleBackColor = true;
            this.DescontoCheckBox.CheckedChanged += new System.EventHandler(this.DescontoCheckBox_CheckedChanged);
            // 
            // DescontoTextBox
            // 
            this.DescontoTextBox.Location = new System.Drawing.Point(96, 12);
            this.DescontoTextBox.MaxLength = 3;
            this.DescontoTextBox.Name = "DescontoTextBox";
            this.DescontoTextBox.Size = new System.Drawing.Size(58, 20);
            this.DescontoTextBox.TabIndex = 444;
            this.DescontoTextBox.Visible = false;
            this.DescontoTextBox.TextChanged += new System.EventHandler(this.DescontoTextBox_TextChanged);
            this.DescontoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescontoTextBox_KeyDown);
            this.DescontoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescontoTextBox_KeyPress);
            // 
            // NovoClienteButton
            // 
            this.NovoClienteButton.Enabled = false;
            this.NovoClienteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoClienteButton.Location = new System.Drawing.Point(206, 2);
            this.NovoClienteButton.Name = "NovoClienteButton";
            this.NovoClienteButton.Size = new System.Drawing.Size(122, 30);
            this.NovoClienteButton.TabIndex = 446;
            this.NovoClienteButton.Text = "&Novo Cliente";
            this.NovoClienteButton.UseVisualStyleBackColor = true;
            this.NovoClienteButton.Visible = false;
            this.NovoClienteButton.Click += new System.EventHandler(this.NovoClienteButton_Click);
            // 
            // FormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(425, 639);
            this.ControlBox = false;
            this.Controls.Add(this.NovoClienteButton);
            this.Controls.Add(this.DescontoTextBox);
            this.Controls.Add(this.DescontoCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClienteGroupBox);
            this.Controls.Add(this.DescricaoProdutoTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EntregaCheckBox);
            this.Controls.Add(this.NotaFiscalCheckBox);
            this.Controls.Add(this.FormaPagamentoGroupBox);
            this.Controls.Add(this.SalvarButton);
            this.Name = "FormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalização de Vendas";
            this.Load += new System.EventHandler(this.FormaPagamento_Load);
            this.FormaPagamentoGroupBox.ResumeLayout(false);
            this.FormaPagamentoGroupBox.PerformLayout();
            this.ClienteGroupBox.ResumeLayout(false);
            this.ClienteGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FormaPagamentoGroupBox;
        private System.Windows.Forms.CheckBox NotaFiscalCheckBox;
        private System.Windows.Forms.CheckBox EntregaCheckBox;
        private System.Windows.Forms.TextBox CreditoTextBox;
        private System.Windows.Forms.TextBox DinheiroTextBox;
        private System.Windows.Forms.TextBox DebitoTextBox;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CreditoComboBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox DescricaoProdutoTextBox;
        private System.Windows.Forms.TextBox EnderecoTextBox;
        private System.Windows.Forms.Label EndereçoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RazaoSocialTextBox;
        private System.Windows.Forms.MaskedTextBox TelefoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.GroupBox ClienteGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotalVendaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TrocoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ValorPagoTextBox;
        private System.Windows.Forms.CheckBox DescontoCheckBox;
        private System.Windows.Forms.TextBox DescontoTextBox;
        private System.Windows.Forms.CheckBox CreditoCheckBox;
        private System.Windows.Forms.CheckBox DinheiroCheckBox;
        private System.Windows.Forms.CheckBox DebitoCheckBox;
        private System.Windows.Forms.Button NovoClienteButton;
    }
}