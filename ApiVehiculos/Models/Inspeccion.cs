//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiVehiculos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inspeccion
    {
        public int IdInspeccion { get; set; }
        public Nullable<int> IdRevision { get; set; }
        public Nullable<int> IdTipoRevision { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdPersona { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Revision Revision { get; set; }
        public virtual TipoRevision TipoRevision { get; set; }
    }
}
