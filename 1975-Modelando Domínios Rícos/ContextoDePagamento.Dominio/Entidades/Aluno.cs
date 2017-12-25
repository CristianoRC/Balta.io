using System.Collections.Generic;
using System.Linq;
using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Flunt.Validations;

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

            AddNotifications(nome, email, documento);
        }

        public void AdicionarAssinatura(Assinatura assinatura)
        {

            bool assinaturaAtiva = false;

            foreach (var item in _assinaturas)
            {
                if (item.Ativa)
                {
                    assinaturaAtiva = true;
                }

            }

            AddNotifications(new Contract()
           .Requires()
           .IsFalse(assinaturaAtiva, "Aluno.Assinaturas", "Você já tem uma assinatura ativa")
           .AreNotEquals(0, assinatura.Pagamentos.Count, "Aluno.Assinatura.Pagamentos", "Esta assinatura não possui pagamentos"));

            if (Valid)
                _assinaturas.Add(assinatura);

        }

        public override string ToString() => Nome.ToString();
    }
}