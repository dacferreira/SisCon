namespace ProjetoFinal.Views
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.ConsultaProdutoVendadataGridView = new System.Windows.Forms.DataGridView();
            this.DescricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecoUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.MovimentoDiarioButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CancelarItemButton = new System.Windows.Forms.Button();
            this.DescricaoProdutoCadastradoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AlterarQuantidadeButton = new System.Windows.Forms.Button();
            this.QuantidadeLabel = new System.Windows.Forms.Label();
            this.QuantidadeLabelTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCompraGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MargemLucroGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalizacaoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMinimoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtualGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntregaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutoVendadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaProdutoVendadataGridView
            // 
            this.ConsultaProdutoVendadataGridView.AllowUserToAddRows = false;
            this.ConsultaProdutoVendadataGridView.AllowUserToDeleteRows = false;
            this.ConsultaProdutoVendadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaProdutoVendadataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaProdutoVendadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaProdutoVendadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.Descricao,
            this.MarcaGridColumn,
            this.PrecoUnitarioColumn,
            this.QuantidadeGridColumn,
            this.PrecoCompraGridColumn,
            this.MargemLucroGridColumn,
            this.LocalizacaoGridColumn,
            this.EstoqueMinimoGridColumn,
            this.EstoqueAtualGridColumn,
            this.DescontoColumn,
            this.EntregaColumn});
            this.ConsultaProdutoVendadataGridView.Location = new System.Drawing.Point(12, 20);
            this.ConsultaProdutoVendadataGridView.Name = "ConsultaProdutoVendadataGridView";
            this.ConsultaProdutoVendadataGridView.ReadOnly = true;
            this.ConsultaProdutoVendadataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsultaProdutoVendadataGridView.Size = new System.Drawing.Size(484, 551);
            this.ConsultaProdutoVendadataGridView.TabIndex = 176;
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
            this.DescricaoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescricaoProdutoTextBox.Location = new System.Drawing.Point(12, 633);
            this.DescricaoProdutoTextBox.MaxLength = 100;
            this.DescricaoProdutoTextBox.Name = "DescricaoProdutoTextBox";
            this.DescricaoProdutoTextBox.Size = new System.Drawing.Size(1300, 38);
            this.DescricaoProdutoTextBox.TabIndex = 2;
            this.DescricaoProdutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescricaoProdutoTextBox_KeyDown);
            this.DescricaoProdutoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescricaoProdutoTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 232;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(540, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 419;
            this.label7.Text = "TOTAL";
            // 
            // QuantidadeTextBox
            // 
            this.QuantidadeTextBox.Enabled = false;
            this.QuantidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuantidadeTextBox.Location = new System.Drawing.Point(542, 365);
            this.QuantidadeTextBox.MaxLength = 6;
            this.QuantidadeTextBox.Name = "QuantidadeTextBox";
            this.QuantidadeTextBox.Size = new System.Drawing.Size(120, 38);
            this.QuantidadeTextBox.TabIndex = 1;
            this.QuantidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantidadeTextBox_KeyDown);
            this.QuantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantidadeTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(540, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 418;
            this.label3.Text = "QUANTIDADE";
            // 
            // PrecoUnitarioTextBox
            // 
            this.PrecoUnitarioTextBox.Enabled = false;
            this.PrecoUnitarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PrecoUnitarioTextBox.Location = new System.Drawing.Point(542, 283);
            this.PrecoUnitarioTextBox.MaxLength = 200;
            this.PrecoUnitarioTextBox.Name = "PrecoUnitarioTextBox";
            this.PrecoUnitarioTextBox.Size = new System.Drawing.Size(120, 38);
            this.PrecoUnitarioTextBox.TabIndex = 413;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(540, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 417;
            this.label4.Text = "SUBTOTAL";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Enabled = false;
            this.SubTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SubTotalTextBox.Location = new System.Drawing.Point(542, 454);
            this.SubTotalTextBox.MaxLength = 200;
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(120, 38);
            this.SubTotalTextBox.TabIndex = 415;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(540, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 416;
            this.label1.Text = "PREÇO UNITÁRIO";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(1190, 292);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 421;
            this.CancelarButton.Text = "Devolução";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // MovimentoDiarioButton
            // 
            this.MovimentoDiarioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovimentoDiarioButton.Location = new System.Drawing.Point(1190, 497);
            this.MovimentoDiarioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovimentoDiarioButton.Name = "MovimentoDiarioButton";
            this.MovimentoDiarioButton.Size = new System.Drawing.Size(122, 60);
            this.MovimentoDiarioButton.TabIndex = 420;
            this.MovimentoDiarioButton.Text = "Movimento Diário";
            this.MovimentoDiarioButton.UseVisualStyleBackColor = true;
            this.MovimentoDiarioButton.Click += new System.EventHandler(this.MovimentoDiarioButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1100, 678);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 422;
            this.label5.Text = "ESC - ABANDONAR VENDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 678);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 423;
            this.label6.Text = "F2 - SELECIONAR QUANTIDADE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(670, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 425;
            this.label9.Text = "F8 - FINALIZAR VENDA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(902, 678);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 16);
            this.label10.TabIndex = 426;
            this.label10.Text = "F11 - IMPRIMIR ORÇAMENTO";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TotalTextBox.Location = new System.Drawing.Point(542, 533);
            this.TotalTextBox.MaxLength = 200;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(120, 38);
            this.TotalTextBox.TabIndex = 430;
            // 
            // CancelarItemButton
            // 
            this.CancelarItemButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarItemButton.Location = new System.Drawing.Point(1190, 432);
            this.CancelarItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarItemButton.Name = "CancelarItemButton";
            this.CancelarItemButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarItemButton.TabIndex = 434;
            this.CancelarItemButton.Text = "Cancelar Item";
            this.CancelarItemButton.UseVisualStyleBackColor = true;
            this.CancelarItemButton.Click += new System.EventHandler(this.CancelarItemButton_Click);
            // 
            // DescricaoProdutoCadastradoTextBox
            // 
            this.DescricaoProdutoCadastradoTextBox.Enabled = false;
            this.DescricaoProdutoCadastradoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DescricaoProdutoCadastradoTextBox.Location = new System.Drawing.Point(540, 206);
            this.DescricaoProdutoCadastradoTextBox.MaxLength = 200;
            this.DescricaoProdutoCadastradoTextBox.Name = "DescricaoProdutoCadastradoTextBox";
            this.DescricaoProdutoCadastradoTextBox.Size = new System.Drawing.Size(377, 38);
            this.DescricaoProdutoCadastradoTextBox.TabIndex = 435;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(538, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 436;
            this.label11.Text = "DESCRIÇÃO";
            // 
            // AlterarQuantidadeButton
            // 
            this.AlterarQuantidadeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarQuantidadeButton.Location = new System.Drawing.Point(1190, 362);
            this.AlterarQuantidadeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterarQuantidadeButton.Name = "AlterarQuantidadeButton";
            this.AlterarQuantidadeButton.Size = new System.Drawing.Size(122, 60);
            this.AlterarQuantidadeButton.TabIndex = 437;
            this.AlterarQuantidadeButton.Text = "Corrigir Quantidade";
            this.AlterarQuantidadeButton.UseVisualStyleBackColor = true;
            this.AlterarQuantidadeButton.Click += new System.EventHandler(this.AlterarQuantidadeButton_Click);
            // 
            // QuantidadeLabel
            // 
            this.QuantidadeLabel.AutoSize = true;
            this.QuantidadeLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeLabel.Location = new System.Drawing.Point(223, 678);
            this.QuantidadeLabel.Name = "QuantidadeLabel";
            this.QuantidadeLabel.Size = new System.Drawing.Size(138, 16);
            this.QuantidadeLabel.TabIndex = 438;
            this.QuantidadeLabel.Text = "QUANTIDADE ATUAL = ";
            // 
            // QuantidadeLabelTextBox
            // 
            this.QuantidadeLabelTextBox.Enabled = false;
            this.QuantidadeLabelTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.QuantidadeLabelTextBox.Location = new System.Drawing.Point(361, 675);
            this.QuantidadeLabelTextBox.MaxLength = 200;
            this.QuantidadeLabelTextBox.Name = "QuantidadeLabelTextBox";
            this.QuantidadeLabelTextBox.Size = new System.Drawing.Size(47, 22);
            this.QuantidadeLabelTextBox.TabIndex = 439;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 90);
            this.pictureBox1.TabIndex = 233;
            this.pictureBox1.TabStop = false;
            // 
            // CodigoGridColumn
            // 
            this.CodigoGridColumn.DataPropertyName = "Codigo";
            this.CodigoGridColumn.HeaderText = "Código";
            this.CodigoGridColumn.Name = "CodigoGridColumn";
            this.CodigoGridColumn.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // MarcaGridColumn
            // 
            this.MarcaGridColumn.DataPropertyName = "Marca";
            this.MarcaGridColumn.HeaderText = "Marca";
            this.MarcaGridColumn.Name = "MarcaGridColumn";
            this.MarcaGridColumn.ReadOnly = true;
            // 
            // PrecoUnitarioColumn
            // 
            this.PrecoUnitarioColumn.DataPropertyName = "PrecoVenda";
            this.PrecoUnitarioColumn.HeaderText = "Preço Unit";
            this.PrecoUnitarioColumn.Name = "PrecoUnitarioColumn";
            this.PrecoUnitarioColumn.ReadOnly = true;
            // 
            // QuantidadeGridColumn
            // 
            this.QuantidadeGridColumn.DataPropertyName = "Quantidade";
            this.QuantidadeGridColumn.HeaderText = "Quantidade";
            this.QuantidadeGridColumn.Name = "QuantidadeGridColumn";
            this.QuantidadeGridColumn.ReadOnly = true;
            // 
            // PrecoCompraGridColumn
            // 
            this.PrecoCompraGridColumn.DataPropertyName = "PrecoCompra";
            this.PrecoCompraGridColumn.HeaderText = "SubTotal";
            this.PrecoCompraGridColumn.Name = "PrecoCompraGridColumn";
            this.PrecoCompraGridColumn.ReadOnly = true;
            // 
            // MargemLucroGridColumn
            // 
            this.MargemLucroGridColumn.DataPropertyName = "MargemLucro";
            this.MargemLucroGridColumn.HeaderText = "Margem Lucro";
            this.MargemLucroGridColumn.Name = "MargemLucroGridColumn";
            this.MargemLucroGridColumn.ReadOnly = true;
            this.MargemLucroGridColumn.Visible = false;
            // 
            // LocalizacaoGridColumn
            // 
            this.LocalizacaoGridColumn.DataPropertyName = "Localizacao";
            this.LocalizacaoGridColumn.HeaderText = "Localizacao";
            this.LocalizacaoGridColumn.Name = "LocalizacaoGridColumn";
            this.LocalizacaoGridColumn.ReadOnly = true;
            this.LocalizacaoGridColumn.Visible = false;
            // 
            // EstoqueMinimoGridColumn
            // 
            this.EstoqueMinimoGridColumn.DataPropertyName = "EstoqueMinimo";
            this.EstoqueMinimoGridColumn.HeaderText = "Estoque Minimo";
            this.EstoqueMinimoGridColumn.Name = "EstoqueMinimoGridColumn";
            this.EstoqueMinimoGridColumn.ReadOnly = true;
            this.EstoqueMinimoGridColumn.Visible = false;
            // 
            // EstoqueAtualGridColumn
            // 
            this.EstoqueAtualGridColumn.DataPropertyName = "EstoqueAtual";
            this.EstoqueAtualGridColumn.HeaderText = "EstoqueAtual";
            this.EstoqueAtualGridColumn.Name = "EstoqueAtualGridColumn";
            this.EstoqueAtualGridColumn.ReadOnly = true;
            this.EstoqueAtualGridColumn.Visible = false;
            // 
            // DescontoColumn
            // 
            this.DescontoColumn.DataPropertyName = "Desconto";
            this.DescontoColumn.HeaderText = "Desconto";
            this.DescontoColumn.Name = "DescontoColumn";
            this.DescontoColumn.ReadOnly = true;
            this.DescontoColumn.Visible = false;
            // 
            // EntregaColumn
            // 
            this.EntregaColumn.DataPropertyName = "Entrega";
            this.EntregaColumn.HeaderText = "Entrega";
            this.EntregaColumn.Name = "EntregaColumn";
            this.EntregaColumn.ReadOnly = true;
            this.EntregaColumn.Visible = false;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 725);
            this.ControlBox = false;
            this.Controls.Add(this.QuantidadeLabelTextBox);
            this.Controls.Add(this.QuantidadeLabel);
            this.Controls.Add(this.AlterarQuantidadeButton);
            this.Controls.Add(this.DescricaoProdutoCadastradoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CancelarItemButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.MovimentoDiarioButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuantidadeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrecoUnitarioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescricaoProdutoTextBox);
            this.Controls.Add(this.ConsultaProdutoVendadataGridView);
            this.KeyPreview = true;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutoVendadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaProdutoVendadataGridView;
        private System.Windows.Forms.TextBox DescricaoProdutoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuantidadeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecoUnitarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button MovimentoDiarioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button CancelarItemButton;
        private System.Windows.Forms.TextBox DescricaoProdutoCadastradoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AlterarQuantidadeButton;
        private System.Windows.Forms.Label QuantidadeLabel;
        private System.Windows.Forms.TextBox QuantidadeLabelTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCompraGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MargemLucroGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalizacaoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMinimoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtualGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntregaColumn;
    }
}