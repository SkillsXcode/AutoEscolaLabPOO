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
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //instanciar um datagridview como popup
        }

        private void frmAdicionarVendas_Load(object sender, EventArgs e)
        {
            //lembrar de gerar data de vencimento :D
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
    }
}
