using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class PagamentoaVista : Pagamento
    {
        public double valorPago {get;}
        public double valorDesconto {get;}

        public PagamentoaVista(double valorPago, double valorDesconto)
        {
            this.valorPago = valorPago;
            this.valorDesconto = valorDesconto;
        }
    }
}
