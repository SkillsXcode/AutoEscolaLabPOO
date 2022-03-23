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

                    foreach(DataGridViewRow linha in dataViewListagemVendas.Rows)
                    {
                        //dataViewServicosAdicionados.Rows.RemoveAt(elemento.Index);
                        try
                        {
                            if(VerificarPagamentoListagem((int)linha.Cells[0].Value))
                            {
                                linha.DefaultCellStyle.BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                DateTime dataVencimento = DateTime.Parse(linha.Cells[8].Value?.ToString());
                                DateTime dataAtual = DateTime.Now;

                                if(dataVencimento < dataAtual)
                                {
                                    linha.DefaultCellStyle.BackColor = Color.Red;
                                }
                                                               
                            }
                            Console.WriteLine(linha.Cells[8].Value?.ToString());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message); 
                        }
                                                
                    }
                    dataViewListagemVendas.Columns[0].Visible = false;
                    dataViewListagemVendas.RowHeadersVisible = false;

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
            var confirmacao = MessageBox.Show("Você realmente realizar o pagamento?", "Cuidado!", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                if (dataViewListagemVendas.SelectedRows != null)
                {
                    if (VerificarPagamento())
                    {
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
                                PreencherListagemVenda();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex.Message);
                        }
                        /*Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[1].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[3].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[4].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[7].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[8].Value.ToString());
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value.ToString());*/
                    }
                    else
                    {
                        MessageBox.Show("Já foi pago!");
                    }
                }
            }


            
        }

        private bool VerificarPagamentoListagem(int idVenda) //se foi pago = true, senão = false
        {
            string queryChecagemPagamento = "SELECT COUNT(*) FROM pagamento WHERE fk_idVenda = @p";

            using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
            {
                conexaoMySQL.Open();
                using (MySqlCommand comandoSql = new MySqlCommand(queryChecagemPagamento, conexaoMySQL))
                {                    
                    comandoSql.Parameters.AddWithValue("@p", idVenda);
                    var resultadoBusca = Convert.ToInt32(comandoSql.ExecuteScalar());
                    if (resultadoBusca > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        private bool VerificarPagamento() //se foi pago = true, senão = false
        {
            string queryChecagemPagamento = "SELECT COUNT(*) FROM pagamento WHERE fk_idVenda = @p";

            using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
            {
                conexaoMySQL.Open();
                using (MySqlCommand comandoSql = new MySqlCommand(queryChecagemPagamento, conexaoMySQL))
                {
                    Console.WriteLine((int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
                    comandoSql.Parameters.AddWithValue("@p", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
                    var resultadoBusca = Convert.ToInt32(comandoSql.ExecuteScalar());
                    if (resultadoBusca > 0)
                    {                        
                        return false;
                    }
                    else
                    {               
                        return true;                        
                    }

                }
            }            
        }

        private void dataViewListagemVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //não usar isso aqui
        }

        private void dataViewListagemVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString());
        }
    }
}
