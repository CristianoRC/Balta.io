using System;

namespace ContextoDePagamento.Compartilhado.Entidades
{
    public abstract class Entidade
    {
        public Entidade()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}