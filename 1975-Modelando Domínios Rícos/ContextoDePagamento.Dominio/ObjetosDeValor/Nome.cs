namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Nome
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public Nome(string primeiroNome, string primeiroSobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = primeiroSobrenome;
        }

        public override string ToString() => $"{this.PrimeiroNome} {this.Sobrenome}";
    }
}