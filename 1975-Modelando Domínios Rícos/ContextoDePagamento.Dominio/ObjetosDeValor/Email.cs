using System.Text.RegularExpressions;
using ContextoDePagamento.Compartilhado.ObjeosDeValor;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Email : ObjetoDeValor
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            this.Endereco = endereco;

            AddNotifications(new Contract()
            .Requires()
            .IsEmail(Endereco, "Email.Endereco", "Email inválido"));
        }
    }
}