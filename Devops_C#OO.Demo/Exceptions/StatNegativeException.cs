using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops_C_OO.Demo.Exceptions
{
    public class StatNegativeException : Exception
    {
        public StatNegativeException() : base("La stat ne peut être négative")
        {
        }

        public StatNegativeException(string? message) : base(message)
        {
        }
    }
}
