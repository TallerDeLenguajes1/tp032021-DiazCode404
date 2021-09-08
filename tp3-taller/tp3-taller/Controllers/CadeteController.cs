using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using tp3_taller.Entidades;

namespace tp3_taller.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearListaCadete(string nombre, string direccion,string telefono)
        {
            try
            {
                List<Cadete> ListaCadetes = new List<Cadete>();
                Cadete MiCadete = new Cadete(nombre, direccion, telefono);

                ListaCadetes.Add(MiCadete);

                return View(ListaCadetes);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
