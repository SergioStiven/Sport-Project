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
    
    public partial class CategoriasContenidos
    {
        public int Consecutivo { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoIdioma { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        public virtual Idiomas Idiomas { get; set; }
    }
}
