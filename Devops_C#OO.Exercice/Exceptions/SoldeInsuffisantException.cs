using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Exercice.Exceptions
{
    internal class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : this("Solde insuffisant")
        {
        }

        public SoldeInsuffisantException(string? message) : base(message)
        {
        }
    }
}
