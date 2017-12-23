using System;

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
            string documento,
            string pagador,
            string endereco,
            string email) : base(
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