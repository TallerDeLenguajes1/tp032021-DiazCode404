using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioDeCadeteria.Entities;//agrego esto para crear el objeto order

namespace ServicioDeCadeteria.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly BusinessClass _dataBase;//aca hago la declaracion de mi variable que simulara ser mi base de datos
        public OrderController(ILogger<OrderController> logger, BusinessClass dataBase)//aca agrego la variable a este controlador
        {
            _logger = logger;
            _dataBase = dataBase;
        }
        
        static int idClient = 100;//

        static int numberOrder = 0;//creo el numero del pedido para enviarlo luego
        public List<string> TipeOfStatus = new List<string>()//creo una lista de los estados de los pedidos
        {
            "Done",
            "InProcess",
            "Canceled"
        };

        public IActionResult OrderCreator()//DEBO CREAR LA PAGINA QUE QUIERO VISUALIZAR
        {
            return View(_dataBase.DeliveryManList);
        }

        //aca se recibiran los datos para crear el pedido
        public IActionResult CreateOrder(string client_name,string client_adress,string client_telephone,string client_order,string id_delivery)
        {
            //creo un objeto cliente
            ClientClass MyClient = new ClientClass(Convert.ToString(idClient), client_name, client_adress, client_telephone);
            //sumo aumento el id del cliente para el proximo cliente
            idClient++;

            //creo un objeto Order
            OrderClass MyOrder = new OrderClass(Convert.ToString(numberOrder), client_order, TipeOfStatus[1], MyClient);
            //aumento el numero de pedido para el proximo pedido
            numberOrder++;

            //ahora tengo que buscar si existe el cadete que tiene el id recibido y agregar el pedido en su lista de pedidos
            _dataBase.DeliveryManList.Find(x => x.DeliveryMan_id == id_delivery).AddOrder(MyOrder);


            _dataBase.OrderList.Add(MyOrder);//aca agrego mis pedidos a la lista de pedidos

            return View("OrderCreator");//RETORNO EL NOMBRE DE LA PAGINA A LA QUE ME QUIERO DIRIGIR DESPUES DE CREAR EL PEDIDO
        }

        public IActionResult OrderViews()
        {
            return View(_dataBase.OrderList);//paso la lista de pedidos a la vista de OrderViews para mostrarla por pantalla
        }

    }
}
