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
    
    public partial class ChatsMensajes
    {
        public int Consecutivo { get; set; }
        public int CodigoChatEnvia { get; set; }
        public int CodigoChatRecibe { get; set; }
        public string Mensaje { get; set; }
        public System.DateTime FechaMensaje { get; set; }
    
        public virtual Chats ChatsEnvia { get; set; }
        public virtual Chats ChatsRecibe { get; set; }
    }
}
