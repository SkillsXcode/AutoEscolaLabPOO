using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class ItemServico
    {
        public double valorItem { get;}
        public string nomeItem { get;}
        public double taxaServico { get;}
        public int quantidade { get;}

        public ItemServico(double valorItem, string nomeItem, double taxaServico, int quantidade  )
        {
            this.nomeItem = nomeItem;
            this.valorItem = valorItem;
            this.taxaServico = taxaServico;
            this.quantidade = quantidade;
        }
    }
}
