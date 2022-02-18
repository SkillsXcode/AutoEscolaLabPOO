using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevo.Models
{
    public enum TiposPagamentos
    {
        CARNE,
        CARTAO,
        AVISTA
    }
    public class FormaPagamento
    {
        TiposPagamentos _carne = TiposPagamentos.CARNE;
        TiposPagamentos _cartao = TiposPagamentos.CARTAO;
        TiposPagamentos _avista = TiposPagamentos.AVISTA;
    }
}