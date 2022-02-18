using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Pagamento
    {
        public DateTime dataPagamento { get;}
        public bool status { get;}

        public Pagamento(DateTime dataPagamento, bool status)
        {
            this.dataPagamento = dataPagamento;
            this.status = status;
        }
    }
}
