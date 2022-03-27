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
    public partial class frmAutenticacao : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        public frmAutenticacao()
        {
            InitializeComponent();
        }        

        private void btnEntrarAutenticacao_Click(object sender, EventArgs e)
        {            
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {                    
                    MySqlCommand cmd = new MySqlCommand("SELECT senhaAutenticacao FROM senha", conexaoMySQL);
                    conexaoMySQL.Open();
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dr.Read();
                    if(txtSenhaAutenticacao.Text == dr["senhaAutenticacao"].ToString())
                    {
                        ExibirNovoFormularioGerenciamentoGeral();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta, por favor tente novamente!");
                        txtSenhaAutenticacao.Clear();
                        txtSenhaAutenticacao.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }

            this.Visible = false;
        }

        private frmGerenciamentoGeral ExibirNovoFormularioGerenciamentoGeral()
        {
            frmGerenciamentoGeral frmGerenciamentogeral = new frmGerenciamentoGeral();
            frmGerenciamentogeral.Show();
            return frmGerenciamentogeral;
        }

        private void frmAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private void btnSairFormularioGeral_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Você realmente deseja sair do sistema?", "Atenção!", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
