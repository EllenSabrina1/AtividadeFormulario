namespace AtividadeFormulario
{
    partial class Menu
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
            this.bt_funcionario = new System.Windows.Forms.Button();
            this.bt_empresa = new System.Windows.Forms.Button();
            this.bt_sairMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_funcionario
            // 
            this.bt_funcionario.Location = new System.Drawing.Point(278, 177);
            this.bt_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_funcionario.Name = "bt_funcionario";
            this.bt_funcionario.Size = new System.Drawing.Size(176, 85);
            this.bt_funcionario.TabIndex = 0;
            this.bt_funcionario.Text = "funcionario";
            this.bt_funcionario.UseVisualStyleBackColor = true;
            this.bt_funcionario.Click += new System.EventHandler(this.bt_funcionario_Click);
            // 
            // bt_empresa
            // 
            this.bt_empresa.Location = new System.Drawing.Point(522, 177);
            this.bt_empresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(175, 85);
            this.bt_empresa.TabIndex = 1;
            this.bt_empresa.Text = "empresa";
            this.bt_empresa.UseVisualStyleBackColor = true;
            this.bt_empresa.Click += new System.EventHandler(this.bt_empresa_Click);
            // 
            // bt_sairMenu
            // 
            this.bt_sairMenu.Location = new System.Drawing.Point(901, 500);
            this.bt_sairMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_sairMenu.Name = "bt_sairMenu";
            this.bt_sairMenu.Size = new System.Drawing.Size(100, 28);
            this.bt_sairMenu.TabIndex = 2;
            this.bt_sairMenu.Text = "sair";
            this.bt_sairMenu.UseVisualStyleBackColor = true;
            this.bt_sairMenu.Click += new System.EventHandler(this.bt_sairMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_sairMenu);
            this.Controls.Add(this.bt_empresa);
            this.Controls.Add(this.bt_funcionario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_funcionario;
        private System.Windows.Forms.Button bt_empresa;
        private System.Windows.Forms.Button bt_sairMenu;
    }
}