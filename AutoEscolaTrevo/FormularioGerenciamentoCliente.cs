﻿using System;
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
    public partial class frmGerenciamentoCliente : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;
        public frmGerenciamentoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarCliente();
        }

        private void frmGerenciamentoCliente_Load(object sender, EventArgs e)
        {
            PreencherListagem();
        }

        private frmCadastrarCliente ExibirNovoFormularioCadastrarCliente()
        {
            frmCadastrarCliente frmCadastrarCliente = new frmCadastrarCliente();
            frmCadastrarCliente.Show();
            return frmCadastrarCliente;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void PreencherListagem()
        {
            using(MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
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

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
            {
                conexaoMySQL.Open();
                MySqlCommand comandoMySQL = new MySqlCommand("DeletarClienteporID", conexaoMySQL);
                comandoMySQL.CommandType = CommandType.StoredProcedure;
                idCliente = Convert.ToInt32(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value);
                comandoMySQL.Parameters.AddWithValue("_id", idCliente);
                comandoMySQL.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado!");
                PreencherListagem();
            }
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

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
