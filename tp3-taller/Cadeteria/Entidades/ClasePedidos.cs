using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Entidades
{
    public class ClasePedidos
    {
        private string id_pedido;
        private string estado;
        private ClaseCliente cliente;
        private string pedido;

        public ClasePedidos(string id_pedido, string estado, ClaseCliente cliente, string pedido)
        {
            this.Id_pedido = id_pedido;
            this.Estado = estado;
            this.Cliente = cliente;
            this.Pedido = pedido;
        }

        public string Id_pedido { get => id_pedido; set => id_pedido = value; }
        public string Estado { get => estado; set => estado = value; }
        public ClaseCliente Cliente { get => cliente; set => cliente = value; }
        public string Pedido { get => pedido; set => pedido = value; }
    }
}
