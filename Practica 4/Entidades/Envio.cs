using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enumeradores;

namespace Entidades
{
    public class Envio
    {
        

        //Los envíos disponen de un número de envío aleatorio (string), un destinatario,
        //un repartidor, un estado de envío, una fecha estimada de entrega, descripción y una fecha de entrega.
        public string Numero { get; set; }
        public Destinatario Destinatario { get; set; }
        public Repartidor Repartidor { get; set; }
        public Estados Estado { get; set; }
        public DateTime FechaEstimada { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }

        public Envio(string numero, Destinatario destinatario, DateTime fechaEstimada, string descripcion)
        {
            Numero = numero;
            Destinatario = destinatario;            
            Estado = Estados.Pendiente;
            FechaEstimada = fechaEstimada;
            Descripcion = descripcion;            
        }
    }
}
