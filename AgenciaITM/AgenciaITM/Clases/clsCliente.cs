using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using AgenciaITM.Models;

namespace AgenciaITM.Clases
{
    public class clsCliente
    {
        private Agencia_ITMEntities dbagITM = new Agencia_ITMEntities();

        public Cliente cliente { get; set; }

        public List<Cliente> ConsultarTodos()
        {
            return dbagITM.Clientes
                   .OrderBy(c => c.nombre)
                   .ToList();
        }

        public Cliente Consultar(int id_cliente)
        {
            return dbagITM.Clientes.FirstOrDefault(c => c.id_cliente == id_cliente);
        }

        public List<Cliente> ConsultarxID(int id_cliente)
        {
            return dbagITM.Clientes
                .Where(c => c.id_cliente == id_cliente)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                dbagITM.Clientes.Add(cliente);
                dbagITM.SaveChanges();
                return "Datos del cliente correctamente guardados";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                Cliente cli = Consultar(cliente.id_cliente);
                if (cli == null)
                {
                    return "Valide el ID del cliente, no registra en la base de datos";
                }
                dbagITM.Clientes.AddOrUpdate(cliente);
                dbagITM.SaveChanges();
                return "Se realiza la actualización de la información correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Eliminar(int id_cliente)
        {
            try
            {
                Cliente cli = Consultar(id_cliente);
                if (cli == null)
                {
                    return "Cliente no se encuentra en base de datos, no se puede realizar acción";
                }
                dbagITM.Clientes.Remove(cli);
                dbagITM.SaveChanges();
                return "Datos correctamente eliminados de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}