﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhEvdSeccionCompetencium
    {
        public int ClaEmpresa { get; set; }
        public int ClaSeccion { get; set; }
        public int ClaPuesto { get; set; }
        public int FolioCompetencia { get; set; }
        public int ClaNivel { get; set; }
        public int ClaComportamiento { get; set; }
        public int FolAuto { get; set; }

        public virtual RhSeccion Cla { get; set; }
    }
}