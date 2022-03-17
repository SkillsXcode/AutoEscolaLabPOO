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
    }
}
