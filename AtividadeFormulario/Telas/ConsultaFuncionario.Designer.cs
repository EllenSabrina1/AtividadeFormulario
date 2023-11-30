namespace AtividadeFormulario
{
    partial class ConsultaFuncionario
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
            this.dataGrid_Funcionario = new System.Windows.Forms.DataGridView();
            this.bt_AddFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Funcionario
            // 
            this.dataGrid_Funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Funcionario.Location = new System.Drawing.Point(12, 37);
            this.dataGrid_Funcionario.Name = "dataGrid_Funcionario";
            this.dataGrid_Funcionario.Size = new System.Drawing.Size(766, 300);
            this.dataGrid_Funcionario.TabIndex = 0;
            this.dataGrid_Funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Funcionario_CellContentClick);
            // 
            // bt_AddFuncionario
            // 
            this.bt_AddFuncionario.Location = new System.Drawing.Point(623, 382);
            this.bt_AddFuncionario.Name = "bt_AddFuncionario";
            this.bt_AddFuncionario.Size = new System.Drawing.Size(113, 23);
            this.bt_AddFuncionario.TabIndex = 1;
            this.bt_AddFuncionario.Text = "Add Funcionario";
            this.bt_AddFuncionario.UseVisualStyleBackColor = true;
            this.bt_AddFuncionario.Click += new System.EventHandler(this.bt_AddFuncionario_Click);
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_AddFuncionario);
            this.Controls.Add(this.dataGrid_Funcionario);
            this.Name = "ConsultaFuncionario";
            this.Text = "ConsultaFuncionario";
            this.Load += new System.EventHandler(this.ConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Funcionario;
        private System.Windows.Forms.Button bt_AddFuncionario;
    }
}