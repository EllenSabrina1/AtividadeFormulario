using AtividadeFormulario.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AtividadeFormulario
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string validarCpf = msk_cpfProp.Text;
                bool resCpf = Validacao.ValidarCpf(validarCpf);

                // Validação do E-mail
                /* string validarCnpj = msk_cnpj.Text;
                 bool resCnpj = Validacao.ValidarEmail(validarCnpj);*/

                if (resCpf)
                {
                    Empresa empresas = new Empresa();


                    empresas.Id = tx_id.Text;
                    empresas.Cnpj = msk_cnpj.Text;
                    empresas.RazaoSocial = tx_razaoSocial.Text;
                    empresas.NomeFantasia = tx_nomeFant.Text;
                    empresas.Situacao = cb_situacao.Text;
                    empresas.RegimeTrib = RadioRegime();
                    empresas.DataInicio = Convert.ToDateTime(dt_inicio.Text);
                    empresas.Telefone = msk_telefone.Text;
                    empresas.CapitalSocial = Convert.ToDouble(tx_capital.Text);
                    empresas.Estado = cb_estado.Text;
                    empresas.Cidade = tx_cidade.Text;
                    empresas.CEP = tx_cep.Text;
                    empresas.Numero = tx_num.Text;
                    empresas.Bairro = tx_bairro.Text;
                    empresas.Rua = tx_rua.Text;
                    empresas.Tipo = RadioTipo();
                    empresas.PorteEmpresa = RadioPorte();
                    empresas.NaturezaJuridica = cb_naturezaJu.Text;
                    empresas.NomeProprietario = tx_nome_Prop.Text;
                    empresas.CpfDoProprietario = msk_cpfProp.Text;


                    Inserir(empresas);
                }
                else
                {
                    string mensagemErro = "Erro ao cadastrar empresa. Problemas encontrados:\n";

                    if (!resCpf)
                    {
                        mensagemErro += "> CPF inválido\n";
                    }




                    MessageBox.Show(mensagemErro);
                }
            }catch (Exception ex) {
                throw;
            }


        }
           
        void Inserir(Empresa empresas)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Empresa (cnpj_emp, razao_social_emp, nome_fant_emp," +
                    " situacao_cadastral_emp, regime_Tributario_emp, data_inicio_emp, telefone_emp, capital_social_emp," +
                    "tipo_emp, porte_empresa_emp, natureza_juridica_emp, nome_prop_emp, cpf_prop_emp) VALUES (" +
                    " @Cnpj, @RazaoSocial, @NomeFantasia, @Situacao, @RegimeTrib, @DataInicio, @Telefone, @CapitalSocial, " +
                    "@Estado, @Cidade, @CEP, @Numero, @Bairro, @Rua, @Tipo, @PorteEmpresa, @NaturezaJuridica, @NomeProprietario, @CpfDoProprietario)");

                comando.Parameters.AddWithValue("@Cnpj", empresas.Cnpj);
                comando.Parameters.AddWithValue("@RazaoSocial", empresas.RazaoSocial);
                comando.Parameters.AddWithValue("@NomeFantasia", empresas.NomeFantasia);
                comando.Parameters.AddWithValue("@Situacao", empresas.Situacao);
                comando.Parameters.AddWithValue("@Regime", empresas.RegimeTrib);
                comando.Parameters.AddWithValue("@DataInicio", empresas.DataInicio);
                comando.Parameters.AddWithValue("@Telefone", empresas.Telefone);
                comando.Parameters.AddWithValue("@CapitalSocial", empresas.CapitalSocial);
                comando.Parameters.AddWithValue("@Estado", empresas.Estado);
                comando.Parameters.AddWithValue("@Cidade", empresas.Cidade);
                comando.Parameters.AddWithValue("@CEP", empresas.CEP);
                comando.Parameters.AddWithValue("@Numero", empresas.Numero);
                comando.Parameters.AddWithValue("@Bairro", empresas.Bairro);
                comando.Parameters.AddWithValue("@Rua", empresas.Rua);
                comando.Parameters.AddWithValue("@Tipo", empresas.Tipo);
                comando.Parameters.AddWithValue("@PorteEmpresa", empresas.PorteEmpresa);
                comando.Parameters.AddWithValue("@NaturezaJuridica", empresas.NaturezaJuridica);
                comando.Parameters.AddWithValue("@NomeProprietario", empresas.NomeProprietario);
                comando.Parameters.AddWithValue("@CpfDoProprietario", empresas.CpfDoProprietario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string RadioRegime()
        {
            string radio = "";

            foreach (Control ctrl in panelRegime.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string RadioTipo()
        {
            string radio = "";

            foreach (Control ctrl in panelTipo.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        public string RadioPorte()
        {
            string radio = "";

            foreach (Control ctrl in panelPorte.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }

            return radio;
        }
        private void rb_simples_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_matriz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_medio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tx_nomeFant_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
