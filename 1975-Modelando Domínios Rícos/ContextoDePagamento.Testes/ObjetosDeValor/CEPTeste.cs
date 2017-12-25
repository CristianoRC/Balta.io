using ContextoDePagamento.Dominio.ObjetosDeValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Testes.ObjetosDeValor
{
    [TestClass]
    public class CEPTeste
    {
        [TestMethod]
        public void CEPValido()
        {
            var cep = new CEP("96085-000");

            Assert.IsTrue(cep.Valid);
        }

        [TestMethod]
        public void CEPInvalido()
        {
            var cep = new CEP("9654085-000");

            Assert.IsFalse(cep.Valid);
        }
    }
}