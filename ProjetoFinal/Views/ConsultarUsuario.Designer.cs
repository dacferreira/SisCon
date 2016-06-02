namespace ProjetoFinal.Views
{
    partial class ConsultarUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.SituacaoLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.CodigoGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConsultaUsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissaoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AtivarButton = new System.Windows.Forms.Button();
            this.InativarButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaUsuariodataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.SituacaoComboBox);
            this.groupBox1.Controls.Add(this.SituacaoLabel);
            this.groupBox1.Controls.Add(this.LoginTextBox);
            this.groupBox1.Controls.Add(this.PesquisarButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 60);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(960, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 233;
            this.button1.Text = "&Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 231;
            this.label2.Text = "Consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 230;
            this.label1.Text = "Filtro:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(430, 22);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(160, 25);
            this.FiltroComboBox.TabIndex = 229;
            // 
            // SituacaoComboBox
            // 
            this.SituacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SituacaoComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituacaoComboBox.FormattingEnabled = true;
            this.SituacaoComboBox.Location = new System.Drawing.Point(690, 22);
            this.SituacaoComboBox.Name = "SituacaoComboBox";
            this.SituacaoComboBox.Size = new System.Drawing.Size(130, 25);
            this.SituacaoComboBox.TabIndex = 227;
            // 
            // SituacaoLabel
            // 
            this.SituacaoLabel.AutoSize = true;
            this.SituacaoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituacaoLabel.Location = new System.Drawing.Point(610, 25);
            this.SituacaoLabel.Name = "SituacaoLabel";
            this.SituacaoLabel.Size = new System.Drawing.Size(69, 17);
            this.SituacaoLabel.TabIndex = 228;
            this.SituacaoLabel.Text = "Situação:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LoginTextBox.Location = new System.Drawing.Point(80, 22);
            this.LoginTextBox.MaxLength = 200;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(200, 20);
            this.LoginTextBox.TabIndex = 222;
            this.LoginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaTextBox_KeyDown);
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.AutoSize = true;
            this.PesquisarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarButton.Location = new System.Drawing.Point(860, 20);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(90, 27);
            this.PesquisarButton.TabIndex = 3;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // CodigoGridViewTextBoxColumn1
            // 
            this.CodigoGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.CodigoGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.CodigoGridViewTextBoxColumn1.Name = "CodigoGridViewTextBoxColumn1";
            this.CodigoGridViewTextBoxColumn1.ReadOnly = true;
            this.CodigoGridViewTextBoxColumn1.Visible = false;
            // 
            // NomeGridViewLinkColumn1
            // 
            this.NomeGridViewLinkColumn1.DataPropertyName = "Nome";
            this.NomeGridViewLinkColumn1.HeaderText = "Nome";
            this.NomeGridViewLinkColumn1.Name = "NomeGridViewLinkColumn1";
            this.NomeGridViewLinkColumn1.ReadOnly = true;
            this.NomeGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NomeGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn1.HeaderText = "Ação";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "Alterar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn2.Text = "Excluir";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "Nome";
            this.dataGridViewLinkColumn1.HeaderText = "Nome";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn3.HeaderText = "Ação";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn3.Text = "Alterar";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.ReadOnly = true;
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn4.Text = "Excluir";
            this.dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.DataPropertyName = "Nome";
            this.dataGridViewLinkColumn2.HeaderText = "Nome";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn5.HeaderText = "Ação";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.ReadOnly = true;
            this.dataGridViewButtonColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn5.Text = "Alterar";
            this.dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.DataPropertyName = "Codigo";
            this.dataGridViewButtonColumn6.HeaderText = "";
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            this.dataGridViewButtonColumn6.ReadOnly = true;
            this.dataGridViewButtonColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn6.Text = "Excluir";
            this.dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
            // 
            // ConsultaUsuariodataGridView
            // 
            this.ConsultaUsuariodataGridView.AllowUserToAddRows = false;
            this.ConsultaUsuariodataGridView.AllowUserToDeleteRows = false;
            this.ConsultaUsuariodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaUsuariodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaUsuariodataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaUsuariodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGridColumn,
            this.NomeGridColumn,
            this.LoginGridColumn,
            this.PermissaoGridColumn,
            this.SituacaoGridColumn});
            this.ConsultaUsuariodataGridView.Location = new System.Drawing.Point(12, 90);
            this.ConsultaUsuariodataGridView.Name = "ConsultaUsuariodataGridView";
            this.ConsultaUsuariodataGridView.ReadOnly = true;
            this.ConsultaUsuariodataGridView.Size = new System.Drawing.Size(1054, 340);
            this.ConsultaUsuariodataGridView.TabIndex = 166;
            this.ConsultaUsuariodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PesquisaUsuarioGridView_CellContentClick);
            // 
            // CodigoGridColumn
            // 
            this.CodigoGridColumn.DataPropertyName = "Codigo";
            this.CodigoGridColumn.HeaderText = "Código";
            this.CodigoGridColumn.Name = "CodigoGridColumn";
            this.CodigoGridColumn.ReadOnly = true;
            // 
            // NomeGridColumn
            // 
            this.NomeGridColumn.DataPropertyName = "Nome";
            this.NomeGridColumn.HeaderText = "Nome";
            this.NomeGridColumn.Name = "NomeGridColumn";
            this.NomeGridColumn.ReadOnly = true;
            // 
            // LoginGridColumn
            // 
            this.LoginGridColumn.DataPropertyName = "Login";
            this.LoginGridColumn.HeaderText = "Login";
            this.LoginGridColumn.Name = "LoginGridColumn";
            this.LoginGridColumn.ReadOnly = true;
            // 
            // PermissaoGridColumn
            // 
            this.PermissaoGridColumn.DataPropertyName = "Permissao";
            this.PermissaoGridColumn.HeaderText = "Acesso";
            this.PermissaoGridColumn.Name = "PermissaoGridColumn";
            this.PermissaoGridColumn.ReadOnly = true;
            // 
            // SituacaoGridColumn
            // 
            this.SituacaoGridColumn.DataPropertyName = "Situacao";
            this.SituacaoGridColumn.HeaderText = "Situacao";
            this.SituacaoGridColumn.Name = "SituacaoGridColumn";
            this.SituacaoGridColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.AtivarButton);
            this.panel1.Controls.Add(this.InativarButton);
            this.panel1.Controls.Add(this.AlterarButton);
            this.panel1.Location = new System.Drawing.Point(12, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 70);
            this.panel1.TabIndex = 181;
            // 
            // AtivarButton
            // 
            this.AtivarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtivarButton.Location = new System.Drawing.Point(260, 10);
            this.AtivarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AtivarButton.Name = "AtivarButton";
            this.AtivarButton.Size = new System.Drawing.Size(122, 60);
            this.AtivarButton.TabIndex = 181;
            this.AtivarButton.Text = "Ativar";
            this.AtivarButton.UseVisualStyleBackColor = true;
            this.AtivarButton.Click += new System.EventHandler(this.AtivarButton_Click);
            // 
            // InativarButton
            // 
            this.InativarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InativarButton.Location = new System.Drawing.Point(130, 10);
            this.InativarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InativarButton.Name = "InativarButton";
            this.InativarButton.Size = new System.Drawing.Size(122, 60);
            this.InativarButton.TabIndex = 180;
            this.InativarButton.Text = "Inativar";
            this.InativarButton.UseVisualStyleBackColor = true;
            this.InativarButton.Click += new System.EventHandler(this.InativarButton_Click);
            // 
            // AlterarButton
            // 
            this.AlterarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarButton.Location = new System.Drawing.Point(0, 10);
            this.AlterarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(122, 60);
            this.AlterarButton.TabIndex = 179;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            this.AlterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsultaUsuariodataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarUsuario";
            this.Text = "Consultar Usuário";
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaUsuariodataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SituacaoComboBox;
        private System.Windows.Forms.Label SituacaoLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn NomeGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn6;
        private System.Windows.Forms.DataGridView ConsultaUsuariodataGridView;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AtivarButton;
        private System.Windows.Forms.Button InativarButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissaoGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoGridColumn;
    }
}