//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xpinn.SportsGo.DomainEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CandidatosVideos
    {
        public int Consecutivo { get; set; }
        public int CodigoCandidato { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Creacion { get; set; }
        public int CodigoArchivo { get; set; }
    
        public virtual Candidatos Candidatos { get; set; }
        public virtual Archivos Archivos { get; set; }
    }
}
