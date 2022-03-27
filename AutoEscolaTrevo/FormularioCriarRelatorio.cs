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
    public partial class FormularioCriarRelatorio : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;

        public FormularioCriarRelatorio()
        {
            InitializeComponent();
        }

        private void FormularioCriarRelatorio_Load(object sender, EventArgs e)
        {
            PreencherListagemCliente();
        }

        private void PreencherListagemCliente()
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
                    dataViewCliente.Columns[6].Visible = false;
                    dataViewCliente.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void dataViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value.ToString());

            ContarVendas();
            TemPendencias();
        }

        private int ContarVendas()
        {
            return -1; //alterar
        }

        private bool TemPendencias()
        {
            return true; //alterar
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
