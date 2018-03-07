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
    
    public partial class Categorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categorias()
        {
            this.CategoriasAnuncios = new HashSet<CategoriasAnuncios>();
            this.CategoriasCandidatos = new HashSet<CategoriasCandidatos>();
            this.CategoriasContenidos = new HashSet<CategoriasContenidos>();
            this.CategoriasEventos = new HashSet<CategoriasEventos>();
            this.CategoriasGrupos = new HashSet<CategoriasGrupos>();
            this.CategoriasRepresentantes = new HashSet<CategoriasRepresentantes>();
            this.Habilidades = new HashSet<Habilidades>();
            this.CategoriasNoticias = new HashSet<CategoriasNoticias>();
        }
    
        public int Consecutivo { get; set; }
        public int CodigoArchivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasAnuncios> CategoriasAnuncios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasCandidatos> CategoriasCandidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasContenidos> CategoriasContenidos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasEventos> CategoriasEventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasGrupos> CategoriasGrupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasRepresentantes> CategoriasRepresentantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habilidades> Habilidades { get; set; }
        public virtual Archivos Archivos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasNoticias> CategoriasNoticias { get; set; }
    }
}
