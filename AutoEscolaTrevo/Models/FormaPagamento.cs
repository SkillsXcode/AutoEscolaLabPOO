using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public enum FormaPagamento
    {
        CARNE,
        CARTAO,
        AVISTA
    }
    public class FormaPagamento
    {
        FormaPagamento _carne = FormaPagamento.Carne;
        FormaPagamento _cartao = FormaPagamento.Cartao;
        FormaPagamento _avista = FormaPagamento.Avista;
    }
}