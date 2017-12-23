using ContextoDePagamento.Dominio.Enumeradores;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Endereco
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
        }
    }
}