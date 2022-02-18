using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Venda
    {
        public double valorVenda { get;}
        public DateTime dataVencimento { get;}
        public int numeroParcelas { get; }
        public double valorParcela { get;}
        public double valorEntrada { get;}
        public DateTime dataVenda { get;}
        public FormaPagamento formaPagamento { get;}
        public ItemServico List<Itens> itens = new List<Itens>();
        public Cliente cliente { get;}
        public Pagamento pagamento { get;}
        

        public Venda(double valorVenda, DateTime dataVencimento, int numeroParcelas, double valorParcela, double valorEntrada, DateTime dataVenda, FormaPagamento formaPagamento, ItemServico itens, Cliente cliente, Pagamento pagamento)
        {
            this.formaPagamento = formaPagamento;
            this.dataVencimento = dataVencimento;
            this.valorParcela = valorParcela;
            this.valorVenda = valorVenda;
            this.valorEntrada = valorEntrada;
            this.dataVenda = dataVenda;
            this.List.Add(itens);
            this.cliente = cliente;
            this.pagamento = pagamento;
        }
    }
}
