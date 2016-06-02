namespace ProjetoFinal.Views
{
    partial class Devolucao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DevolverTodosButton = new System.Windows.Forms.Button();
            this.DevolverButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoVendaTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.ConsultaProdutoVendadataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVendaGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoItemPedidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoDevolucaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoItemPedidoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinalizarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.RemoverItemButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutoVendadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDevolucaoDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.DevolverTodosButton);
            this.panel1.Controls.Add(this.DevolverButton);
            this.panel1.Location = new System.Drawing.Point(13, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 70);
            this.panel1.TabIndex = 183;
            // 
            // DevolverTodosButton
            // 
            this.DevolverTodosButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevolverTodosButton.Location = new System.Drawing.Point(130, 8);
            this.DevolverTodosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DevolverTodosButton.Name = "DevolverTodosButton";
            this.DevolverTodosButton.Size = new System.Drawing.Size(122, 60);
            this.DevolverTodosButton.TabIndex = 4;
            this.DevolverTodosButton.Text = "Devolver Todos";
            this.DevolverTodosButton.UseVisualStyleBackColor = true;
            this.DevolverTodosButton.Click += new System.EventHandler(this.DevolverTodosButton_Click);
            // 
            // DevolverButton
            // 
            this.DevolverButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevolverButton.Location = new System.Drawing.Point(1, 8);
            this.DevolverButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DevolverButton.Name = "DevolverButton";
            this.DevolverButton.Size = new System.Drawing.Size(122, 60);
            this.DevolverButton.TabIndex = 3;
            this.DevolverButton.Text = "Devolver Item";
            this.DevolverButton.UseVisualStyleBackColor = true;
            this.DevolverButton.Click += new System.EventHandler(this.DevolverButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodigoVendaTextBox);
            this.groupBox1.Controls.Add(this.PesquisarButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 52);
            this.groupBox1.TabIndex = 182;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 231;
            this.label2.Text = "Codigo Venda:";
            // 
            // CodigoVendaTextBox
            // 
            this.CodigoVendaTextBox.Location = new System.Drawing.Point(121, 24);
            this.CodigoVendaTextBox.MaxLength = 200;
            this.CodigoVendaTextBox.Name = "CodigoVendaTextBox";
            this.CodigoVendaTextBox.Size = new System.Drawing.Size(200, 20);
            this.CodigoVendaTextBox.TabIndex = 1;
            this.CodigoVendaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodigoVendaTextBox_KeyDown);
            this.CodigoVendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoVendaTextBox_KeyPress);
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.AutoSize = true;
            this.PesquisarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarButton.Location = new System.Drawing.Point(340, 20);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(90, 27);
            this.PesquisarButton.TabIndex = 2;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // ConsultaProdutoVendadataGridView
            // 
            this.ConsultaProdutoVendadataGridView.AllowUserToAddRows = false;
            this.ConsultaProdutoVendadataGridView.AllowUserToDeleteRows = false;
            this.ConsultaProdutoVendadataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultaProdutoVendadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaProdutoVendadataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ConsultaProdutoVendadataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaProdutoVendadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.Descricao,
            this.MarcaGridColumn,
            this.PrecoVendaGridColumn,
            this.QuantidadeGridColumn,
            this.ValorGridColumn,
            this.CodigoItemPedidoColumn});
            this.ConsultaProdutoVendadataGridView.Location = new System.Drawing.Point(13, 86);
            this.ConsultaProdutoVendadataGridView.Name = "ConsultaProdutoVendadataGridView";
            this.ConsultaProdutoVendadataGridView.ReadOnly = true;
            this.ConsultaProdutoVendadataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsultaProdutoVendadataGridView.Size = new System.Drawing.Size(488, 340);
            this.ConsultaProdutoVendadataGridView.TabIndex = 9;
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
            // PrecoVendaGridColumn
            // 
            this.PrecoVendaGridColumn.DataPropertyName = "PrecoUnitario";
            this.PrecoVendaGridColumn.FillWeight = 1.999249F;
            this.PrecoVendaGridColumn.HeaderText = "Preço Unitário";
            this.PrecoVendaGridColumn.Name = "PrecoVendaGridColumn";
            this.PrecoVendaGridColumn.ReadOnly = true;
            // 
            // QuantidadeGridColumn
            // 
            this.QuantidadeGridColumn.DataPropertyName = "Quantidade";
            this.QuantidadeGridColumn.FillWeight = 0.219666F;
            this.QuantidadeGridColumn.HeaderText = "Quantidade";
            this.QuantidadeGridColumn.Name = "QuantidadeGridColumn";
            this.QuantidadeGridColumn.ReadOnly = true;
            // 
            // ValorGridColumn
            // 
            this.ValorGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorGridColumn.DataPropertyName = "Valor";
            this.ValorGridColumn.HeaderText = "Valor";
            this.ValorGridColumn.Name = "ValorGridColumn";
            this.ValorGridColumn.ReadOnly = true;
            // 
            // CodigoItemPedidoColumn
            // 
            this.CodigoItemPedidoColumn.DataPropertyName = "CodigoItemPedido";
            this.CodigoItemPedidoColumn.HeaderText = "CodigoItemPedido";
            this.CodigoItemPedidoColumn.Name = "CodigoItemPedidoColumn";
            this.CodigoItemPedidoColumn.ReadOnly = true;
            this.CodigoItemPedidoColumn.Visible = false;
            // 
            // ProdutoDevolucaoDataGridView
            // 
            this.ProdutoDevolucaoDataGridView.AllowUserToAddRows = false;
            this.ProdutoDevolucaoDataGridView.AllowUserToDeleteRows = false;
            this.ProdutoDevolucaoDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProdutoDevolucaoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdutoDevolucaoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProdutoDevolucaoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProdutoDevolucaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.CodigoItemPedidoGridColumn});
            this.ProdutoDevolucaoDataGridView.Location = new System.Drawing.Point(567, 86);
            this.ProdutoDevolucaoDataGridView.Name = "ProdutoDevolucaoDataGridView";
            this.ProdutoDevolucaoDataGridView.ReadOnly = true;
            this.ProdutoDevolucaoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProdutoDevolucaoDataGridView.Size = new System.Drawing.Size(488, 340);
            this.ProdutoDevolucaoDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.FillWeight = 0.03729939F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.FillWeight = 0.2864331F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.FillWeight = 0.4442831F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoUnitario";
            this.dataGridViewTextBoxColumn4.FillWeight = 1.999249F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn5.FillWeight = 0.219666F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // CodigoItemPedidoGridColumn
            // 
            this.CodigoItemPedidoGridColumn.DataPropertyName = "CodigoItemPedido";
            this.CodigoItemPedidoGridColumn.HeaderText = "CodigoItemPedido";
            this.CodigoItemPedidoGridColumn.Name = "CodigoItemPedidoGridColumn";
            this.CodigoItemPedidoGridColumn.ReadOnly = true;
            this.CodigoItemPedidoGridColumn.Visible = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 530;
            this.lineShape1.X2 = 530;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 428;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1077, 512);
            this.shapeContainer1.TabIndex = 185;
            this.shapeContainer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.FinalizarButton);
            this.panel2.Controls.Add(this.CancelarButton);
            this.panel2.Controls.Add(this.RemoverItemButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(530, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 70);
            this.panel2.TabIndex = 184;
            // 
            // FinalizarButton
            // 
            this.FinalizarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalizarButton.Location = new System.Drawing.Point(399, 5);
            this.FinalizarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinalizarButton.Name = "FinalizarButton";
            this.FinalizarButton.Size = new System.Drawing.Size(122, 60);
            this.FinalizarButton.TabIndex = 7;
            this.FinalizarButton.Text = "Finalizar";
            this.FinalizarButton.UseVisualStyleBackColor = true;
            this.FinalizarButton.Click += new System.EventHandler(this.FinalizarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(399, 5);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // RemoverItemButton
            // 
            this.RemoverItemButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverItemButton.Location = new System.Drawing.Point(139, 5);
            this.RemoverItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoverItemButton.Name = "RemoverItemButton";
            this.RemoverItemButton.Size = new System.Drawing.Size(122, 60);
            this.RemoverItemButton.TabIndex = 5;
            this.RemoverItemButton.Text = "Remover Item";
            this.RemoverItemButton.UseVisualStyleBackColor = true;
            this.RemoverItemButton.Click += new System.EventHandler(this.RemoverItemButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Alterar Quantidade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 232;
            this.label1.Text = "Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 233;
            this.label3.Text = "Devolução";
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(1077, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProdutoDevolucaoDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsultaProdutoVendadataGridView);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Devolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucao";
            this.Load += new System.EventHandler(this.Devolucao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Devolucao_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutoVendadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDevolucaoDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DevolverTodosButton;
        private System.Windows.Forms.Button DevolverButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoVendaTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.DataGridView ConsultaProdutoVendadataGridView;
        private System.Windows.Forms.DataGridView ProdutoDevolucaoDataGridView;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FinalizarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RemoverItemButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVendaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItemPedidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoItemPedidoGridColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}