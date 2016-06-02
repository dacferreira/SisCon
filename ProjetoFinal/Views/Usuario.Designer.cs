namespace ProjetoFinal.Views
{
    partial class Usuario
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
            System.Windows.Forms.Label acessoLabel;
            System.Windows.Forms.Label senhagerenciaLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label label1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.AcessoComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ContatoPrincipalLabel = new System.Windows.Forms.Label();
            acessoLabel = new System.Windows.Forms.Label();
            senhagerenciaLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // acessoLabel
            // 
            acessoLabel.AutoSize = true;
            acessoLabel.Location = new System.Drawing.Point(536, 81);
            acessoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            acessoLabel.Name = "acessoLabel";
            acessoLabel.Size = new System.Drawing.Size(66, 17);
            acessoLabel.TabIndex = 20;
            acessoLabel.Text = "* Acesso:";
            // 
            // senhagerenciaLabel
            // 
            senhagerenciaLabel.AutoSize = true;
            senhagerenciaLabel.Location = new System.Drawing.Point(279, 81);
            senhagerenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            senhagerenciaLabel.Name = "senhagerenciaLabel";
            senhagerenciaLabel.Size = new System.Drawing.Size(130, 17);
            senhagerenciaLabel.TabIndex = 18;
            senhagerenciaLabel.Text = "* Confirmar Senha:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(16, 81);
            senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(61, 17);
            senhaLabel.TabIndex = 5;
            senhaLabel.Text = "* Senha:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(281, 23);
            loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(57, 17);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "* Login:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 17);
            label1.TabIndex = 230;
            label1.Text = "* Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NomeTextBox);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.AcessoComboBox);
            this.groupBox2.Controls.Add(acessoLabel);
            this.groupBox2.Controls.Add(this.ConfirmarSenhaTextBox);
            this.groupBox2.Controls.Add(senhagerenciaLabel);
            this.groupBox2.Controls.Add(this.SenhaTextBox);
            this.groupBox2.Controls.Add(senhaLabel);
            this.groupBox2.Controls.Add(this.LoginTextBox);
            this.groupBox2.Controls.Add(loginLabel);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(660, 168);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(22, 47);
            this.NomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeTextBox.MaxLength = 100;
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(216, 23);
            this.NomeTextBox.TabIndex = 1;
            // 
            // AcessoComboBox
            // 
            this.AcessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcessoComboBox.FormattingEnabled = true;
            this.AcessoComboBox.Location = new System.Drawing.Point(530, 103);
            this.AcessoComboBox.Name = "AcessoComboBox";
            this.AcessoComboBox.Size = new System.Drawing.Size(123, 25);
            this.AcessoComboBox.TabIndex = 5;
            // 
            // ConfirmarSenhaTextBox
            // 
            this.ConfirmarSenhaTextBox.Location = new System.Drawing.Point(284, 105);
            this.ConfirmarSenhaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmarSenhaTextBox.MaxLength = 20;
            this.ConfirmarSenhaTextBox.Name = "ConfirmarSenhaTextBox";
            this.ConfirmarSenhaTextBox.PasswordChar = '*';
            this.ConfirmarSenhaTextBox.Size = new System.Drawing.Size(216, 23);
            this.ConfirmarSenhaTextBox.TabIndex = 4;
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(21, 105);
            this.SenhaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SenhaTextBox.MaxLength = 20;
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.PasswordChar = '*';
            this.SenhaTextBox.Size = new System.Drawing.Size(216, 23);
            this.SenhaTextBox.TabIndex = 3;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(285, 47);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTextBox.MaxLength = 50;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(216, 23);
            this.LoginTextBox.TabIndex = 2;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(550, 440);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 7;
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
            this.SalvarButton.TabIndex = 6;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 409;
            this.label5.Text = "* Campo Obrigatório";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(12, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(250, 32);
            this.TituloLabel.TabIndex = 408;
            this.TituloLabel.Text = "Cadastrar Usuário";
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
            this.shapeContainer1.TabIndex = 414;
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
            // ContatoPrincipalLabel
            // 
            this.ContatoPrincipalLabel.AutoSize = true;
            this.ContatoPrincipalLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContatoPrincipalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContatoPrincipalLabel.Location = new System.Drawing.Point(12, 69);
            this.ContatoPrincipalLabel.Name = "ContatoPrincipalLabel";
            this.ContatoPrincipalLabel.Size = new System.Drawing.Size(172, 23);
            this.ContatoPrincipalLabel.TabIndex = 415;
            this.ContatoPrincipalLabel.Text = "Dados do Usuário";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(684, 512);
            this.ControlBox = false;
            this.Controls.Add(this.ContatoPrincipalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ConfirmarSenhaTextBox;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.ComboBox AcessoComboBox;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TituloLabel;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label ContatoPrincipalLabel;
    }
}