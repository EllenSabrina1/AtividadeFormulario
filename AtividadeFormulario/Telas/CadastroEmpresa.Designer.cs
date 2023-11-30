namespace AtividadeFormulario
{
    partial class CadastroEmpresa
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
            this.tx_razaoSocial = new System.Windows.Forms.TextBox();
            this.tx_nomeFant = new System.Windows.Forms.TextBox();
            this.tx_nome_Prop = new System.Windows.Forms.TextBox();
            this.tx_capital = new System.Windows.Forms.TextBox();
            this.cb_situacao = new System.Windows.Forms.ComboBox();
            this.rb_simples = new System.Windows.Forms.RadioButton();
            this.rb_lucro = new System.Windows.Forms.RadioButton();
            this.rb_real = new System.Windows.Forms.RadioButton();
            this.rb_matriz = new System.Windows.Forms.RadioButton();
            this.rb_filial = new System.Windows.Forms.RadioButton();
            this.rb_pequeno = new System.Windows.Forms.RadioButton();
            this.rb_grande = new System.Windows.Forms.RadioButton();
            this.rb_medio = new System.Windows.Forms.RadioButton();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.cb_naturezaJu = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_cep = new System.Windows.Forms.TextBox();
            this.tx_num = new System.Windows.Forms.TextBox();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.tx_rua = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.msk_cpfProp = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.msk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.panelRegime = new System.Windows.Forms.Panel();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.panelPorte = new System.Windows.Forms.Panel();
            this.panelRegime.SuspendLayout();
            this.panelTipo.SuspendLayout();
            this.panelPorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_razaoSocial
            // 
            this.tx_razaoSocial.BackColor = System.Drawing.Color.Lavender;
            this.tx_razaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_razaoSocial.Location = new System.Drawing.Point(55, 94);
            this.tx_razaoSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_razaoSocial.Name = "tx_razaoSocial";
            this.tx_razaoSocial.Size = new System.Drawing.Size(384, 15);
            this.tx_razaoSocial.TabIndex = 0;
            // 
            // tx_nomeFant
            // 
            this.tx_nomeFant.BackColor = System.Drawing.Color.Lavender;
            this.tx_nomeFant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nomeFant.Location = new System.Drawing.Point(55, 158);
            this.tx_nomeFant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nomeFant.Name = "tx_nomeFant";
            this.tx_nomeFant.Size = new System.Drawing.Size(384, 15);
            this.tx_nomeFant.TabIndex = 1;
            this.tx_nomeFant.TextChanged += new System.EventHandler(this.tx_nomeFant_TextChanged);
            // 
            // tx_nome_Prop
            // 
            this.tx_nome_Prop.BackColor = System.Drawing.Color.Lavender;
            this.tx_nome_Prop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome_Prop.Location = new System.Drawing.Point(55, 224);
            this.tx_nome_Prop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nome_Prop.Name = "tx_nome_Prop";
            this.tx_nome_Prop.Size = new System.Drawing.Size(384, 15);
            this.tx_nome_Prop.TabIndex = 2;
            // 
            // tx_capital
            // 
            this.tx_capital.BackColor = System.Drawing.Color.Lavender;
            this.tx_capital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_capital.Location = new System.Drawing.Point(55, 289);
            this.tx_capital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_capital.Name = "tx_capital";
            this.tx_capital.Size = new System.Drawing.Size(153, 15);
            this.tx_capital.TabIndex = 3;
            // 
            // cb_situacao
            // 
            this.cb_situacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_situacao.FormattingEnabled = true;
            this.cb_situacao.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_situacao.Location = new System.Drawing.Point(539, 154);
            this.cb_situacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_situacao.Name = "cb_situacao";
            this.cb_situacao.Size = new System.Drawing.Size(156, 24);
            this.cb_situacao.TabIndex = 6;
            // 
            // rb_simples
            // 
            this.rb_simples.AutoSize = true;
            this.rb_simples.BackColor = System.Drawing.Color.Lavender;
            this.rb_simples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_simples.Location = new System.Drawing.Point(4, 4);
            this.rb_simples.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_simples.Name = "rb_simples";
            this.rb_simples.Size = new System.Drawing.Size(160, 24);
            this.rb_simples.TabIndex = 7;
            this.rb_simples.TabStop = true;
            this.rb_simples.Text = "Simples Nacional";
            this.rb_simples.UseVisualStyleBackColor = false;
            this.rb_simples.CheckedChanged += new System.EventHandler(this.rb_simples_CheckedChanged);
            // 
            // rb_lucro
            // 
            this.rb_lucro.AutoSize = true;
            this.rb_lucro.BackColor = System.Drawing.Color.Lavender;
            this.rb_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lucro.Location = new System.Drawing.Point(4, 33);
            this.rb_lucro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_lucro.Name = "rb_lucro";
            this.rb_lucro.Size = new System.Drawing.Size(158, 24);
            this.rb_lucro.TabIndex = 8;
            this.rb_lucro.TabStop = true;
            this.rb_lucro.Text = "Lucro Presumido";
            this.rb_lucro.UseVisualStyleBackColor = false;
            this.rb_lucro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_real
            // 
            this.rb_real.AutoSize = true;
            this.rb_real.BackColor = System.Drawing.Color.Lavender;
            this.rb_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_real.Location = new System.Drawing.Point(4, 65);
            this.rb_real.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_real.Name = "rb_real";
            this.rb_real.Size = new System.Drawing.Size(64, 24);
            this.rb_real.TabIndex = 9;
            this.rb_real.TabStop = true;
            this.rb_real.Text = "Real";
            this.rb_real.UseVisualStyleBackColor = false;
            // 
            // rb_matriz
            // 
            this.rb_matriz.AutoSize = true;
            this.rb_matriz.BackColor = System.Drawing.Color.Lavender;
            this.rb_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_matriz.Location = new System.Drawing.Point(4, 4);
            this.rb_matriz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_matriz.Name = "rb_matriz";
            this.rb_matriz.Size = new System.Drawing.Size(77, 24);
            this.rb_matriz.TabIndex = 10;
            this.rb_matriz.TabStop = true;
            this.rb_matriz.Text = "Matriz";
            this.rb_matriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_matriz.UseVisualStyleBackColor = false;
            this.rb_matriz.CheckedChanged += new System.EventHandler(this.rb_matriz_CheckedChanged);
            // 
            // rb_filial
            // 
            this.rb_filial.AutoSize = true;
            this.rb_filial.BackColor = System.Drawing.Color.Lavender;
            this.rb_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_filial.Location = new System.Drawing.Point(6, 36);
            this.rb_filial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_filial.Name = "rb_filial";
            this.rb_filial.Size = new System.Drawing.Size(65, 24);
            this.rb_filial.TabIndex = 11;
            this.rb_filial.TabStop = true;
            this.rb_filial.Text = "Filial";
            this.rb_filial.UseVisualStyleBackColor = false;
            // 
            // rb_pequeno
            // 
            this.rb_pequeno.AutoSize = true;
            this.rb_pequeno.BackColor = System.Drawing.Color.Lavender;
            this.rb_pequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pequeno.Location = new System.Drawing.Point(4, 4);
            this.rb_pequeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_pequeno.Name = "rb_pequeno";
            this.rb_pequeno.Size = new System.Drawing.Size(95, 24);
            this.rb_pequeno.TabIndex = 12;
            this.rb_pequeno.TabStop = true;
            this.rb_pequeno.Text = "Pequeno";
            this.rb_pequeno.UseVisualStyleBackColor = false;
            // 
            // rb_grande
            // 
            this.rb_grande.AutoSize = true;
            this.rb_grande.BackColor = System.Drawing.Color.Lavender;
            this.rb_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_grande.Location = new System.Drawing.Point(4, 36);
            this.rb_grande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_grande.Name = "rb_grande";
            this.rb_grande.Size = new System.Drawing.Size(85, 24);
            this.rb_grande.TabIndex = 13;
            this.rb_grande.TabStop = true;
            this.rb_grande.Text = "Grande";
            this.rb_grande.UseVisualStyleBackColor = false;
            // 
            // rb_medio
            // 
            this.rb_medio.AutoSize = true;
            this.rb_medio.BackColor = System.Drawing.Color.Lavender;
            this.rb_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_medio.Location = new System.Drawing.Point(4, 65);
            this.rb_medio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_medio.Name = "rb_medio";
            this.rb_medio.Size = new System.Drawing.Size(75, 24);
            this.rb_medio.TabIndex = 14;
            this.rb_medio.TabStop = true;
            this.rb_medio.Text = "Médio";
            this.rb_medio.UseVisualStyleBackColor = false;
            this.rb_medio.CheckedChanged += new System.EventHandler(this.rb_medio_CheckedChanged);
            // 
            // dt_inicio
            // 
            this.dt_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_inicio.Location = new System.Drawing.Point(308, 290);
            this.dt_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(137, 22);
            this.dt_inicio.TabIndex = 15;
            // 
            // cb_naturezaJu
            // 
            this.cb_naturezaJu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_naturezaJu.FormattingEnabled = true;
            this.cb_naturezaJu.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.cb_naturezaJu.Location = new System.Drawing.Point(539, 290);
            this.cb_naturezaJu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_naturezaJu.Name = "cb_naturezaJu";
            this.cb_naturezaJu.Size = new System.Drawing.Size(156, 24);
            this.cb_naturezaJu.TabIndex = 16;
            // 
            // cb_estado
            // 
            this.cb_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
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
            this.cb_estado.Location = new System.Drawing.Point(81, 430);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(156, 24);
            this.cb_estado.TabIndex = 17;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.Lavender;
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Location = new System.Drawing.Point(308, 439);
            this.tx_cidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(157, 15);
            this.tx_cidade.TabIndex = 18;
            // 
            // tx_cep
            // 
            this.tx_cep.BackColor = System.Drawing.Color.Lavender;
            this.tx_cep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cep.Location = new System.Drawing.Point(549, 439);
            this.tx_cep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_cep.Name = "tx_cep";
            this.tx_cep.Size = new System.Drawing.Size(147, 15);
            this.tx_cep.TabIndex = 19;
            // 
            // tx_num
            // 
            this.tx_num.BackColor = System.Drawing.Color.Lavender;
            this.tx_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_num.Location = new System.Drawing.Point(749, 439);
            this.tx_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_num.Name = "tx_num";
            this.tx_num.Size = new System.Drawing.Size(155, 15);
            this.tx_num.TabIndex = 20;
            // 
            // tx_bairro
            // 
            this.tx_bairro.BackColor = System.Drawing.Color.Lavender;
            this.tx_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_bairro.Location = new System.Drawing.Point(81, 523);
            this.tx_bairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(384, 15);
            this.tx_bairro.TabIndex = 21;
            // 
            // tx_rua
            // 
            this.tx_rua.BackColor = System.Drawing.Color.Lavender;
            this.tx_rua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rua.Location = new System.Drawing.Point(525, 523);
            this.tx_rua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_rua.Name = "tx_rua";
            this.tx_rua.Size = new System.Drawing.Size(379, 15);
            this.tx_rua.TabIndex = 22;
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.Color.Lavender;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Location = new System.Drawing.Point(387, 345);
            this.tx_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(141, 15);
            this.tx_id.TabIndex = 23;
            // 
            // msk_cpfProp
            // 
            this.msk_cpfProp.BackColor = System.Drawing.Color.Lavender;
            this.msk_cpfProp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_cpfProp.Location = new System.Drawing.Point(539, 231);
            this.msk_cpfProp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_cpfProp.Mask = "000,000,000-00";
            this.msk_cpfProp.Name = "msk_cpfProp";
            this.msk_cpfProp.Size = new System.Drawing.Size(157, 15);
            this.msk_cpfProp.TabIndex = 25;
            // 
            // msk_telefone
            // 
            this.msk_telefone.BackColor = System.Drawing.Color.Lavender;
            this.msk_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_telefone.Location = new System.Drawing.Point(539, 98);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_telefone.Mask = "(99) 00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(157, 15);
            this.msk_telefone.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 581);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 581);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // msk_cnpj
            // 
            this.msk_cnpj.Location = new System.Drawing.Point(131, 345);
            this.msk_cnpj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_cnpj.Mask = "00,000,000/0000-00";
            this.msk_cnpj.Name = "msk_cnpj";
            this.msk_cnpj.Size = new System.Drawing.Size(132, 22);
            this.msk_cnpj.TabIndex = 29;
            // 
            // panelRegime
            // 
            this.panelRegime.BackColor = System.Drawing.Color.Transparent;
            this.panelRegime.Controls.Add(this.rb_simples);
            this.panelRegime.Controls.Add(this.rb_lucro);
            this.panelRegime.Controls.Add(this.rb_real);
            this.panelRegime.Location = new System.Drawing.Point(735, 94);
            this.panelRegime.Name = "panelRegime";
            this.panelRegime.Size = new System.Drawing.Size(174, 96);
            this.panelRegime.TabIndex = 30;
            // 
            // panelTipo
            // 
            this.panelTipo.BackColor = System.Drawing.Color.Transparent;
            this.panelTipo.Controls.Add(this.rb_matriz);
            this.panelTipo.Controls.Add(this.rb_filial);
            this.panelTipo.Location = new System.Drawing.Point(733, 206);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(90, 71);
            this.panelTipo.TabIndex = 31;
            // 
            // panelPorte
            // 
            this.panelPorte.BackColor = System.Drawing.Color.Transparent;
            this.panelPorte.Controls.Add(this.rb_pequeno);
            this.panelPorte.Controls.Add(this.rb_grande);
            this.panelPorte.Controls.Add(this.rb_medio);
            this.panelPorte.Location = new System.Drawing.Point(735, 304);
            this.panelPorte.Name = "panelPorte";
            this.panelPorte.Size = new System.Drawing.Size(115, 100);
            this.panelPorte.TabIndex = 32;
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtividadeFormulario.Properties.Resources.cadastro_de_empresa__2___1_;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.panelPorte);
            this.Controls.Add(this.panelTipo);
            this.Controls.Add(this.panelRegime);
            this.Controls.Add(this.msk_cnpj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.msk_cpfProp);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.tx_rua);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.tx_num);
            this.Controls.Add(this.tx_cep);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.cb_naturezaJu);
            this.Controls.Add(this.dt_inicio);
            this.Controls.Add(this.cb_situacao);
            this.Controls.Add(this.tx_capital);
            this.Controls.Add(this.tx_nome_Prop);
            this.Controls.Add(this.tx_nomeFant);
            this.Controls.Add(this.tx_razaoSocial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroEmpresa";
            this.Text = "CadastroFunc";
            this.Load += new System.EventHandler(this.CadastroEmpresa_Load);
            this.panelRegime.ResumeLayout(false);
            this.panelRegime.PerformLayout();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelPorte.ResumeLayout(false);
            this.panelPorte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_razaoSocial;
        private System.Windows.Forms.TextBox tx_nomeFant;
        private System.Windows.Forms.TextBox tx_nome_Prop;
        private System.Windows.Forms.TextBox tx_capital;
        private System.Windows.Forms.ComboBox cb_situacao;
        private System.Windows.Forms.RadioButton rb_simples;
        private System.Windows.Forms.RadioButton rb_lucro;
        private System.Windows.Forms.RadioButton rb_real;
        private System.Windows.Forms.RadioButton rb_matriz;
        private System.Windows.Forms.RadioButton rb_filial;
        private System.Windows.Forms.RadioButton rb_pequeno;
        private System.Windows.Forms.RadioButton rb_grande;
        private System.Windows.Forms.RadioButton rb_medio;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.ComboBox cb_naturezaJu;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_cep;
        private System.Windows.Forms.TextBox tx_num;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.TextBox tx_rua;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.MaskedTextBox msk_cpfProp;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox msk_cnpj;
        private System.Windows.Forms.Panel panelRegime;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.Panel panelPorte;
    }
}