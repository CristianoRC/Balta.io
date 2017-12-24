using System.Text.RegularExpressions;
using ContextoDePagamento.Compartilhado.ObjeosDeValor;
using ContextoDePagamento.Dominio.Enumeradores;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Documento : ObjetoDeValor
    {
        public string ValorDoumento { get; private set; }
        public EDocumento Tipo { get; private set; }

        public Documento(string valorDoumento, EDocumento tipo)
        {
            if (tipo == EDocumento.CPF)
            {
                var CPFvalido = validarCPF(valorDoumento);

                if (!CPFvalido)
                    AddNotification("Documento.ValorDocumento", "CPF inválido");
            }
            else
            {
                var RGvalido = validarRG(valorDoumento);

                if (!RGvalido)
                    AddNotification("Documento.ValorDocumento", "RG inválido");
            }

            this.ValorDoumento = valorDoumento;
            this.Tipo = tipo;
        }


        //Validações somente de exemplo
        private bool validarCPF(string CPF)
        {
            return Regex.IsMatch(CPF, @"(^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$)");
        }

        private bool validarRG(string RG)
        {
            return Regex.IsMatch(RG, @"[0-9]{1}?\.[0-9]{3}?\.[0-9]{3}?");
        }
    }
}