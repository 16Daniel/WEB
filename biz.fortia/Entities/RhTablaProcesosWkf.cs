﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhTablaProcesosWkf
    {
        public int ClaProceso { get; set; }
        public int ClaTabla { get; set; }
        public DateTime? FechaUltCambio { get; set; }

        public virtual RhProcesosWkf ClaProcesoNavigation { get; set; }
        public virtual RhTablaWkf ClaTablaNavigation { get; set; }
    }
}