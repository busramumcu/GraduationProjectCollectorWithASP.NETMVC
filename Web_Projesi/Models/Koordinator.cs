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
    
    public partial class Koordinator
    {
        public int Kullanici_Id { get; set; }
        public string Unvan { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
    }
}
