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
    public partial class frmEditarCliente : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=mysql;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           /* using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
            {
                conexaoMySQL.Open();
                MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarCliente", conexaoMySQL);
                comandoMySQL.CommandType = CommandType.StoredProcedure;

                Console.WriteLine(idCliente);
                
                
                //idCliente = Convert.ToInt32(dataViewCliente.CurrentRow.Cells[0].Value.toString();

                comandoMySQL.ExecuteNonQuery();
                MessageBox.Show("Cliente Editado com Sucesso!");
                
            }*/
            this.Close();
            
        }
    }
    }

