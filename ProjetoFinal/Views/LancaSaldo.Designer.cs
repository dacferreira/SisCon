namespace ProjetoFinal.Views
{
    partial class LancaSaldo
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
            this.label7 = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LancamentoTextBox = new System.Windows.Forms.TextBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SaldoAtualTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 413;
            this.label7.Text = "Saldo:";
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Enabled = false;
            this.SaldoTextBox.Location = new System.Drawing.Point(116, 23);
            this.SaldoTextBox.MaxLength = 200;
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(114, 20);
            this.SaldoTextBox.TabIndex = 412;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 415;
            this.label1.Text = "*Lancamento:";
            // 
            // LancamentoTextBox
            // 
            this.LancamentoTextBox.Location = new System.Drawing.Point(116, 51);
            this.LancamentoTextBox.MaxLength = 200;
            this.LancamentoTextBox.Name = "LancamentoTextBox";
            this.LancamentoTextBox.Size = new System.Drawing.Size(114, 20);
            this.LancamentoTextBox.TabIndex = 414;
            this.LancamentoTextBox.TextChanged += new System.EventHandler(this.LancamentoTextBox_TextChanged);
            this.LancamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LancamentoTextBox_KeyDown);
            this.LancamentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LancamentoTextBox_KeyPress);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarButton.Location = new System.Drawing.Point(15, 140);
            this.SalvarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(122, 60);
            this.SalvarButton.TabIndex = 416;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 418;
            this.label2.Text = "Saldo Atual:";
            // 
            // SaldoAtualTextBox
            // 
            this.SaldoAtualTextBox.Enabled = false;
            this.SaldoAtualTextBox.Location = new System.Drawing.Point(116, 79);
            this.SaldoAtualTextBox.MaxLength = 200;
            this.SaldoAtualTextBox.Name = "SaldoAtualTextBox";
            this.SaldoAtualTextBox.Size = new System.Drawing.Size(114, 20);
            this.SaldoAtualTextBox.TabIndex = 417;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(145, 140);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(122, 60);
            this.CancelarButton.TabIndex = 419;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // LancaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaldoAtualTextBox);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LancamentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaldoTextBox);
            this.Name = "LancaSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar Saldo";
            this.Load += new System.EventHandler(this.LancaSaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LancamentoTextBox;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaldoAtualTextBox;
        private System.Windows.Forms.Button CancelarButton;
    }
}