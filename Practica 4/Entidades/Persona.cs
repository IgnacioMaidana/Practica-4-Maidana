using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        //De los destinatarios y repartidores se conoce un dni, nombre y apellido,
        //código postal, latitud, longitud y teléfono de contacto.
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CodPostal { get; set; }
        public int Latitud { get; set; }
        public int Longitud { get; set; }
        public int Telefono { get; set; }


    }
}
