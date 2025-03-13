using AgenciaITM.Clases;
using AgenciaITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaITM.Controllers
{
    public class ValuesController : ApiController
    {
        private clsVivienda _viviendaService = new clsVivienda();

        public IHttpActionResult Get()
        {
            var viviendas = _viviendaService.Consultar();
            return Ok(viviendas); 
        }

        
        public IHttpActionResult Get(int id)
        {
            var vivienda = _viviendaService.ConsultarxID(id);
            if (vivienda == null || vivienda.Count == 0)
            {
                return NotFound(); 
            }
            return Ok(vivienda); 
        }

       
        public IHttpActionResult Post([FromBody] Vivienda vivienda)
        {
            if (vivienda == null)
            {
                return BadRequest("La vivienda no puede ser nula.");
            }

            _viviendaService.vivienda = vivienda;
            string resultado = _viviendaService.Insertar();
            return Ok(resultado);
        }

        
        public IHttpActionResult Put(int id, [FromBody] Vivienda vivienda)
        {
            if (vivienda == null || vivienda.id_vivienda != id)
            {
                return BadRequest("Datos de la vivienda no válidos.");
            }

            _viviendaService.vivienda = vivienda;
            string resultado = _viviendaService.Actualizar();
            return Ok(resultado); 
        }

        
        public IHttpActionResult Delete(int id)
        {
            string resultado = _viviendaService.Eliminar(id);
            if (resultado.Contains("no se encuentra"))
            {
                return NotFound(); 
            }
            return Ok(resultado); 
        }
    }
}
