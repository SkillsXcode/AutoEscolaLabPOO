using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscolaTrevo
{
    public partial class frmPopUp : Form
    {
        public frmPopUp()
        {
            InitializeComponent();
        }

        private void lblTextoConfirmacao_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciarClientes();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarCliente();
        }

        private void frmPopUp_Load(object sender, EventArgs e)
        {

        }

        private frmGerenciamentoCliente ExibirNovoFormularioGerenciarClientes()
        {
            this.Close();
            frmGerenciamentoCliente frmClientes = new frmGerenciamentoCliente();
            frmClientes.Show();
            return frmClientes;
        }

        private frmCadastrarCliente ExibirNovoFormularioCadastrarCliente()
        {
            this.Close();
            frmCadastrarCliente frmcadastrarcliente = new frmCadastrarCliente();
            frmcadastrarcliente.Show();
            return frmcadastrarcliente;
        }
    }
}
