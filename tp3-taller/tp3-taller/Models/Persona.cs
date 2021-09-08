using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp3_taller.Models
{
    public class Persona
    {
        private string id;
        private string nombre;
        private string direccion;
        private string telefono;

        public Persona(string id, string nombre, string direccion, string telefono)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
