using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDeCadeteriaII.Entidades
{
    public class ClaseCadete
    {
        private string id_cadete;
        private string Nombre;
        private string Apellido;
        private string dni;
        private string Direccion;
        private string Telefono;
        private List<ClasePedido> listPedidos;

        public ClaseCadete(string nombre, string apellido, string dni, string direccion, string telefono)
        {
            Nombre1 = nombre;
            Apellido1 = apellido;
            DNI = dNI;
            Direccion1 = direccion;
            Telefono1 = telefono;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string DNI { get => DNI; set => DNI = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }


        private void AgregarCliente(ClasePedido pedido)
        {
            listPedidos.Add(pedido);
        }
    }
}
