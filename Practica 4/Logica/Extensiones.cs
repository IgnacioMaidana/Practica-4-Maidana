using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Extensiones
    {

        public static double CalcularDistancia (this Entidades.Persona persona, Entidades.Repartidor repartidor)
        {
            double distance = 0;
            double Lat = (repartidor.Latitud - persona.Latitud) * (Math.PI / 180);
            double Lon = (repartidor.Longitud - persona.Longitud) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(persona.Latitud * (Math.PI / 180)) * Math.Cos(repartidor.Latitud * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = 6371 * c; // 6,371 km
            return distance;
        }
    }
}
