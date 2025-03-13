using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
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

        public List<Vivienda> ConsultarTodos()
        {
            return dbagITM.Viviendas
                   .OrderBy(v => v.Agencia.nombre)
                   .ToList();
        }

        public Vivienda Consultar(int id_vivienda)
        {
            return dbagITM.Viviendas.FirstOrDefault(v => v.id_vivienda == id_vivienda);
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
                Vivienda viv = Consultar(vivienda.id_vivienda);
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
                Vivienda viv = Consultar(id_vivienda);
                if (viv == null)
                {
                    return "La vivienda no se encuetra en la base de datos";
                }
                dbagITM.Viviendas.Remove(viv);
                dbagITM.SaveChanges();
                return "Se eliminó la vivienda en la base de datos.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}