using System;
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public Nome NomeDoTitular { get; private set; }
        public string NumeroCartao { get; private set; }
        public string UmtimaTransacao { get; private set; }

        public PagamentoCartaoDeCredito(
            Nome nomeDoTitular,
            string numeroCartao,
            string umtimaTransacao,
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
            NomeDoTitular = nomeDoTitular;
            NumeroCartao = numeroCartao;
            UmtimaTransacao = umtimaTransacao;
        }
    }
}