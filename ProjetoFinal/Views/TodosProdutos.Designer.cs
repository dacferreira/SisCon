namespace ProjetoFinal.Views
{
    partial class TodosProdutos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.todosProdutos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todosProdutos1 = new ProjetoFinal.TodosProdutos();
            this.produtoTableAdapter = new ProjetoFinal.TodosProdutosTableAdapters.ProdutoTableAdapter();
            this.VendaMensal = new ProjetoFinal.Views.VendaMensal();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutos1)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.todosProdutos1BindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TodosProdutos";
            reportDataSource1.Value = this.produtoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoFinal.Views.TodosProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(563, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // todosProdutos1BindingSource
            // 
            this.todosProdutos1BindingSource.DataSource = this.todosProdutos1;
            this.todosProdutos1BindingSource.Position = 0;
            // 
            // todosProdutos1
            // 
            this.todosProdutos1.DataSetName = "TodosProdutos";
            this.todosProdutos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // VendaMensal
            // 
            this.VendaMensal.ClientSize = new System.Drawing.Size(593, 262);
            this.VendaMensal.Location = new System.Drawing.Point(130, 130);
            this.VendaMensal.Name = "VendaMensal";
            this.VendaMensal.Text = "VendaMensal";
            this.VendaMensal.Visible = false;
            // 
            // TodosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 409);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TodosProdutos";
            this.Text = "TodosProdutos";
            this.Load += new System.EventHandler(this.TodosProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjetoFinal.TodosProdutos todosProdutos1;
        private System.Windows.Forms.BindingSource todosProdutos1BindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private TodosProdutosTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private VendaMensal VendaMensal;
    }
}