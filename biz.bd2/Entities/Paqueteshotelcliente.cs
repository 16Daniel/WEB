﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Paqueteshotelcliente
    {
        public int Codtarifa { get; set; }
        public int Codcliente { get; set; }
        public int Posicion { get; set; }
        public bool? Combruto { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; }
        public virtual Tarifashotel CodtarifaNavigation { get; set; }
    }
}