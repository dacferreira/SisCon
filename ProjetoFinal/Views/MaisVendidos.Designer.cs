namespace ProjetoFinal.Views
{
    partial class MaisVendidos
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
            this.produtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maisVendidos2 = new ProjetoFinal.MaisVendidos();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maisVendidos1 = new ProjetoFinal.MaisVendidos();
            this.itemPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtoTableAdapter = new ProjetoFinal.MaisVendidosTableAdapters.ProdutoTableAdapter();
            this.produtoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.maisVendidos3 = new ProjetoFinal.MaisVendidos();
            this.produtoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource2
            // 
            this.produtoBindingSource2.DataMember = "Produto";
            this.produtoBindingSource2.DataSource = this.maisVendidos2;
            // 
            // maisVendidos2
            // 
            this.maisVendidos2.DataSetName = "MaisVendidos";
            this.maisVendidos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.maisVendidos2;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.maisVendidos1;
            // 
            // maisVendidos1
            // 
            this.maisVendidos1.DataSetName = "MaisVendidos";
            this.maisVendidos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MaisVendidos";
            reportDataSource1.Value = this.produtoBindingSource5;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoFinal.Views.MaisVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(449, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource3
            // 
            this.produtoBindingSource3.DataMember = "Produto";
            this.produtoBindingSource3.DataSource = this.maisVendidos2;
            // 
            // maisVendidos3
            // 
            this.maisVendidos3.DataSetName = "MaisVendidos";
            this.maisVendidos3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource4
            // 
            this.produtoBindingSource4.DataMember = "Produto";
            this.produtoBindingSource4.DataSource = this.maisVendidos3;
            // 
            // produtoBindingSource5
            // 
            this.produtoBindingSource5.DataMember = "Produto";
            this.produtoBindingSource5.DataSource = this.maisVendidos3;
            // 
            // MaisVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 347);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MaisVendidos";
            this.Text = "MaisVendidos";
            this.Load += new System.EventHandler(this.MaisVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisVendidos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjetoFinal.MaisVendidos maisVendidos1;
        private System.Windows.Forms.BindingSource itemPedidoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private MaisVendidosTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private ProjetoFinal.MaisVendidos maisVendidos2;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.BindingSource produtoBindingSource2;
        private System.Windows.Forms.BindingSource produtoBindingSource3;
        private ProjetoFinal.MaisVendidos maisVendidos3;
        private System.Windows.Forms.BindingSource produtoBindingSource4;
        private System.Windows.Forms.BindingSource produtoBindingSource5;
    }
}