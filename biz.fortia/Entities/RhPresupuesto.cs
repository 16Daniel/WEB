﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhPresupuesto
    {
        public int ClaEmpresa { get; set; }
        public int ClaPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double DiasPresupuesto { get; set; }
        public int ClaSalarioMinimo { get; set; }
        public int ClaTabInfo { get; set; }
        public int IncluyeVacantes { get; set; }
        public int Prorratear { get; set; }
        public double? DiasProyectar { get; set; }
        public int? ApProyeccion { get; set; }
        public int ClaPlantilla { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public int Origen { get; set; }
        public int? Importa { get; set; }
        public int? Exporta { get; set; }
    }
}