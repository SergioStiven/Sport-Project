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
    
    public partial class Contactos
    {
        public int Consecutivo { get; set; }
        public int CodigoPersonaOwner { get; set; }
        public int CodigoPersonaContacto { get; set; }
    
        public virtual Personas PersonasContacto { get; set; }
        public virtual Personas PersonasOwner { get; set; }
    }
}
