namespace AtividadeFormulario
{
    partial class CadastroFuncionario
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
            this.tx_nomeFunc = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_end = new System.Windows.Forms.TextBox();
            this.tx_cidadeFunc = new System.Windows.Forms.TextBox();
            this.msk_telefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.cb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.cb_estadoFun = new System.Windows.Forms.ComboBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_idFunc = new System.Windows.Forms.TextBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.msk_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.bt_salvarFun = new System.Windows.Forms.Button();
            this.bt_cancelarFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_nomeFunc
            // 
            this.tx_nomeFunc.BackColor = System.Drawing.Color.Lavender;
            this.tx_nomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nomeFunc.Location = new System.Drawing.Point(43, 128);
            this.tx_nomeFunc.Name = "tx_nomeFunc";
            this.tx_nomeFunc.Size = new System.Drawing.Size(288, 13);
            this.tx_nomeFunc.TabIndex = 1;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Lavender;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Location = new System.Drawing.Point(43, 271);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(288, 13);
            this.tx_email.TabIndex = 2;
            // 
            // tx_end
            // 
            this.tx_end.BackColor = System.Drawing.Color.Lavender;
            this.tx_end.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_end.Location = new System.Drawing.Point(432, 382);
            this.tx_end.Name = "tx_end";
            this.tx_end.Size = new System.Drawing.Size(207, 13);
            this.tx_end.TabIndex = 3;
            // 
            // tx_cidadeFunc
            // 
            this.tx_cidadeFunc.BackColor = System.Drawing.Color.Lavender;
            this.tx_cidadeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidadeFunc.Location = new System.Drawing.Point(233, 382);
            this.tx_cidadeFunc.Name = "tx_cidadeFunc";
            this.tx_cidadeFunc.Size = new System.Drawing.Size(139, 13);
            this.tx_cidadeFunc.TabIndex = 4;
            // 
            // msk_telefoneFunc
            // 
            this.msk_telefoneFunc.BackColor = System.Drawing.Color.Lavender;
            this.msk_telefoneFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_telefoneFunc.Location = new System.Drawing.Point(432, 128);
            this.msk_telefoneFunc.Mask = "(99) 00000-0000";
            this.msk_telefoneFunc.Name = "msk_telefoneFunc";
            this.msk_telefoneFunc.Size = new System.Drawing.Size(118, 13);
            this.msk_telefoneFunc.TabIndex = 27;
            // 
            // msk_cpfFunc
            // 
            this.msk_cpfFunc.BackColor = System.Drawing.Color.Lavender;
            this.msk_cpfFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_cpfFunc.Location = new System.Drawing.Point(43, 206);
            this.msk_cpfFunc.Mask = "000,000,000-00";
            this.msk_cpfFunc.Name = "msk_cpfFunc";
            this.msk_cpfFunc.Size = new System.Drawing.Size(118, 13);
            this.msk_cpfFunc.TabIndex = 28;
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.Color.Lavender;
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Location = new System.Drawing.Point(244, 206);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(128, 13);
            this.tx_rg.TabIndex = 29;
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.FormattingEnabled = true;
            this.cb_estadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "União estável",
            "Viúvo",
            "Divorciado"});
            this.cb_estadoCivil.Location = new System.Drawing.Point(432, 268);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoCivil.TabIndex = 30;
            // 
            // cb_estadoFun
            // 
            this.cb_estadoFun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_estadoFun.FormattingEnabled = true;
            this.cb_estadoFun.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            "Distrito Federal"});
            this.cb_estadoFun.Location = new System.Drawing.Point(43, 379);
            this.cb_estadoFun.Name = "cb_estadoFun";
            this.cb_estadoFun.Size = new System.Drawing.Size(118, 21);
            this.cb_estadoFun.TabIndex = 31;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.Color.Lavender;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Location = new System.Drawing.Point(249, 504);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(82, 13);
            this.tx_salario.TabIndex = 32;
            // 
            // tx_idFunc
            // 
            this.tx_idFunc.BackColor = System.Drawing.Color.Lavender;
            this.tx_idFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_idFunc.Location = new System.Drawing.Point(422, 499);
            this.tx_idFunc.Name = "tx_idFunc";
            this.tx_idFunc.Size = new System.Drawing.Size(84, 13);
            this.tx_idFunc.TabIndex = 33;
            // 
            // cb_funcao
            // 
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "Professor(a)",
            "Coordenador(a)",
            "Diretor(a)",
            "Secretário(a)",
            "Bibliotecário(a)",
            "Psicólogo(a)",
            "Orientador(a) ",
            "Auxiliar",
            "Enfermeiro(a)",
            "Intérprete de Libras"});
            this.cb_funcao.Location = new System.Drawing.Point(43, 496);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(121, 21);
            this.cb_funcao.TabIndex = 34;
            // 
            // msk_dataNasc
            // 
            this.msk_dataNasc.BackColor = System.Drawing.Color.Lavender;
            this.msk_dataNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_dataNasc.Location = new System.Drawing.Point(432, 206);
            this.msk_dataNasc.Mask = "00/00/0000";
            this.msk_dataNasc.Name = "msk_dataNasc";
            this.msk_dataNasc.Size = new System.Drawing.Size(100, 13);
            this.msk_dataNasc.TabIndex = 35;
            this.msk_dataNasc.ValidatingType = typeof(System.DateTime);
            this.msk_dataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // bt_salvarFun
            // 
            this.bt_salvarFun.Location = new System.Drawing.Point(582, 462);
            this.bt_salvarFun.Name = "bt_salvarFun";
            this.bt_salvarFun.Size = new System.Drawing.Size(75, 23);
            this.bt_salvarFun.TabIndex = 36;
            this.bt_salvarFun.Text = "Salvar";
            this.bt_salvarFun.UseVisualStyleBackColor = true;
            this.bt_salvarFun.Click += new System.EventHandler(this.bt_salvarFun_Click);
            // 
            // bt_cancelarFun
            // 
            this.bt_cancelarFun.Location = new System.Drawing.Point(582, 491);
            this.bt_cancelarFun.Name = "bt_cancelarFun";
            this.bt_cancelarFun.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelarFun.TabIndex = 37;
            this.bt_cancelarFun.Text = "cancelar";
            this.bt_cancelarFun.UseVisualStyleBackColor = true;
            this.bt_cancelarFun.Click += new System.EventHandler(this.bt_cancelarFun_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtividadeFormulario.Properties.Resources.Cadastro_Funcionario__3_;
            this.ClientSize = new System.Drawing.Size(701, 530);
            this.Controls.Add(this.bt_cancelarFun);
            this.Controls.Add(this.bt_salvarFun);
            this.Controls.Add(this.msk_dataNasc);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.tx_idFunc);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.cb_estadoFun);
            this.Controls.Add(this.cb_estadoCivil);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.msk_cpfFunc);
            this.Controls.Add(this.msk_telefoneFunc);
            this.Controls.Add(this.tx_cidadeFunc);
            this.Controls.Add(this.tx_end);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nomeFunc);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nomeFunc;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_end;
        private System.Windows.Forms.TextBox tx_cidadeFunc;
        private System.Windows.Forms.MaskedTextBox msk_telefoneFunc;
        private System.Windows.Forms.MaskedTextBox msk_cpfFunc;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.ComboBox cb_estadoCivil;
        private System.Windows.Forms.ComboBox cb_estadoFun;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.TextBox tx_idFunc;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.MaskedTextBox msk_dataNasc;
        private System.Windows.Forms.Button bt_salvarFun;
        private System.Windows.Forms.Button bt_cancelarFun;
    }
}