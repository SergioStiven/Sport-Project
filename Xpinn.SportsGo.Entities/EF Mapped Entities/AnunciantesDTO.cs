//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xpinn.SportsGo.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnunciantesDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnunciantesDTO()
        {
            this.Anuncios = new HashSet<AnunciosDTO>();
        }

        public int Consecutivo { get; set; }
        public int CodigoPersona { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Empresa { get; set; }

        public virtual PersonasDTO Personas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnunciosDTO> Anuncios { get; set; }
    }
}
