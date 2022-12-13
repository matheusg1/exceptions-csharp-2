using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExceptions2.Exceptions
{
    public class DataInvalidaException : Exception
    {
        public DataInvalidaException(string message) : base(message)
        {
        }
    }
}
