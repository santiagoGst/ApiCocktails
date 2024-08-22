using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiCocktails.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiCocktails.Controllers
{
    [Route("Vidrios")]
    public class VidrioController : ControllerBase
    {
        private IServicios servicios;
        public VidrioController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(servicios.ObtenerVidrios());
        }
    }
}