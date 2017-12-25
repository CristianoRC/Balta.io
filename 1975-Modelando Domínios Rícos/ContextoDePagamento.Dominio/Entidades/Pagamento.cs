using System;
using System.Collections.Generic;
using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.Entidades
{
    public abstract class Pagamento : Entidade
    {
        public string Numero { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public Documento Documento { get; private set; }
        public string Pagador { get; private set; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }

        public Pagamento(DateTime data, DateTime dataExpiracao, decimal total, decimal totalPago, Documento documento, string pagador, Endereco endereco, Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            Data = data;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPago = totalPago;
            Documento = documento;
            Pagador = pagador;
            Endereco = endereco;
            Email = email;

            AddNotifications(new Contract()
            .Requires()
            .IsLowerOrEqualsThan(0, Total, "Pagamento.Total", "O total não pode ser Zero")
            .IsGreaterOrEqualsThan(Total, TotalPago, "Pagamento.TotalPago", "O valor pago não pode ser maior que o total"));
        }
    }
}