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
    public partial class frmGerenciamentoGeral : Form
    {
        public frmGerenciamentoGeral()
        {
            InitializeComponent();
        }

        private void btnGerenciarServicos_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciarServicos();
        }

        private void frmGerenciamentoGeral_Load(object sender, EventArgs e)
        {

        }

        private frmGerenciamentoServicos ExibirNovoFormularioGerenciarServicos()
        {
            frmGerenciamentoServicos frmServicos = new frmGerenciamentoServicos();
            frmServicos.Show();
            return frmServicos;
        }

        private frmGerenciamentoCliente ExibirNovoFormularioGerenciarClientes()
        {
            frmGerenciamentoCliente frmClientes = new frmGerenciamentoCliente();
            frmClientes.Show();
            return frmClientes;
        }

        private void btnGerenciarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciarClientes();
        }
    }
}
