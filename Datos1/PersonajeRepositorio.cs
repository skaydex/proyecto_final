using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeFinalProyect.Datos1
{
    public class PersonajeRepositorio
    {
        public static List<Personajes> Personajes { get; private set; }



        public static void InicializarRepositorio()
        {
            Personajes = new List<Personajes>();


        }

        public static void AñadirPersonaje(Personajes personajes)
        {
            Personajes.Add(personajes);



        }
        public static void EliminarPersonaje(string id)
        {
            Personajes.RemoveAll(e => e.id.Equals(id));

        }
        public static void ActualizarPersonaje(string idPerosnajeOrigen, Personajes personajeModificados)
        {
            int indicePersonajeOriginal = Personajes.FindIndex(e => e.id == idPerosnajeOrigen);
            if (indicePersonajeOriginal != -1)
            {
                Personajes[indicePersonajeOriginal] = personajeModificados;

            }
        }
    }
}
