using System;
using System.Collections.Generic;

namespace ContextoDePagamento.Dominio.Entidades
{
    public abstract class Pagamento
    {
        public string Numero { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Documento { get; private set; }
        public string Pagador { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }

        public Pagamento(DateTime data, DateTime dataExpiracao, decimal total, decimal totalPago, string documento, string pagador, string endereco, string email)
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
        }
    }
}