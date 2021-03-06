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

        private frmListarVendas ExibirNovoFormularioListarVendas()
        {
            frmListarVendas frmVendas = new frmListarVendas();
            frmVendas.Show();
            return frmVendas;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioListarVendas();
        }

        private void btnInserirPagamento_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioInserirPagamento();
        }

        private frmGerenciarPagamentos ExibirNovoFormularioInserirPagamento()
        {
            frmGerenciarPagamentos frmPagamentos = new frmGerenciarPagamentos();
            frmPagamentos.Show();
            return frmPagamentos;
        }

        private FormularioCriarRelatorio ExibirNovoFormularioRelatorio()
        {
            FormularioCriarRelatorio frmRelatorio = new FormularioCriarRelatorio();
            frmRelatorio.Show();
            return frmRelatorio;
        }

        private void btnGerenciarCliente_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciarClientes();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioRelatorio();
        }

        private void btnSairFormularioGeral_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Você realmente deseja sair do sistema?", "Atenção!", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }                
        }
    }
}
