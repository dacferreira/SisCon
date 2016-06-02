namespace ProjetoFinal.Views
{
    partial class Cliente
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ContatoPrincipalLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.CelularTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CEPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RGTextBox = new System.Windows.Forms.TextBox();
            this.RGLabel = new System.Windows.Forms.Label();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefoneComercialLabel = new System.Windows.Forms.Label();
            this.UFLabel = new System.Windows.Forms.Label();
            this.CidadeLabel = new System.Windows.Forms.Label();
            this.CEPLabel = new System.Windows.Forms.Label();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.EndereçoLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PessoaFisicaRadioButton = new System.Windows.Forms.RadioButton();
            this.PessoaJuridicaRadioButton = new System.Windows.Forms.RadioButton();
            this.PessoaFisicaGroupBox = new System.Windows.Forms.GroupBox();
            this.PessoaJuridicaGroupBox = new System.Windows.Forms.GroupBox();
            this.CNPJTextBox = new System.Windows.Forms.MaskedTextBox();
            this.InsEstadualTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RazaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.ApelidoTextBox = new System.Windows.Forms.TextBox();
            this.CPFTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ObservaçãoTextBox = new System.Windows.Forms.TextBox();
            this.UFTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.BairroTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PessoaFisicaGroupBox.SuspendLayout();
            this.PessoaJuridicaGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 512);
            this.shapeContainer1.TabIndex = 367;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 668;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // ContatoPrincipalLabel
            // 
            this.ContatoPrincipalLabel.AutoSize = true;
            this.ContatoPrincipalLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContatoPrincipalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContatoPrincipalLabel.Location = new System.Drawing.Point(12, 69);
            this.ContatoPrincipalLabel.Name = "ContatoPrincipalLabel";
            this.ContatoPrincipalLabel.Size = new System.Drawing.Size(170, 23);
            this.ContatoPrincipalLabel.TabIndex = 391;
            this.ContatoPrincipalLabel.Text = "Dados do Cliente";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeTextBox.Location = new System.Drawing.Point(120, 55);
            this.NomeTextBox.MaxLength = 100;
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(387, 23);
            this.NomeTextBox.TabIndex = 3;
            this.NomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomeTextBox_KeyPress);
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(460, 355);
            this.CelularTextBox.Mask = "(99) 00000-0000";
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(86, 20);
            this.CelularTextBox.TabIndex = 11;
            // 
            // CEPTextBox
            // 
            this.CEPTextBox.Location = new System.Drawing.Point(460, 265);
            this.CEPTextBox.Mask = "00000-999";
            this.CEPTextBox.Name = "CEPTextBox";
            this.CEPTextBox.Size = new System.Drawing.Size(64, 20);
            this.CEPTextBox.TabIndex = 5;
            // 
            // RGTextBox
            // 
            this.RGTextBox.Location = new System.Drawing.Point(300, 25);
            this.RGTextBox.MaxLength = 12;
            this.RGTextBox.Name = "RGTextBox";
            this.RGTextBox.Size = new System.Drawing.Size(157, 23);
            this.RGTextBox.TabIndex = 2;
            this.RGTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RGTextBox_KeyDown);
            this.RGTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGTextBox_KeyPress);
            // 
            // RGLabel
            // 
            this.RGLabel.AutoSize = true;
            this.RGLabel.Location = new System.Drawing.Point(250, 30);
            this.RGLabel.Name = "RGLabel";
            this.RGLabel.Size = new System.Drawing.Size(31, 17);
            this.RGLabel.TabIndex = 389;
            this.RGLabel.Text = "RG:";
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Location = new System.Drawing.Point(10, 30);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(43, 17);
            this.CPFLabel.TabIndex = 388;
            this.CPFLabel.Text = "*CPF:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 360);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(92, 17);
            this.EmailLabel.TabIndex = 387;
            this.EmailLabel.Text = "Observação:";
            // 
            // TelefoneComercialLabel
            // 
            this.TelefoneComercialLabel.AutoSize = true;
            this.TelefoneComercialLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneComercialLabel.Location = new System.Drawing.Point(380, 360);
            this.TelefoneComercialLabel.Name = "TelefoneComercialLabel";
            this.TelefoneComercialLabel.Size = new System.Drawing.Size(58, 17);
            this.TelefoneComercialLabel.TabIndex = 385;
            this.TelefoneComercialLabel.Text = "Celular:";
            // 
            // UFLabel
            // 
            this.UFLabel.AutoSize = true;
            this.UFLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFLabel.Location = new System.Drawing.Point(380, 300);
            this.UFLabel.Name = "UFLabel";
            this.UFLabel.Size = new System.Drawing.Size(32, 17);
            this.UFLabel.TabIndex = 383;
            this.UFLabel.Text = "*UF:";
            // 
            // CidadeLabel
            // 
            this.CidadeLabel.AutoSize = true;
            this.CidadeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CidadeLabel.Location = new System.Drawing.Point(12, 300);
            this.CidadeLabel.Name = "CidadeLabel";
            this.CidadeLabel.Size = new System.Drawing.Size(67, 17);
            this.CidadeLabel.TabIndex = 382;
            this.CidadeLabel.Text = "*Cidade:";
            // 
            // CEPLabel
            // 
            this.CEPLabel.AutoSize = true;
            this.CEPLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPLabel.Location = new System.Drawing.Point(380, 270);
            this.CEPLabel.Name = "CEPLabel";
            this.CEPLabel.Size = new System.Drawing.Size(44, 17);
            this.CEPLabel.TabIndex = 381;
            this.CEPLabel.Text = "*CEP:";
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EnderecoTextBox.Location = new System.Drawing.Point(120, 265);
            this.EnderecoTextBox.MaxLength = 100;
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(224, 20);
            this.EnderecoTextBox.TabIndex = 4;
            // 
            // EndereçoLabel
            // 
            this.EndereçoLabel.AutoSize = true;
            this.EndereçoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndereçoLabel.Location = new System.Drawing.Point(12, 270);
            this.EndereçoLabel.Name = "EndereçoLabel";
            this.EndereçoLabel.Size = new System.Drawing.Size(79, 17);
            this.EndereçoLabel.TabIndex = 380;
            this.EndereçoLabel.Text = "*Endereço:";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(10, 60);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(58, 17);
            this.NomeLabel.TabIndex = 379;
            this.NomeLabel.Text = "*Nome:";
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(420, 440);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 60);
            this.SalvarButton.TabIndex = 12;
            this.SalvarButton.Text = "&Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 394;
            this.label2.Text = "* Campo Obrigatório";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(12, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(245, 32);
            this.TituloLabel.TabIndex = 393;
            this.TituloLabel.Text = "Cadastrar Cliente";
            // 
            // PessoaFisicaRadioButton
            // 
            this.PessoaFisicaRadioButton.AutoSize = true;
            this.PessoaFisicaRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PessoaFisicaRadioButton.Location = new System.Drawing.Point(27, 116);
            this.PessoaFisicaRadioButton.Name = "PessoaFisicaRadioButton";
            this.PessoaFisicaRadioButton.Size = new System.Drawing.Size(108, 21);
            this.PessoaFisicaRadioButton.TabIndex = 15;
            this.PessoaFisicaRadioButton.TabStop = true;
            this.PessoaFisicaRadioButton.Text = "Pessoa Fisica";
            this.PessoaFisicaRadioButton.UseVisualStyleBackColor = true;
            this.PessoaFisicaRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // PessoaJuridicaRadioButton
            // 
            this.PessoaJuridicaRadioButton.AutoSize = true;
            this.PessoaJuridicaRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PessoaJuridicaRadioButton.Location = new System.Drawing.Point(143, 116);
            this.PessoaJuridicaRadioButton.Name = "PessoaJuridicaRadioButton";
            this.PessoaJuridicaRadioButton.Size = new System.Drawing.Size(124, 21);
            this.PessoaJuridicaRadioButton.TabIndex = 15;
            this.PessoaJuridicaRadioButton.TabStop = true;
            this.PessoaJuridicaRadioButton.Text = "Pessoa Juridica";
            this.PessoaJuridicaRadioButton.UseVisualStyleBackColor = true;
            this.PessoaJuridicaRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // PessoaFisicaGroupBox
            // 
            this.PessoaFisicaGroupBox.Controls.Add(this.PessoaJuridicaGroupBox);
            this.PessoaFisicaGroupBox.Controls.Add(this.ApelidoTextBox);
            this.PessoaFisicaGroupBox.Controls.Add(this.CPFTextBox);
            this.PessoaFisicaGroupBox.Controls.Add(this.PesquisarButton);
            this.PessoaFisicaGroupBox.Controls.Add(this.label1);
            this.PessoaFisicaGroupBox.Controls.Add(this.CPFLabel);
            this.PessoaFisicaGroupBox.Controls.Add(this.RGLabel);
            this.PessoaFisicaGroupBox.Controls.Add(this.RGTextBox);
            this.PessoaFisicaGroupBox.Controls.Add(this.NomeLabel);
            this.PessoaFisicaGroupBox.Controls.Add(this.NomeTextBox);
            this.PessoaFisicaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PessoaFisicaGroupBox.Location = new System.Drawing.Point(12, 136);
            this.PessoaFisicaGroupBox.Name = "PessoaFisicaGroupBox";
            this.PessoaFisicaGroupBox.Size = new System.Drawing.Size(600, 120);
            this.PessoaFisicaGroupBox.TabIndex = 404;
            this.PessoaFisicaGroupBox.TabStop = false;
            this.PessoaFisicaGroupBox.Text = "Pessoa Fisica";
            // 
            // PessoaJuridicaGroupBox
            // 
            this.PessoaJuridicaGroupBox.Controls.Add(this.CNPJTextBox);
            this.PessoaJuridicaGroupBox.Controls.Add(this.InsEstadualTextBox);
            this.PessoaJuridicaGroupBox.Controls.Add(this.button1);
            this.PessoaJuridicaGroupBox.Controls.Add(this.label4);
            this.PessoaJuridicaGroupBox.Controls.Add(this.label5);
            this.PessoaJuridicaGroupBox.Controls.Add(this.label7);
            this.PessoaJuridicaGroupBox.Controls.Add(this.RazaoSocialTextBox);
            this.PessoaJuridicaGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PessoaJuridicaGroupBox.Location = new System.Drawing.Point(0, 1);
            this.PessoaJuridicaGroupBox.Name = "PessoaJuridicaGroupBox";
            this.PessoaJuridicaGroupBox.Size = new System.Drawing.Size(600, 120);
            this.PessoaJuridicaGroupBox.TabIndex = 405;
            this.PessoaJuridicaGroupBox.TabStop = false;
            this.PessoaJuridicaGroupBox.Text = "Pessoa Juridica";
            // 
            // CNPJTextBox
            // 
            this.CNPJTextBox.Location = new System.Drawing.Point(120, 25);
            this.CNPJTextBox.Mask = "00,000,000/0000-00";
            this.CNPJTextBox.Name = "CNPJTextBox";
            this.CNPJTextBox.Size = new System.Drawing.Size(124, 23);
            this.CNPJTextBox.TabIndex = 1;
            // 
            // InsEstadualTextBox
            // 
            this.InsEstadualTextBox.Location = new System.Drawing.Point(300, 25);
            this.InsEstadualTextBox.MaxLength = 20;
            this.InsEstadualTextBox.Name = "InsEstadualTextBox";
            this.InsEstadualTextBox.Size = new System.Drawing.Size(144, 23);
            this.InsEstadualTextBox.TabIndex = 2;
            this.InsEstadualTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsEstadualTextBox_KeyDown);
            this.InsEstadualTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsEstadualTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(962, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 406;
            this.label4.Text = "IE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 388;
            this.label5.Text = "*CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 379;
            this.label7.Text = "*Razão Social:";
            // 
            // RazaoSocialTextBox
            // 
            this.RazaoSocialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RazaoSocialTextBox.Location = new System.Drawing.Point(120, 55);
            this.RazaoSocialTextBox.MaxLength = 100;
            this.RazaoSocialTextBox.Name = "RazaoSocialTextBox";
            this.RazaoSocialTextBox.Size = new System.Drawing.Size(396, 23);
            this.RazaoSocialTextBox.TabIndex = 3;
            // 
            // ApelidoTextBox
            // 
            this.ApelidoTextBox.Location = new System.Drawing.Point(90, 85);
            this.ApelidoTextBox.MaxLength = 50;
            this.ApelidoTextBox.Name = "ApelidoTextBox";
            this.ApelidoTextBox.Size = new System.Drawing.Size(180, 23);
            this.ApelidoTextBox.TabIndex = 405;
            this.ApelidoTextBox.Visible = false;
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.Location = new System.Drawing.Point(120, 25);
            this.CPFTextBox.Mask = "000,000,000-00";
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(93, 23);
            this.CPFTextBox.TabIndex = 1;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.AutoSize = true;
            this.PesquisarButton.Location = new System.Drawing.Point(962, 22);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(77, 27);
            this.PesquisarButton.TabIndex = 3;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 406;
            this.label1.Text = "* Apelido:";
            this.label1.Visible = false;
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CidadeTextBox.Location = new System.Drawing.Point(120, 295);
            this.CidadeTextBox.MaxLength = 100;
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(151, 20);
            this.CidadeTextBox.TabIndex = 6;
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(460, 326);
            this.TelefoneTextBox.Mask = "(99) 0000-0000";
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(86, 20);
            this.TelefoneTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 407;
            this.label6.Text = "*Telefone:";
            // 
            // ObservaçãoTextBox
            // 
            this.ObservaçãoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ObservaçãoTextBox.Location = new System.Drawing.Point(120, 355);
            this.ObservaçãoTextBox.MaxLength = 200;
            this.ObservaçãoTextBox.Multiline = true;
            this.ObservaçãoTextBox.Name = "ObservaçãoTextBox";
            this.ObservaçãoTextBox.Size = new System.Drawing.Size(224, 50);
            this.ObservaçãoTextBox.TabIndex = 10;
            // 
            // UFTextBox
            // 
            this.UFTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UFTextBox.Location = new System.Drawing.Point(460, 295);
            this.UFTextBox.MaxLength = 2;
            this.UFTextBox.Name = "UFTextBox";
            this.UFTextBox.Size = new System.Drawing.Size(64, 20);
            this.UFTextBox.TabIndex = 7;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(550, 440);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // BairroTextBox
            // 
            this.BairroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BairroTextBox.Location = new System.Drawing.Point(120, 326);
            this.BairroTextBox.MaxLength = 50;
            this.BairroTextBox.Name = "BairroTextBox";
            this.BairroTextBox.Size = new System.Drawing.Size(151, 20);
            this.BairroTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 409;
            this.label3.Text = "*Bairro:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(684, 512);
            this.ControlBox = false;
            this.Controls.Add(this.BairroTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.PessoaFisicaGroupBox);
            this.Controls.Add(this.UFTextBox);
            this.Controls.Add(this.ObservaçãoTextBox);
            this.Controls.Add(this.TelefoneTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CidadeTextBox);
            this.Controls.Add(this.PessoaJuridicaRadioButton);
            this.Controls.Add(this.PessoaFisicaRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.ContatoPrincipalLabel);
            this.Controls.Add(this.CelularTextBox);
            this.Controls.Add(this.CEPTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelefoneComercialLabel);
            this.Controls.Add(this.UFLabel);
            this.Controls.Add(this.CidadeLabel);
            this.Controls.Add(this.CEPLabel);
            this.Controls.Add(this.EnderecoTextBox);
            this.Controls.Add(this.EndereçoLabel);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.PessoaFisicaGroupBox.ResumeLayout(false);
            this.PessoaFisicaGroupBox.PerformLayout();
            this.PessoaJuridicaGroupBox.ResumeLayout(false);
            this.PessoaJuridicaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label ContatoPrincipalLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.MaskedTextBox CelularTextBox;
        private System.Windows.Forms.MaskedTextBox CEPTextBox;
        private System.Windows.Forms.TextBox RGTextBox;
        private System.Windows.Forms.Label RGLabel;
        private System.Windows.Forms.Label CPFLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelefoneComercialLabel;
        private System.Windows.Forms.Label UFLabel;
        private System.Windows.Forms.Label CidadeLabel;
        private System.Windows.Forms.Label CEPLabel;
        private System.Windows.Forms.TextBox EnderecoTextBox;
        private System.Windows.Forms.Label EndereçoLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TituloLabel;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RadioButton PessoaFisicaRadioButton;
        private System.Windows.Forms.RadioButton PessoaJuridicaRadioButton;
        private System.Windows.Forms.GroupBox PessoaFisicaGroupBox;
        private System.Windows.Forms.GroupBox PessoaJuridicaGroupBox;
        private System.Windows.Forms.TextBox InsEstadualTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RazaoSocialTextBox;
        private System.Windows.Forms.TextBox ApelidoTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.MaskedTextBox TelefoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ObservaçãoTextBox;
        private System.Windows.Forms.TextBox UFTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.MaskedTextBox CPFTextBox;
        private System.Windows.Forms.MaskedTextBox CNPJTextBox;
        private System.Windows.Forms.TextBox BairroTextBox;
        private System.Windows.Forms.Label label3;
    }
}