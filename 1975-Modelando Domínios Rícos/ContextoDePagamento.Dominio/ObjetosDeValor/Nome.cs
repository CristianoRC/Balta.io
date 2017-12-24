using ContextoDePagamento.Compartilhado.ObjeosDeValor;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Nome : ObjetoDeValor
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
        public Nome(string primeiroNome, string primeiroSobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = primeiroSobrenome;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(PrimeiroNome, 3, "Nome.PrimeiroNome", "O nome deve ter no mínimo três caracteres")
            .HasMinLen(Sobrenome, 3, "Nome.Sobrenome", "O sobrenome deve ter no mínimo três caracteres"));
        }

        public override string ToString() => $"{this.PrimeiroNome} {this.Sobrenome}";
    }
}