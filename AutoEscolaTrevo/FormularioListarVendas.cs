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
using System.Collections.ObjectModel;

namespace AutoEscolaTrevo
{
    public partial class frmListarVendas : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/

        public frmListarVendas()
        {
            InitializeComponent();
        }

        private void FormularioVendas_Load(object sender, EventArgs e)
        {
            PreencherListagemVenda();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmRegistrarNovasVendas_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioAdicionarVendas();
        }

        private void lblSinalMais_Click(object sender, EventArgs e)
        {

        }

        private frmAdicionarVendas ExibirNovoFormularioAdicionarVendas()
        {
            frmAdicionarVendas frmVendas = new frmAdicionarVendas();
            frmVendas.Show();
            frmVendas.ReceberObjetoAnteriorVenda(this);
            return frmVendas;
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
                    dataViewListagemVendas.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }            
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void dataViewListagemVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MudarNomeTxtValorVenda()
        {
            txtResultadoItens.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void MudarNomeLabelValorVenda()
        {            
            lblResultadoValorVenda.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void MudarNomeLabelFormaPagamento()
        { 
            lblResultadoFormaPagamento.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString();            
        }

        private void MudarNomesParcela()
        {
            lblResultadoDataVenda.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[4].Value.ToString();
            lblResultadoValorParcela.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[6].Value.ToString();
            lblResultadoDataVencimento.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[8].Value.ToString();
            lblResultadoQuantidadeParcelas.Text = dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[9].Value.ToString();
        }

        private void MudarVisibilidadeLabels(bool parametro)
        {
            if(parametro == false)
            {
                lblQuantidadeParcelas.Visible = parametro;
                lblResultadoQuantidadeParcelas.Visible = parametro;                
                lblQuantidadeParcelas.Visible = parametro;
                lblResultadoQuantidadeParcelas.Visible = parametro;
                lblDataVenda.Visible = parametro;
                lblResultadoDataVenda.Visible = parametro;
                lblValorParcela.Visible = parametro;
                lblResultadoValorParcela.Visible = parametro;
                lblDataVencimento.Visible = parametro;
                lblResultadoDataVencimento.Visible = parametro;
            }
            else
            {
                lblQuantidadeParcelas.Visible = parametro;
                lblResultadoQuantidadeParcelas.Visible = parametro;
                lblQuantidadeParcelas.Visible = parametro;
                lblResultadoQuantidadeParcelas.Visible = parametro;
                lblDataVenda.Visible = parametro;
                lblResultadoDataVenda.Visible = parametro;
                lblValorParcela.Visible = parametro;
                lblResultadoValorParcela.Visible = parametro;
                lblDataVencimento.Visible = parametro;
                lblResultadoDataVencimento.Visible = parametro;
            }            
        }

        private void MudarModoExibicao(string tipoPagamento)
        {

            if(tipoPagamento.Contains("VISTA"))
            {
                MudarVisibilidadeLabels(false);
                //lblDataVenda; lblValorParcela; lblDataVencimento
                MudarNomeLabelValorVenda();
                MudarNomeTxtValorVenda();
                MudarNomeLabelFormaPagamento();

            }
            else if(tipoPagamento.Contains("PRAZO"))
            {
                MudarVisibilidadeLabels(true);
                MudarNomeLabelFormaPagamento();
                MudarNomesParcela();


            } else
            {
                MessageBox.Show("Confirme o tipo de pagamento, no cadastro!");
            }
            Console.WriteLine(tipoPagamento);
        }

        private void dataViewListagemVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MudarModoExibicao(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString());
            
            
            
            //MudarNomeLabelFormaPagamento();
            

            //if()
            //Console.WriteLine(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[3].Value.ToString());
            //MudarNomeLabelCliente();
        }

        private void MudarNomeLabelCliente()
        {
            try
            {
                MySqlConnection conexaoLocal = new MySqlConnection(conexao);
                conexaoLocal.Open();
                MySqlCommand comandoSql = new MySqlCommand("SELECT * FROM cliente WHERE id = @id;");
                comandoSql.Parameters.AddWithValue("@id", Convert.ToInt32(dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[2].Value.ToString()));
                MySqlDataReader leitor = comandoSql.ExecuteReader(); 
                while(leitor.Read())
                {
                    Console.WriteLine(leitor.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Erro no banco: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);            
            }
        }

        /*
         private bool VerificarPagamentoListagem(int idVenda) //se foi pago = true, senão = false
        {
            string queryChecagemPagamento = "SELECT COUNT(*) FROM pagamento WHERE fk_idVenda = @p";

            using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
            {
                conexaoMySQL.Open();
                using (MySqlCommand comandoSql = new MySqlCommand(queryChecagemPagamento, conexaoMySQL))
                {
                    Console.WriteLine((int)dataViewListagemVendas.Rows[dataViewListagemVendas.CurrentRow.Index].Cells[0].Value);
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
         
         */
    }
}
