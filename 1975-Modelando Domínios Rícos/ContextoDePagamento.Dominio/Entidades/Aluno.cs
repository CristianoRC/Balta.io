using System.Collections.Generic;
using System.Linq;
using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Aluno : Entidade
    {
        private IList<Assinatura> _assinaturas;
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }

        public Aluno(Nome nome, Email email, Documento documento)
        {
            Nome = nome;
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

        public override string ToString() => Nome.ToString();
    }
}