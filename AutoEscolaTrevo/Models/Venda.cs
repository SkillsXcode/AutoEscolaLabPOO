using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace AutoEscolaTrevo.Models
{
    public class Venda
    {
        ItenServico iten = new ItenServico();
        List<ItenServico> itenservico = new List<ItenServico>();

        Pagamento pag = new Pagamento();
        List<Pagamento> ListaPagamento = new List<Pagamento>();


        private double valorVenda;
        private DateTime dataVenda;
        private FormaPagamento formaPagamento;
        private DateTime dataVencimento;
        private int numeroParcelas;
        private double valorParcela;
        private double valorEntrada;
        private Cliente cliente;
        private Pagamento pagamento;
        public object List { get; private set; }

        public Venda(double valorVenda, DateTime dataVencimento, int numeroParcelas, double valorParcela, double valorEntrada, DateTime dataVenda, FormaPagamento formaPagamento, ItemServico itens, Cliente cliente, Pagamento pagamento)
        {
            this.formaPagamento = formaPagamento;
            this.dataVencimento = dataVencimento;
            this.valorParcela = valorParcela;
            this.valorVenda = valorVenda;
            this.valorEntrada = valorEntrada;
            this.dataVenda = dataVenda;
            this.cliente = cliente;
            this.pagamento = pagamento;
            this.numeroParcelas = numeroParcelas;
            this.itenservico = itenservico;
            this.ListaPagamento = ListaPagamento;
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

    internal class ItenServico
    {
    }
    internal class Pagamento
    {

    }
}
