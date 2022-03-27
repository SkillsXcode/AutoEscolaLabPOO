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
            Console.WriteLine("Total de vendas: ");

            ContarVendasAlterarLabel((int)dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value);
            Console.WriteLine("TP: " + TemPendencias((int)dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value));
            AlterarLabelNomeCliente();
            /*ContarVendas();*/
            
        }

        private void ContarVendasAlterarLabel(int idCliente)
        {
            string query = "SELECT COUNT(*) FROM VENDA WHERE fk_idCliente = @idCliente";

            using (var conexaoMySql = new MySqlConnection(conexao))            
            using (MySqlCommand comando = new MySqlCommand(query, conexaoMySql))
            using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
            {
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                
                DataTable tabelaTemp = new DataTable();
                adaptador.Fill(tabelaTemp);
                lblResultadoQuantidadeVendas.Text = tabelaTemp.Rows[0]["COUNT(*)"].ToString();
                lblResultadoQuantidadeVendas.Visible = true;
                Console.WriteLine("==>" + tabelaTemp.Rows[0]["COUNT(*)"]);
                //lblResultadoNomeCliente.Text = tabelaTemp.Rows[0].ToString();
            }
            //repensar a consulta na tabela correta ^^
            //dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value.ToString()
        }

        private void AlterarLabelNomeCliente()
        {            
            lblResultadoNomeCliente.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value.ToString();
            lblResultadoNomeCliente.Visible = true;
        }

        private string TemPendencias(int idCliente)
        {
            try
            {
                string query = "SELECT dataVencimento AS dataV FROM venda WHERE fk_idCliente = @idCliente; ";

                using (var conexaoMySql = new MySqlConnection(conexao))
                using (MySqlCommand comando = new MySqlCommand(query, conexaoMySql))
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                {
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    DataTable tabelaTemp = new DataTable();
                    adaptador.Fill(tabelaTemp);
                    //lblResultadoQuantidadeVendas.Text = tabelaTemp.Rows[0]["dataV"].ToString();
                    //lblResultadoQuantidadeVendas.Visible = true;
                    Console.WriteLine("==>" + tabelaTemp.Rows[0]["dataV"]);
                    //lblResultadoNomeCliente.Text = tabelaTemp.Rows[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }
            
            

            return "Não"; //alterar
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {            
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("ProcurarCliente", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("_CampoBusca", txtBuscarClienteRelatorio.Text);
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
    }
}
