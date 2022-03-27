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

        private DateTime AdicionarUmMes(DateTime data)
        {
            data = data.AddMonths(1);
            return data;
        }

        private void btnPagarVenda_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Você realmente realizar o pagamento?", "Cuidado!", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {

                if (dataViewListagemVendas.SelectedRows != null)
                {
                    if (dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString().Contains("Carnê"))
                    {

                        var idTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value;
                        var itensServicoTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[1].Value;
                        var formaPagamentoTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value;
                        var fk_idClienteTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[3].Value;
                        var dataVendaTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[4].Value;
                        var valorVendaTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value;
                        var valorParcelaTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value;
                        var valorEntradaTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[7].Value;
                        var dataVencimentoTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[8].Value;
                        var numeroParcelasTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value;
                        var parcelasAPagarTemp = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[10].Value;


                        

                        //persistência temporária
                        //Console.WriteLine("REEE: " + dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value.ToString());
                        if(Convert.ToInt32(parcelasAPagarTemp) > 0) 
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
                                if (dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value != DBNull.Value) comandoMySQL.Parameters.AddWithValue("_valorPagoCarne", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value));
                                comandoMySQL.Parameters.AddWithValue("_multaAtraso", null);
                                comandoMySQL.Parameters.AddWithValue("_valorPagoAVista", null);
                                comandoMySQL.Parameters.AddWithValue("_valorDesconto", null);
                                comandoMySQL.ExecuteNonQuery();
                                PreencherListagemVenda();
                            }
                            using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                            {
                                conexaoMySQL.Open();
                                MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarVenda", conexaoMySQL);
                                comandoMySQL.CommandType = CommandType.StoredProcedure;
                                comandoMySQL.Parameters.AddWithValue("_id", Convert.ToInt32(idTemp));
                                comandoMySQL.Parameters.AddWithValue("_itensServico", itensServicoTemp.ToString());
                                comandoMySQL.Parameters.AddWithValue("_formaPagamento", formaPagamentoTemp.ToString()); //alterar quando for outras formas de pagamento
                                comandoMySQL.Parameters.AddWithValue("_fk_idCliente", Convert.ToInt32(fk_idClienteTemp));                                
                                comandoMySQL.Parameters.AddWithValue("_dataVenda", Convert.ToDateTime(dataVendaTemp.ToString()));
                                comandoMySQL.Parameters.AddWithValue("_valorVenda", Convert.ToDouble(valorVendaTemp));
                                comandoMySQL.Parameters.AddWithValue("_valorParcela", Convert.ToDouble(valorParcelaTemp));
                                comandoMySQL.Parameters.AddWithValue("_valorEntrada", Convert.ToDouble(valorEntradaTemp));
                                if(Convert.ToInt32(parcelasAPagarTemp) == 1)
                                {
                                    comandoMySQL.Parameters.AddWithValue("_dataVencimento", null);
                                }
                                else
                                {
                                    comandoMySQL.Parameters.AddWithValue("_dataVencimento", AdicionarUmMes(Convert.ToDateTime(dataVencimentoTemp.ToString())));
                                }
                                
                                comandoMySQL.Parameters.AddWithValue("_numeroParcelas", Convert.ToInt32(numeroParcelasTemp));
                                comandoMySQL.Parameters.AddWithValue("_parcelasAPagar", (Convert.ToInt32(parcelasAPagarTemp) - 1));                                
                                comandoMySQL.ExecuteNonQuery();
                                MessageBox.Show("Pagamento realizado com Sucesso!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Todas as parcelas foram saldadas!");
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
                        Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[10].Value.ToString());

                        Console.WriteLine("TEMP: " + idTemp);
                        Console.WriteLine("TEMP: " + itensServicoTemp);
                        Console.WriteLine("TEMP: " + formaPagamentoTemp);
                        Console.WriteLine("TEMP: " + fk_idClienteTemp);
                        Console.WriteLine("TEMP: " + dataVendaTemp);
                        Console.WriteLine("TEMP: " + valorVendaTemp);
                        Console.WriteLine("TEMP: " + valorParcelaTemp);
                        Console.WriteLine("TEMP: " + valorEntradaTemp);
                        Console.WriteLine("TEMP: " + dataVencimentoTemp);
                        Console.WriteLine("TEMP: " + numeroParcelasTemp);
                        Console.WriteLine("TEMP: " + parcelasAPagarTemp);

                        PreencherListagemVenda();
                        //Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value.ToString());

                        /*using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                        {
                            conexaoMySQL.Open();
                            MySqlCommand comandoMySQL = new MySqlCommand("AdicionarEditarPagamento", conexaoMySQL);
                            comandoMySQL.CommandType = CommandType.StoredProcedure;
                            comandoMySQL.Parameters.AddWithValue("_id", idPagamento);
                            comandoMySQL.Parameters.AddWithValue("_dataPagamento", AplicarPadraoAmericano(DateTime.Today));
                            comandoMySQL.Parameters.AddWithValue("_fk_idVenda", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
                            comandoMySQL.Parameters.AddWithValue("_sts", true);
                            if(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value != DBNull.Value) comandoMySQL.Parameters.AddWithValue("_valorPagoCarne", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value));
                            comandoMySQL.Parameters.AddWithValue("_multaAtraso", null);
                            comandoMySQL.Parameters.AddWithValue("_valorPagoAVista", null);
                            comandoMySQL.Parameters.AddWithValue("_valorDesconto", null);
                            comandoMySQL.ExecuteNonQuery();                            
                            PreencherListagemVenda();
                        }*/

                        //persistência temporária
                        //Console.WriteLine("REEE: " + dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value.ToString());
                        /*if(Convert.ToInt32(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[13].Value) > 0) 
                        {
                            using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                            {
                                conexaoMySQL.Open();
                                MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarVenda", conexaoMySQL);
                                comandoMySQL.CommandType = CommandType.StoredProcedure;
                                comandoMySQL.Parameters.AddWithValue("_id", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
                                comandoMySQL.Parameters.AddWithValue("_itensServico", dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[1].Value.ToString());
                                comandoMySQL.Parameters.AddWithValue("_formaPagamento", dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString()); //alterar quando for outras formas de pagamento
                                comandoMySQL.Parameters.AddWithValue("_fk_idCliente", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[3].Value);                                
                                comandoMySQL.Parameters.AddWithValue("_dataVenda", Convert.ToDateTime(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[4].Value.ToString()));
                                comandoMySQL.Parameters.AddWithValue("_valorVenda", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value));
                                comandoMySQL.Parameters.AddWithValue("_valorParcela", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value));
                                comandoMySQL.Parameters.AddWithValue("_valorEntrada", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[7].Value));
                                comandoMySQL.Parameters.AddWithValue("_dataVencimento", Convert.ToDateTime(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[8].Value.ToString()));
                                comandoMySQL.Parameters.AddWithValue("_numeroParcelas", (int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value);
                                comandoMySQL.Parameters.AddWithValue("_parcelasAPagar", ((int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[13].Value) - 1);                                
                                comandoMySQL.ExecuteNonQuery();
                                MessageBox.Show("Pagamento realizado com Sucesso!");
                            }
                        }*/

                        /*
                         => Gravar em venda, o abate de uma parcela
                         => Gravar em pagamento, o preço da parcela
                         */
                    }
                    else
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
                                    comandoMySQL.Parameters.AddWithValue("_valorPagoAVista", Convert.ToDouble(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value));
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
            try
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    try
                    {
                        conexaoMySQL.Open();
                        using (MySqlCommand comandoSql = new MySqlCommand(queryChecagemPagamento, conexaoMySQL))
                        {
                            //Console.WriteLine((int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no banco: " + ex.Message);
                        return false;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message);
                return false;
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
