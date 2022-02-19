using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Cliente
    {
        private bool status;
        private string cpf;
        private string numeroIdentidade;
        private string nomeCliente;
        private string dataNascimento;

        public Cliente(bool status, string cpf, string numeroIdentidade, string nomeCliente, string dataNascimento)
        {
            this.status = status;
            this.cpf = cpf;
            this.numeroIdentidade = numeroIdentidade;
            this.nomeCliente = nomeCliente;
            this.dataNascimento = dataNascimento;
        }

        public string getStatus()
        {
            return status;
        }

        public string getCpf()
        {
            return cpf;
        }

        public string getNumeroIdentidade()
        {
            return numeroIdentidade;
        }

        public string getNomeCliente()
        {
            return nomeCliente;
        }

        public string getDataNascimento()
        {
            return dataNascimento;
        }
    }
}
