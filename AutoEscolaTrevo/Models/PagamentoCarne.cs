using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class PagamentoCarne : Pagamento
    {
        private double valorPago;
        private double multaAtraso;

        public PagamentoCarne(double valorPago, double multaAtraso, DateTime dataPagamento, bool status) : base(dataPagamento, status)
        {
            this.valorPago = valorPago;
            this.multaAtraso = multaAtraso;
        }

        public double getValorPago()
        {
            return valorPago;
        }      

        public double getMultaAtraso()
        {
            return multaAtraso;
        }  
    }
}
