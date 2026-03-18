using System;

namespace CadastroAluno
{
    public class CadastroInvalidoException : Exception
    {
        public CadastroInvalidoException(string mensagem) : base(mensagem)
        {
        }
    }
}