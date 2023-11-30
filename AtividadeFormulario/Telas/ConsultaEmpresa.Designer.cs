namespace AtividadeFormulario
{
    partial class ConsultaEmpresa
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
            this.dataGridConsultaEmp = new System.Windows.Forms.DataGridView();
            this.bt_addEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsultaEmp
            // 
            this.dataGridConsultaEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaEmp.Location = new System.Drawing.Point(36, 72);
            this.dataGridConsultaEmp.Name = "dataGridConsultaEmp";
            this.dataGridConsultaEmp.Size = new System.Drawing.Size(711, 269);
            this.dataGridConsultaEmp.TabIndex = 0;
            // 
            // bt_addEmpresa
            // 
            this.bt_addEmpresa.Location = new System.Drawing.Point(597, 397);
            this.bt_addEmpresa.Name = "bt_addEmpresa";
            this.bt_addEmpresa.Size = new System.Drawing.Size(123, 23);
            this.bt_addEmpresa.TabIndex = 1;
            this.bt_addEmpresa.Text = "Add Empresa";
            this.bt_addEmpresa.UseVisualStyleBackColor = true;
            this.bt_addEmpresa.Click += new System.EventHandler(this.bt_addEmpresa_Click);
            // 
            // ConsultaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_addEmpresa);
            this.Controls.Add(this.dataGridConsultaEmp);
            this.Name = "ConsultaEmpresa";
            this.Text = "ConsultaEmpresa";
            this.Load += new System.EventHandler(this.ConsultaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsultaEmp;
        private System.Windows.Forms.Button bt_addEmpresa;
    }
}