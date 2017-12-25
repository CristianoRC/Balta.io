using System;
using System.Text.RegularExpressions;
using ContextoDePagamento.Compartilhado.ObjeosDeValor;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class CEP : ObjetoDeValor
    {
        public uint NumeroCEP { get; private set; }

        public CEP(string CEP)
        {
            if (Validar(CEP))
            {
                NumeroCEP = Convert.ToUInt32(CEP.ToString().Replace("-", ""));
            }
            else
            {
                AddNotification("CEP.NumeroCEP", "CEP inválido");
            }
        }

        private bool Validar(string CEP)
        {
            if (CEP.Length <= 9)
            {
                return Regex.IsMatch(CEP, ("[0-9]{5}-[0-9]{3}"));
            }
            return false;
        }

        public string Formatar()
        {
            return NumeroCEP.ToString(@"00000\-000");
        }
    }
}