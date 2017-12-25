using System;
using ContextoDePagamento.Dominio.Entidades;
using ContextoDePagamento.Dominio.Enumeradores;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Testes.Entidades
{
    [TestClass]
    public class PagamentoTeste
    {
        [TestMethod]
        [DataRow(-12, -12)]
        [DataRow(-0.1, 0.1)]
        public void PagamentoComValoreaMenoresAZero(double valorTotal, double ValorPago)
        {
            var endereco = new Endereco
           (
               new CEP("94100-300"),
               "Teste",
               ELogradouro.avenida,
               "289A",
               "Centro"
           );


            var pagamento = new PagamentoBoleto(
               "4654asd",
               "654684164884684",
               DateTime.Now,
               DateTime.Now.AddDays(5),
               Convert.ToDecimal(valorTotal),
               Convert.ToDecimal(ValorPago),
               new Documento("896.350.050-08", EDocumento.CPF),
               "Cristiano Cunha",
              endereco,
              new Email("Contato@cristianoprogramador.com"));

            Assert.IsTrue(pagamento.Invalid);
        }


        [TestMethod]
        [DataRow(15, 21)]
        [DataRow(10, 17)]
        public void PagamentoComValorPagoMaiorQueOTotal(double valorTotal, double ValorPago)
        {
            var endereco = new Endereco
           (
               new CEP("94100-300"),
               "Teste",
               ELogradouro.avenida,
               "289A",
               "Centro"
           );


            var pagamento = new PagamentoBoleto(
               "4654asd",
               "654684164884684",
               DateTime.Now,
               DateTime.Now.AddDays(5),
               Convert.ToDecimal(valorTotal),
               Convert.ToDecimal(ValorPago),
               new Documento("896.350.050-08", EDocumento.CPF),
               "Cristiano Cunha",
              endereco,
              new Email("Contato@cristianoprogramador.com"));

            Assert.IsTrue(pagamento.Invalid);
        }

        [TestMethod]
        [DataRow(21, 15)]
        [DataRow(17, 17)]
        public void PagamentoComValorMenorOuIgualAoTotal(double valorTotal, double ValorPago)
        {
            var endereco = new Endereco
           (
               new CEP("94100-300"),
               "Teste",
               ELogradouro.avenida,
               "289A",
               "Centro"
           );


            var pagamento = new PagamentoBoleto(
               "4654asd",
               "654684164884684",
               DateTime.Now,
               DateTime.Now.AddDays(5),
               Convert.ToDecimal(valorTotal),
               Convert.ToDecimal(ValorPago),
               new Documento("896.350.050-08", EDocumento.CPF),
               "Cristiano Cunha",
              endereco,
              new Email("Contato@cristianoprogramador.com"));

            Assert.IsTrue(pagamento.Valid);
        }
    }
}