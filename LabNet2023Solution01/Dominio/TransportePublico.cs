using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class TransportePublico
    {
        public string nombre { get; set; }
        public int pasajeros { get; set; }

        public TransportePublico(int pasajeros, string nombre)
        {
            this.pasajeros = pasajeros;
            this.nombre = nombre;
        }

        public abstract string Informacion();
        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
