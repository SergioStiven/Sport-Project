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
    
    public partial class CandidatosResponsables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CandidatosResponsables()
        {
            this.Candidatos = new HashSet<Candidatos>();
        }
    
        public int Consecutivo { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoFijo { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Candidatos> Candidatos { get; set; }
    }
}
