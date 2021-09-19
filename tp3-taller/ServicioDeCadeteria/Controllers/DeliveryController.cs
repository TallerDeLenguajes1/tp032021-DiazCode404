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

            return View("DeliveryManCreator");
        }

        public IActionResult ShowAllDeliveryMan()
        {
            return View(_dataBase.DeliveryManList);//paso la lista de cadetes para mostrar en la vista ShowAllDeliveryMan
        }


    }
}
