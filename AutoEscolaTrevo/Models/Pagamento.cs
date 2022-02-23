using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Pagamento
    {
        private DateTime dataPagamento;
        private bool status;

        public Pagamento()
        {
        }

        public Pagamento(DateTime dataPagamento, bool status)
        {
            this.dataPagamento = dataPagamento;
            this.status = status;
        }

        public DateTime getDataPagamento()
        {
            return dataPagamento;
        }

        public bool getStatus()
        {
            return status;
        }
    }
}
