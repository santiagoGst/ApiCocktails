using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiCocktails.Models;
using ApiCocktails.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiCocktails.Controllers
{
    [ApiController]
    [Route("Inicio")]
    public class InicioController : Controller
    {
        private IServicios servicios;
        public InicioController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpPost("ValidarUsuario")]
        public IActionResult ValidarUsuario([FromBody] Usuario u){
            Usuario respuesta = servicios.ValidarUsuario(u);
            return Ok(respuesta);
        }

        [HttpPost("RegistrarUsuario")]
        public IActionResult RegistrarUsuario([FromBody] Usuario u){
            bool respuesta = servicios.RegistrarUsuario(u);
            return Ok(respuesta);
        }
    }
}