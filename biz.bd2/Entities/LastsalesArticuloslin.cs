﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class LastsalesArticuloslin
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public string Codbarras { get; set; }
        public string Codbarras2 { get; set; }
        public string Codbarras3 { get; set; }
        public string Descatalogado { get; set; }

        public virtual LastsalesArticulo CodarticuloNavigation { get; set; }
    }
}