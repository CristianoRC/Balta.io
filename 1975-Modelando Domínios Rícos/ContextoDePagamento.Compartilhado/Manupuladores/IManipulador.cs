using ContextoDePagamento.Compartilhado.Comandos;

namespace ContextoDePagamento.Compartilhado.Manupuladores
{
    public interface IManipulador<T> where T : IComando
    {
        IResultadoComando Manipula(T comando);
    }
}