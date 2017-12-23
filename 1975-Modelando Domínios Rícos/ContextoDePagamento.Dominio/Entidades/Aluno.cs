using System.Collections.Generic;
using System.Linq;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Aluno
    {
        private IList<Assinatura> _assinaturas;
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Documento { get; private set; }
        public string Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }

        public Aluno(string nome, string sobrenome, string email, string documento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Documento = documento;

            _assinaturas = new List<Assinatura>();
        }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            //Cancela todas as assinaturas e coloca a nova como principal

            foreach (var item in _assinaturas)
                item.Desativar();


            _assinaturas.Add(assinatura);
        }

        public override string ToString() => $"{Nome} {Sobrenome}";
    }
}