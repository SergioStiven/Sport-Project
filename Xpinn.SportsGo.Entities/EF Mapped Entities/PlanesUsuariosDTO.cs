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

    public partial class PlanesUsuariosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanesUsuariosDTO()
        {
            this.Usuarios = new HashSet<UsuariosDTO>();
        }

        public int Consecutivo { get; set; }
        public int CodigoPlan { get; set; }
        public System.DateTime Adquisicion { get; set; }
        public System.DateTime Vencimiento { get; set; }
        public int NumeroCategoriasUsadas { get; set; }

        public virtual PlanesDTO Planes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuariosDTO> Usuarios { get; set; }
    }
}
