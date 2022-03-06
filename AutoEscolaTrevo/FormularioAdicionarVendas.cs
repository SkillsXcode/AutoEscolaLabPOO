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
        private int idServicoSelecionado = 0;
        private int contLinServAdc = 0; //Contador Linha Servico Adicionado
        private double contGloValTot = 0; //Contador Global do Valor Total de Venda

        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
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

        private void frmAdicionarVendas_Load(object sender, EventArgs e)
        {
            PreencherListagemServicos();
            PreencherListagemClientes();
            ClonarEstiloTabelaServico();

            //lembrar de fazer uma função para gerar data de vencimento :D
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

        private void PreencherListagemClientes()
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
            }                      
            
        }

        private void MudarNomeLabelCliente()
        {
            //Console.WriteLine(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value);
            lblNomeCliente.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value.ToString();




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
            MudarNomeLabelCliente();
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
                    //ManipularLabelValorTotal(((double)elemento.Index) * - 1);
                }
                //ManipularLabelValorTotal(dataViewServicosAdicionados.CurrentRow);
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

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            VerificarTodosCampos();
        }

        private bool VerificarTodosCampos()
        {
            //Console.WriteLine(dtpDataNascimento.Text);
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
            }
            return true;
        }
    }
}
