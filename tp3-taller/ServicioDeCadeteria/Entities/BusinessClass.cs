using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioDeCadeteria.Entities;

namespace ServicioDeCadeteria.Entities
{
    //esta clase simulara ser un repositorio para aglutinar las demas clases y objetos.
    //asi podremos llevar toda la informacion a distintas vistas
    public class BusinessClass
    {
        private List<OrderClass> orderList;

        /*
         * PREGUNTA: ¿PORQUE NO PUEDO USAR ESTE CONSTRUCTOR PARA CREAR LA LISTA DE PEDIDOS?
         * ES PORQUE DEBO PASARLE UNA LISTA?
         * 
        public BusinessClass(List<OrderClass> orderList)
        {
            this.orderList = orderList;
        }
        */

        public BusinessClass()
        {
            orderList = new List<OrderClass>();//de esta forma instancio la lista de pedidos sin necesidad de estar pasandole datos?
        }
        public List<OrderClass> OrderList { get => orderList; set => orderList = value; }

    }
}
