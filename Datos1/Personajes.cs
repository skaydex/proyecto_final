using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeFinalProyect.Datos1
{
    public class Personajes
    {
        public string id { get; private set; }
        public string Nombre { get; private set; }
        public string Serie { get; private set; }
        public string FechaNAc { get; private set; }
        public string Poder { get; private set; }
        public string FraseFav { get; private set; }
        public string Vestimenta { get; private set; }
        public string Altura { get; private set; }
        public string Estado { get; private set; }
        public string Direccion { get; private set; }
        public string Latitud { get; private set; }
        public string Longitud { get; private set; }

        public Personajes(string id, string nombre, string serie, string fechanac, string poder, string frasefav, string vestimenta, string altura, string estado, string direccion, string latitud, string longitud)
        {

            this.id = id;
            this.Nombre = nombre;
            this.Serie = serie;
            this.FechaNAc = fechanac;
            this.Poder = poder;
            this.FraseFav = frasefav;
            this.Vestimenta = vestimenta;
            this.Altura = altura;
            this.Estado = estado;
            this.Direccion = direccion;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }
}   }
