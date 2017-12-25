using System;
using System.Collections.Generic;
using ContextoDePagamento.Dominio.Entidades;
using ContextoDePagamento.Dominio.Enumeradores;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Testes.Entidades
{
    [TestClass]
    public class AlunoTeste
    {
        [TestMethod]
        public void ErroAoAtivarAssinaturaDuasAtivas()
        {
            var aluno = new Aluno(
                new Nome("Cristiano", "Cunha"),
                new Email("Contato@cristianoprogramador.com"),
                new Documento("896.350.050-08", EDocumento.CPF));

            aluno.AdicionarAssinatura(new Assinatura(DateTime.Now.AddDays(30)));
            aluno.AdicionarAssinatura(new Assinatura(DateTime.Now.AddDays(15)));

            Assert.IsFalse(aluno.Valid);
        }

        [TestMethod]
        public void ErroAoAtivarAssinaturaSemPagamento()
        {
            var aluno = new Aluno(
                new Nome("Cristiano", "Cunha"),
                new Email("Contato@cristianoprogramador.com"),
                new Documento("896.350.050-08", EDocumento.CPF));

            aluno.AdicionarAssinatura(new Assinatura(DateTime.Now.AddDays(15)));

            Assert.IsFalse(aluno.Valid);
        }

        [TestMethod]
        public void SucessoAoAtivarAssinatura()
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
                150, 0,
                new Documento("896.350.050-08", EDocumento.CPF),
                "Cristiano Cunha",
               endereco,
               new Email("Contato@cristianoprogramador.com"));

            var assinatura = new Assinatura(DateTime.Now.AddDays(30));


            var aluno = new Aluno(
                           new Nome("Cristiano", "Cunha"),
                           new Email("contato@cristianoprogramador.com"),
                           new Documento("896.350.050-08", EDocumento.CPF));

            assinatura.AddicionarPagamento(pagamento);

            aluno.AdicionarAssinatura(assinatura);

            Assert.IsTrue(aluno.Valid);
        }
    }
}