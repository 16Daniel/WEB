﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Favoritoslin
    {
        public int Codfavorito { get; set; }
        public int Posicion { get; set; }
        public int? Codarticulo { get; set; }
        public int? Tipo { get; set; }

        public virtual Favoritoscab CodfavoritoNavigation { get; set; }
    }
}