using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros, string nombre) : base(pasajeros, nombre)
        {
        }

        public override string Avanzar()
        {
            return "run, run!! avanzo como taxi";
        }

        public override string Detenerse()
        {
            return "run, run!!";
        }

        public override string Informacion()
        {
            return $"{nombre}: {pasajeros} pasajeros";
        }
    }
}
