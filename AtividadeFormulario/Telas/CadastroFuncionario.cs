using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using AtividadeFormulario.Configuracao;

namespace AtividadeFormulario
{
    public partial class CadastroFuncionario : Form
    {
        List<Funcionario> listaCadastros = new List<Funcionario>();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_salvarFun_Click(object sender, EventArgs e)
        {
            //List<Funcionario> listaCadastros = new List<Funcionario>();
            string validarCpf = msk_cpfFunc.Text;
            bool resultadoCpf = Validacao.ValidarCpf(validarCpf);

            // Validação do E-mail
            string validarEmail = tx_email.Text;
            bool resultadoEmail = Validacao.ValidarEmail(validarEmail);

            if (resultadoCpf && resultadoEmail)
            {
                Funcionario f = new Funcionario();
                f.Id = tx_idFunc.Text;
                f.Nome = tx_nomeFunc.Text;
                f.Email = tx_email.Text;
                f.DataNascimento = msk_dataNasc.Text;
                f.CPF = msk_cpfFunc.Text;
                f.RG = tx_rg.Text;
                f.Estado = cb_estadoFun.Text;
                f.Cidade = tx_cidadeFunc.Text;
                f.Endereco = tx_end.Text;
                f.EstadoCivil = cb_estadoCivil.Text;
                f.Telefone = msk_telefoneFunc.Text;
                f.Funcao = cb_funcao.Text;
                f.Salario = Convert.ToDouble(tx_salario.Text);

                Inserir(f);

                MessageBox.Show($"Salvo!");
                //Form3 formulario1 = new Form3();
                //formulario1.Show();
                //this.Close();
            }

            else
            {
                string mensagemErro = "Erro ao cadastrar funcionário. Problemas encontrados:\n";

                if (!resultadoCpf)
                {
                    mensagemErro += "> CPF inválido\n";
                }

                if (!resultadoEmail)
                {
                    mensagemErro += "> E-mail inválido\n";
                }

                MessageBox.Show(mensagemErro);
            }
        
    }

        private void bt_cancelarFun_Click(object sender, EventArgs e)
        {
            //Form2 formulario1 = new Form2();
            //formulario1.Show();
            this.Close();
        }

        void Inserir(Funcionario f)
        {

            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_fun, cpf_fun, rg_fun, estadoCivil_fun, data_nascimento_fun, " +
                    "celular_fun, estado_fun, cidade_fun,endereco_fun, email_fun, funcao_fun, salario_fun)" +
                    "VALUES (@Nome, @CPF, @RG, @EstadoCivil, @DataNascimento, @Telefone, @Estado, @Cidade, @Endereco, @Email, @Funcao, @Salario)")  ;

                comando.Parameters.AddWithValue("@Nome", f.Nome);
                comando.Parameters.AddWithValue("@CPF", f.CPF);
                comando.Parameters.AddWithValue("@RG", f.RG);
                comando.Parameters.AddWithValue("@EstadoCivil", f.EstadoCivil);
                comando.Parameters.AddWithValue("@DataNascimento", f.DataNascimento);
                comando.Parameters.AddWithValue("@Telefone", f.Telefone);
                comando.Parameters.AddWithValue("@Estado", f.Estado);
                comando.Parameters.AddWithValue("@Cidade", f.Cidade);
                comando.Parameters.AddWithValue("@Endereco", f.Endereco);
                comando.Parameters.AddWithValue("@Email", f.Email);
                comando.Parameters.AddWithValue("@Funcao", f.Funcao);
                comando.Parameters.AddWithValue("@Salario", f.Salario);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

            /*void consultar()
            {
                try
                {
                    var conexao = new Conexao();
                    var comando = conexao.Comando("SELECT * FROM Funcionario");
                    var leitor = comando.ExecuteReader();

                    //string resultado = null;

                    while(leitor.Read()) 
                    {
                        var funcionari = new Funcionario();

                        funcionari.Id = leitor.GetString("id_fun");
                        funcionari.Nome = leitor.GetString("nome_fun");
                        funcionari.CPF = leitor.GetString("cpf_fun");
                        funcionari.RG = leitor.GetString("rg_fun");
                        funcionari.EstadoCivil = leitor.GetString("estadoCivil_fun");
                        funcionari.DataNascimento = leitor.GetDateTime("data_nascimento_fun");
                        funcionari.Telefone = leitor.GetString("celular_fun");
                        funcionari.Estado = leitor.GetString("estado_fun");
                        funcionari.Cidade = leitor.GetString("cidade_fun");
                        funcionari.Endereco = leitor.GetString("endereco_fun");
                        funcionari.Email = leitor.GetString("email_fun");
                        funcionari.Funcao = leitor.GetString("funcao_fun");
                        funcionari.Salario = leitor.GetDouble("salario_fun");

                        var posicaoColuna = leitor.GetOrdinal("cpf_fun");

                        if(! leitor.IsDBNull(posicaoColuna) )
                        {
                            funcionari.CPF = leitor.GetString("cpf_fun");
                        }

                        listaCadastros.Add(funcionari);

                        //resultado += "\n" + leitor.GetString("nome_fun");
                    }

                    //dataGridFuncionario.DataSource = listaCadastros;
                    //MessageBox.Show(resultado);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
