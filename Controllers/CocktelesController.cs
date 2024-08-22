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
    [Route("Cockteles")]
    public class CocktelesController : ControllerBase
    {
        private IServicios servicios;
        public CocktelesController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(servicios.ObtenerCockteles());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cocktel c){
            bool respuesta = servicios.InsertarCocktel(c);
            return Ok(respuesta);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cocktel c){
            bool respuesta = servicios.ActualizarCocktel(c);
            return Ok(respuesta);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery]string id){
            bool respuesta = servicios.EliminarCocktel(id);
            return Ok(respuesta);
        }

        [HttpGet("Individual")]
        public IActionResult ObtenerProductoPorId([FromQuery]string id){
            return Ok(servicios.ObtenerCocktel(id));
        }
    }
}