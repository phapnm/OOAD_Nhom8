//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOAD_Nhom8.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NganHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NganHang()
        {
            this.TheNganHangs = new HashSet<TheNganHang>();
        }
    
        public int Id { get; set; }
        public string TenNganHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheNganHang> TheNganHangs { get; set; }
    }
}
