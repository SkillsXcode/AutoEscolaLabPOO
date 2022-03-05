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
            /*dataViewServicosAdicionados.Rows.Clear();
            dataViewServicosAdicionados.Columns.Add("id", "nomeServico", "valorServico", "valorMinino", "taxaServico", "codigoServico");
            for (int i = 0; i< dataViewServicos.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataViewServicos.Rows[i].Cells[0].Value) == true)
                {
                    int col = dataViewServicosAdicionados.Rows.Add();
                    dataViewServicosAdicionados.Rows[col].Cells[0].Value = dataViewCliente.Rows[col].Cells[1].Value.ToString();
                    dataViewServicosAdicionados.Rows[col].Cells[1].Value = dataViewCliente.Rows[col].Cells[2].Value.ToString();
                    dataViewServicosAdicionados.Rows[col].Cells[2].Value = dataViewCliente.Rows[col].Cells[3].Value.ToString();
                    dataViewServicosAdicionados.Rows[col].Cells[3].Value = dataViewCliente.Rows[col].Cells[4].Value.ToString();
                    dataViewServicosAdicionados.Rows[col].Cells[4].Value = dataViewCliente.Rows[col].Cells[5].Value.ToString();
                    dataViewServicosAdicionados.Rows[col].Cells[5].Value = dataViewCliente.Rows[col].Cells[6].Value.ToString();

                }

            }*/
        }

        private void MudarNomeLabelCliente()
        {
            //Console.WriteLine(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value);
            lblNomeCliente.Text = dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value.ToString();




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
    }
}
