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
    
    public partial class Monedas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monedas()
        {
            this.Paises = new HashSet<Paises>();
            this.HistorialPagosPersonas = new HashSet<HistorialPagosPersonas>();
        }
    
        public int Consecutivo { get; set; }
        public string Descripcion { get; set; }
        public decimal CambioMoneda { get; set; }
        public string AbreviaturaMoneda { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paises> Paises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialPagosPersonas> HistorialPagosPersonas { get; set; }
    }
}