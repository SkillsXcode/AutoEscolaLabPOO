using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class ItemServico
    {
        Servico servico = new Servico();

        private double valorItem;
        private string nomeItem;
        private double taxaServico;
        private int quantidade;

        public ItemServico(double valorItem, string nomeItem, double taxaServico, int quantidade  )
        {
            this.nomeItem = nomeItem;
            this.valorItem = valorItem;
            this.taxaServico = taxaServico;
            this.quantidade = quantidade;
            servico = servico;
        }

        public double getValorItem()
        {
            return valorItem;
        }

        public string getNomeItem()
        {
            return nomeItem;
        }
        
        public double getTaxaServico()
        {
            return taxaServico;
        }
        
        public int getQuantidade()
        {
            return quantidade;
        }      
    }
}
