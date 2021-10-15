using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDeCadeteriaII.Entidades
{
    public class ClaseCliente
    {
        private string id_cliente;
        private string nombre_cliente;
        private string direccion_cliente;
        private string telefono_cliente;

        public ClaseCliente(string id_cliente, string nombre_cliente, string direccion_cliente, string telefono_cliente)
        {
            this.Id_cliente = id_cliente;
            this.Nombre = nombre_cliente;
            this.Direccion = direccion_cliente;
            this.Telefono = telefono_cliente;
        }

        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre_cliente; set => nombre_cliente = value; }
        public string Direccion { get => direccion_cliente; set => direccion_cliente = value; }
        public string Telefono { get => telefono_cliente; set => telefono_cliente = value; }
    }
}
