//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Projesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dosya
    {
        public int Gorev_Id { get; set; }
        public int Kullanici_Id { get; set; }
        public string Dosya_Adi { get; set; }
        public string Yukleme_Yeri { get; set; }
        public string Dosya_Uzantisi { get; set; }
    
        public virtual Gorev Gorev { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
