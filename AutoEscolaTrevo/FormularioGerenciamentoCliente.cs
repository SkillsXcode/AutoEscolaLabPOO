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
    public partial class frmGerenciamentoCliente : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=fisica1997;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;
        public frmGerenciamentoCliente()
        {
            InitializeComponent();
        }

        

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarCliente();
            this.Close();
        }

        private void frmGerenciamentoCliente_Load(object sender, EventArgs e)
        {
            PreencherListagem();
        }

        private frmCadastrarCliente ExibirNovoFormularioCadastrarCliente()
        {
            frmCadastrarCliente frmCadastrarCliente = new frmCadastrarCliente();
            frmCadastrarCliente.Show();
            return frmCadastrarCliente;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataViewCliente.CurrentRow.Index != -1)
            {

                frmEditarCliente formularioClienteEdicao = new frmEditarCliente();

                formularioClienteEdicao.txtBoxNome.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value.ToString();
                formularioClienteEdicao.maskedtxtboxCpf.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[2].Value.ToString();
                formularioClienteEdicao.txtBoxRg.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[3].Value.ToString();
                formularioClienteEdicao.dtpDataExpedicao.Value = Convert.ToDateTime(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[4].Value.ToString());
                formularioClienteEdicao.dtpDataNascimento.Value = Convert.ToDateTime(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[5].Value.ToString());
                formularioClienteEdicao.ShowDialog();
            }
            this.Close();


        }

        private void PreencherListagem()
        {
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("VisualizarTodosClientes", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbCliente = new DataTable();
                    adaptador.Fill(dtbCliente);
                    dataViewCliente.DataSource = dtbCliente;
                    dataViewCliente.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }

            
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {

            try
            {
                var msg = MessageBox.Show("Tem certeza que deseja excluir o cliente " + (dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value) + " ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                    {
                        conexaoMySQL.Open();
                        MySqlCommand comandoMySQL = new MySqlCommand("DeletarClienteporID", conexaoMySQL);
                        comandoMySQL.CommandType = CommandType.StoredProcedure;
                        idCliente = Convert.ToInt32(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value);
                        comandoMySQL.Parameters.AddWithValue("_id", idCliente);
                        comandoMySQL.ExecuteNonQuery();
                        MessageBox.Show("Cliente deletado!");
                        PreencherListagem();
                    }
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }            
        }

        private void btnVoltarGerenciarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciamentoGeral();
        }

        private frmGerenciamentoGeral ExibirNovoFormularioGerenciamentoGeral()
        {
            frmGerenciamentoGeral frmGerenciamentogeral = new frmGerenciamentoGeral();
            frmGerenciamentogeral.Show();
            return frmGerenciamentogeral;
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("ProcurarCliente", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("_CampoBusca", txtBuscarCliente.Text);
                    DataTable dtbCliente = new DataTable();
                    adaptador.Fill(dtbCliente);
                    dataViewCliente.DataSource = dtbCliente;
                    dataViewCliente.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }            
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
