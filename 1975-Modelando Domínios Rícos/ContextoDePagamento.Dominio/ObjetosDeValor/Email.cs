using System.Text.RegularExpressions;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Email
    {
        public string Endereco { get; private set; }


        public Email(string endereco)
        {
            if (Regex.IsMatch(endereco, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                this.Endereco = endereco;
            }
            else
            {
                throw new System.Exception("Email inválido");
            }
        }
    }
}