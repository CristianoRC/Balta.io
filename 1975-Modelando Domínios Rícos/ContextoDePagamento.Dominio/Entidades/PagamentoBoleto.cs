using System;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoDeBarras { get; private set; }
        public string NumeroBoleto { get; private set; }

        public PagamentoBoleto(
            string codigoDeBarras,
            string numeroBoleto,
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
            CodigoDeBarras = codigoDeBarras;
            NumeroBoleto = numeroBoleto;
        }
    }
}