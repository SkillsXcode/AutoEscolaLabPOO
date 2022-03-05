using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoEscolaTrevo
{  
    public partial class frmCadastrarServico : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idServico = 0;

        public frmCadastrarServico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarServico_Load(object sender, EventArgs e)
        {
            LimparTodosCampos();
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            if (VerificarTodosCampos())
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {      

                    conexaoMySQL.Open();
                    MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarServico", conexaoMySQL);
                    comandoMySQL.CommandType = CommandType.StoredProcedure;
                    comandoMySQL.Parameters.AddWithValue("_id", idServico);
                    comandoMySQL.Parameters.AddWithValue("_nomeServico", txtBoxNomeServico.Text.Trim());                    
                    comandoMySQL.Parameters.AddWithValue("_valorServico", numValorServico.Value);
                    comandoMySQL.Parameters.AddWithValue("_valorMinimo", numValorMinServico.Value);
                    comandoMySQL.Parameters.AddWithValue("_taxaServico", numTaxaServico.Value);
                    comandoMySQL.Parameters.AddWithValue("_codigoServico", mskTxtCodigoServico.Text);
                    comandoMySQL.ExecuteNonQuery();
                    MessageBox.Show("Serviço Cadastrado com Sucesso!");
                    LimparTodosCampos();
                    ExibirNovoFormularioGerenciarServicos();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos, por favor!");
            }
        }
        private void LimparTodosCampos()
        {
            txtBoxNomeServico.Text = mskTxtCodigoServico.Text = "";
            numValorServico.Value = numValorMinServico.Value = numTaxaServico.Value = 0;
            idServico = 0;
        }
        private bool VerificarTodosCampos()
        {
            if (txtBoxNomeServico.Text == "" || mskTxtCodigoServico.Text == "")
            {
                Console.WriteLine("Existem campos vazios");
                return false;
            }
            return true;
        }

        private frmGerenciamentoServicos ExibirNovoFormularioGerenciarServicos()
        {
            this.Close();
            frmGerenciamentoServicos frmServicos = new frmGerenciamentoServicos();
            frmServicos.Show();
            return frmServicos;
        }
    }
}
