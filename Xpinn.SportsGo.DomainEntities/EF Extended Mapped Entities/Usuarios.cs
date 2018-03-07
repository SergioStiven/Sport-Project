﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpinn.SportsGo.Util.Portable.Enums;
using Xpinn.SportsGo.Util.Portable.BaseClasses;
using Xpinn.SportsGo.Util.HelperClasses;

namespace Xpinn.SportsGo.DomainEntities
{
    public partial class Usuarios : BaseEntity
    {
        public TipoPerfil TipoPerfil
        {
            get
            {
                return CodigoTipoPerfil.ToEnum<TipoPerfil>();
            }
            set
            {
                CodigoTipoPerfil = (int)value;
            }
        }
    }
}
