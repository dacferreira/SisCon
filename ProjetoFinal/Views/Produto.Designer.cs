namespace ProjetoFinal.Views
{
    partial class Produto
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
            this.EstoqueMinimoTextBox = new System.Windows.Forms.TextBox();
            this.DescricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.PrecoVendaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MargemLucroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecoCompraProdutoTextBox = new System.Windows.Forms.TextBox();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LocalizacaoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EstoqueAtualTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.ContatoPrincipalLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EstoqueMinimoTextBox
            // 
            this.EstoqueMinimoTextBox.Enabled = false;
            this.EstoqueMinimoTextBox.Location = new System.Drawing.Point(260, 359);
            this.EstoqueMinimoTextBox.MaxLength = 200;
            this.EstoqueMinimoTextBox.Name = "EstoqueMinimoTextBox";
            this.EstoqueMinimoTextBox.Size = new System.Drawing.Size(114, 20);
            this.EstoqueMinimoTextBox.TabIndex = 5888;
            this.EstoqueMinimoTextBox.Visible = false;
            this.EstoqueMinimoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EstoqueMinimoTextBox_KeyDown);
            this.EstoqueMinimoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstoqueMinimoTextBox_KeyPress);
            // 
            // DescricaoProdutoTextBox
            // 
            this.DescricaoProdutoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DescricaoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricaoProdutoTextBox.Location = new System.Drawing.Point(260, 135);
            this.DescricaoProdutoTextBox.MaxLength = 200;
            this.DescricaoProdutoTextBox.Multiline = true;
            this.DescricaoProdutoTextBox.Name = "DescricaoProdutoTextBox";
            this.DescricaoProdutoTextBox.Size = new System.Drawing.Size(234, 32);
            this.DescricaoProdutoTextBox.TabIndex = 1;
            // 
            // PrecoVendaTextBox
            // 
            this.PrecoVendaTextBox.Location = new System.Drawing.Point(260, 270);
            this.PrecoVendaTextBox.MaxLength = 200;
            this.PrecoVendaTextBox.Name = "PrecoVendaTextBox";
            this.PrecoVendaTextBox.Size = new System.Drawing.Size(114, 20);
            this.PrecoVendaTextBox.TabIndex = 5;
            this.PrecoVendaTextBox.TextChanged += new System.EventHandler(this.PrecoVendaTextBox_TextChanged);
            this.PrecoVendaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrecoVendaTextBox_KeyDown);
            this.PrecoVendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoVendaTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 368;
            this.label2.Text = "*Preço Venda do Produto:";
            // 
            // MargemLucroTextBox
            // 
            this.MargemLucroTextBox.Location = new System.Drawing.Point(260, 240);
            this.MargemLucroTextBox.MaxLength = 200;
            this.MargemLucroTextBox.Name = "MargemLucroTextBox";
            this.MargemLucroTextBox.Size = new System.Drawing.Size(114, 20);
            this.MargemLucroTextBox.TabIndex = 4;
            this.MargemLucroTextBox.TextChanged += new System.EventHandler(this.MargemLucroTextBox_TextChanged);
            this.MargemLucroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MargemLucroTextBox_KeyDown);
            this.MargemLucroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MargemLucroTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 367;
            this.label1.Text = "*Margem de Lucro:";
            // 
            // PrecoCompraProdutoTextBox
            // 
            this.PrecoCompraProdutoTextBox.Location = new System.Drawing.Point(260, 210);
            this.PrecoCompraProdutoTextBox.MaxLength = 200;
            this.PrecoCompraProdutoTextBox.Name = "PrecoCompraProdutoTextBox";
            this.PrecoCompraProdutoTextBox.Size = new System.Drawing.Size(114, 20);
            this.PrecoCompraProdutoTextBox.TabIndex = 3;
            this.PrecoCompraProdutoTextBox.TextChanged += new System.EventHandler(this.PrecoCompraProdutoTextBox_TextChanged);
            this.PrecoCompraProdutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrecoCompraProdutoTextBox_KeyDown);
            this.PrecoCompraProdutoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoCompraProdutoTextBox_KeyPress);
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.Location = new System.Drawing.Point(12, 210);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(192, 17);
            this.NomeLabel.TabIndex = 366;
            this.NomeLabel.Text = "*Preço Compra do Produto:";
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFLabel.Location = new System.Drawing.Point(12, 145);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(160, 17);
            this.CPFLabel.TabIndex = 365;
            this.CPFLabel.Text = "*Descrição do Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 400;
            this.label5.Text = "* Campo Obrigatório";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(12, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(254, 32);
            this.TituloLabel.TabIndex = 399;
            this.TituloLabel.Text = "Cadastrar Produto";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 668;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 512);
            this.shapeContainer1.TabIndex = 405;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rectangleShape1.Location = new System.Drawing.Point(10, 65);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(660, 30);
            // 
            // LocalizacaoTextBox
            // 
            this.LocalizacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LocalizacaoTextBox.Location = new System.Drawing.Point(260, 300);
            this.LocalizacaoTextBox.MaxLength = 200;
            this.LocalizacaoTextBox.Name = "LocalizacaoTextBox";
            this.LocalizacaoTextBox.Size = new System.Drawing.Size(114, 20);
            this.LocalizacaoTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 409;
            this.label3.Text = "*Localização:";
            // 
            // EstoqueAtualTextBox
            // 
            this.EstoqueAtualTextBox.Location = new System.Drawing.Point(260, 329);
            this.EstoqueAtualTextBox.MaxLength = 8;
            this.EstoqueAtualTextBox.Name = "EstoqueAtualTextBox";
            this.EstoqueAtualTextBox.Size = new System.Drawing.Size(114, 20);
            this.EstoqueAtualTextBox.TabIndex = 7;
            this.EstoqueAtualTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EstoqueAtualTextBox_KeyDown);
            this.EstoqueAtualTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstoqueAtualTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 411;
            this.label7.Text = "*Saldo Atual:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(550, 440);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 9;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(420, 440);
            this.SalvarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 60);
            this.SalvarButton.TabIndex = 8;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // ContatoPrincipalLabel
            // 
            this.ContatoPrincipalLabel.AutoSize = true;
            this.ContatoPrincipalLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContatoPrincipalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContatoPrincipalLabel.Location = new System.Drawing.Point(12, 69);
            this.ContatoPrincipalLabel.Name = "ContatoPrincipalLabel";
            this.ContatoPrincipalLabel.Size = new System.Drawing.Size(175, 23);
            this.ContatoPrincipalLabel.TabIndex = 414;
            this.ContatoPrincipalLabel.Text = "Dados do Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 415;
            this.label8.Text = "%";
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MarcaTextBox.Location = new System.Drawing.Point(260, 180);
            this.MarcaTextBox.MaxLength = 200;
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(114, 20);
            this.MarcaTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 417;
            this.label9.Text = "  Marca:";
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(684, 512);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ContatoPrincipalLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.EstoqueAtualTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LocalizacaoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.EstoqueMinimoTextBox);
            this.Controls.Add(this.DescricaoProdutoTextBox);
            this.Controls.Add(this.PrecoVendaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MargemLucroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecoCompraProdutoTextBox);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.CPFLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EstoqueMinimoTextBox;
        private System.Windows.Forms.TextBox DescricaoProdutoTextBox;
        private System.Windows.Forms.TextBox PrecoVendaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MargemLucroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecoCompraProdutoTextBox;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label CPFLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TituloLabel;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox LocalizacaoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EstoqueAtualTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalvarButton;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label ContatoPrincipalLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.Label label9;
    }
}