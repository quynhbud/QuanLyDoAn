//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlsv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QLDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QLDA()
        {
            this.QLDASVs = new HashSet<QLDASV>();
        }
    
        public string Ma_ĐA { get; set; }
        public string Ten_ĐA { get; set; }
        public string The_loai { get; set; }
        public string Chuyen_nganh { get; set; }
    
        public virtual Nganh Nganh { get; set; }
        public virtual The_Loai The_Loai1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLDASV> QLDASVs { get; set; }
    }
}
