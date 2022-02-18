using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Servico
    {
        public string nomeServico {get;}
        public double valorServico {get;} 
        public double valorMinimo {get;}
        public int codigoServico {get;}
        public double taxaServico {get;}

        public Servico(string nomeServico, double valorServico, double valorMinimo, int codigoServico, double taxaServico)
        {
            this.nomeServico = nomeServico;
            this.valorServico = valorServico;
            this.valorMinimo = valorMinimo;
            this.codigoServico = codigoServico;
            this.taxaServico = taxaServico;
        }
    }
}
