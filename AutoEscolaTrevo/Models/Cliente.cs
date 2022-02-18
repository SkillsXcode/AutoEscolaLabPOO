using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Cliente
    {
        private bool status { get;}
        private string cpf { get;}
        private string numeroIdentidade { get;}
        private string nomeCliente { get;}
        private string dataNascimento { get;}

        public Cliente(bool status, string cpf, string numeroIdentidade, string nomeCliente, string dataNascimento)
        {
            this.status = status;
            this.cpf = cpf;
            this.numeroIdentidade = numeroIdentidade;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
        }
    }
}
