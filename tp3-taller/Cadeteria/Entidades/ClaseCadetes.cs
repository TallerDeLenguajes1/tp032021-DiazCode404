using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Entidades
{
    public class ClaseCadetes
    {
        private string id_cadete;
        private string apellido_cadete;
        private string nombre_cadete;
        private string domicilio_cadete;
        private string dni_cadete;
        private string telefono_cadete;
        private List<ClasePedidos> lista_de_pedidos;

        public ClaseCadetes(string id_cadete, string apellido_cadete, string nombre_cadete, string domicilio_cadete, string dni_cadete, string telefono_cadete)
        {
            this.id_cadete = id_cadete;
            this.apellido_cadete = apellido_cadete;
            this.nombre_cadete = nombre_cadete;
            this.domicilio_cadete = domicilio_cadete;
            this.dni_cadete = dni_cadete;
            this.telefono_cadete = telefono_cadete;
        }

        public string Id_cadete { get => id_cadete; set => id_cadete = value; }
        public string Apellido_cadete { get => apellido_cadete; set => apellido_cadete = value; }
        public string Nombre_cadete { get => nombre_cadete; set => nombre_cadete = value; }
        public string Domicilio_cadete { get => domicilio_cadete; set => domicilio_cadete = value; }
        public string Dni_cadete { get => dni_cadete; set => dni_cadete = value; }
        public string Telefono_cadete { get => telefono_cadete; set => telefono_cadete = value; }
        public List<ClasePedidos> Lista_de_pedidos { get => lista_de_pedidos; set => lista_de_pedidos = value; }

        public void AsignarPedidoACadete(ClasePedidos Pedido)
        {
            Lista_de_pedidos.Add(Pedido);
        }
    }
}
