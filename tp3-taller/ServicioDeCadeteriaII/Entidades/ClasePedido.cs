using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDeCadeteriaII.Entidades
{
    public class ClasePedido
    {
        private string id_pedido;
        private string estado;
        private string observacion;
        private ClaseCliente cliente;

        public ClasePedido(string id_pedido, string estado, string observacion, string id_cliente, string nombre_cliente, string direccion_cliente, string telefono_cliente, ClaseCliente cliente)
        {
            this.Id_pedido = id_pedido;
            this.Estado = estado;
            this.Observacion = observacion;
            this.Cliente = new ClaseCliente(id_cliente, nombre_cliente, direccion_cliente, telefono_cliente);
        }

        public string Id_pedido { get => id_pedido; set => id_pedido = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public ClaseCliente Cliente { get => cliente; set => cliente = value; }
    }
}
