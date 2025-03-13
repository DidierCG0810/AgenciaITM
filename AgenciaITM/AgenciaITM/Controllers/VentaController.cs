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
    [RoutePrefix("api/Venta")]
    public class VentaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Venta> ConsultarTodos()
        {
            clsVenta vts = new clsVenta();
            return vts.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Venta Consultar(int id_venta)
        {
            clsVenta vts = new clsVenta();
            return vts.Consultar(id_venta);
        }

        [HttpGet]
        [Route("ConsultarxID")]
        public List<Venta> ConsultarxID(int id_venta)
        {
            clsVenta vts = new clsVenta();
            return vts.ConsultarxID(id_venta);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Venta venta)
        {
            clsVenta vts = new clsVenta();
            vts.venta = venta;
            return vts.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Venta venta)
        {
            clsVenta vts = new clsVenta();
            vts.venta = venta;
            return vts.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id_venta)
        {
            clsVenta vts = new clsVenta();
            return vts.Eliminar(id_venta);
        }

    }
}