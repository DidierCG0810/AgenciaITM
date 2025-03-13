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
    [RoutePrefix("api/TipoVivienda")]
    public class TipoViviendaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TipoVivienda> ConsultarTodos()
        {
            clsTipoVivienda tipovivienda = new clsTipoVivienda();
            return tipovivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public TipoVivienda Consultar(int id_tipo_vivienda)
        {
            clsTipoVivienda tipo_vivienda = new clsTipoVivienda();
            return tipo_vivienda.Consultar(id_tipo_vivienda);
        }

        [HttpGet]
        [Route("ConsultarxID")]
        public List<TipoVivienda> ConsultarxID(int id_tipo_vivienda)
        {
            clsTipoVivienda tipo_vivienda = new clsTipoVivienda();
            return tipo_vivienda.ConsultarxID(id_tipo_vivienda);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TipoVivienda tipo_vivienda)
        {
            clsTipoVivienda TipViv = new clsTipoVivienda();
            TipViv.tipo_vivienda = tipo_vivienda;
            return TipViv.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TipoVivienda tipo_vivienda)
        {
            clsTipoVivienda TipViv = new clsTipoVivienda();
            TipViv.tipo_vivienda = tipo_vivienda;
            return TipViv.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id_tipo_vivienda)
        {
            clsTipoVivienda TipViv = new clsTipoVivienda();
            return TipViv.Eliminar(id_tipo_vivienda);
        }

    }
}