using System;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public string NomeDoTitular { get; private set; }
        public string NumeroCartao { get; private set; }
        public string UmtimaTransacao { get; private set; }

        public PagamentoCartaoDeCredito(
            string nomeDoTitular,
            string numeroCartao,
            string umtimaTransacao,
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
            NomeDoTitular = nomeDoTitular;
            NumeroCartao = numeroCartao;
            UmtimaTransacao = umtimaTransacao;
        }
    }
}