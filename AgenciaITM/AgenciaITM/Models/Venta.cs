//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaITM.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class Venta
    {
        public int id_venta { get; set; }
        public int id_cliente { get; set; }
        public int id_vivienda { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public double precio_venta { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
        [JsonIgnore]
        public virtual Vivienda Vivienda { get; set; }
    }
}
