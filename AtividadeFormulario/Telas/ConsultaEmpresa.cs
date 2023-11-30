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
    public partial class ConsultaEmpresa : Form
    {
        List<Empresa> listaEmp = new List<Empresa>();
        public ConsultaEmpresa()
        {
            InitializeComponent();
        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Empresa");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Empresa e = new Empresa();

                    e.Id = leitor.GetString("id_emp");
                    e.Cnpj = leitor.GetString("Cnpj_emp");
                    e.RazaoSocial = leitor.GetString("razao_social_emp");
                    e.NomeFantasia = leitor.GetString("nome_fant_emp");
                    e.Situacao = leitor.GetString("situacao_cadastral_emp");
                    e.DataInicio = leitor.GetDateTime("data_inicio_emp");
                    e.Telefone = leitor.GetString("telefone_emp");
                    e.CapitalSocial = leitor.GetDouble("capital_social_emp");
                    e.Tipo = leitor.GetString("tipo_emp");
                    e.PorteEmpresa = leitor.GetString("porte_empresa_emp");
                    e.NaturezaJuridica = leitor.GetString("natureza_juridica_emp");
                    e.NomeProprietario = leitor.GetString("nome_prop_emp");
                    e.CpfDoProprietario = leitor.GetString("cpf_prop_emp");


                    var posicaoColuna = leitor.GetOrdinal("cpf_fun");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {
                        e.CpfDoProprietario = leitor.GetString("cpf_prop_emp");
                    }

                    listaEmp.Add(e);
                }

                dataGridConsultaEmp.DataSource = null;
                dataGridConsultaEmp.Refresh();
                dataGridConsultaEmp.DataSource = listaEmp;
            }

            catch
            {
                throw;
            }
        }

        private void bt_addEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadE = new CadastroEmpresa();
            cadE.ShowDialog();
        }

        private void ConsultaEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
