﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhIsrLiquidar
    {
        public int ClaEmpresa { get; set; }
        public int ClaTrab { get; set; }
        public int Anio { get; set; }
        public int FolAutoIsrLiq { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public int? ClaPeriodo { get; set; }
        public int? ClaPerded { get; set; }
        public int? ClaPerdedCompensar { get; set; }
        public byte TipoCarcre { get; set; }
        public double? ImporteTotal { get; set; }
        public byte? NumPeriodos { get; set; }
        public double? ImportePeriodo { get; set; }
        public double? Saldo { get; set; }
        public double? TotIsrCompensar { get; set; }
        public double? SaldoIsrCompensar { get; set; }
        public byte Status { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public int? ClaRazonSocial { get; set; }
    }
}