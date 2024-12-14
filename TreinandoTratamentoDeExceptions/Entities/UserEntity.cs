using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoTratamentoDeExceptions.Entities
{
    public class UserEntity
    {
        public int idade;
        public int Idade
        {
            get
            {
                return idade;
            } set
            {
                try
                {
                    if (value < 18) {
                          throw new UserException("Exception 1: Idade menor que 18 1");
                    }
                    else
                    {
                        idade = value;
                    }
                    
                }
                catch (UserException ex) 
                {
                  throw new UserException(ex.Message);
                }
                //Sempre usar exception por último
                catch (Exception ex)
                {
                    throw;
                }
                // Deixar apenas o throw, ele vai pra exception especifica!!!
            }
        }
        public string Nome { get; set; }
    }
}
