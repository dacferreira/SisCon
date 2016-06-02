namespace ProjetoFinal.Views
{
    partial class TodosProdutosAtivos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.todosProdutosAtivos1 = new ProjetoFinal.TodosProdutosAtivos();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new ProjetoFinal.TodosProdutosAtivosTableAdapters.ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutosAtivos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TodosProdutosAtivos";
            reportDataSource1.Value = this.produtoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoFinal.Views.TodosProdutosAtivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(641, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // todosProdutosAtivos1
            // 
            this.todosProdutosAtivos1.DataSetName = "TodosProdutosAtivos";
            this.todosProdutosAtivos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.todosProdutosAtivos1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // TodosProdutosAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TodosProdutosAtivos";
            this.Text = "TodosProdutosAtivos";
            this.Load += new System.EventHandler(this.TodosProdutosAtivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todosProdutosAtivos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjetoFinal.TodosProdutosAtivos todosProdutosAtivos1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private TodosProdutosAtivosTableAdapters.ProdutoTableAdapter produtoTableAdapter;
    }
}