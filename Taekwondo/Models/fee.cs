//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taekwondo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fee()
        {
            this.studentfees = new HashSet<studentfee>();
        }
    
        public string feeID { get; set; }
        public string feedesc { get; set; }
        public string feeamount { get; set; }
        public string duedate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentfee> studentfees { get; set; }
    }
}