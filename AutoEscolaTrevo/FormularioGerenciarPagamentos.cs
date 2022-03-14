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
    public partial class frmGerenciarPagamentos : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idPagamento = 0;
        public frmGerenciarPagamentos()
        {
            InitializeComponent();
        }

        private void frmGerenciarPagamentos_Load(object sender, EventArgs e)
        {
            PreencherListagemVenda();
            /*criar função para colorir os pagos, através de consulta no banco e 
             * travar a inserção de pagamentos neste método ^^             
             */ 
        }

        public void PreencherListagemVenda()
        {
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("VisualizarTodasVendas", conexaoMySQL);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbVenda = new DataTable();
                    adaptador.Fill(dtbVenda);
                    dataViewListagemVendas.DataSource = dtbVenda;
                    dataViewListagemVendas.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string AplicarPadraoAmericano(DateTime data)
        {
            string dia = data.Day.ToString(), mes = data.Month.ToString(), ano = data.Year.ToString();
            if (data.Month >= 1 && data.Month <= 9)
            {
                mes = "0" + mes;
            }
            string dataAmericana = ano + "/" + mes + "/" + dia;


            return dataAmericana;
        }

        private void btnPagarVenda_Click(object sender, EventArgs e)
        {
            if(dataViewListagemVendas.SelectedRows != null)
            {

                /*
                    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    dataPagamento DATE,
                    fk_idVenda INT,
                    FOREIGN KEY (`fk_idVenda`) REFERENCES venda(`id`),
                    sts BOOLEAN,
                    valorPagoCarne DOUBLE,
                    multaAtraso DOUBLE,
                    valorPagoAVista DOUBLE,
                    valorDesconto DOUBLE
                 */

                try
                {
                    using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                    {
                        conexaoMySQL.Open();
                        MySqlCommand comandoMySQL = new MySqlCommand("AdicionarEditarPagamento", conexaoMySQL);
                        comandoMySQL.CommandType = CommandType.StoredProcedure;
                        comandoMySQL.Parameters.AddWithValue("_id", idPagamento);
                        comandoMySQL.Parameters.AddWithValue("_dataPagamento", AplicarPadraoAmericano(DateTime.Today));
                        comandoMySQL.Parameters.AddWithValue("_fk_idVenda", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
                        comandoMySQL.Parameters.AddWithValue("_sts", true);
                        comandoMySQL.Parameters.AddWithValue("_valorPagoCarne", null);
                        comandoMySQL.Parameters.AddWithValue("_multaAtraso", null);
                        comandoMySQL.Parameters.AddWithValue("_valorPagoAVista", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value));
                        comandoMySQL.Parameters.AddWithValue("_valorDesconto", null);
                        comandoMySQL.ExecuteNonQuery();
                        MessageBox.Show("Pagamento realizado com Sucesso!");                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }



                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[1].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[3].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[4].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[7].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[8].Value.ToString());
                Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value.ToString());


            }

            



        }
    }
}
