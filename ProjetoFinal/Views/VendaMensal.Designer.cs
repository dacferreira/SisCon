namespace ProjetoFinal.Views
{
    partial class VendaMensal
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
            this.vendaMensal1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaMensal1 = new ProjetoFinal.VendaMensal();
            this.vendaMensal1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new ProjetoFinal.VendaMensalTableAdapters.VendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VendaMensal";
            reportDataSource1.Value = this.vendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoFinal.Views.VendaMensal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(593, 262);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vendaMensal1BindingSource
            // 
            this.vendaMensal1BindingSource.DataSource = this.vendaMensal1;
            this.vendaMensal1BindingSource.Position = 0;
            // 
            // vendaMensal1
            // 
            this.vendaMensal1.DataSetName = "VendaMensal";
            this.vendaMensal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaMensal1BindingSource1
            // 
            this.vendaMensal1BindingSource1.DataSource = this.vendaMensal1;
            this.vendaMensal1BindingSource1.Position = 0;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.vendaMensal1;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // VendaMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VendaMensal";
            this.Text = "VendaMensal";
            this.Load += new System.EventHandler(this.VendaMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaMensal1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendaMensal1BindingSource;
        private ProjetoFinal.VendaMensal vendaMensal1;
        private System.Windows.Forms.BindingSource vendaMensal1BindingSource1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private VendaMensalTableAdapters.VendaTableAdapter vendaTableAdapter;
    }
}