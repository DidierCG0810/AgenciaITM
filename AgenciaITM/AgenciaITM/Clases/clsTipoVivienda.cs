using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using AgenciaITM.Models;

namespace AgenciaITM.Clases
{
    public class clsTipoVivienda
    {
        private Agencia_ITMEntities dbagITM = new Agencia_ITMEntities();

        public TipoVivienda tipo_vivienda { get; set; }

        public List<TipoVivienda> ConsultarTodos()
        {
            return dbagITM.TipoViviendas
                   .OrderBy(tv => tv.id_tipo_vivienda)
                   .ToList();
        }
       
        public TipoVivienda Consultar(int id_tipo_vivienda)
        {
            return dbagITM.TipoViviendas.FirstOrDefault(tv => tv.id_tipo_vivienda == id_tipo_vivienda);
        }

        public List<TipoVivienda> ConsultarxID(int id_tipo_vivienda)
        {
            return dbagITM.TipoViviendas
                .Where(tv => tv.id_tipo_vivienda == id_tipo_vivienda)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                dbagITM.TipoViviendas.Add(tipo_vivienda);
                dbagITM.SaveChanges();
                return "Se carga la información del tipo de la vivienda correctamente";
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
                TipoVivienda tipviv = Consultar(tipo_vivienda.id_tipo_vivienda);
                if (tipviv == null)
                {
                    return "El tipo devivienda no corresponde a propiedad registrada en agencia";
                }
                dbagITM.TipoViviendas.AddOrUpdate(tipo_vivienda);
                dbagITM.SaveChanges();
                return "Se realiza la actualización de la información correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Eliminar(int id_tipo_vivienda)
        {
            try
            {
                TipoVivienda tipviv = Consultar(id_tipo_vivienda);
                if (tipviv == null)
                {
                    return "El tipo de vivienda no se encuetra en la base de datos";
                }
                dbagITM.TipoViviendas.Remove(tipviv);
                dbagITM.SaveChanges();
                return "La información del tipo de vivienda se borra correctamente de la base de datos.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
