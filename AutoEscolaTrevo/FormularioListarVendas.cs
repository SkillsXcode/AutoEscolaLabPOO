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
    public partial class frmListarVendas : Form
    {
        public frmListarVendas()
        {
            InitializeComponent();
        }

        private void FormularioVendas_Load(object sender, EventArgs e)
        {

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
            return frmVendas;
        }
    }
}
