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
    
    public partial class Gorev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gorev()
        {
            this.Dosyas = new HashSet<Dosya>();
        }
    
        public int Gorev_Id { get; set; }
        public string Gorev_Adi { get; set; }
        public string Aciklama { get; set; }
        public System.DateTime S_Date { get; set; }
        public System.DateTime E_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dosya> Dosyas { get; set; }
    }
}
