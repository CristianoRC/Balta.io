using ContextoDePagamento.Compartilhado.Comandos;

namespace ContextoDePagamento.Dominio.Comandos
{
    public class ResultadoComando : IResultadoComando
    {

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }

        public ResultadoComando(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public ResultadoComando() { }

    }
}