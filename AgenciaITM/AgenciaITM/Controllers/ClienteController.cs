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
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos()
        {
            clsCliente cliente = new clsCliente();
            return cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Cliente Consultar(int id_cliente)
        {
            clsCliente cliente = new clsCliente();
            return cliente.Consultar(id_cliente);
        }

        [HttpGet]
        [Route("ConsultarxID")]
        public List<Cliente> ConsultarxID(int id_cliente)
        {
            clsCliente cliente = new clsCliente();
            return cliente.ConsultarxID(id_cliente);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente cliente)
        {
            clsCliente cli = new clsCliente();
            cli.cliente = cliente;
            return cli.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cliente)
        {
            clsCliente cli = new clsCliente();
            cli.cliente = cliente;
            return cli.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id_cliente)
        {
            clsCliente cli = new clsCliente();
            return cli.Eliminar(id_cliente);
        }

    }
}