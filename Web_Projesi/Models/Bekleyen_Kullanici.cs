﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Web_Projesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bekleyen_Kullanici
    {
        public int B_Id { get; set; }
        [StringLength(50, ErrorMessage = "Kullanıcı adı can be no larger than 50 characters"), Required]
        public string Kullanici_Adi { get; set; }
        [StringLength(50, ErrorMessage = "Şifre adı can be no larger than 50 characters"), Required]
        public string Sifre { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [StringLength(50, ErrorMessage = "Ad adı can be no larger than 50 characters"), Required]
        public string Ad { get; set; }
        [StringLength(50, ErrorMessage = "Soyad adı can be no larger than 50 characters"), Required]
        public string Soyad { get; set; }
        public bool Onay { get; set; }
    }
}