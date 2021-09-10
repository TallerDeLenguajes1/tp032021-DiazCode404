using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp3_taller.Models;

namespace tp3_taller.Entidades
{
    public class Pedido
    {
        private int numero;
        private string observacion;
        private Persona cliente;
        private string estado;

        public Pedido(string observacion, Persona cliente, string estado)
        {
            this.Observacion = observacion;
            this.Cliente = cliente;
            this.Estado = estado;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public Persona Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
