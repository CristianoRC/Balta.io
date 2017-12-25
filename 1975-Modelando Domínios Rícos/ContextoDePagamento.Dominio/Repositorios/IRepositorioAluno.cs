using ContextoDePagamento.Dominio.Entidades;
using ContextoDePagamento.Dominio.Enumeradores;

namespace ContextoDePagamento.Dominio.Repositorios
{
    public interface IAlunoRepositorio
    {
        bool DocumentoExiste(string documento, EDocumento tipoDocumento);
        bool EmailExiste(string email);
        void CriarAssinatura(Aluno aluno);
    }
}