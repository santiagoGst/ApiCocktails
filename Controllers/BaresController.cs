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
    [Route("Bares")]
    public class BaresController : ControllerBase
    {
        private IServicios servicios;
        public BaresController(IServicios servicios)
        {
            this.servicios = servicios;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(servicios.ObtenerBares());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Bar b){
            bool respuesta = servicios.InsertarBar(b);
            return Ok(respuesta);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Bar b){
            bool respuesta = servicios.ActualizarBar(b);
            return Ok(respuesta);
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery]string id){
            bool respuesta = servicios.EliminarBar(id);
            return Ok(respuesta);
        }

        [HttpGet("Individual")]
        public IActionResult ObtenerBarPorId([FromQuery]string id){
            return Ok(servicios.ObtenerBar(id));
        }
    }
}