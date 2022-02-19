using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public class Cliente
    {
        private bool status;
        private string nomeCliente;
        private string cpf;
        private string numeroIdentidade;
        private DateTime dataExpedicaoIdentidade;        
        private DateTime dataNascimento;

        public Cliente(bool status, string nomeCliente, string cpf, string numeroIdentidade, DateTime dataExpedicaoIdentidade, DateTime dataNascimento)
        {
            this.status = status;
            this.nomeCliente = nomeCliente;
            this.cpf = cpf;
            this.numeroIdentidade = numeroIdentidade;
            this.dataExpedicaoIdentidade = dataExpedicaoIdentidade;
            this.dataNascimento = dataNascimento;
        }

        public bool getStatus()
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

        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }

        public DateTime getDataExpedicaoIdentidade()
        {
            return dataExpedicaoIdentidade;
        }
    }
}
