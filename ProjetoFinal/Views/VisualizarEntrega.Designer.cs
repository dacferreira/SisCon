namespace ProjetoFinal.Views
{
    partial class VisualizarEntrega
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
            this.QuantidadeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutodataGridView)).BeginInit();
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
            this.QuantidadeGridColumn});
            this.ConsultaProdutodataGridView.Location = new System.Drawing.Point(12, 12);
            this.ConsultaProdutodataGridView.Name = "ConsultaProdutodataGridView";
            this.ConsultaProdutodataGridView.ReadOnly = true;
            this.ConsultaProdutodataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsultaProdutodataGridView.Size = new System.Drawing.Size(1054, 466);
            this.ConsultaProdutodataGridView.TabIndex = 176;
            this.ConsultaProdutodataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaProdutodataGridView_KeyDown);
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
            // QuantidadeGridColumn
            // 
            this.QuantidadeGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantidadeGridColumn.DataPropertyName = "Quantidade";
            this.QuantidadeGridColumn.HeaderText = "Quantidade";
            this.QuantidadeGridColumn.Name = "QuantidadeGridColumn";
            this.QuantidadeGridColumn.ReadOnly = true;
            // 
            // VisualizarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 490);
            this.Controls.Add(this.ConsultaProdutodataGridView);
            this.Name = "VisualizarEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Produtos Entrega";
            this.Load += new System.EventHandler(this.VisualizarEntrega_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VisualizarEntrega_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProdutodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaProdutodataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeGridColumn;
    }
}