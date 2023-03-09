using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DemasiadoTextoException : Exception
    {
        public DemasiadoTextoException():base ("Se sobrepasó la cantidad de caracteres") 
        {
        }
    }
}
