using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using AgenciaITM.Models;

namespace AgenciaITM.Clases
{
    public class clsVenta
    {
        private Agencia_ITMEntities dbagITM = new Agencia_ITMEntities();

        public Venta venta { get; set; }

        public List<Venta> ConsultarTodos()
        {
            return dbagITM.Ventas
                   .OrderBy(vt => vt.id_venta)
                   .ToList();
        }

        public Venta Consultar(int id_venta)
        {
            return dbagITM.Ventas.FirstOrDefault(vt => vt.id_venta == id_venta);
        }

        public List<Venta> ConsultarxID(int id_venta)
        {
            return dbagITM.Ventas
                .Where(vt => vt.id_venta == id_venta)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                dbagITM.Ventas.Add(venta);
                dbagITM.SaveChanges();
                return "La venta se guardo de forma correcta";
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
                Venta vts = Consultar(venta.id_venta);
                if (vts == null)
                {
                    return "Valide el ID de la venta, no se puede guadar actualización";
                }
                dbagITM.Ventas.AddOrUpdate(venta);
                dbagITM.SaveChanges();
                return "Se realiza la actualización de la información correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Eliminar(int id_venta)
        {
            try
            {
                Venta vts = Consultar(id_venta);
                if (vts == null)
                {
                    return "La venta no registra en la base de datos, no se puede realizar acción";
                }
                dbagITM.Ventas.Remove(vts);
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
