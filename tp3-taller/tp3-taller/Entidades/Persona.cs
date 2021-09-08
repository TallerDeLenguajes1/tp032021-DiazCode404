using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp3_taller.Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        public Persona(string nombre, string direccion, string telefono)
        {
        //    this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public void AgregarID(int num)
        {
            this.id = num;
        }
    }
}
