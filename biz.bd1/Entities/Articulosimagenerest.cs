﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Articulosimagenerest
    {
        public int Codarticulo { get; set; }
        public byte[] Imagen { get; set; }
        public byte[] Version { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; }
    }
}