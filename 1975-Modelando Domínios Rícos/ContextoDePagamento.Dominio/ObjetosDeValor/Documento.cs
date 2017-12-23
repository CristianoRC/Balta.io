using ContextoDePagamento.Dominio.Enumeradores;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Documento
    {
        public string ValorDoumento { get; private set; }
        public EDocumento Tipo { get; private set; }

        public Documento(string valorDoumento, EDocumento tipo)
        {
            if (tipo == EDocumento.CPF)
            {
                var CPFvalido = Validacoes.CPF.Validar(valorDoumento);

                if (!CPFvalido)
                    throw new System.Exception("CPF inválido");
            }
            else
            {
                var RGvalido = Validacoes.RG.Validar(valorDoumento);

                if (!RGvalido)
                    throw new System.Exception("CPF inválido");
            }

            this.ValorDoumento = valorDoumento;
            this.Tipo = tipo;
        }
    }
}