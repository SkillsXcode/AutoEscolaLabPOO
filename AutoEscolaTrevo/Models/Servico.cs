using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace AutoEscolaTrevo.Models
{
    public class Servico
    {
        List<Servico> servicos = new List<Servico>();

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
            this.servicos = servicos;
        }

        public Servico()
        {
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
