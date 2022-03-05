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
    public partial class frmCadastrarCliente : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void lblCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            LimparTodosCampos();
            
        }
        
        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDataExpedicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {       
            
            if (VerificarTodosCampos())
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarCliente", conexaoMySQL);
                    comandoMySQL.CommandType = CommandType.StoredProcedure;
                    comandoMySQL.Parameters.AddWithValue("_id", idCliente);
                    comandoMySQL.Parameters.AddWithValue("_sts", true);
                    comandoMySQL.Parameters.AddWithValue("_nomeCliente", txtBoxNome.Text.Trim());
                    comandoMySQL.Parameters.AddWithValue("_cpf", txtBoxCpf.Text.Trim());
                    comandoMySQL.Parameters.AddWithValue("_numeroIdentidade", txtBoxRg.Text.Trim());
                    comandoMySQL.Parameters.AddWithValue("_dataExpedicaoIdentidade", AplicarPadraoAmericano(dtpDataExpedicao.Value).Trim());
                    comandoMySQL.Parameters.AddWithValue("_dataNascimento", AplicarPadraoAmericano(dtpDataNascimento.Value).Trim());                    
                    comandoMySQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente Cadastrado com Sucesso!");
                    LimparTodosCampos();
                    ExibirNovoFormularioGerenciarClientes();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos, por favor!");
            }
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool VerificarTodosCampos()
        {
            //Console.WriteLine(dtpDataNascimento.Text);
            if(txtBoxNome.Text == "" || txtBoxRg.Text == "" || txtBoxCpf.Text == "")
            {
                Console.WriteLine("Existem campos vazios");
                return false;
            }
            return true;
        }

        private string AplicarPadraoAmericano(DateTime data)
        {
            string dia = data.Day.ToString(), mes = data.Month.ToString(), ano = data.Year.ToString();
            if(data.Month >= 1  && data.Month <= 9)
            {
                mes = "0" + mes;
            }
            string dataAmericana = ano + "/" + mes + "/" + dia;

            
            return dataAmericana;
        }

        private void LimparTodosCampos()
        {
            txtBoxNome.Text = txtBoxCpf.Text = txtBoxRg.Text = "";
            idCliente = 0;
        }

        private void btnVoltarCadastrarCliente_Click(object sender, EventArgs e)
        {
            

            Form formBackground = new Form();
            try
            {
                using (frmPopUp frmpopup = new frmPopUp())
                {

                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.TopMost = true;
                    formBackground.StartPosition = FormStartPosition.CenterScreen;
                    formBackground.Size = new Size(754,586);
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();


                    frmpopup.Owner = formBackground;
                    frmpopup.ShowDialog();
                    formBackground.Dispose();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            
            
            //ExibirNovoFormularioGerenciarClientes();

        }

        /*private frmPopUp ExibirNovoFormularioPopUp()
        {
            frmPopUp frmpopup = new frmPopUp();
            frmpopup.Show();
            return frmpopup;
        }*/

        private frmGerenciamentoCliente ExibirNovoFormularioGerenciarClientes()
        {
            frmGerenciamentoCliente frmClientes = new frmGerenciamentoCliente();            
            frmClientes.Show();
            return frmClientes;
        }
    }
}
