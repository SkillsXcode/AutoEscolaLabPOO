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
using System.Text.RegularExpressions;

namespace AutoEscolaTrevo
{
    public partial class frmGerenciamentoCliente : Form
    {
        private string conexao = @"Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=mysql;"; /* ajustar estes parâmetros para conseguir conectar :D*/
        private int idCliente = 0;
        public frmGerenciamentoCliente()
        {
            InitializeComponent();
        }

        

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarCliente();
            this.Close();
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
            frmCadastrarCliente formularioClienteEdicao = new frmCadastrarCliente();

            formularioClienteEdicao.lblCadastrarCliente.Text = "Editar Cliente";
            formularioClienteEdicao.btnCadastrar.Text = "Editar";
            formularioClienteEdicao.btnVoltarCadastrarCliente.Visible = false;
            formularioClienteEdicao.ShowDialog();

            //formularioClienteEdicao.btnCadastrar_Click
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
                {
                    conexaoMySQL.Open();
                    MySqlCommand comandoMySQL = new MySqlCommand("AdcionarEditarCliente", conexaoMySQL);
                    comandoMySQL.CommandType = CommandType.StoredProcedure;

                    idCliente = Convert.ToInt32(dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[0].Value);
                    comandoMySQL.Parameters.AddWithValue("_id", idCliente);

                    comandoMySQL.Parameters.AddWithValue("_sts", true);
                    comandoMySQL.Parameters.AddWithValue("_nomeCliente", formularioClienteEdicao.txtBoxNome.Text.Trim());
                    comandoMySQL.Parameters.AddWithValue("_cpf", Regex.Replace(formularioClienteEdicao.maskedtxtboxCpf.Text, @"[^0-9a-zA-Z\._]", ""));
                    comandoMySQL.Parameters.AddWithValue("_numeroIdentidade", formularioClienteEdicao.txtBoxRg.Text.Trim());
                    comandoMySQL.Parameters.AddWithValue("_dataExpedicaoIdentidade", formularioClienteEdicao.AplicarPadraoAmericano(formularioClienteEdicao.dtpDataExpedicao.Value).Trim());
                    comandoMySQL.Parameters.AddWithValue("_dataNascimento", formularioClienteEdicao.AplicarPadraoAmericano(formularioClienteEdicao.dtpDataNascimento.Value).Trim());
                    comandoMySQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente Editado com Sucesso!");
                }
            


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
            var msg = MessageBox.Show("Tem certeza que deseja excluir o cliente " + (dataViewCliente.Rows[dataViewCliente.CurrentRow.Index].Cells[1].Value) + " ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                using (MySqlConnection conexaoMySQL = new MySqlConnection(conexao))
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
                this.Close();
            } else
            {
                this.Close();
            }
            
        }

        private void btnVoltarGerenciarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
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
