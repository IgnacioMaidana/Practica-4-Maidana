using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Principal
    {
        List<Envio> ListaEnvios = new List<Envio>();
        List<Destinatario> ListaDestinatarios = new List<Destinatario>();
        List<Repartidor> ListaRepartidores = new List<Repartidor>();


        public string GenerarEnvio(int dniDestinatario, DateTime fechaEstimada, string descripcion)
        {
            Random rnd = new Random();
            string Numero = rnd.Next(100).ToString(); // agregar una validacion en caso de que se repita un codigo

            if (ListaDestinatarios.Exists(x => x.Dni == dniDestinatario))
            {
                Envio envio = new Envio(Numero, ListaDestinatarios.Where(x => x.Dni == dniDestinatario).First(), fechaEstimada, descripcion);
                return Numero;
            }
            else
            {
                // retorne un json
                return null;
            }
        }

        //Se necesita un servicio que permita actualizar un envío, recibiendo el código de seguimiento como parámetro.
        //Se recibe como cuerpo de la solicitud el estado actual.
        //Se debe validar que el nuevo estado sea válido con la lógica correspondiente.
        //En el caso que el estado sea “ENTREGADO” calcular y almacenar la comisión del repartidor
        //y la fecha efectiva de entrega.
        public void ActualizarEnvio(string codigo, Enumeradores.Estados estado)
        {
            Envio envio = ListaEnvios.Where(x => x.Numero == codigo).First();

            if (estado == envio.Estado +1)
            {
                envio.Estado = estado;
                if (estado == Enumeradores.Estados.Entregado)
                {
                    //calcular comision y fecha
                }

            }
        }

        //Se necesita un servicio que asigne un repartidor a un envío enviado
        //como parámetro utilizando la menor distancia entre ambos, es decir,
        //se debe asignar el repartidor que menor distancia tenga con el destinatario.
        //Retornar como respuesta todos los datos del repartidor asignado.

        public Repartidor AsignarRepartidor(Envio envio ) 
        {
            Repartidor designado = null;
            double distanciaMin = 0; 
            foreach (Repartidor repartidor in ListaRepartidores)
            {
                if (designado == null)
                {
                    designado = repartidor;
                    distanciaMin = envio.Destinatario.CalcularDistancia(repartidor); //revisar la extension
                }
                else if (distanciaMin < envio.Destinatario.CalcularDistancia(repartidor))
                {
                    designado = repartidor;
                    distanciaMin = envio.Destinatario.CalcularDistancia(repartidor);
                }                
            }
            return designado;
        }

        //Se necesita un servicio que retorne una lista de repartidores indicando únicamente
        //(nombre y apellido, total ganado por comisiones, cantidad de envíos realizados),
        //filtrando los envíos por fecha desde / hasta (usar la fecha de creación del envio y no la de entrega final,
        //usar solamente los envíos entregados.

        public List<Entidades.Repartidor> GenerarListaRepartidoresFiltrada()
        {

        }
    }
}