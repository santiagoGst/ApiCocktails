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
    [Route("CategoriasCockteles")]
    public class CategoriasCocktelesController : ControllerBase
    {
        private IServicios servicios;
        public CategoriasCocktelesController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(servicios.ObtenerCategoriasCockteles());
        }
    }
}