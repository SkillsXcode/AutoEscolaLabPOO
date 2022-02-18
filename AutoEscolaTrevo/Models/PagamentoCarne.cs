using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class PagamentoCarne : Pagamento
    {
        public double valorPago { get;}
        public double multaAtraso { get;}

        public PagamentoCarne(double valorPago, double multaAtraso )
        {
            this.valorPago = valorPago;
            this.multaAtraso = multaAtraso;
        }
    }
}
