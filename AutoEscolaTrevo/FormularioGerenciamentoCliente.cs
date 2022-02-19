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
    public partial class frmGerenciamentoCliente : Form
    {
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

        }

        private frmCadastrarCliente ExibirNovoFormularioCadastrarCliente()
        {
            frmCadastrarCliente frmCadastrarCliente = new frmCadastrarCliente();
            frmCadastrarCliente.Show();
            return frmCadastrarCliente;
        }
        
    }
}
