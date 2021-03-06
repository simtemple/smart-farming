//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartFarming
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pesticide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pesticide()
        {
            this.Quotations = new HashSet<Quotation>();
        }
    
        public int id { get; set; }
        public int dealer_id { get; set; }
        public int crop_id { get; set; }
        public string Category { get; set; }
        public string PesticideName { get; set; }
        public string PesticideImage { get; set; }
        public string State { get; set; }
        public string PackingType { get; set; }
        public string Dosage { get; set; }
        public string Formulation { get; set; }
        public string PesticideDescription { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
