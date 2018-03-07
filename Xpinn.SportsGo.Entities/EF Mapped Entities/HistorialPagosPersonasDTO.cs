﻿//------------------------------------------------------------------------------
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

    public partial class HistorialPagosPersonasDTO
    {
        public int Consecutivo { get; set; }
        public int CodigoPersona { get; set; }
        public System.DateTime FechaPago { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoPlan { get; set; }
        public decimal Precio { get; set; }
        public int? CodigoEstado { get; set; }
        public string TextoFacturaFormato { get; set; }
        public Nullable<int> CodigoArchivo { get; set; }
        public string ReferenciaPago { get; set; }
        public string ObservacionesCliente { get; set; }
        public string ObservacionesAdministrador { get; set; }
        public int CodigoMoneda { get; set; }

        public virtual EstadoPagoDTO EstadoPago { get; set; }
        public virtual PaisesDTO Paises { get; set; }
        public virtual PersonasDTO Personas { get; set; }
        public virtual PlanesDTO Planes { get; set; }
        public virtual ArchivosDTO Archivos { get; set; }
        public virtual MonedasDTO Monedas { get; set; }
    }
}
