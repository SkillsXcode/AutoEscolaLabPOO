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
    public partial class frmAdicionarVendas : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idVenda = 0;
        private int contLinServAdc = 0; //Contador Linha Servico Adicionado
        private double contGloValTot = 0; //Contador Global do Valor Total de Venda
        private frmListarVendas vendaGlobal;

        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void frmAdicionarVendas_Load(object sender, EventArgs e)
        {            
            PreencherListagemServicos();
            PreencherListagemClientes();
            ClonarEstiloTabelaServico();

            //lembrar de fazer uma função para gerar data de vencimento, caso seja carnê :D
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Tem certeza que deseja SAIR da área de Registrar Vendas?", "Tem certeza?", MessageBoxButtons.YesNo);
            if(confirmacao == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void lblServicosAdicionados_Click(object sender, EventArgs e)
        {

        }

        private void PreencherListagemServicos()
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
                    dataViewServicos.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void PreencherListagemClientes()
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
                    dataViewCliente.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            if (dataViewServicos.CurrentRow != null)
            {
                dataViewServicosAdicionados.Rows.Add();                
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[0].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[0].Value.ToString();
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[1].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[1].Value.ToString();
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[2].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[2].Value.ToString();
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[3].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[3].Value.ToString();
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[4].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[4].Value.ToString();
                dataViewServicosAdicionados.Rows[contLinServAdc].Cells[5].Value = dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[5].Value.ToString();               
                contLinServAdc++;
                ManipularLabelValorTotal((double)dataViewServicos.Rows[dataViewServicos.CurrentRow.Index].Cells[2].Value);
                MudarLabelTotalParcela();
            }                      
            
        }

        private void MudarNomeLabelCliente()
        {            
            lblNomeCliente.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void MudarLabelTotalParcela()
        {
            if(mskTxtNumeroParcelas.Text != "")
            {
                double total = CalcularParcela(Convert.ToInt32(mskTxtNumeroParcelas.Text));

                lblResultadoValorParcela.Text = total.ToString();
            }
            
        }

        private void ClonarEstiloTabelaServico()
        {
            foreach (DataGridViewColumn coluna in dataViewServicos.Columns)
            {
                dataViewServicosAdicionados.Columns.Add(coluna.Clone() as DataGridViewColumn);
            }
        }

        private void dataViewServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void dataViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblMscNomeCliente_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmAdicionarVendas_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            if (dataViewServicosAdicionados.CurrentRow != null)
            {
                foreach (DataGridViewRow elemento in dataViewServicosAdicionados.SelectedRows)
                {
                    dataViewServicosAdicionados.Rows.RemoveAt(elemento.Index); //alterar para linha inteira
                    ManipularLabelValorTotal(Convert.ToDouble(elemento.Cells[2].Value) * - 1);                    
                }
                MudarLabelTotalParcela();
            }
            if(dataViewServicosAdicionados.RowCount == 0)
            {
                ZerarContador();
            }
        }

        private void ZerarContador()
        {
            contLinServAdc = 0;
        }

        private void ManipularLabelValorTotal(double valorEnviado)
        {            
            contGloValTot += valorEnviado;
            lblValorTotal.Text = contGloValTot.ToString();
            
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

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            
            if(mskTxtNumeroParcelas.Text == "")
            {
                Console.WriteLine("REEEEEEEEEEEEEEEEEEE");
            }
            Console.WriteLine(mskTxtNumeroParcelas.Text);
            if(VerificarTodosCampos() && (Convert.ToDouble(numUpDownValorEntrada.Text) < contGloValTot))
            {
                PreencherCampoServicosAdicionadosBanco();

                try
                {
                    using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                    {
                        Console.WriteLine(PreencherCampoServicosAdicionadosBanco());
                        conexaoMySQL.Open();
                        MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarVenda", conexaoMySQL);
                        comandoMySQL.CommandType = CommandType.StoredProcedure;
                        comandoMySQL.Parameters.AddWithValue("_id", idVenda);
                        comandoMySQL.Parameters.AddWithValue("_itensServico", PreencherCampoServicosAdicionadosBanco());
                        comandoMySQL.Parameters.AddWithValue("_formaPagamento", cmbxTipoPagamento.Text); 
                        comandoMySQL.Parameters.AddWithValue("_fk_idCliente", (int)dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value);
                        comandoMySQL.Parameters.AddWithValue("_dataVenda", AplicarPadraoAmericano(dtpDataVenda.Value).Trim());
                        comandoMySQL.Parameters.AddWithValue("_valorVenda", contGloValTot - Convert.ToDouble(numUpDownValorEntrada.Text)); //valor total menos a entrada
                        //campos referentes às parcelas, cuidado ao mexer aqui
                        if (cmbxTipoPagamento.SelectedIndex > 2)
                        {                            
                            if(mskTxtNumeroParcelas.Text != "")
                            {
                                comandoMySQL.Parameters.AddWithValue("_valorParcela", CalcularParcela(Convert.ToInt32(mskTxtNumeroParcelas.Text)));                            
                            }
                            else
                            {
                                comandoMySQL.Parameters.AddWithValue("_valorParcela", null);
                            }                             
                            comandoMySQL.Parameters.AddWithValue("_valorEntrada", Convert.ToDouble(numUpDownValorEntrada.Text));
                            DateTime dataTemporaria = this.dtpDataVenda.Value;
                            comandoMySQL.Parameters.AddWithValue("_dataVencimento", AplicarPadraoAmericano(AdicionarUmMes(dataTemporaria)));
                            comandoMySQL.Parameters.AddWithValue("_numeroParcelas", Convert.ToInt32(mskTxtNumeroParcelas.Text));
                            comandoMySQL.Parameters.AddWithValue("_parcelasAPagar", Convert.ToInt32(mskTxtNumeroParcelas.Text));
                        }
                        else
                        {
                            comandoMySQL.Parameters.AddWithValue("_valorParcela", null);
                            comandoMySQL.Parameters.AddWithValue("_valorEntrada", null);
                            comandoMySQL.Parameters.AddWithValue("_dataVencimento", null);
                            comandoMySQL.Parameters.AddWithValue("_numeroParcelas", null);
                            comandoMySQL.Parameters.AddWithValue("_parcelasAPagar", null);
                        }                        
                        comandoMySQL.ExecuteNonQuery();
                        MessageBox.Show("Venda Cadastrada com Sucesso!");
                        vendaGlobal.PreencherListagemVenda();
                        idVenda = 0;
                        var confirmacao = MessageBox.Show("Deseja cadastrar outra venda?", "Atenção!", MessageBoxButtons.YesNo);
                        if (confirmacao == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }               
            }
            else
            {
                MessageBox.Show("Insira um valor de entrada menor que o total.");
            }
        }

        private double CalcularParcela(int totalParcelas)
        {
            double totalParcela;

            totalParcela = contGloValTot / totalParcelas;

            return totalParcela;
        }

        private bool VerificarTodosCampos()
        {            
            if (cmbxTipoPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de pagamento!");
                Console.WriteLine("Selecione um tipo de pagamento!");
                return false;
            }
            else if(dataViewServicosAdicionados.CurrentRow == null)
            {
                MessageBox.Show("Selecione, pelo menos, um serviço a ser adcionado!");
                Console.WriteLine("Selecione, pelo menos, um serviço a ser adcionado!");
                return false;
            } else if(dataViewCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Cliente!");
                Console.WriteLine("Selecione um Cliente!");
            } else if(cmbxTipoPagamento.SelectedIndex > 1 && numUpDownValorEntrada.Value < 0)
            {
                MessageBox.Show("Insira um valor válido na Entrada!");
                Console.WriteLine("Insira um valor válido na Entrada!");
                return false;
            } else if(mskTxtNumeroParcelas.Text == "" && cmbxTipoPagamento.SelectedIndex > 1)
            {
                MessageBox.Show("Insira um valor válido nas Parcelas!");
                Console.WriteLine("Insira um valor válido nas Parcelas!");
                return false;
            }
            return true;
        }

        private string PreencherCampoServicosAdicionadosBanco()
        {
            string pseudoListaServicos = "";
            for (int i = 0; i < dataViewServicosAdicionados.Rows.Count; i++)
            {
                pseudoListaServicos += dataViewServicosAdicionados.Rows[i].Cells[1].Value.ToString();
                pseudoListaServicos += "; ";
            }
            return pseudoListaServicos;
        }
        
        public void ReceberObjetoAnteriorVenda(frmListarVendas listarVendas)
        {
            vendaGlobal = listarVendas;            
        }

        private void cmbxTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbxTipoPagamento.SelectedIndex > 1)
            {              
                lblNumeroParcelas.Visible = true;
                mskTxtNumeroParcelas.Visible = true;
                //lblResultadoValorParcela.Text = CalcularParcela(Convert.ToInt32(mskTxtNumeroParcelas.Text)).ToString();
            } 
            else
            {                
                lblNumeroParcelas.Visible = false;
                mskTxtNumeroParcelas.Visible = false;
            }
        }

        private void lblNumeroParcelas_Click(object sender, EventArgs e)
        {

        }

        private void mskTxtNumeroParcelas_TextChanged(object sender, EventArgs e)
        {
            MudarLabelTotalParcela();
        }

        private void mskTxtNumeroParcelas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numUpDownValorEntrada_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataViewServicosAdicionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MudarNomeLabelCliente();
        }
    }
}
