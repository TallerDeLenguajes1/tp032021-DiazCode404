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
        static int id = 0;
<<<<<<< HEAD

        private readonly ILogger<CadeteController> _logger;
        private readonly List<Cadete> cadetes;
        public CadeteController(ILogger<CadeteController> logger, List<Cadete>Cadetes)
=======
        

        private readonly ILogger<CadeteController> _logger;
        private readonly List<Cadete> cadetes;

        public CadeteController(ILogger<CadeteController> logger,List<Cadete> Cadetes)
>>>>>>> d27da61527637817c8ce9033175b63001d05ea5e
        {
            cadetes = Cadetes;
            _logger = logger;
            cadetes = Cadetes;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }
        public IActionResult Index()
        {
            return View(cadetes);
        }

        public IActionResult AltaCadete(string nombre, string direccion,string telefono)
        {
            try
            {
<<<<<<< HEAD
                id++;
                Cadete MiCadete = new Cadete(nombre, direccion, telefono);
                MiCadete.AgregarID(id);
                cadetes.Add(MiCadete);

=======
                if (nombre != null)
                {
                    id++;
                    Cadete MiCadete = new Cadete(nombre, direccion, telefono);
                    MiCadete.AgregarID(id);
                    cadetes.Add(MiCadete);
                }
>>>>>>> d27da61527637817c8ce9033175b63001d05ea5e
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
