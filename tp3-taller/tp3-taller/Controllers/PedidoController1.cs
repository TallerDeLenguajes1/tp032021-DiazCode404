using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp3_taller.Controllers
{
    public class PedidoController1 : Controller
    {
        private readonly ILogger<PedidoController1> _logger;

        public PedidoController1(ILogger<PedidoController1> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }
        public IActionResult Index()
        {
            return View();
        }
    
        
    }
}
