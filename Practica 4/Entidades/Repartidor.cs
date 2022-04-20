using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repartidor : Persona
    {
        //Además de los repartidores se conoce el % de comisión por envío.
        public int Comision { get; set; }

    }
}
