using System;
using Flunt.Notifications;

namespace ContextoDePagamento.Compartilhado.Entidades
{
    public abstract class Entidade : Notifiable
    {
        public Entidade()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}