using ContextoDePagamento.Dominio.Enumeradores;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Testes.ObjetosDeValor
{
    [TestClass]
    public class DocumentoTeste
    {
        [TestMethod]
        public void CPFValido()
        {
            var cpf = new Documento("333.173.657-06", EDocumento.CPF);

            Assert.IsTrue(cpf.Valid);
        }

        [TestMethod]
        public void CPFInalido()
        {
            var cpf = new Documento("333.173.65706", EDocumento.CPF);

            Assert.IsFalse(cpf.Valid);
        }

        [TestMethod]
        public void RGValido()
        {
            var rg = new Documento("23.494.703-2", EDocumento.RG);

            Assert.IsTrue(rg.Valid);
        }

        [TestMethod]
        public void RGInvalido()
        {
            var rg = new Documento("23.4947.a98", EDocumento.RG);

            Assert.IsFalse(rg.Valid);
        }
    }
}