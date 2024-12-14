using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoTratamentoDeExceptions.Entities
{
    public class UserException : Exception
    {
        public const string MENSAGEM_PADRAO = "Idade incorreta";
        public UserException(string? message = MENSAGEM_PADRAO) : base(message)
        {
        }
    }
}
