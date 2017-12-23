using System.Text.RegularExpressions;

namespace ContextoDePagamento.Dominio.Validacoes
{
    public static class RG
    {
        public static bool Validar(string RG)
        {
            return Regex.IsMatch(RG, @"[0-9]{1}?\.[0-9]{3}?\.[0-9]{3}?");
        }
    }
}