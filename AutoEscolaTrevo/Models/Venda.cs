using System;
using System.Globalization;
using System.Threading;


namespace AutoEscolaTrevo.Models
{
    public class Venda
    {
        private double valorVenda;
        private DateTime dataVencimento;
        private int numeroParcelas;
        private double valorParcela;
        private double valorEntrada;
        private DateTime dataVenda;
        private FormaPagamento formaPagamento;
        //private ItemServico List<Itens> itens = new List<Itens>();
        private Cliente cliente;
        private Pagamento pagamento;
        

        public Venda(double valorVenda, DateTime dataVencimento, int numeroParcelas, double valorParcela, double valorEntrada, DateTime dataVenda, FormaPagamento formaPagamento, ItemServico itens, Cliente cliente, Pagamento pagamento)
        {
            this.formaPagamento = formaPagamento;
            this.dataVencimento = dataVencimento;
            this.valorParcela = valorParcela;
            this.valorVenda = valorVenda;
            this.valorEntrada = valorEntrada;
            this.dataVenda = dataVenda;
            //this.List.Add(itens);
            this.cliente = cliente;
            this.pagamento = pagamento;
        }

        public double getValorVenda()
        {
            return valorVenda;
        }

        public DateTime getDataVencimento()
        {
            return dataVencimento;
        }
        
        public int getNumeroParcelas()
        {
            return numeroParcelas;
        }
        
        public double getValorParcela()
        {
            return valorParcela;
        }
        
        public double getValorEntrada()
        {
            return valorEntrada;
        }
        
        public DateTime getDataVenda()
        {
            return dataVenda;
        }
        
        public FormaPagamento getFormaPagamento()
        {
            return formaPagamento;
        }
        
        public Cliente getCliente()
        {
            return cliente;
        }
        
        public Pagamento getPagamento()
        {
            return pagamento;
        }      
    }
}
