using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeFormulario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_funcionario_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario conF = new ConsultaFuncionario();
            conF.ShowDialog();
            //this.Dispose();
        }

        private void bt_empresa_Click(object sender, EventArgs e)
        {
            ConsultaEmpresa consultaEmp = new ConsultaEmpresa();
            consultaEmp.ShowDialog();
        }

        private void bt_sairMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
