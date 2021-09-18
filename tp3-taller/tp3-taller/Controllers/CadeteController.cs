using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp3_taller.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        public HomeController(ILogger<HomeController> logger)
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
