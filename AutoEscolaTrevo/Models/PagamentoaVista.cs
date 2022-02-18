using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class PagamentoaVista : Pagamento
    {
        private double valorPago;
        private double valorDesconto;

        public PagamentoaVista(double valorPago, double valorDesconto, DateTime dataPagamento, bool status) : base(dataPagamento, status)
        {
            this.valorPago = valorPago;
            this.valorDesconto = valorDesconto;
        }

        public double getValorPago()
        {
            return valorPago;
        }

        public double getValorDesconto()
        {
            return valorDesconto;
        }

    }

}
