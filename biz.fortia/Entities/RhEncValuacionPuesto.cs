﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhEncValuacionPuesto
    {
        public RhEncValuacionPuesto()
        {
            RhDetValuacionPuestos = new HashSet<RhDetValuacionPuesto>();
        }

        public int FolValuacion { get; set; }
        public int ClaEmpresa { get; set; }
        public int ClaPuesto { get; set; }
        public DateTime FechaValuacion { get; set; }
        public int Estatus { get; set; }
        public double? Puntaje { get; set; }
        public string FormulaTabulador { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public int? UsuarioAutoriza { get; set; }
        public int? ClaTabulador { get; set; }
        public int? Nivel { get; set; }

        public virtual ICollection<RhDetValuacionPuesto> RhDetValuacionPuestos { get; set; }
    }
}