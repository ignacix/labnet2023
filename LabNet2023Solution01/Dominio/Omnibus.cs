using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros, string nombre) : base(pasajeros,nombre)
        {
        }

        public override string Avanzar()
        {
            return $"RUUUN!!, avanzo como Ómnibus";
        }

        public override string Detenerse()
        {
            return $"PSHH!!, me detengo como Ómnibus";
        }

        public override string Informacion()
        {
            return $"{nombre}: {pasajeros} pasajeros";
        }
    }
}
