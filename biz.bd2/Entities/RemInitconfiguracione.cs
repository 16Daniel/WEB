﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class RemInitconfiguracione
    {
        public int Idfront { get; set; }
        public bool? Inittermndisp { get; set; }
        public int? Idconfigtermdisp { get; set; }
        public bool? Initsalas { get; set; }
        public int? Idconfigsalas { get; set; }
        public bool? Initpantventa { get; set; }
        public int? Idconfigpantventa { get; set; }
        public bool? Delventasexit { get; set; }
        public int? Diasdelventasexit { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; }
    }
}