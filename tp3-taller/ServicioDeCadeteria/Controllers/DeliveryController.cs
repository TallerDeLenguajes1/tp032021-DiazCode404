using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioDeCadeteria.Entities;//agrego sto para usar la clase Business

namespace ServicioDeCadeteria.Controllers
{
    public class DeliveryController : Controller
    {
        private readonly ILogger<DeliveryController> _logger;
        private readonly BusinessClass _dataBase;
        public DeliveryController(ILogger<DeliveryController> logger, BusinessClass dataBase)
        {
            _logger = logger;
            _dataBase = dataBase;
        }

        public IActionResult DeliveryManCreator()
        {
            return View();
        }
        static int id_deliveryMan = 10;//creo una variable para generar el id del cadete
        public IActionResult CreateDeliveryMan(string deliveryMan_name, string deliveryMan_adress, string deliveryMan_telephone)
        {
            //instancio un cadete
            DeliveryClass MyDeliveryMan = new DeliveryClass(Convert.ToString(id_deliveryMan), deliveryMan_name, deliveryMan_adress, deliveryMan_telephone);

            //agrego mi cadete creado a la lista de cadetes
            _dataBase.DeliveryManList.Add(MyDeliveryMan);
            //escribo el cadete en el archivo
            _dataBase.SaveDeliveryMan(_dataBase.DeliveryManList);
            id_deliveryMan++;//aumento el id del cadete


            return View("DeliveryManCreator");
        }

        public IActionResult ShowAllDeliveryMan()
        {
            //cuando entro a esta vista tengo que hacer la deserializacion de los que contiene el archivo y pasarle el contenido
            
            return View(_dataBase.DeserializerDeliveryManList());//paso la lista de cadetes para mostrar en la vista ShowAllDeliveryMan
        }


    }
}
