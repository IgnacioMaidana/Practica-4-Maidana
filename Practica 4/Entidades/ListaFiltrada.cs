using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaFiltrada
    {
        //(nombre y apellido, total ganado por comisiones, cantidad de envíos realizados),
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ganancias { get; set; }
        public int CantEnvios { get; set; }

    }
}
