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
    public partial class frmGerenciamentoServicos : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idServico = 0;

        public frmGerenciamentoServicos()
        {
            InitializeComponent();
        }

        private void FormularioGerenciamentoServicos_Load(object sender, EventArgs e)
        {
            PreencherListagem();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarServico();
            this.Close();
        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("ProcurarServico", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("_CampoBusca", txtBuscarServico.Text);
                    DataTable dtbServico = new DataTable();
                    adaptador.Fill(dtbServico);
                    dataViewServicos.DataSource = dtbServico;
                    dataViewServicos.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Tem certeza que deseja excluir o serviço " + (dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[1].Value) + " ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                    {
                        conexaoMySQL.Open();
                        MySqlCommand comandoMySQL = new MySqlCommand("DeletarServicoporID", conexaoMySQL);
                        comandoMySQL.CommandType = CommandType.StoredProcedure;
                        idServico = Convert.ToInt32(dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[0].Value);
                        comandoMySQL.Parameters.AddWithValue("_id", idServico);
                        comandoMySQL.ExecuteNonQuery();
                        MessageBox.Show("Servico deletado!");
                        PreencherListagem();
                    }
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

        private void PreencherListagem()
        {
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("VisualizarTodosServicos", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbServico = new DataTable();
                    adaptador.Fill(dtbServico);
                    dataViewServicos.DataSource = dtbServico;
                    dataViewServicos.Columns[0].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            
        }

        private frmCadastrarServico ExibirNovoFormularioCadastrarServico()
        {
            frmCadastrarServico frmCadastrarServico = new frmCadastrarServico();
            frmCadastrarServico.Show();
            return frmCadastrarServico;
        }

        private void dataViewServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
