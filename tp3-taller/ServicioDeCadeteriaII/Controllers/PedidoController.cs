using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicioDeCadeteriaII.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioDeCadeteriaII.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly DataBase _dataBase;
        public PedidoController(ILogger<PedidoController> logger, DataBase dataBase)
        {
            _logger = logger;
            _dataBase = dataBase;
        }
        public IActionResult Index()
        {
            return View();
        }

        static int id_cliente;
        public IActionResult GuardarPedido(string nombre_cliente, string apellido_cliente, string direccion_cliente, string telefono_cliente, string pedido)
        {
            _dataBase.crearPedido(apellido_cliente + nombre_cliente, direccion_cliente, telefono_cliente, pedido);

            return RedirectToAction("Index");
        }
    }
}
