namespace ProjetoFinal.Views
{
    partial class Desconto
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.ValorRadioButton = new System.Windows.Forms.RadioButton();
            this.PercentualRadioButton = new System.Windows.Forms.RadioButton();
            this.DescontoLabel = new System.Windows.Forms.Label();
            this.ValorDescontoTextBox = new System.Windows.Forms.TextBox();
            this.PercentualLabel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(12, 172);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 39);
            this.btnLogin.TabIndex = 421;
            this.btnLogin.Text = "Aplicar Desconto";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ValorRadioButton
            // 
            this.ValorRadioButton.AutoSize = true;
            this.ValorRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ValorRadioButton.Location = new System.Drawing.Point(59, 23);
            this.ValorRadioButton.Name = "ValorRadioButton";
            this.ValorRadioButton.Size = new System.Drawing.Size(57, 20);
            this.ValorRadioButton.TabIndex = 432;
            this.ValorRadioButton.TabStop = true;
            this.ValorRadioButton.Text = "Valor";
            this.ValorRadioButton.UseVisualStyleBackColor = true;
            this.ValorRadioButton.CheckedChanged += new System.EventHandler(this.ValorRadioButton_CheckedChanged);
            // 
            // PercentualRadioButton
            // 
            this.PercentualRadioButton.AutoSize = true;
            this.PercentualRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.PercentualRadioButton.Location = new System.Drawing.Point(154, 23);
            this.PercentualRadioButton.Name = "PercentualRadioButton";
            this.PercentualRadioButton.Size = new System.Drawing.Size(89, 20);
            this.PercentualRadioButton.TabIndex = 433;
            this.PercentualRadioButton.TabStop = true;
            this.PercentualRadioButton.Text = "Percentual";
            this.PercentualRadioButton.UseVisualStyleBackColor = true;
            this.PercentualRadioButton.CheckedChanged += new System.EventHandler(this.PercentualRadioButton_CheckedChanged);
            // 
            // DescontoLabel
            // 
            this.DescontoLabel.AutoSize = true;
            this.DescontoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DescontoLabel.Location = new System.Drawing.Point(76, 86);
            this.DescontoLabel.Name = "DescontoLabel";
            this.DescontoLabel.Size = new System.Drawing.Size(150, 23);
            this.DescontoLabel.TabIndex = 437;
            this.DescontoLabel.Text = "Valor Desconto";
            // 
            // ValorDescontoTextBox
            // 
            this.ValorDescontoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ValorDescontoTextBox.Location = new System.Drawing.Point(93, 112);
            this.ValorDescontoTextBox.MaxLength = 6;
            this.ValorDescontoTextBox.Name = "ValorDescontoTextBox";
            this.ValorDescontoTextBox.Size = new System.Drawing.Size(120, 38);
            this.ValorDescontoTextBox.TabIndex = 436;
            this.ValorDescontoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValorDescontoTextBox_KeyDown);
            this.ValorDescontoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorDescontoTextBox_KeyPress);
            // 
            // PercentualLabel
            // 
            this.PercentualLabel.AutoSize = true;
            this.PercentualLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PercentualLabel.Location = new System.Drawing.Point(182, 120);
            this.PercentualLabel.Name = "PercentualLabel";
            this.PercentualLabel.Size = new System.Drawing.Size(26, 23);
            this.PercentualLabel.TabIndex = 438;
            this.PercentualLabel.Text = "%";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(201, 172);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 39);
            this.btnSair.TabIndex = 439;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Desconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(317, 269);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.PercentualLabel);
            this.Controls.Add(this.DescontoLabel);
            this.Controls.Add(this.ValorDescontoTextBox);
            this.Controls.Add(this.PercentualRadioButton);
            this.Controls.Add(this.ValorRadioButton);
            this.Controls.Add(this.btnLogin);
            this.Name = "Desconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto";
            this.Load += new System.EventHandler(this.Desconto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton ValorRadioButton;
        private System.Windows.Forms.RadioButton PercentualRadioButton;
        private System.Windows.Forms.Label DescontoLabel;
        private System.Windows.Forms.TextBox ValorDescontoTextBox;
        private System.Windows.Forms.Label PercentualLabel;
        private System.Windows.Forms.Button btnSair;
    }
}