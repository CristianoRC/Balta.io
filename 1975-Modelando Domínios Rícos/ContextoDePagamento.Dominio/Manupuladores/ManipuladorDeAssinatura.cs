using ContextoDePagamento.Compartilhado.Comandos;
using ContextoDePagamento.Compartilhado.Manupuladores;
using ContextoDePagamento.Dominio.Entidades;
using Flunt.Notifications;

namespace ContextoDePagamento.Dominio.Manupuladores
{
    public class ManipuladorDeAssinatura : Notifiable, IManipulador<Assinatura>
    {
        public IResultadoComando Manipula(Assinatura comando)
        {
            throw new System.NotImplementedException();
        }
    }
}