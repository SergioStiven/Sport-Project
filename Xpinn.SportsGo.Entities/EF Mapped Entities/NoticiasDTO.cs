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
    
    public partial class NoticiasDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NoticiasDTO()
        {
            this.CategoriasNoticias = new HashSet<CategoriasNoticiasDTO>();
            this.NoticiasContenidos = new HashSet<NoticiasContenidosDTO>();
            this.NoticiasPaises = new HashSet<NoticiasPaisesDTO>();
        }
    
        public int Consecutivo { get; set; }
        public System.DateTime Creacion { get; set; }
        public string UrlPublicidad { get; set; }
        public Nullable<int> CodigoArchivo { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoTipoNoticia { get; set; }

        public virtual ArchivosDTO Archivos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriasNoticiasDTO> CategoriasNoticias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoticiasContenidosDTO> NoticiasContenidos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoticiasPaisesDTO> NoticiasPaises { get; set; }
        public virtual UsuariosDTO Usuarios { get; set; }
        public virtual TipoPublicacionDTO TipoPublicacion { get; set; }
    }
}