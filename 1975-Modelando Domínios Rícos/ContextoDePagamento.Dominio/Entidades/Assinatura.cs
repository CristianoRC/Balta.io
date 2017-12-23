using System;
using System.Collections.Generic;
using System.Linq;
using ContextoDePagamento.Compartilhado.Entidades;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Assinatura : Entidade
    {
        IList<Pagamento> _pagamentos;

        public DateTime DataDeCriacao { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        public DateTime? DataDeExpiracao { get; private set; }
        public bool Ativa { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get { return _pagamentos.ToArray(); } }

        public Assinatura(DateTime? dataDeExpiracao)
        {
            DataDeCriacao = DateTime.Now;
            DataUltimaAtualizacao = DateTime.Now;
            DataDeExpiracao = dataDeExpiracao;
            Ativa = true;

            _pagamentos = new List<Pagamento>();
        }

        public void Ativar()
        {
            Ativa = true;
            DataUltimaAtualizacao = DateTime.Now;
        }

        public void Desativar()
        {
            Ativa = false;
            DataUltimaAtualizacao = DateTime.Now;
        }

        public void AddicionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }
    }
}