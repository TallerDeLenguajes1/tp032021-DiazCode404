using Cadeteria.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly DataBase _dataBase;
        public PedidoController(ILogger<PedidoController> logger, DataBase DATABASE)
        {
            _logger = logger;
            _dataBase = DATABASE;
        }

        public IActionResult Pedidos()
        {
            return View();
        }
        public IActionResult VerPedidos()
        {
            return View(_dataBase.LeerArchivoDePedidos());
        }

        public IActionResult crearPedido(string apellido_cliente, string nombre_cliente, string domicilio_cliente, string telefono_cliente, string pedido)
        {
            _dataBase.crearPedido(apellido_cliente, nombre_cliente, domicilio_cliente, telefono_cliente, pedido);
            return RedirectToAction("Pedidos");
        }

        public IActionResult Info(string id)
        {
            var pedido = _dataBase.LeerArchivoDePedidos().Find(x => x.Id_pedido == id);
            return View(pedido);
        }
    }
}
