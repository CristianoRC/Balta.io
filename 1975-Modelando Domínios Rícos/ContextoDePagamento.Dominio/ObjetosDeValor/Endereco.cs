using ContextoDePagamento.Compartilhado.ObjeosDeValor;
using ContextoDePagamento.Dominio.Enumeradores;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Endereco : ObjetoDeValor
    {
        public CEP CEP { get; private set; }
        public string Logradouro { get; private set; }
        public ELogradouro Tipo { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Referencia { get; private set; }
        public string Bairro { get; private set; }

        public Endereco(CEP cep, string logradouro, ELogradouro tipo, string numero, string bairro)
        {
            this.CEP = cep;
            this.Logradouro = logradouro;
            this.Tipo = tipo;
            this.Numero = numero;
            this.Bairro = bairro;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(logradouro, 2, "Endereco.Logradouro", "O logradouro deve ter no mínimo 2 caracteres")
            .HasMinLen(numero, 1, "Endereco.Numero", "O Numero deve ter no mínimo 1 caractere")
            .HasMinLen(bairro, 2, "Endereco.Bairro", "O Bairro deve ter no mínimo 2 caracteres")
            );

        }

        public Endereco(
            CEP cep,
            string logradouro,
            ELogradouro tipo,
            string numero,
            string complemento,
            string referencia,
            string bairro)
        {
            this.CEP = cep;
            this.Logradouro = logradouro;
            this.Tipo = tipo;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Referencia = referencia;
            this.Bairro = bairro;

            AddNotifications(new Contract()
           .Requires()
           .HasMinLen(logradouro, 2, "Endereco.Logradouro", "O logradouro deve ter no mínimo 2 caracteres")
           .HasMinLen(numero, 1, "Endereco.Numero", "O Numero deve ter no mínimo 1 caractere")
           .HasMinLen(bairro, 2, "Endereco.Bairro", "O Bairro deve ter no mínimo 2 caracteres")
           );
        }
    }
}