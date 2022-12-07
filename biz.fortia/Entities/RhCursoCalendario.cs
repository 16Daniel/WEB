﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhCursoCalendario
    {
        public RhCursoCalendario()
        {
            RhCursoCalendarioDets = new HashSet<RhCursoCalendarioDet>();
        }

        public int FolioCurso { get; set; }
        public int ClaEmpresa { get; set; }
        public int? ClaPeriodoDnc { get; set; }
        public int ClaCurso { get; set; }
        public int TipoCurso { get; set; }
        public DateTime FechaGen { get; set; }
        public int? ClaUsuarioAutoriza { get; set; }
        public DateTime? FechaAutoriza { get; set; }
        public byte Estatus { get; set; }
        public int OrigenCurso { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? ClaInstruc { get; set; }
        public int? ClaSala { get; set; }
        public int? ClaTrabRevisa { get; set; }
        public int? ClaEmpresaRevisa { get; set; }
        public int FolioRef { get; set; }
        public string NomGpo { get; set; }
        public int? ClaUsuarioCancela { get; set; }
        public DateTime? FechaCancela { get; set; }
        public string NomInstruc { get; set; }
        public int? ConsecutivoCursoStps { get; set; }

        public virtual ICollection<RhCursoCalendarioDet> RhCursoCalendarioDets { get; set; }
    }
}