using Cadeteria.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;
        private readonly DataBase _dataBase;
        public CadeteController(ILogger<CadeteController> logger, DataBase DATABASE)
        {
            _logger = logger;
            _dataBase = DATABASE;
        }
        public IActionResult Cadetes()
        {
            
            return View();
        }
        
        public IActionResult crearCadetes(string apellido_cadete, string nombre_cadete, string dni_cadete, string domicilio_cadete, string telefono_cadete)
        {
            _dataBase.CrearCadete(apellido_cadete, nombre_cadete, dni_cadete, domicilio_cadete, telefono_cadete);
            
            return RedirectToAction("Cadetes");
        }

        public IActionResult VerCadetes()
        {
            return View(_dataBase.LeerArchivoDeCadetes());
        }
    }
}
