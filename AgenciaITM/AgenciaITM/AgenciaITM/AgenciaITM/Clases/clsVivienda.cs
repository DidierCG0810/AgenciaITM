using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Web;
using AgenciaITM.Models;

namespace AgenciaITM.Clases
{
    public class clsVivienda
    {
        private Agencia_ITMEntities dbagITM = new Agencia_ITMEntities();

        public Vivienda vivienda { get ; set; }

        public List<Vivienda> Consultar()
        {
            return dbagITM.Viviendas
                   .OrderBy(v => v.Agencia)
                   .ToList();
        }

        public List<Vivienda> ConsultarxID (int id_vivienda)
        {
            return dbagITM.Viviendas
                .Where(v => v.id_vivienda == id_vivienda)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                dbagITM.Viviendas.Add(vivienda);
                dbagITM.SaveChanges();
                return "Se agrega la vivienda correctamente";
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
                Vivienda viv = dbagITM.Viviendas.Find(vivienda.id_vivienda);
                if (viv == null) 
                {
                    return "La vivienda no se encuentra registrada en la agencia";
                }
                dbagITM.Viviendas.AddOrUpdate(vivienda);
                dbagITM.SaveChanges();
                return "Se realiza la actualización de la información correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Eliminar(int id_vivienda)
        {
            try
            {
                Vivienda viv = dbagITM.Viviendas.Find(id_vivienda);
                if (viv == null)
                {
                    return "La vivienda no se encuentra registrada en la agencia";
                }
                dbagITM.Viviendas.Remove(viv);
                dbagITM.SaveChanges();
                return "Se elimina la vivienda correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        
    }
}
}