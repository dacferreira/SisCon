namespace ProjetoFinal.Views
{
    partial class AlterarQuantidade
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NovaQuantidadeTextBox = new System.Windows.Forms.TextBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantidadeAtualTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(148, 125);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "&Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 432;
            this.label2.Text = "Nova Quantidade";
            // 
            // NovaQuantidadeTextBox
            // 
            this.NovaQuantidadeTextBox.Location = new System.Drawing.Point(146, 61);
            this.NovaQuantidadeTextBox.MaxLength = 200;
            this.NovaQuantidadeTextBox.Name = "NovaQuantidadeTextBox";
            this.NovaQuantidadeTextBox.Size = new System.Drawing.Size(114, 20);
            this.NovaQuantidadeTextBox.TabIndex = 1;
            this.NovaQuantidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NovaQuantidadeTextBox_KeyDown);
            this.NovaQuantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NovaQuantidadeTextBox_KeyPress);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(18, 125);
            this.SalvarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 60);
            this.SalvarButton.TabIndex = 2;
            this.SalvarButton.Text = "&Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 429;
            this.label7.Text = "Quantidade Atual";
            // 
            // QuantidadeAtualTextBox
            // 
            this.QuantidadeAtualTextBox.Enabled = false;
            this.QuantidadeAtualTextBox.Location = new System.Drawing.Point(146, 32);
            this.QuantidadeAtualTextBox.MaxLength = 200;
            this.QuantidadeAtualTextBox.Name = "QuantidadeAtualTextBox";
            this.QuantidadeAtualTextBox.Size = new System.Drawing.Size(114, 20);
            this.QuantidadeAtualTextBox.TabIndex = 428;
            // 
            // AlterarQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NovaQuantidadeTextBox);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QuantidadeAtualTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Quantidade";
            this.Load += new System.EventHandler(this.AlterarQuantidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NovaQuantidadeTextBox;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuantidadeAtualTextBox;
    }
}