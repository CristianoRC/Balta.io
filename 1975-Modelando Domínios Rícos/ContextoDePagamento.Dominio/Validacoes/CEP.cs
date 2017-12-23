using System.Text.RegularExpressions;

namespace ContextoDePagamento.Dominio.Validacoes
{
    public class CEP
    {
        public static bool Validar(string CEP)
        {
            return Regex.IsMatch(CEP, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}