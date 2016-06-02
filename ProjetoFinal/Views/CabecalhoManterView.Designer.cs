namespace ProjetoFinal.Views
{
    partial class CabecalhoManterView
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
            this.DadosLabel = new System.Windows.Forms.Label();
            this.ConsultarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TipoContratolabel = new System.Windows.Forms.Label();
            this.SetaLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // DadosLabel
            // 
            this.DadosLabel.AutoSize = true;
            this.DadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DadosLabel.Location = new System.Drawing.Point(12, 79);
            this.DadosLabel.Name = "DadosLabel";
            this.DadosLabel.Size = new System.Drawing.Size(92, 16);
            this.DadosLabel.TabIndex = 247;
            this.DadosLabel.Text = "Dados do ...";
            // 
            // ConsultarLinkLabel
            // 
            this.ConsultarLinkLabel.AutoSize = true;
            this.ConsultarLinkLabel.Location = new System.Drawing.Point(12, 25);
            this.ConsultarLinkLabel.Name = "ConsultarLinkLabel";
            this.ConsultarLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.ConsultarLinkLabel.TabIndex = 246;
            this.ConsultarLinkLabel.TabStop = true;
            this.ConsultarLinkLabel.Text = "Consultar";
            // 
            // TipoContratolabel
            // 
            this.TipoContratolabel.AutoSize = true;
            this.TipoContratolabel.Location = new System.Drawing.Point(88, 25);
            this.TipoContratolabel.Name = "TipoContratolabel";
            this.TipoContratolabel.Size = new System.Drawing.Size(52, 13);
            this.TipoContratolabel.TabIndex = 244;
            this.TipoContratolabel.Text = "Cadastrar";
            // 
            // SetaLabel1
            // 
            this.SetaLabel1.AutoSize = true;
            this.SetaLabel1.Location = new System.Drawing.Point(69, 25);
            this.SetaLabel1.Name = "SetaLabel1";
            this.SetaLabel1.Size = new System.Drawing.Size(13, 13);
            this.SetaLabel1.TabIndex = 245;
            this.SetaLabel1.Text = ">";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 243;
            this.label1.Text = "(*) Campo Obrigatório";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(12, 5);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(92, 16);
            this.TituloLabel.TabIndex = 242;
            this.TituloLabel.Text = "Cadastrar ...";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(814, 101);
            this.shapeContainer1.TabIndex = 248;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 813;
            this.lineShape1.Y1 = 44;
            this.lineShape1.Y2 = 44;
            // 
            // CabecalhoManterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 101);
            this.Controls.Add(this.DadosLabel);
            this.Controls.Add(this.ConsultarLinkLabel);
            this.Controls.Add(this.TipoContratolabel);
            this.Controls.Add(this.SetaLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CabecalhoManterView";
            this.Text = "CabecalhoManterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DadosLabel;
        private System.Windows.Forms.LinkLabel ConsultarLinkLabel;
        private System.Windows.Forms.Label TipoContratolabel;
        private System.Windows.Forms.Label SetaLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TituloLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}