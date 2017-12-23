using ContextoDePagamento.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Testes.Entidades
{
    [TestClass]
    public class AlunoTeste
    {
        [TestMethod]
        public void X()
        {
            var aluno = new Aluno(
                "Cristiano",
                "R. Cunha",
                "Contato@cristianoprogramador.com",
                "1568315861");

            Assert.AreEqual("Cristiano R. Cunha", aluno.ToString());
        }
    }
}