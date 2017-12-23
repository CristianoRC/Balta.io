using System;
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoPayPal : Pagamento
    {
        public string CodigoTransacao { get; private set; }

        public PagamentoPayPal(
            string codigoTransacao,
            DateTime data,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            Documento documento,
            string pagador,
            Endereco endereco,
            Email email) : base(
                data,
                dataExpiracao,
                total,
                totalPago,
                documento,
                pagador,
                endereco,
                email)
        {
            CodigoTransacao = codigoTransacao;
        }

    }
}