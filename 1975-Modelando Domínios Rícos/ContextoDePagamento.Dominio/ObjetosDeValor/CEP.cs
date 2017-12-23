using System;
using System.Text.RegularExpressions;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class CEP
    {
        public uint NumeroCEP { get; private set; }

        public CEP(string CEP)
        {
            if (Validacoes.CEP.Validar(CEP))
            {
                NumeroCEP = Convert.ToUInt32(CEP);
            }
            else
            {
                throw new Exception("CEP inválido");
            }
        }

        public string Formatar()
        {
            return NumeroCEP.ToString(@"00000\-000");
        }
    }
}