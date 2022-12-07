﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class SysSegPwd
    {
        public string Password { get; set; }
        public DateTime FechaUltCambio { get; set; }
        public string PasswordWeb { get; set; }
        public DateTime? FechaUltCambioWeb { get; set; }
        public byte LongitudMinPwd { get; set; }
        public short NumDiasCaducidad { get; set; }
        public short NumDiasAvisoCaducidad { get; set; }
        public short NumIntentosBloqueo { get; set; }
        public short NumDiasInactividad { get; set; }
        public bool NoPermitirLetrasConsecutivas { get; set; }
        public bool NoPermitirPalabrasReservadas { get; set; }
        public int? NumRepetirPwdHisto { get; set; }
        public int? ValidarTipoCaracter { get; set; }
        public bool NoIncluirNombCuentaUsuario { get; set; }
        public bool NoIncluirNombreUsuario { get; set; }
        public short PermitirNLetrasMayusculas { get; set; }
        public short PermitirNLetrasMinusculas { get; set; }
        public short PermitirNNumeros { get; set; }
        public short PermitirNCaracteresEsp { get; set; }
        public string BlinkOrganization { get; set; }
        public string BlinkApplication { get; set; }
        public string BlinkUser { get; set; }
        public string BlinkPassword { get; set; }
        public string BlinkToken { get; set; }
        public string TokenSincronizaComedor { get; set; }
        public string GoogleClientId { get; set; }
        public string GoogleClientSecret { get; set; }
        public string SamlProviderName { get; set; }
        public string SamlIdentityProvider { get; set; }
        public string SamlSsoUrl { get; set; }
        public string SamlX509Certificate { get; set; }
        public string KioscoSamlProviderName { get; set; }
        public string KioscoSamlIdentityProvider { get; set; }
        public string KioscoSamlSsoUrl { get; set; }
        public string KioscoSamlX509Certificate { get; set; }
        public int ClaSegPwd { get; set; }
        public bool? PermiteAislamiento { get; set; }
    }
}