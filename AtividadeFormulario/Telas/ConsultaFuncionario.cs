using AtividadeFormulario.Configuracao;
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
    public partial class ConsultaFuncionario : Form
    {
        List<Funcionario> listaCadastros = new List<Funcionario>();
        public ConsultaFuncionario()
        {
            InitializeComponent();
            Consultar();
        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {

        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Id = leitor.GetString("id_fun");
                    funcionario.Nome = leitor.GetString("nome_fun");
                    funcionario.CPF = leitor.GetString("cpf_fun");
                    funcionario.RG = leitor.GetString("rg_fun");
                    funcionario.EstadoCivil = leitor.GetString("estadoCivil_fun");
                    funcionario.DataNascimento = leitor.GetString("data_nascimento_fun");
                    funcionario.Telefone = leitor.GetString("celular_fun");
                    funcionario.Estado = leitor.GetString("estado_fun");
                    funcionario.Cidade = leitor.GetString("cidade_fun");
                    funcionario.Endereco = leitor.GetString("endereco_fun");
                    funcionario.Email = leitor.GetString("email_fun");
                    funcionario.Funcao = leitor.GetString("funcao_fun");
                    funcionario.Salario = leitor.GetDouble("salario_fun");


                    var posicaoColuna = leitor.GetOrdinal("cpf_fun");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {
                        funcionario.CPF = leitor.GetString("cpf_fun");
                    }

                    listaCadastros.Add(funcionario);
                }

                dataGrid_Funcionario.DataSource = null;
                dataGrid_Funcionario.Refresh();
                dataGrid_Funcionario.DataSource = listaCadastros;
            }

            catch
            {
                throw;
            }
        }

        private void bt_AddFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadF = new CadastroFuncionario();
            cadF.ShowDialog();
        }

        private void dataGrid_Funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
