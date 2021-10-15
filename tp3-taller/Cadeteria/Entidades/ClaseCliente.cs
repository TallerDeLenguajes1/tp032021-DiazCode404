using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Entidades
{
    public class ClaseCliente
    {
        private string id_cliente;
        private string apellido_cliente;
        private string nombre_cliente;
        private string domicilio_cliente;
        private string telefono_cliente;

        public ClaseCliente(string id_cliente ,string apellido_cliente, string nombre_cliente, string domicilio_cliente, string telefono_cliente)
        {
            this.id_cliente = id_cliente;
            this.Apellido_cliente = apellido_cliente;
            this.Nombre_cliente = nombre_cliente;
            this.Domicilio_cliente = domicilio_cliente;
            this.Telefono_cliente = telefono_cliente;
        }

        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Apellido_cliente { get => apellido_cliente; set => apellido_cliente = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Domicilio_cliente { get => domicilio_cliente; set => domicilio_cliente = value; }
        public string Telefono_cliente { get => telefono_cliente; set => telefono_cliente = value; }
    }
}
