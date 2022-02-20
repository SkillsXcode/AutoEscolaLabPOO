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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void lblCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            LimparCamposDatas();
            
        }
        
        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDataExpedicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {       
            //Console.WriteLine(dtpDataExpedicao.Text);
            AplicarPadraoAmericano(dtpDataExpedicao.Value);
            if (VerificarTodosCampos())
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("Server=localhost;Database=autoescolatrevo;Uid=root;Pwd=admin");
                    string strSQL = " ";
                    con.Open();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LimparCamposDatas()
        {
            /*dtpDataExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDataExpedicao.CustomFormat = " ";
            dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDataNascimento.CustomFormat = " ";*/
        }

        private bool VerificarTodosCampos()
        {
            //Console.WriteLine(dtpDataNascimento.Text);
            if(txtBoxNome.Text == "" || txtBoxRg.Text == "" || txtBoxCpf.Text == "")
            {
                Console.WriteLine("Existem campos vazios");
                return false;
            }
            return true;
        }

        private string AplicarPadraoAmericano(DateTime data)
        {
            string dia = data.Day.ToString(), mes = data.Month.ToString(), ano = data.Year.ToString();
            if(data.Month >= 1  && data.Month <= 9)
            {
                mes = "0" + mes;
            }
            string dataAmericana = ano + "/" + mes + "/" + dia;

            Console.WriteLine(dataAmericana);
            return dataAmericana;
        }
    }
}
