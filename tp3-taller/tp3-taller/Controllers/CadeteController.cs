﻿using Microsoft.AspNetCore.Mvc;
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

        private readonly ILogger<CadeteController> _logger;
        private readonly List<Cadete> cadetes;
        public CadeteController(ILogger<CadeteController> logger, List<Cadete>Cadetes)
        {
            cadetes = Cadetes;
            _logger = logger;
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
                id++;
                Cadete MiCadete = new Cadete(nombre, direccion, telefono);
                MiCadete.AgregarID(id);
                cadetes.Add(MiCadete);

                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
