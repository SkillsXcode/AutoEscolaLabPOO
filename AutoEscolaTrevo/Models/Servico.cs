using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Servico
    {
        private string nomeServico;
        private double valorServico; 
        private double valorMinimo;
        private int codigoServico;
        private double taxaServico;

        public Servico(string nomeServico, double valorServico, double valorMinimo, int codigoServico, double taxaServico)
        {
            this.nomeServico = nomeServico;
            this.valorServico = valorServico;
            this.valorMinimo = valorMinimo;
            this.codigoServico = codigoServico;
            this.taxaServico = taxaServico;
        }

        public string getNomeServico()
        {
            return nomeServico;
        }

        public double getValorServico()
        {
            return valorServico;
        }

        public double getValorMinimo()
        {
            return valorMinimo;
        }

        public int getCodigoServico()
        {
            return codigoServico;
        }

        public double getTaxaServico()
        {
            return taxaServico;
        }
    }
}
