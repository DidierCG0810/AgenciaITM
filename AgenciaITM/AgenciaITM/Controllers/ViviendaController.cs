using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AgenciaITM.Clases;
using AgenciaITM.Models;

namespace AgenciaITM.Controllers
{
    [RoutePrefix("api/Vivienda")]
    public class ViviendaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vivienda> ConsultarTodos()
        {
            clsVivienda vivienda = new clsVivienda();
            return vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Vivienda Consultar(int id_vivienda)
        {
            clsVivienda vivienda = new clsVivienda();
            return vivienda.Consultar(id_vivienda);
        }

        [HttpGet]
        [Route("ConsultarxID")]
        public List<Vivienda> ConsultarxID(int id_vivienda)
        {
            clsVivienda vivienda = new clsVivienda();
            return vivienda.ConsultarxID(id_vivienda);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vivienda Vivienda)
        {
            clsVivienda Viv = new clsVivienda();
            Viv.vivienda = Vivienda;
            return Viv.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda vivienda)
        {
            clsVivienda Viv = new clsVivienda();
            Viv.vivienda = vivienda;
            return Viv.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id_vivienda)
        {
            clsVivienda Viv = new clsVivienda();
            return Viv.Eliminar(id_vivienda);
        }
    
    }
}