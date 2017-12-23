using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextoDePagamento.Dominio;

namespace ContextoDePagamento.Testes.Validacoes
{
    //CPF e RG meramente ilustrativo, foram gerados através de um site.
    //CPF: 817.387.387-95
    //RG : 
    //CEP: 96085-000

    [TestClass]
    public class ValidacoesTeste
    {
        [TestMethod]
        public void TestarCEP()
        {
            var CEPValido = Dominio.Validacoes.CEP.Validar("96085-000");
            var CEPInvalido = Dominio.Validacoes.CEP.Validar("960-5000");

            Assert.AreEqual(true, CEPValido);
            Assert.AreEqual(false, CEPInvalido);
        }

        [TestMethod]
        public void TestarCPF()
        {
            var CPFValido = Dominio.Validacoes.CPF.Validar("030.491.200-02");
            var CPFInvalido = Dominio.Validacoes.CPF.Validar("1254.952-55");

            Assert.AreEqual(true, CPFValido);
            Assert.AreEqual(false, CPFInvalido);
        }

        [TestMethod]
        public void TestarRG()
        {
            var RGValido = Dominio.Validacoes.RG.Validar("39.284.962-8");
            var RGInvalido = Dominio.Validacoes.RG.Validar("6456456456656");

            Assert.AreEqual(true, RGValido);
            Assert.AreEqual(false, RGInvalido);
        }
    }
}