using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Dominio
{
    public class Logic
    {
    public Exception DisparoEscepcion()
        {
            throw new FormatException();
        }           
    public Exception DisparoExcepcionPersonalizada()
        {
            throw new DemasiadoTextoException();
        }

    }
}  
