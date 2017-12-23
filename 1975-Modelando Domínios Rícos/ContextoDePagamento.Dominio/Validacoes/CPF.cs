using System.Text.RegularExpressions;

namespace ContextoDePagamento.Dominio.Validacoes
{
    public class CPF
    {
        public static bool Validar(string CPF)
        {
            return Regex.IsMatch(CPF, @"(^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$)");
        }
    }
}